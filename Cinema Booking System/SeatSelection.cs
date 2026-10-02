using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using ADOX;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlTypes;
using System.Configuration;
using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Cinema_Booking_System
{
    public partial class frmSeatSelection : Form
    {
        private const string EXAMPLEDB = "CinemaDatabase2.mdb";
        private const string CONNECTION_STRING = @"Provider=Microsoft Jet 4.0 OLE DB Provider;Data Source = " + EXAMPLEDB + ";";

        int bookingId = UserSession.CurrentBookingId;
        private const int MAX_SEATS = 5;
        private ToolTip seatToolTip = new ToolTip();
        
        public frmSeatSelection()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        private void frmSeatSelection_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                UserSession.DeleteBooking(UserSession.CurrentBookingId);
                Application.ExitThread();
            }
        }
        private void frmSeatSelection_Load(object sender, EventArgs e)
        {
            GenerateSeatButtons();
            UpdateSelectedSeatSummary();
        }
        private void GenerateSeatButtons()
        {
            //string sSqlString = @"SELECT SeatId, SeatNumber, SeatType, SeatTypePrice, RowLetter, ColumnNumber, 'Available' as SeatStatus FROM Seats";
            string sSqlString = @"
                SELECT ss.ScreeningSeatId, ss.SeatId, s.SeatNumber, s.SeatType, s.SeatTypePrice, s.RowLetter, s.ColumnNumber, ss.SeatStatus
                FROM ScreeningSeats ss
                INNER JOIN Seats s ON ss.SeatId = s.SeatId
                WHERE ss.MovieScreeningId = ?";
            using (OleDbConnection cnn = new OleDbConnection(CONNECTION_STRING))
            {
                using (OleDbCommand cmd = new OleDbCommand(sSqlString, cnn))
                {
                    cmd.Parameters.AddWithValue("?", UserSession.SelectedMovieScreening.MovieScreeningId);
                    try
                    {
                        cnn.Open();
                        OleDbDataReader dr = cmd.ExecuteReader();
 
                        //while (dr.Read())
                        //{
                        //    int seatid = Convert.ToInt32(dr["SeatId"]);
                        //    InsertSeats(seatid, "Available", bookingId);
                        //}
                        //dr.Close();
                        //dr = cmd.ExecuteReader();

                        while(dr.Read())
                        {
                            int seatId = Convert.ToInt32(dr["SeatId"]);
                            int screeningSeatId = Convert.ToInt32(dr["ScreeningSeatId"]);
                            string seatNumber = dr["SeatNumber"].ToString();
                            string seatType = dr["SeatType"].ToString();
                            decimal seatTypePrice = Convert.ToDecimal(dr["SeatTypePrice"]);
                            string seatStatus = "Available"; //automatically defaults to "Available" if null
                            string rowLetter = dr["RowLetter"].ToString();
                            string columnNumber = dr["ColumnNumber"].ToString();

                            //check if the seat is in UserSession.SelectedSeats
                            Seat selectSeat = null;
                            foreach (var seat in UserSession.SelectedSeats)
                            {
                                if (seat.SeatId == seatId)
                                {
                                    selectSeat = seat;
                                    break;
                                }
                            }
                            if (selectSeat != null)
                            {
                                seatStatus = "Selected";
                            }

                            Button seatButton = new Button
                            {
                                Name = $"btn_{seatNumber}",
                                Text = seatType.Substring(0, 1), //display first letter of its seat type
                                Dock = DockStyle.Fill,
                                BackColor = GetColourForSeats(seatType, seatStatus),
                                Tag = new SeatDetails
                                {
                                    SeatId = seatId,
                                    ScreeningSeatId = screeningSeatId,
                                    SeatNumber = seatNumber,
                                    SeatType = seatType,
                                    SeatTypePrice = seatTypePrice,
                                    SeatStatus = seatStatus,
                                    RowLetter = rowLetter,
                                    ColumnNumber = columnNumber
                                }
                            };
                            
                            seatButton.Click += SeatButton_Click;
                            tlpSeatButtons.Controls.Add(seatButton);

                            //adding tooltips to provide seat type information when hovering over a button
                            seatToolTip.SetToolTip(seatButton, $"Type: {seatType}\nPrice: £{seatTypePrice:F2}\nStatus: {seatStatus}");
                            var seatDetails = (dynamic)seatButton.Tag;

                            MessageBox.Show($"seat id: {seatDetails.SeatId}\n" +
                                            $"seat number: {seatDetails.SeatNumber}\n" +
                                            $"seat type: {seatDetails.SeatType}\n" +
                                            $"seat type price: £{seatDetails.SeatTypePrice:F2}\n" +
                                            $"seat Status: {seatDetails.SeatStatus}\n" +
                                            $"row letter: {seatDetails.RowLetter}\n" +
                                            $"column number: {seatDetails.ColumnNumber}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading seat buttons: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            UpdateBookedSeats();
        }
        private void UpdateBookedSeats()
        {
            string checkBookedQuery = @"SELECT SeatId FROM ScreeningSeats WHERE MovieScreeningId = ? AND SeatStatus = ?";
            using (OleDbConnection cnn = new OleDbConnection(CONNECTION_STRING))
            {
                using (OleDbCommand cmd = new OleDbCommand(checkBookedQuery, cnn))
                {
                    cmd.Parameters.AddWithValue("?", UserSession.SelectedMovieScreening.MovieScreeningId);
                    cmd.Parameters.AddWithValue("?", "Booked");
                    try
                    {
                        cnn.Open();
                        OleDbDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            int seatId = Convert.ToInt32(dr["SeatId"]);
                            foreach (Control control in tlpSeatButtons.Controls)
                            {
                                if (control is Button button)
                                {
                                    var seatDetails = (SeatDetails)button.Tag;
                                    if (seatDetails.SeatId == seatId && seatDetails.SeatStatus != "Selected")
                                    {
                                        seatDetails.SeatStatus = "Booked";
                                        button.BackColor = GetColourForSeats(seatDetails.SeatType, "Booked");
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating booked seats: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }
        
        private void SeatButton_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                var seatDetails = (dynamic)clickedButton.Tag;
                int movieScreeningId = UserSession.SelectedMovieScreening.MovieScreeningId;

                txtDisplaySeatId.Text = seatDetails.SeatId.ToString();
                txtDisplaySeatNumber.Text = seatDetails.SeatNumber.ToString();

                if (seatDetails.SeatStatus == "Booked")
                {
                    MessageBox.Show("This seat is already booked.", "Seat Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (seatDetails.SeatStatus == "Selected")
                {
                    UpdateSeatStatus(seatDetails.SeatId, "Available", movieScreeningId);
                    seatDetails.SeatStatus = "Available";
                    clickedButton.Tag = seatDetails;
                    clickedButton.BackColor = GetColourForSeats(seatDetails.SeatType, "Available");
                    
                    Seat seatToRemove = null;
                    foreach (var seat in UserSession.SelectedSeats)
                    {
                        if (seat.SeatNumber == seatDetails.SeatNumber)
                        {
                            seatToRemove = seat;
                            break;
                        }
                    }
                    if (seatToRemove != null)
                    {
                        UserSession.SelectedSeats.Remove(seatToRemove);
                    }
                }
                else if(seatDetails.SeatStatus == "Available")
                {
                    if (UserSession.SelectedSeats.Count >= MAX_SEATS) //only lets user select a maximum of 5 seats
                    {
                        MessageBox.Show($"Sorry, you can only select up to {MAX_SEATS} seats.", "Seat Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Seat existingSeat = null;
                    foreach(var seat in UserSession.SelectedSeats)
                    {
                        if(seat.SeatNumber == seatDetails.SeatNumber)
                        {
                            existingSeat = seat;
                            break;
                        }
                    }
                    if(existingSeat == null)
                    {
                        UserSession.SelectedSeats.Add(new Seat(seatDetails.SeatId, seatDetails.ScreeningSeatId, seatDetails.SeatNumber, seatDetails.SeatType, seatDetails.SeatTypePrice, "Selected"));
                        UpdateSeatStatus(seatDetails.SeatId, "Selected", movieScreeningId);
                        seatDetails.SeatStatus = "Selected";
                        clickedButton.Tag = seatDetails;
                        clickedButton.BackColor = Color.Yellow;
                    }
                    else
                    {
                        MessageBox.Show("This seat is already selected.", "Seat Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                UpdateSelectedSeatSummary();
            }
        }
        private void InsertSeats(int seatId, string newStatus, int bookingId)
        {
            if (newStatus != "Selected" && newStatus != "Booked")
            {
                try
                {
                    //check if the seat already exists for this booking
                    string checkExistingQuery = "SELECT COUNT(*) FROM BookingSeats WHERE BookingId = ? AND SeatId = ?";
                    using (OleDbConnection cnn = new OleDbConnection(CONNECTION_STRING))
                    {
                        using (OleDbCommand cmd = new OleDbCommand(checkExistingQuery, cnn))
                        {
                            cmd.Parameters.AddWithValue("?", bookingId);
                            cmd.Parameters.AddWithValue("?", seatId);
                            try
                            {
                                cnn.Open();
                                int seatCount = Convert.ToInt32(cmd.ExecuteScalar());
                                if (seatCount > 0)
                                {
                                    //MessageBox.Show("Seat already exists, no need to insert", "Seat Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error checking existing seat: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    //check if BookingId exists in the Bookings table
                    string checkQuery = "SELECT COUNT(*) FROM Bookings WHERE BookingId = ?";
                    using (OleDbConnection cnn = new OleDbConnection(CONNECTION_STRING))
                    {
                        using (OleDbCommand cmd = new OleDbCommand(checkQuery, cnn))
                        {
                            cmd.Parameters.AddWithValue("?", bookingId);
                            try
                            {
                                cnn.Open();
                                int bookingCount = Convert.ToInt32(cmd.ExecuteScalar());
                                if (bookingCount == 0)
                                {
                                    MessageBox.Show("Booking ID does not exist. Please create a new booking.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error checking booking: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    //proceeds to insert into BookingSeats if thde booking exists
                    string insertQuery = "INSERT INTO BookingSeats(BookingId, SeatId, SeatStatus) VALUES(?, ?, ?)";
                    using (OleDbConnection cnn = new OleDbConnection(CONNECTION_STRING))
                    {
                        using (OleDbCommand cmd = new OleDbCommand(insertQuery, cnn))
                        {
                            cmd.Parameters.AddWithValue("?", bookingId);
                            cmd.Parameters.AddWithValue("?", seatId);
                            cmd.Parameters.AddWithValue("?", newStatus);
                            try
                            {
                                cnn.Open();
                                cmd.ExecuteNonQuery();
                                //MessageBox.Show("Data successfully inserted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Debug.WriteLine($"Data successfully inserted for seat: {seatId}");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error inserting seat: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error occurred. Please try again later.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void UpdateSeatStatus(int seatId, string newStatus, int movieScreeningId)
        {
            try
            {
                string sSqlString = "UPDATE ScreeningSeats SET SeatStatus = ? WHERE SeatId = ? AND MovieScreeningId = ?";
                using (OleDbConnection cnn = new OleDbConnection(CONNECTION_STRING))
                {
                    using (OleDbCommand cmd = new OleDbCommand(sSqlString, cnn))
                    {
                        cmd.Parameters.AddWithValue("?", newStatus);
                        cmd.Parameters.AddWithValue("?", seatId);
                        cmd.Parameters.AddWithValue("?", movieScreeningId);
                        try
                        {
                            cnn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                Debug.WriteLine($"Seat status updated successfully for SeatId: {seatId}");
                            }
                            else
                            {
                                Debug.WriteLine($"Failed to update seat status for SeatId: {seatId}");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error updating seat status: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurred. Please try again later.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateSelectedSeatSummary()
        {
            StringBuilder summary = new StringBuilder();
            decimal totalPrice = 0;

            foreach (var seat in UserSession.SelectedSeats)
            {
                summary.AppendLine($"Seat: {seat.SeatNumber}, Type: {seat.SeatType}, Price: £{seat.SeatTypePrice:F2}");
                totalPrice += seat.SeatTypePrice;
            }
            summary.AppendLine($"Total Price: £{totalPrice:F2}");
            txtSelectedSeats.Clear();
            txtSelectedSeats.AppendText(summary.ToString());
        }

        
        private Color GetColourForSeats(string seatType, string seatStatus)
        {
            //if (seatStatus == "Available") return Color.Green;
            if (seatStatus == "Booked") return Color.Red;
            if (seatStatus == "Selected") return Color.Yellow;

            switch (seatType)
            {
                case "Standard": return Color.Gray;
                case "Premium": return Color.Blue;
                case "Accessible":return Color.LightYellow;                    
                case "VIP":return Color.Purple;                    
                default:return Color.LightGray;                    
            };
        }


        private void btnConfirmSeats_Click(object sender, EventArgs e)
        {
            if (UserSession.SelectedSeats.Count == 0)
            {
                MessageBox.Show("Please select a seat first before you proceed.", "Seat not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(UserSession.SelectedSeats.Count != -1)
            {
                MessageBox.Show("Selected seats successfully", "Cinema Booking System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NavigationHelper.Navigate(this, new frmPayment());
            }
        }

        private void tlpSeatSelection_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

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

        private void txtSelectedSeats_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            NavigationHelper.Navigate(this,new frmMainMenu());
        }        
    }
    public class SeatDetails
    {
        public int SeatId { get; set; }
        public int ScreeningSeatId { get; set; }
        public string SeatNumber { get; set; }
        public string SeatType { get; set; }
        public decimal SeatTypePrice { get; set; }
        public string SeatStatus { get; set; }
        public string RowLetter { get; set; }
        public string ColumnNumber { get; set; }

    }

}