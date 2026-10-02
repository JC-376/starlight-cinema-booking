using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.VisualBasic;
using Cinema_Booking_System;
using static Cinema_Booking_System.frmPayment;
using System.IO;
using System.Text.RegularExpressions;

namespace Cinema_Booking_System
{
    public partial class frmBookingConfirmation : Form
    {
        private const string EXAMPLEDB = "CinemaDatabase2.mdb";
        private const string CONNECTION_STRING = @"Provider=Microsoft Jet 4.0 OLE DB Provider;Data Source = " + EXAMPLEDB + ";";
        private void frmBookingConfirmation_FormClosing(object sender, FormClosingEventArgs e) 
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }

        public frmBookingConfirmation()
        {       
            InitializeComponent();
        }

        private void frmBookingConfirmation_Load(object sender, EventArgs e)
        {
            //LoadUser(); // Retrieve and display user details

            CreateDataGridView();
            UpdateDataGridView();
            LoadDetails();
        }
        private void CreateDataGridView()
        {
            dgvSeatSummary2.AutoGenerateColumns = false;

            var seatNumberColumn = new DataGridViewTextBoxColumn
            {
                Name = "SeatNumber",
                HeaderText = "Seat Number",
                DataPropertyName = "SeatNumber"
            };
            dgvSeatSummary2.Columns.Add(seatNumberColumn);

            var seatTypeColumn = new DataGridViewTextBoxColumn
            {
                Name = "SeatType",
                HeaderText = "Seat Type",
                DataPropertyName = "SeatType",
            };
            dgvSeatSummary2.Columns.Add(seatTypeColumn);

            var seatPriceColumn = new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Price",
                DataPropertyName = "Price",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("en-GB") }
            };
            dgvSeatSummary2.Columns.Add(seatPriceColumn);
        }
        private void UpdateDataGridView()
        {
            List<SelectedSeat> selectedSeatList = new List<SelectedSeat>();
            foreach (var seat in UserSession.SelectedSeats)
            {
                selectedSeatList.Add(new SelectedSeat
                {
                    SeatNumber = seat.SeatNumber,
                    SeatType = seat.SeatType,
                    Price = seat.SeatTypePrice,
                });
            }
            dgvSeatSummary2.DataSource = selectedSeatList;
        }
        private void LoadDetails()
        {
            //Movie Details
            lblMovieName.Text = UserSession.SelectedMovie.Title;
            //to ensure that label properties support large text
            lblMovieName.AutoSize = false;
            lblMovieName.AutoEllipsis = true;

            lblDuration.Text = $"{UserSession.SelectedMovie.Duration} min";
            lblTime.Text = UserSession.SelectedShowtime.StartTime.ToString("HH:mm");

            string seatList = "";
            for (int i = 0; i < UserSession.SelectedSeats.Count; i++)
            {
                seatList += UserSession.SelectedSeats[i].SeatNumber;
                if (i < (UserSession.SelectedSeats.Count - 1))
                {
                    seatList += ", ";
                }
            }
            lblSeats.Text = seatList;

            //Seat Details
            
            lblPrice.Text = $"£{CalculateTotalPrice():F2}";

            //User Details
            lblFullName.Text = $"{UserSession.LoggedInUser.Forename} {UserSession.LoggedInUser.Surname}";
            lblEmailAddress.Text = UserSession.LoggedInUser.Email;
            lblPhoneNumber.Text = "Click to Add";
            lblPhoneNumber.Font = new Font(lblPhoneNumber.Font, FontStyle.Underline);
            lblPhoneNumber.ForeColor = Color.Blue;
            lblPhoneNumber.Click += lblPhoneNumber_Click;
        }
        private void lblPhoneNumber_Click(object sender, EventArgs e)
        {
            string userInput = Interaction.InputBox("Enter your phone number:", "Edit Phone Number", lblPhoneNumber.Text);
            if (!string.IsNullOrWhiteSpace(userInput) && Regex.IsMatch(userInput, @"^\+?\d{10,15}$"))
            {
                lblPhoneNumber.Text = userInput;
            }
            else
            {
                MessageBox.Show("Please enter a valid phone number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void lblPhoneNumber_MouseEnter(object sender, EventArgs e)
        {
            lblPhoneNumber.ForeColor = Color.DarkBlue;
        }
        private void lblPhoneNumber_MouseLeave(object sender, EventArgs e)
        {
            lblPhoneNumber.ForeColor = Color.Blue;
        }

        private void grpBookingConfirmation_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            NavigationHelper.Navigate(this, new frmMainMenu());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                UserSession.DeleteBooking(UserSession.CurrentBookingId);
                UserSession.LogOut();
                MessageBox.Show("You have been logged out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

                NavigationHelper.Navigate(this, new frmMainMenu());
            }
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            try
            {
                int bookingId = UserSession.CurrentBookingId;
                DateTime paymentDate = DateTime.Now;
                string formattedBookingDate = paymentDate.ToString("dd/MM/yyyy");

                string seatList = "";
                for (int i = 0; i < UserSession.SelectedSeats.Count; i++)
                {
                    seatList += UserSession.SelectedSeats[i].SeatNumber;
                    if (i < (UserSession.SelectedSeats.Count - 1))
                    {
                        seatList += ", ";
                    }
                }

                //string sSqlString = "INSERT INTO Bookings (BookingId, UserId, MovieId, ShowtimeId, BookingDate, BookingStatus, Seats, TotalCost) " +
                //                    "VALUES (@BookingId, @UserId, @MovieId, @ShowtimeId, @BookingDate, @BookingStatus, @Seats, @TotalCost)";
                string updateSeatsQuery = "UPDATE ScreeningSeats SET SeatStatus = ? WHERE ScreeningSeatId = ?";
                string updateBookingQuery = "UPDATE Bookings SET UserId = ?, MovieScreeningId = ?, BookingDate = ?, BookingStatus = ?, TotalCost = ? WHERE BookingId = ?";


                using (OleDbConnection cnn = new OleDbConnection(CONNECTION_STRING))
                {
                    cnn.Open();

                    // Update seat status in the ScreeningSeats table
                    foreach (var seat in UserSession.SelectedSeats)
                    {
                        using (OleDbCommand cmdSeat = new OleDbCommand(updateSeatsQuery, cnn))
                        {
                            cmdSeat.Parameters.AddWithValue("?", "Booked");
                            cmdSeat.Parameters.AddWithValue("?", seat.ScreeningSeatId); // Assuming ScreeningSeatId is stored in UserSession.SelectedSeats
                            cmdSeat.ExecuteNonQuery();
                        }
                    }

                    using (OleDbCommand cmdBooked = new OleDbCommand(updateBookingQuery, cnn))
                    {
                        cmdBooked.Parameters.AddWithValue("?", UserSession.LoggedInUser.UserId);
                        cmdBooked.Parameters.AddWithValue("?", UserSession.SelectedMovieScreening.MovieScreeningId);
                        cmdBooked.Parameters.AddWithValue("?", formattedBookingDate);
                        cmdBooked.Parameters.AddWithValue("?", "Booked");
                        cmdBooked.Parameters.AddWithValue("?", CalculateTotalPrice());
                        cmdBooked.Parameters.AddWithValue("?", UserSession.CurrentBookingId);
                        cmdBooked.ExecuteNonQuery();
                    }
                }
                UserSession.RestartBooking();
                MessageBox.Show("Booking confirmed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NavigationHelper.Navigate(this, new frmMainMenu());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnGenerateTicket_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the folder where the program's executable is located
                string programFolder = AppDomain.CurrentDomain.BaseDirectory;

                //define the ticket file path in the program's folder
                string ticketFilePath = $"{programFolder}\\CinemaBookingTicket_{Guid.NewGuid()}.txt";

                //write the ticket details to the file
                using (StreamWriter writer = new StreamWriter(ticketFilePath))
                {
                    writer.WriteLine("Cinema Booking Ticket");
                    writer.WriteLine("----------------------------");
                    writer.WriteLine($"Movie: {UserSession.SelectedMovie.Title}");
                    writer.WriteLine($"Duration: {UserSession.SelectedMovie.Duration} minutes");
                    writer.WriteLine($"Showtime: {UserSession.SelectedShowtime.StartTime:HH:mm}");
                    writer.WriteLine($"Seats: {string.Join(", ", UserSession.SelectedSeats.Select(seat => seat.SeatNumber))}");
                    writer.WriteLine($"Total Price: £{CalculateTotalPrice():F2}");
                    writer.WriteLine("----------------------------");
                    writer.WriteLine($"Booked By: {UserSession.LoggedInUser.Forename} {UserSession.LoggedInUser.Surname}");
                    writer.WriteLine($"Email: {UserSession.LoggedInUser.Email}");
                    writer.WriteLine($"Booking Date: {DateTime.Now:dd/MM/yyyy}");
                    writer.WriteLine("----------------------------");
                    writer.WriteLine("Thank you for booking with us!");
                }

                //open the file after creation
                System.Diagnostics.Process.Start("notepad.exe", ticketFilePath);

                MessageBox.Show("Your ticket has been generated and opened.", "Ticket Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // cancel the currrent booking process
            //clear all unsaved data and navigate back to appropriate stage(main menu or previsous forms)
            DialogResult result = MessageBox.Show("Are you sure you want to cancel this booking? All unsaved changes will be lost.","Cancel Booking",
                MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                UserSession.SelectedSeats.Clear();
                UserSession.SelectedMovie = null;
                UserSession.SelectedShowtime = null;
                NavigationHelper.Navigate(this,new frmMainMenu());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NavigationHelper.Navigate(this, new frmPayment());
        }

        private void btnBookMovies_Click(object sender, EventArgs e)
        {
            // redirects user to the movie selection or booking process
            //clears current selects (if needed) and load the movie selection form

        }

        private void btnViewBookings_Click(object sender, EventArgs e)
        {
            //shows the users booking history or active bookings
            //load a form that fetches and displays booking detials from the database
        }

        private decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;
            for (int i = 0; i < UserSession.SelectedSeats.Count; i++)
            {
                totalPrice += UserSession.SelectedSeats[i].SeatTypePrice;
            }
            return totalPrice;
        }

        
    }
}
