using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using ADOX;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Cinema_Booking_System
{
    public partial class frmLogin : Form
    {
        private const string EXAMPLEDB = "CinemaDatabase2.mdb";
        private const string CONNECTION_STRING = @"Provider=Microsoft Jet 4.0 OLE DB Provider;Data Source = " + EXAMPLEDB + ";";

        public frmLogin()
        {
            InitializeComponent();
            Generate.GenerateScreening(DateTime.Today, DateTime.Today.AddDays(2));

        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e) 
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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            bool active = false;
            if(!active == false) //only occurs when i change active to true
            {
                HashAndUpdatePassword();
            }
        }
        private void HashAndUpdatePassword()
        {
            string filename = "UserDetails.txt";

            using(OleDbConnection cnn = new OleDbConnection(CONNECTION_STRING))
            {
                try
                {
                    cnn.Open();

                    string sSqlString = "SELECT UserId, Username, Password FROM Users;";
                    using(OleDbCommand cmd = new OleDbCommand(sSqlString, cnn))
                    {
                        OleDbDataReader dr = cmd.ExecuteReader();

                        using(StreamWriter SW = new StreamWriter(filename, false))
                        {
                            while (dr.Read()) //used to iterate through all the rows
                            {
                                int userId = dr.GetInt32(0);
                                string username = dr.GetString(1);
                                string password = dr.GetString(2);

                                if(password.Length == 64 && password.All(c => Uri.IsHexDigit(c)))
                                {
                                    continue;
                                }

                                //writes username and plain-text password to the file
                                SW.WriteLine($"Username: {username}, Password: {password}");

                                string hashedPassword = HashPassword(password);

                                string UpdateSQL = "UPDATE Users SET [Password] = @password WHERE UserId = @userId";
                                using(OleDbCommand update_cmd = new OleDbCommand(UpdateSQL, cnn))
                                {
                                    update_cmd.Parameters.AddWithValue("@password", hashedPassword);
                                    update_cmd.Parameters.AddWithValue("@userId", userId);

                                    update_cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    MessageBox.Show("Passwords update succesfully. User details saved to text file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error update passwords: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // toggle password visibility
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }
        private string HashPassword(string password)
        {
            using(SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach(byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //retrieve the usrename and password from the textboxes
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            OleDbConnection cnn = new OleDbConnection(CONNECTION_STRING);

            //checks if textboxes are empty or not
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (cnn.State != ConnectionState.Open)
                {
                    try
                    {
                        cnn.Open();

                        string hashedPassword = HashPassword(password);

                        //SQL query with parameters to check user credentials
                        //string sSqlString = $"SELECT * FROM Users WHERE Username = '{username}' AND Password = '{password}';";

                        string sSqlString = "SELECT * FROM Users WHERE Username = @username AND Password = @password;";

                        using (OleDbCommand cmd = new OleDbCommand(sSqlString, cnn))
                        {
                            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@password", hashedPassword);

                            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            if (dt.Rows.Count >= 1)
                            {
                                //retrieve data for new User Object
                                User loggedUser = new User(
                                    Convert.ToInt32(dt.Rows[0]["UserId"]),
                                    dt.Rows[0]["Username"].ToString(),
                                    dt.Rows[0]["Password"].ToString(),
                                    null, //ConfirmPassword
                                    dt.Rows[0]["Forename"].ToString(),
                                    dt.Rows[0]["Surname"].ToString(),
                                    dt.Rows[0]["Email"].ToString(),
                                    null //Postcode
                                    );

                                UserSession.LogIn(loggedUser);


                                MessageBox.Show("Logged in successfully", "Cinema Booking System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //navigate to movie selection form
                                NavigationHelper.Navigate(this, new frmMovieSelection());
                            }
                            else
                            {
                                MessageBox.Show("Incorrect username or password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any errors that might occur during querying the database
                        MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        cnn.Close();
                    }
                }
            }
        }


        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            NavigationHelper.Navigate(this, new frmRegister());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            NavigationHelper.Navigate(this, new frmMainMenu());

        }
    }
}
