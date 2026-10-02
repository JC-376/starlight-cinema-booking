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
using System.IO;
using ADOX;
using System.Security.Cryptography;


namespace Cinema_Booking_System
{
    public static class DatabaseUtils
    {
        private const string EXAMPLEDB = "CinemaDatabase2.mdb";
        private const string CONNECTION_STRING = @"Provider=Microsoft Jet 4.0 OLE DB Provider;Data Source = " + EXAMPLEDB + ";";
        

        public static void CreateDatabase()
        {
            try
            {
                //Check if the database exists
                if (!File.Exists(EXAMPLEDB))
                {
                    //create a catalog object
                    CatalogClass cat = new CatalogClass();

                    //create the database
                    cat.Create(CONNECTION_STRING);
                    MessageBox.Show("Database created successfully", "Cinema Booking System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //create database tables in the database
                    CreateTables();

                    //cleanup
                    cat = null;
                }
                else
                {
                    MessageBox.Show("The database already exists", "Cinema Booking System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Cinema Booking System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }   

        public static DataTable ExecuteSqlNonQuery(String sSqlString)
        {
            OleDbConnection cnn = new OleDbConnection(CONNECTION_STRING); //create a new connection to the database
            OleDbCommand cmd = new OleDbCommand(sSqlString, cnn); //sSqlString string contains a SQL statement to run on the databse
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                cnn.Open();
                da.Fill(dt);
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cinema Booking System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return dt; //return the data retrieved by the query
        }
        private static void CreateTables()
        {
            string _sSqlString_Users;
            string _sSqlString_Movies;
            string _sSqlString_Showtimes;
            string _sSqlString_Screens;
            string _sSqlString_MovieScreenings;
            string _sSqlString_Seats;
            string _sSqlString_ScreeningSeats;
            string _sSqlString_Bookings;
            string _sSqlString_BookingSeats;
            string _sSqlString_Payments;

            // create users table
            _sSqlString_Users = "CREATE TABLE Users("
                                            + "UserId INT IDENTITY(1,1),"
                                            + "Username VARCHAR(50),"
                                            + "[Password] VARCHAR(255)," //enclose in square brackets because it is a reserved keyword in sql
                                            + "Forename VARCHAR(50),"
                                            + "Surname VARCHAR(50),"
                                            + "Email VARCHAR(50),"
                                            + "Postcode VARCHAR(50),"
                                            + "PRIMARY KEY(UserId)"
                                            + ")";
            ExecuteSqlNonQuery(_sSqlString_Users);

            // create movies table
            _sSqlString_Movies = "CREATE TABLE Movies("
                                            + "MovieId SHORT NOT NULL,"
                                            + "Title VARCHAR(255),"
                                            + "Genre VARCHAR(50),"
                                            + "Duration INTEGER,"
                                            + "ReleaseDate DATE,"
                                            + "Director VARCHAR(50),"
                                            + "AgeRating VARCHAR(10),"
                                            + "[Language] CHAR(50)," //enclose in square brackets because it is a reserved keyword in sql
                                            + "PRIMARY KEY(MovieId)"
                                            + ")";
            ExecuteSqlNonQuery(_sSqlString_Movies);

            // create showtimes table
            _sSqlString_Showtimes = "CREATE TABLE Showtimes("
                                            + "ShowtimeId SHORT NOT NULL,"
                                            + "StartTime TIME,"
                                            + "PRIMARY KEY(ShowtimeId)"
                                            + ")";
            ExecuteSqlNonQuery(_sSqlString_Showtimes);

            // create screens table
            _sSqlString_Screens = "CREATE TABLE Screens("
                                            + "ScreenId SHORT NOT NULL,"
                                            + "ScreenNumber INTEGER,"
                                            + "Capacity INTEGER,"
                                            + "PRIMARY KEY(ScreenId)"
                                            + ")";
            ExecuteSqlNonQuery(_sSqlString_Screens);

            //create movie screening table
            _sSqlString_MovieScreenings = "CREATE TABLE MovieScreenings("
                                            + "MovieScreeningId SHORT NOT NULL,"
                                            + "MovieId SHORT NOT NULL,"
                                            + "ShowtimeId SHORT NOT NULL,"
                                            + "ScreenId SHORT NOT NULL,"
                                            + "ScreeningDate Date,"
                                            + "PRIMARY KEY(MovieScreeningId),"
                                            + "FOREIGN KEY(MovieId) REFERENCES Movies(MovieId),"
                                            + "FOREIGN KEY(ShowtimeId) REFERENCES Showtimes(ShowtimeId),"
                                            + "FOREIGN KEY(ScreenId) REFERENCES Screens(ScreenId)"
                                            + ")";
            ExecuteSqlNonQuery (_sSqlString_MovieScreenings);

            //create seats table
            _sSqlString_Seats = "CREATE TABLE Seats("
                                            + "SeatId SHORT NOT NULL,"
                                            + "SeatNumber VARCHAR(50),"
                                            + "SeatType VARCHAR(50),"
                                            + "SeatTypePrice CURRENCY,"
                                            //+ "SeatStatus VARCHAR(50),"
                                            + "RowLetter VARCHAR(50),"
                                            + "ColumnNumber INTEGER,"
                                            + "PRIMARY KEY(SeatId)"
                                            + ")";
            ExecuteSqlNonQuery(_sSqlString_Seats);

            //create screening seats table
            _sSqlString_ScreeningSeats = "CREATE TABLE ScreeningSeats("
                                            + "ScreeningSeatId INT IDENTITY(1,1),"
                                            + "MovieScreeningId INT NOT NULL,"
                                            + "SeatId INT NOT NULL,"
                                            + "SeatStatus VARCHAR(50) NOT NULL DEFAULT 'Available',"
                                            + "PRIMARY KEY(ScreeningSeatId),"
                                            + "FOREIGN KEY(MovieScreeningId) REFERENCES MovieScreenings(MovieScreeningId),"
                                            + "FOREIGN KEY(SeatId) REFERENCES Seats(SeatId)"
                                            + ")";
            ExecuteSqlNonQuery(_sSqlString_ScreeningSeats);

            //create bookings table
            _sSqlString_Bookings = "CREATE TABLE Bookings("
                                            + "BookingId SHORT NOT NULL,"
                                            + "UserId INT NOT NULL,"
                                            + "MovieScreeningId SHORT NOT NULL,"
                                            //+ "MovieId SHORT NOT NULL,"
                                            //+ "ShowtimeId SHORT NOT NULL,"
                                            + "BookingDate DATE,"
                                            + "BookingStatus VARCHAR(50),"
                                            //+ "Seats VARCHAR(50),"
                                            + "TotalCost CURRENCY,"
                                            + "PRIMARY KEY(BookingId),"
                                            + "FOREIGN KEY(UserId) REFERENCES Users(UserId),"
                                            //+ "FOREIGN KEY(MovieId) REFERENCES Movies(MovieId),"
                                            //+ "FOREIGN KEY(ShowtimeId) REFERENCES Movies(ShowtimeId)"
                                            + "FOREIGN KEY(MovieScreeningId) REFERENCES MovieScreenings(MovieScreeningId)"
                                            + ")";
            ExecuteSqlNonQuery(_sSqlString_Bookings);

            //create booking seats table
            _sSqlString_BookingSeats = "CREATE TABLE BookingSeats("
                                            + "BookingId SHORT NOT NULL,"
                                            + "SeatId SHORT NOT NULL,"
                                            + "SeatStatus VARCHAR(50),"
                                            + "PRIMARY KEY(BookingId, SeatId),"
                                            + "FOREIGN KEY(BookingId) REFERENCES Bookings(BookingId),"
                                            + "FOREIGN KEY(SeatId) REFERENCES Seats(SeatId)"
                                            + ")";
            ExecuteSqlNonQuery( _sSqlString_BookingSeats);           

            //create payments table
            _sSqlString_Payments = "CREATE TABLE Payments("
                                            + "PaymentId SHORT NOT NULL,"
                                            + "BookingId SHORT NOT NULL,"
                                            + "PaymentDate DATE,"
                                            + "AmountPaid CURRENCY,"
                                            + "PaymentMethod VARCHAR(50),"
                                            + "PRIMARY KEY(PaymentId),"
                                            + "FOREIGN KEY(BookingId) REFERENCES Bookings(BookingId)"
                                            + ")";
            ExecuteSqlNonQuery(_sSqlString_Payments);

            //generates screening for the next 30 days
            //GenerateScreening(DateTime.Today, DateTime.Today.AddDays(2));
        }
        public static string HashPassword(string Password)
        {
            using(var sha256 = SHA256.Create())
            {
                byte[] hashedbytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Password));
                return BitConverter.ToString(hashedbytes).Replace("-", "").ToLower();
            }
        }
        //public static void GenerateScreening(DateTime startDate, DateTime endDate)
        //{
        //    string query = "INSERT INTO MovieScreenings (MovieScreeningId, MovieId, ShowtimeId, ScreenId, ScreeningDate) Values (?, ?, ?, ?, ?)";
        //    using(OleDbConnection cnn = new OleDbConnection(CONNECTION_STRING))
        //    {
        //        cnn.Open();
        //        using(OleDbCommand cmd = new OleDbCommand(query, cnn))
        //        {
        //            int movieScreeningId = 1;
        //            int totalScreens = 5;

        //            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
        //            {
        //                for(int movieId = 1; movieId <= 100; movieId++)
        //                {
        //                    for(int showtimeId = 1; showtimeId <= 19; showtimeId++)
        //                    {
        //                        int screenId = (movieScreeningId % totalScreens) + 1;

        //                        cmd.Parameters.Clear();
        //                        cmd.Parameters.AddWithValue("?", movieScreeningId);
        //                        cmd.Parameters.AddWithValue("?", movieId);
        //                        cmd.Parameters.AddWithValue("?", showtimeId);
        //                        cmd.Parameters.AddWithValue("?", screenId);
        //                        cmd.Parameters.AddWithValue("?", date);
        //                        cmd.ExecuteNonQuery();

        //                        movieScreeningId++;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

    }
}
