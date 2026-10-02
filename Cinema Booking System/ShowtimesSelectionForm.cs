using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Booking_System
{
    public partial class frmShowtimesSelection : Form
    {
        private const string EXAMPLEDB = "CinemaDatabase2.mdb";
        private const string CONNECTION_STRING = @"Provider=Microsoft Jet 4.0 OLE DB Provider;Data Source = " + EXAMPLEDB + ";";
        public frmShowtimesSelection()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        private void frmShowtimesSelection_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                UserSession.DeleteBooking(UserSession.CurrentBookingId);
                Application.Exit();
            }
        }

        private void btnSelectShowtimes_Click(object sender, EventArgs e)
        {
            if(UserSession.SelectedShowtime.ShowtimeId > 0)
            {
                GetMovieScreeningDetails(UserSession.SelectedMovie.MovieId, UserSession.SelectedShowtime.ShowtimeId);

                decimal totalCost = 0;
                UserSession.InsertBooking(UserSession.CurrentBookingId, UserSession.LoggedInUser.UserId,UserSession.SelectedMovieScreening.MovieScreeningId, DateTime.Now, "Pending", totalCost);

                MessageBox.Show("Selected showtime successfully", "Cinema Booking System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NavigationHelper.Navigate(this, new frmSeatSelection());
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NavigationHelper.Navigate(this, new frmMovieSelection());
        }

        private void frmShowtimesSelection_Load(object sender, EventArgs e)
        {
            lblDisplayMovieID.Text = $"Movie ID: {UserSession.SelectedMovie.MovieId}";
            lblDisplayMovieTitle.Text = $"Movie Title: {UserSession.SelectedMovie.Title}";

            foreach (Control control in grpShowtimes.Controls)
            {
                Button btn = (Button)control;
                btn.Click += new EventHandler(ShowtimeButton_Click);
            }
        }
        private void ShowtimeButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string StartTime = clickedButton.Text;
                if (string.IsNullOrEmpty(StartTime))
                {
                    MessageBox.Show("Start time is empty. Cannot proceed with the query", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int ShowtimeId = GetShowtimeId(StartTime);

                if(ShowtimeId != -1)
                {
                    UserSession.SelectedShowtime = new Showtime
                    (
                        ShowtimeId,
                        UserSession.SelectedMovie.MovieId,
                        Convert.ToDateTime(StartTime)
                    );
                    
                    MessageBox.Show($"Showtime ID: {UserSession.SelectedShowtime.ShowtimeId}" +
                                    $"\nStart Time: {StartTime}", "Showtime Details",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Invalid showtime selected", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }   
        }
        private int GetShowtimeId(string StartTime)
        {
            int showtimeId = -1;

            if (string.IsNullOrEmpty(StartTime))
            {
                MessageBox.Show("Start time is empty. Cannot proceed with the query", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return showtimeId;
            }

            string sSqlString = "SELECT ShowtimeId FROM Showtimes WHERE StartTime = @StartTime"; 
            using(OleDbConnection cnn = new OleDbConnection(CONNECTION_STRING))
            {
                using(OleDbCommand cmd = new OleDbCommand(sSqlString, cnn))
                {
                    cmd.Parameters.AddWithValue("@StartTime", StartTime);
                    try
                    {
                        cnn.Open();
                        showtimeId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return showtimeId;
        }
        private void GetMovieScreeningDetails(int movieId, int showtimeId)
        {
            string sSqlString = "SELECT MovieScreeningId, ScreeningDate, ScreenId FROM MovieScreenings WHERE MovieId = @movieId AND ShowtimeId = @showtimeId AND ScreeningDate BETWEEN @startDate AND @endDate";
            using(OleDbConnection cnn = new OleDbConnection(CONNECTION_STRING))
            {
                using(OleDbCommand cmd = new OleDbCommand(sSqlString, cnn))
                {
                    cmd.Parameters.AddWithValue("@movieId", movieId);
                    cmd.Parameters.AddWithValue("@showtimeId", showtimeId);
                    cmd.Parameters.AddWithValue("@startDate", DateTime.Today);
                    cmd.Parameters.AddWithValue("@endDate", DateTime.Today.AddDays(2));
                    try
                    {
                        cnn.Open();
                        OleDbDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            int movieScreeningId = Convert.ToInt32(dr["MovieScreeningId"]);
                            DateTime screeningDate = Convert.ToDateTime(dr["ScreeningDate"]);
                            int screenId = Convert.ToInt32(dr["ScreenId"]);

                            UserSession.SelectedMovieScreening = new MovieScreening
                            (
                                movieScreeningId,
                                movieId,
                                showtimeId,
                                screenId,
                                screeningDate
                            );
                        }
                        else
                        {
                            MessageBox.Show("No movie screening found for the selected movie and showtime", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error retrieving movie screening details: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                UserSession.DeleteBooking(UserSession.CurrentBookingId);
                UserSession.LogOut();// clears the user session
                MessageBox.Show("You have been logged out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

                NavigationHelper.Navigate(this, new frmMainMenu());
            }
        }
    }
}
