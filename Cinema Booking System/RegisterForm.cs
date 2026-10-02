using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using ADOX;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Markup;

namespace Cinema_Booking_System
{
    public partial class frmRegister : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();

        private const string EXAMPLEDB = "CinemaDatabase2.mdb";
        private const string CONNECTION_STRING = @"Provider=Microsoft Jet 4.0 OLE DB Provider;Data Source = " + EXAMPLEDB + ";";

        public frmRegister()
        {            
            InitializeComponent();            
        }
        private void frmRegister_FormClosing(object sender, FormClosingEventArgs e) { Application.Exit(); } //Exits the form instead of closing it like before


        private void frmRegister_Load(object sender, EventArgs e)
        {
            // Create the database
            DatabaseUtils.CreateDatabase();

            // it initialises textboxes with placeholder text
            SetPlaceholderText(txtUsername, "Enter Username");
            SetPlaceholderText(txtPassword, "Enter Password", isPassword: true);
            SetPlaceholderText(txtConfirmPassword, "Confirm Password", isPassword: true);
            SetPlaceholderText(txtForename, "Enter Forename");
            SetPlaceholderText(txtSurname, "Enter Surname");
            SetPlaceholderText(txtEmail, "Enter Email");
            SetPlaceholderText(txtPostcode, "Enter Postcode");

            //put placeholder event holders in place
            //txtUsername.GotFocus += RemovePlaceholderText;
            //txtPassword.GotFocus += RemovePlaceholderText;
            //txtConfirmPassword.GotFocus += RemovePlaceholderText;
            //txtForename.GotFocus += RemovePlaceholderText;
            //txtSurname.GotFocus += RemovePlaceholderText;
            //txtEmail.GotFocus += RemovePlaceholderText;
            //txtPostcode.GotFocus += RemovePlaceholderText;

            //txtUsername.LostFocus += AddPlaceholderText;
            //txtPassword.LostFocus += AddPlaceholderText;
            //txtConfirmPassword.LostFocus += AddPlaceholderText;
            //txtForename.LostFocus += AddPlaceholderText;
            //txtSurname.LostFocus += AddPlaceholderText;
            //txtEmail.LostFocus += AddPlaceholderText;
            //txtPostcode.LostFocus += AddPlaceholderText;

            foreach(var control in this.Controls.OfType<TextBox>())
            {
                control.GotFocus += RemovePlaceholderText;
                control.LostFocus += AddPlaceholderText;
            }
                      

        }
        private void SetPlaceholderText(TextBox textBox, string placeholder, bool isPassword = false)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.ForeColor = Color.Gray;
                textBox.Text = placeholder;

                if (isPassword)
                {
                    textBox.PasswordChar = '\0';
                }
            }
        }
        private void RemovePlaceholderText(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.ForeColor == Color.Gray)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;

                //enable password mask for password fields after user starts typing
                if(textBox == txtPassword || textBox == txtConfirmPassword)
                {
                    textBox.PasswordChar = '*';//Show asteriks
                }
            }
        }
        private void AddPlaceholderText(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.ForeColor = Color.Gray;
                if (textBox == txtUsername) textBox.Text = "Enter Username";                
                if (textBox == txtPassword)
                {
                    textBox.Text = "Enter Password";
                    textBox.PasswordChar = '\0'; //disable asteriks
                }
                if (textBox == txtConfirmPassword)
                {
                    textBox.Text = "Confirm Password";
                    textBox.PasswordChar = '\0'; //disable asteriks
                }                
                if (textBox == txtForename) textBox.Text = "Enter Forename";
                if (textBox == txtSurname) textBox.Text = "Enter Surname";
                if (textBox == txtEmail) textBox.Text = "Enter Email";
                if (textBox == txtPostcode) textBox.Text = "Enter Postcode";
            }
        }

        private void txtForename_TextChanged(object sender, EventArgs e) { }
        private void txtSurname_TextChanged(object sender, EventArgs e) { }
        private void txtEmail_TextChanged(object sender, EventArgs e) 
        {
            if (isValidEmail(txtEmail.Text))
            {
                txtEmail.BackColor = Color.LightGreen;
            }
            else
            {
                txtEmail.BackColor = Color.Pink;
            }
        }
        private bool isValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return mail.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void txtPostcode_TextChanged(object sender, EventArgs e) { }
        private void txtUsername_TextChanged(object sender, EventArgs e) { }
        private void txtPassword_TextChanged(object sender, EventArgs e) { }
        private void txtConfirmPassword_TextChanged(object sender, EventArgs e) { }
        private void chkTermsAndConditions_CheckedChanged(object sender, EventArgs e) { }
        private void lblCinemaBookingSystem_Click(object sender, EventArgs e) { }



        private void btnRegister_Click(object sender, EventArgs e)
        {            
            errorProvider.Clear();

            //retrieves the user input from textboxes 
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string forename = txtForename.Text;
            string surname = txtSurname.Text;
            string email = txtEmail.Text;
            string postcode = txtPostcode.Text.ToUpper();

            //validate the registration form inputs and capture error message for each input
            bool isFormValid = ValidateRegisterForm(username, password,confirmPassword,forename, surname, email, postcode,
                out string usernameError, out string passwordError, out string confirmPasswordError, out string emailError, out string postcodeError);

            //display appropriate error messages if validations fails
            if (!isFormValid)
            {
                if (!string.IsNullOrEmpty(usernameError))
                    errorProvider.SetError(txtUsername, usernameError);
                if (!string.IsNullOrEmpty(passwordError))
                    errorProvider.SetError(txtPassword, passwordError);
                if (!string.IsNullOrEmpty(confirmPasswordError))
                    errorProvider.SetError(txtConfirmPassword, confirmPasswordError);
                if (!string.IsNullOrEmpty(emailError))
                    errorProvider.SetError(txtEmail, emailError);
                if (!string.IsNullOrEmpty(postcodeError))
                    errorProvider.SetError(txtPostcode, postcodeError);

                return;
            }

            //makes user accept the terms and conditions
            //PS - there is no terms and conditions. it is just for formality
            if (!chkTermsAndConditions.Checked)
            {
                MessageBox.Show("You must agree to the Terms and Conditions");
                return;
            }            

            try
            {
                //write to textfile so you dont forget password
                string filename = "UserDetails.txt";

                using(StreamWriter SW = new StreamWriter(filename, true))
                {
                    SW.WriteLine("Username: " + username +", Password: " + password);
                }


                //insert a row to the users table
                //string _sSqlString = "INSERT INTO Users(Username, [Password], Forename, Surname, Email, Postcode) " +
                //    "Values('" + username + "', '" + password + "', '" + forename + "', '" + surname + "', '" + email + "', '" + postcode + "')";


                //run the command
                //DatabaseUtils.ExecuteSqlNonQuery(_sSqlString);

                string hashedPassword = HashPassword(password);              
                using(OleDbConnection cnn = new OleDbConnection(CONNECTION_STRING))
                {
                    string _sSqlString = "INSERT INTO Users(Username, [Password], Forename, Surname, Email, Postcode) " +
                    "Values(@username, @password, @forename, @surname, @email, @postcode)";
                    
                    using (OleDbCommand cmd = new OleDbCommand(_sSqlString, cnn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@forename", forename);
                        cmd.Parameters.AddWithValue("@surname", surname);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@postcode", postcode);

                        try
                        {
                            cnn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Registration successfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error during registration: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                //if validation passes, creates the new user
                //MessageBox.Show("Registration successful.Click OK to redirect to login page.");
                
                //navigate to login page form
                NavigationHelper.Navigate(this, new frmLogin());

            }
            catch (Exception ex)
            {
                // Handle any errors that might occur during database insertion
                MessageBox.Show($"An error occurred while registering the user: {ex.Message}");
            }
        }
        private string HashPassword(string password)
        {
            using(SHA256 sha256_hashed = SHA256.Create())
            {
                byte[] bytes = sha256_hashed.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                foreach(byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private bool ValidateRegisterForm(string username,string password,string confirmPassword,string forename,string surname, string email, string postcode,
            out string usernameError, out string passwordError, out string confirmPasswordError, out string emailError, out string postcodeError)
        {
            bool isValid = true;
            
            //initializes each error messages
            usernameError = string.Empty;
            passwordError = string.Empty;
            confirmPasswordError = string.Empty;
            emailError = string.Empty;
            postcodeError = string.Empty;

            //checks if username field is empty
            if (string.IsNullOrEmpty(username))
            {
                usernameError = "Username is required.";
                isValid = false;
            }

            //makes sure password is in correct format
            if (!ValidatePassword(password, out passwordError))
            {
                isValid = false;
            }

            //double checks user typed in correct password
            if (password != confirmPassword)
            {
                confirmPasswordError = "Passwords do not match.";
                isValid = false;
            }

            //using regex makes sure email is in proper format such as it containing the '@' symbol in email
            if (!ValidateEmail(email))
            {
                emailError = "Invalid email format";
                isValid = false;
            }

            //makes sure postcode textbox isnt empty and validates it
            if (string.IsNullOrEmpty(postcode))
            {
                postcodeError = "Postcode is required.";
                isValid = false;
            }            

            return isValid;
        }        

        public bool ValidateEmail(string emailAddress)
        {
            //regex pattern to validate email address format
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
            var regex = new Regex(pattern); //create regex object with the pattern
            return regex.IsMatch(emailAddress); //return whether the email address matches the pattern
        }

        public bool ValidatePassword(string password, out string ErrorMessage)
        {
            var input = password; //local variable to hold the password
            ErrorMessage = string.Empty;

            //checks if password is empty or whitespace
            if (string.IsNullOrWhiteSpace(input))
            {
                ErrorMessage = "Password should not be empty";
                return false;
            }

            //define regex patterns for different password criteria
            var hasNumber = new Regex(@"[0-9]+"); //pattern for checking numeric values
            var hasUpperChar = new Regex(@"[A-Z]+"); //pattern for checking uppercase letters
            var hasMiniMaxChars = new Regex(@".{8,20}"); //pattern to check password length (8 to 20 charcters)
            var hasLowerChar = new Regex(@"[a-z]+"); //pattern to check for lowercase letters
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]"); //pattern to check for special characters

            //validates password based on different criterias
            if (!hasLowerChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain at least one lower case letter";
                return false;
            }
            if (!hasUpperChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain at least one upper case letter";
                return false;
            }
            if (!hasMiniMaxChars.IsMatch(input))
            {
                ErrorMessage = "Password should be between 8 and 15 characters long";
                return false;
            }
            if (!hasNumber.IsMatch(input))
            {
                ErrorMessage = "Password should contain at least one numeric value";
                return false;
            }
            if (!hasSymbols.IsMatch(input))
            {
                ErrorMessage = "Password should contain at least one special case characters";
                return false;
            }
            
            return true; //return true if all criteria are met
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
            txtConfirmPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtForename.Text = "";
            txtSurname.Text = "";
            txtEmail.Text = "";
            txtPostcode.Text = "";
            chkTermsAndConditions.Checked = false;
            txtForename.Focus();
        }

        private void lblBackToLogin_Click(object sender, EventArgs e)
        {
            NavigationHelper.Navigate(this, new frmLogin());
        }

        private void lblBackToMainMenu_Click(object sender, EventArgs e)
        {
            NavigationHelper.Navigate(this, new frmMainMenu());
        }
    }
}
