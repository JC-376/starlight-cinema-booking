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
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Diagnostics;

namespace Cinema_Booking_System
{
    public partial class frmMainMenu : Form
    {
        const string LoginRequiredMessage = "Please log in first to book movies.";
        const string LogoutConfirmationMessage = "Are you sure you want to logout?";

        public frmMainMenu()
        {
            InitializeComponent();
            
            //binds the logout icon to the logout button
            //so if you make the button visibility false then the icon's visibility also changes to false 
            picLogout.DataBindings.Add("Visible", btnLogout, "Visible");

            //only allowed to logout if the user is logged in 
            if (!UserSession.IsLoggedIn)
            {
                btnLogout.Visible = false;
            }            
        }     

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e) 
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to exit?","Exit Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                if (UserSession.IsLoggedIn)
                {
                    UserSession.LogOut();
                }
                if(UserSession.UserBookings.Count == 0)
                {
                    UserSession.DeleteBooking(UserSession.CurrentBookingId);
                }
                Application.Exit();
            }
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            if (UserSession.IsLoggedIn)
            {
                MessageBox.Show($"Welcome back, {UserSession.LoggedInUser.Username}", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblCinemaBookingSystem_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!UserSession.IsLoggedIn)
            {
                try
                {
                    NavigationHelper.Navigate(this, new frmLogin());
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please logout first to login a new account.", "Login Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!UserSession.IsLoggedIn)
            {
                try
                {                    
                    NavigationHelper.Navigate(this, new frmRegister());
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please logout first to register.", "Login Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBookMovies_Click(object sender, EventArgs e)
        {
            if (UserSession.IsLoggedIn)
            {
                try
                {
                    UserSession.RestartBooking();
                    NavigationHelper.Navigate(this, new frmMovieSelection());
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
            else
            {
                MessageBox.Show("Please log in first to book movies.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show(LogoutConfirmationMessage, "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                UserSession.DeleteBooking(UserSession.CurrentBookingId);
                UserSession.LogOut();
                MessageBox.Show("You have been logged out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

                NavigationHelper.Navigate(this, new frmMainMenu());
            }
        }
    }
    public static class NavigationHelper
    {
        public static void Navigate(Form currentForm, Form targetForm)
        {
            try
            {
                targetForm.Show();
                currentForm.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Navigation error: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
    public static class Generate
    {

        private const string EXAMPLEDB = "CinemaDatabase2.mdb";
        private const string CONNECTION_STRING = @"Provider=Microsoft Jet 4.0 OLE DB Provider;Data Source = " + EXAMPLEDB + ";";
        public static int GenerateUniqueId(string table, string NameId)
        {
            int uniqueId;
            Random rnd = new Random();

            using (OleDbConnection cnn = new OleDbConnection(CONNECTION_STRING))
            {
                cnn.Open();
                while (true)
                {
                    uniqueId = rnd.Next(1000, 9999);
                    string sSqlString = $"SELECT COUNT(*) FROM {table} WHERE {NameId} = ?";
                    using (OleDbCommand cmd = new OleDbCommand(sSqlString, cnn))
                    {
                        cmd.Parameters.AddWithValue("?", uniqueId);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count == 0) //breaks out of the loop if no existing payment ID matches
                        {
                            break;
                        }
                    }
                }
                return uniqueId;
            }
        }
        public static void GenerateScreening(DateTime startDate, DateTime endDate)
        {
            string checkQuery = "SELECT COUNT(*) FROM MovieScreenings WHERE ScreeningDate BETWEEN ? AND ?";
            string maxIdQuery = "SELECT MAX(MovieScreeningId) FROM MovieScreenings";
            string insertQuery = "INSERT INTO MovieScreenings (MovieScreeningId, MovieId, ShowtimeId, ScreenId, ScreeningDate) Values (?, ?, ?, ?, ?)";

            try
            {
                using (OleDbConnection cnn = new OleDbConnection(CONNECTION_STRING))
                {
                    cnn.Open();


                    //checks if screening already exist for the given date range
                    bool exist;
                    using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, cnn))
                    {
                        checkCmd.Parameters.AddWithValue("?", startDate);
                        checkCmd.Parameters.AddWithValue("?", endDate);

                        exist = Convert.ToInt32(checkCmd.ExecuteScalar()) > 0;
                    }
                    if (exist)
                    {
                        Debug.WriteLine("Screenings already exist for the given date range. Skipping generation.");
                        return;
                    }

                    // Retrieve the maximum MovieScreeningId
                    int movieScreeningId = 1;
                    using (OleDbCommand maxIdCmd = new OleDbCommand(maxIdQuery, cnn))
                    {
                        object result = maxIdCmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            movieScreeningId = Convert.ToInt32(result) + 1;
                        }
                    }

                    //generate new screening if none exist
                    using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, cnn))
                    {
                        int totalScreens = 5;

                        for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                        {
                            for (int movieId = 1; movieId <= 100; movieId++)
                            {
                                for (int showtimeId = 1; showtimeId <= 19; showtimeId++)
                                {
                                    int screenId = ((movieScreeningId - 1) % totalScreens) + 1;

                                    insertCmd.Parameters.Clear();
                                    insertCmd.Parameters.AddWithValue("?", movieScreeningId);
                                    insertCmd.Parameters.AddWithValue("?", movieId);
                                    insertCmd.Parameters.AddWithValue("?", showtimeId);
                                    insertCmd.Parameters.AddWithValue("?", screenId);
                                    insertCmd.Parameters.AddWithValue("?", date);
                                    insertCmd.ExecuteNonQuery();

                                    GenerateSeatsForScreening(movieScreeningId, cnn);


                                    movieScreeningId++;
                                }
                            }
                        }
                    }
                }
            }
            catch (OleDbException oleDbEx)
            {
                MessageBox.Show($"An database error occurred: {oleDbEx.Message}", "Database Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private static void GenerateSeatsForScreening(int movieScreeningId, OleDbConnection cnn)
        {
            string insertSeatsQuery = "INSERT INTO ScreeningSeats (MovieScreeningId, SeatId, SeatStatus) VALUES (?, ?, ?)";

            //a seating arrangement of 8 rows with 6 seats per row
            int totalRows = 8;
            int seatsPerRow = 6;
            int seatId = 1;

            using (OleDbCommand insertSeatsCmd = new OleDbCommand(insertSeatsQuery, cnn))
            {
                for (int row = 1; row <= totalRows; row++)
                {
                    for (int col = 1; col <= seatsPerRow; col++)
                    {
                        string seatStatus = "Available"; // All seats are available initially

                        insertSeatsCmd.Parameters.Clear();
                        insertSeatsCmd.Parameters.AddWithValue("?", movieScreeningId);
                        insertSeatsCmd.Parameters.AddWithValue("?", seatId);
                        insertSeatsCmd.Parameters.AddWithValue("?", seatStatus);
                        insertSeatsCmd.ExecuteNonQuery();

                        seatId++;
                    }
                }
            }
        }
    }


    public static class UserSession
    {
        private const string EXAMPLEDB = "CinemaDatabase2.mdb";
        private const string CONNECTION_STRING = @"Provider=Microsoft Jet 4.0 OLE DB Provider;Data Source = " + EXAMPLEDB + ";";

        //current user session data
        public static bool IsLoggedIn { get; private set; } = false;
        public static User LoggedInUser { get; private set; } = null;

        //session specific data
        public static Movie SelectedMovie { get; set; } = null;
        public static Showtime SelectedShowtime { get; set; } = null;
        public static MovieScreening SelectedMovieScreening { get; set; } = null;
        public static List<Seat> SelectedSeats { get; set; } = new List<Seat>();
        public static List<Payment> UserPayments { get; set; } = new List<Payment>();
        public static List<Booking> UserBookings { get; set; } = new List<Booking>();

        public static int CurrentScreeningSeatId;
        public static int CurrentBookingId;

        public static void LogIn(User user)
        {
            LoggedInUser = user;
            IsLoggedIn = true;
            
            //initialise session data
            SelectedMovie = null;
            SelectedShowtime = null;
            SelectedMovieScreening = null;
            SelectedSeats = new List<Seat>();
            UserPayments = new List<Payment>();
            UserBookings = new List<Booking>();

            //generate a new unique booking id for this session
            CurrentBookingId = Generate.GenerateUniqueId("Bookings", "BookingId");


        }
        public static void LogOut()
        {
            //resets the users progress
            LoggedInUser = null;
            IsLoggedIn = false;

            //clear session data
            SelectedMovie = null;
            SelectedShowtime = null;
            SelectedMovieScreening = null;
            SelectedSeats.Clear();
            UserPayments.Clear();
            UserBookings.Clear();

            //reset BookingId
            CurrentBookingId = 0;
        }
        public static void RestartBooking()
        {
            SelectedMovie = null;
            SelectedShowtime  =null;
            SelectedMovieScreening = null;
            SelectedSeats.Clear();
            UserPayments.Clear();

            CurrentBookingId = Generate.GenerateUniqueId("Bookings","BookingId");
            CurrentScreeningSeatId =0;
        }
        public static void InsertBooking(int bookingId, int userId, int movieScreeningId, DateTime bookingDate, string bookingStatus, decimal totalCost)
        {
            MessageBox.Show($"Bookingid: {bookingId}\n" +
                            $"UserId: {userId}\n" +
                            $"MovieScreeningId: {movieScreeningId}\n" +
                            $"BookingDate: {bookingDate}\n" +
                            $"BookingStatus: {bookingStatus}\n" +
                            $"TotalCost: {totalCost}");

            string insertQuery = "INSERT INTO Bookings(BookingId, UserId, MovieScreeningId, BookingDate, BookingStatus, TotalCost) VALUES(?, ?, ?, ?, ?, ?)";
            using (OleDbConnection cnn = new OleDbConnection(CONNECTION_STRING))
            {
                using (OleDbCommand cmd = new OleDbCommand(insertQuery, cnn))
                {
                    cmd.Parameters.AddWithValue("?", bookingId);
                    cmd.Parameters.AddWithValue("?", userId);
                    cmd.Parameters.AddWithValue("?", movieScreeningId);
                    cmd.Parameters.AddWithValue("?", bookingDate.ToString("dd/MM/yyyy"));
                    cmd.Parameters.AddWithValue("?", bookingStatus);
                    cmd.Parameters.AddWithValue("?", totalCost);
                    try
                    {
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        //MessageBox.Show("Data successfully inserted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Debug.WriteLine("(InsertBooking) Data successfully inserted.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error inserting booking: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public static void DeleteBooking(int bookingId)
        {
            if(UserSession.IsLoggedIn == true)
            {
                string deleteQuery1 = "DELETE * FROM BookingSeats WHERE BookingId = ?";
                using (OleDbConnection cnn = new OleDbConnection(CONNECTION_STRING))
                {
                    using (OleDbCommand cmd = new OleDbCommand(deleteQuery1, cnn))
                    {
                        cmd.Parameters.AddWithValue("?", bookingId);
                        try
                        {
                            cnn.Open();
                            cmd.ExecuteNonQuery();
                            //MessageBox.Show("Data from BookingSeats successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //Debug.WriteLine($"(DeleteBooking: BookingSeats) Data from BookingSeats successfully deleted. BookingId: {bookingId}");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error deleting booking seats: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                string deleteQuery2 = "DELETE FROM Bookings WHERE BookingId = ?";
                using (OleDbConnection cnn = new OleDbConnection(CONNECTION_STRING))
                {
                    using (OleDbCommand cmd = new OleDbCommand(deleteQuery2, cnn))
                    {
                        cmd.Parameters.AddWithValue("?", bookingId);
                        try
                        {
                            cnn.Open();
                            cmd.ExecuteNonQuery();
                            //MessageBox.Show("Data from Bookings successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //Debug.WriteLine($"(DeleteBooking: Bookings) Data from Bookings successfully deleted. BookingId: {bookingId}");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error deleting booking: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }            
        }
    }

    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Postcode { get; set; }

        //contsructor method for User object
        public User(int userId, string username, string password, string confirmPassword, string forename, string surname, string email, string postcode)
        {
            UserId = userId;
            Username = username;
            Password = password;
            ConfirmPassword = confirmPassword;
            Forename = forename;
            Surname = surname;
            Email = email;
            Postcode = postcode;
        }
    }

    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public string ReleaseDate { get; set; }
        public string Director { get; set; }
        public string AgeRating { get; set; }
        public string Language { get; set; }

        //contsructor method for Movie object
        public Movie(int movieId, string title, string genre, int duration,
            string releaseDate, string director, string ageRating, string language)
        {
            MovieId = movieId;
            Title = title;
            Genre = genre;
            Duration = duration;
            ReleaseDate = releaseDate;
            Director = director;
            AgeRating = ageRating;
            Language = language;
        }
    }

    public class Showtime
    {
        public int ShowtimeId { get; set; }
        public int MovieId { get; set; }
        public DateTime StartTime { get; set; }

        //contsructor method for Showtime object
        public Showtime(int showtimeId, int movieId, DateTime startTime)
        {
            ShowtimeId = showtimeId;
            MovieId = movieId;
            StartTime = startTime;
        }
    }

    public class Screen
    {
        public int ScreenId { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }

        //contsructor method for Screen object
        public Screen(int screenId, int screenNumber, int capacity)
        {
            ScreenId = screenId;
            ScreenNumber = screenNumber;
            Capacity = capacity;
        }
    }

    public class MovieScreening
    {
        public int MovieScreeningId { get; set; }
        public int MovieId { get; set; }
        public int ShowtimeId { get; set; }
        public int ScreenId { get; set; }
        public DateTime ScreeningDate { get; set; }

        //contsructor method for Movie Screening object
        public MovieScreening(int movieScreeningId, int movieId, int showtimeId, int screenId, DateTime screeningDate)
        {
            MovieScreeningId = movieScreeningId;
            MovieId = movieId;
            ShowtimeId = showtimeId;
            ScreenId = screenId;
            ScreeningDate = screeningDate;
        }
    }

    public class Seat
    {
        public int SeatId { get; set; }
        public int ScreeningSeatId { get; set; }
        public string SeatNumber { get; set; }
        public string SeatType { get; set; }
        public decimal SeatTypePrice { get; set; }
        public string SeatStatus { get; set; }

       //contsructor method for Seat object
        public Seat(int seatId, int screeningSeatId, string seatNumber, string seatType, decimal seatTypePrice, string seatStatus)
        {
            SeatId = seatId;
            ScreeningSeatId =screeningSeatId;
            SeatNumber = seatNumber;
            SeatType = seatType;
            SeatTypePrice = seatTypePrice;
            SeatStatus = seatStatus;
        }
    }
    public class Booking
    {
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public int MovieScreeningId { get; set; }
        public DateTime BookingDate { get; set; }
        public string BookingStatus { get; set; }
        public List<BookingSeat> BookingSeats { get; set; }
        public decimal TotalCost { get; set; }

        //contsructor method for Booking object
        public Booking(int bookingId, int userId, int movieScreeningId, DateTime bookingDate,
            string bookingStatus, List<BookingSeat> bookingSeats, decimal totalCost)
        {
            BookingId = bookingId;
            UserId = userId;
            MovieScreeningId = movieScreeningId;
            BookingDate = bookingDate;
            BookingStatus = bookingStatus;
            BookingSeats = bookingSeats;
            TotalCost = totalCost;
        }
    }

    public class BookingSeat
    {
        public int BookingId { get; set; }
        public int SeatId { get; set; }
        public string SeatStatus { get; set; } // "Available", "Selected", "Booked"

        //contsructor method for Booking Seat object
        public BookingSeat(int bookingId, int seatId, string seatStatus)
        {
            BookingId = bookingId;
            SeatId = seatId;
            SeatStatus = seatStatus;
        }
    }

    public class Payment
    {
        public int PaymentId { get; set; }
        public int BookingId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal AmountPaid { get; set; }
        public string PaymentMethod { get; set; }

        //contsructor method for Payment object
        public Payment(int paymentId, int bookingId, DateTime paymentDate, decimal amountPaid, string paymentMethod)
        {
            PaymentId = paymentId;
            BookingId = bookingId;
            PaymentDate = paymentDate;
            AmountPaid = amountPaid;
            PaymentMethod = paymentMethod;
        }
    }    
}
