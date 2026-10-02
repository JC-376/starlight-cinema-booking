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
using System.Text.RegularExpressions;

namespace Cinema_Booking_System
{
    public partial class frmPayment : Form
    {
        private const string EXAMPLEDB = "CinemaDatabase2.mdb";
        private const string CONNECTION_STRING = @"Provider=Microsoft Jet 4.0 OLE DB Provider;Data Source = " + EXAMPLEDB + ";";
        private ToolTip toolTip;

        private bool isCardHolderNameValid = false;
        private bool isCardNumberValid = false;
        private bool isExpiryDateValid = false;
        private bool isCVVValid = false;
        public frmPayment()
        {
            InitializeComponent();
            this.CenterToScreen();
            InitialiseToolTips();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            ResetValidationState();

            int currentYear = DateTime.Now.Year; //get the current year
            dtpExpiryDate.MinDate = new DateTime(currentYear,1,1); // set the minimum date to the start of the year
            dtpExpiryDate.Value = DateTime.Now;

            lblMovieTitleValue.Text = UserSession.SelectedMovie.Title;
            lblDateValue.Text = UserSession.SelectedMovie.ReleaseDate;
            lblTimeValue.Text = UserSession.SelectedShowtime.StartTime.ToString("HH:mm");

            string seatList = "";
            for(int i = 0; i < UserSession.SelectedSeats.Count; i++)
            {
                seatList += UserSession.SelectedSeats[i].SeatNumber;
                if(i < (UserSession.SelectedSeats.Count - 1) )
                {
                    seatList += ", ";
                }
            }
            lblSeatsValue.Text = seatList;

            decimal totalPrice = 0;
            for(int i = 0; i < UserSession.SelectedSeats.Count; i++)
            {
                totalPrice += UserSession.SelectedSeats[i].SeatTypePrice;
            }
            lblTotalPriceValue.Text = $"£{totalPrice:F2}";

            CreateDataGridView();
            UpdateDataGridView();
        }
        
        private void InitialiseToolTips()
        {
            toolTip = new ToolTip();
            toolTip.SetToolTip(txtCardNumber, "Enter your 16-digit card number without spaces.");
            toolTip.SetToolTip(txtCVV, "Enter the 3-digit CVV number from the back of your card.");
            toolTip.SetToolTip(dtpExpiryDate, "Select your card's expiry date. Ensure it is in the future.");
            toolTip.SetToolTip(txtCardHolderName, "Enter the name as it appears on your card.");
        }
        private void ResetValidationState()
        {
            txtCardHolderName.BackColor = Color.White;
            txtCardNumber.BackColor = Color.White;
            dtpExpiryDate.BackColor = Color.White;
            txtCVV.BackColor = Color.White;

            picCardHolderNameWarning.Visible = false;
            picCardNumberWarning.Visible = false;
            picExpiryDateWarning.Visible = false;
            picCVVWarning.Visible = false;
        }
        private void CreateDataGridView()
        {
            dgvSeatSummary.AutoGenerateColumns = false;

            var seatNumberColumn = new DataGridViewTextBoxColumn
            {
                Name = "SeatNumber",
                HeaderText = "Seat Number",
                DataPropertyName = "SeatNumber"
            };
            dgvSeatSummary.Columns.Add(seatNumberColumn);

            var seatTypeColumn = new DataGridViewTextBoxColumn
            {
                Name = "SeatType",
                HeaderText = "Seat Type",
                DataPropertyName = "SeatType",
            };
            dgvSeatSummary.Columns.Add(seatTypeColumn);

            var seatPriceColumn = new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Price",
                DataPropertyName = "Price",
                DefaultCellStyle = new DataGridViewCellStyle { Format ="C2", FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("en-GB")}
            };
            dgvSeatSummary.Columns.Add(seatPriceColumn);
        }
        private void UpdateDataGridView()
        {
            List<SelectedSeat> selectedSeatList = new List<SelectedSeat>();
            foreach(var seat in UserSession.SelectedSeats)
            {
                selectedSeatList.Add(new SelectedSeat
                {
                    SeatNumber = seat.SeatNumber,
                    SeatType = seat.SeatType,
                    Price = seat.SeatTypePrice,
                });
            }
            dgvSeatSummary.DataSource = selectedSeatList;
        }
        private void ValidatePayment()
        {
            bool isValid = isCardHolderNameValid && isCardNumberValid && isExpiryDateValid && isCVVValid;         

            // Enable/Disable Confirm Payment Button
            btnConfirmPayment.Enabled = isValid;            
        }
        
        private void SaveTransaction(decimal totalPrice)
        {
            int paymentId = Generate.GenerateUniqueId("Payments","PaymentId");
            DateTime paymentDate = DateTime.Now;
            string formattedPaymentDate = paymentDate.ToString("dd/MM/yyyy");

            MessageBox.Show($"Payment ID is: {paymentId}\n" +
                            $"Date/Time: {paymentDate}\n" +
                            $"Amount Paid: {totalPrice}", "Payment Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            string sSqlString = "INSERT INTO Payments (PaymentId, BookingId, PaymentDate, AmountPaid, PaymentMethod) VALUES (?, ?, ?, ?, ?)";
            using (OleDbConnection cnn = new OleDbConnection(CONNECTION_STRING))
            {
                using(OleDbCommand cmd = new OleDbCommand(sSqlString, cnn))
                {
                    cmd.Parameters.AddWithValue("?",paymentId);
                    cmd.Parameters.AddWithValue("?", UserSession.CurrentBookingId);
                    cmd.Parameters.AddWithValue("?", formattedPaymentDate);
                    cmd.Parameters.AddWithValue("?",totalPrice);
                    cmd.Parameters.AddWithValue("?", "Credit Card");

                    try
                    {
                        cnn.Open();
                        cmd.ExecuteNonQuery();

                        UserSession.UserPayments.Add(new Payment(paymentId,UserSession.CurrentBookingId, paymentDate, totalPrice, "Credit Card"));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving payment: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        
        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {

            if (btnConfirmPayment.Enabled)
            {
                DialogResult userConfirmation = MessageBox.Show("Confirm your payment?", "Payment Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(userConfirmation == DialogResult.Yes)
                {
                    try
                    {
                        decimal totalPrice = UserSession.SelectedSeats.Sum(seat => seat.SeatTypePrice);
                        SaveTransaction(totalPrice);

                        MessageBox.Show("Payment successfull", "Cinema Booking System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NavigationHelper.Navigate(this, new frmBookingConfirmation());
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Error occurred during payment processing: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }            
        }
        private void txtCardHolderName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCardHolderName.Text) || !Regex.IsMatch(txtCardHolderName.Text,@"^[a-zA-Z\s]+$"))
            {
                isCardHolderNameValid = false;
                txtCardHolderName.BackColor = Color.Pink;
                picCardHolderNameWarning.Visible = true;
                toolTip.SetToolTip(picCardHolderNameWarning, "Please enter a valid name (letters and spaces only).");
            }
            else
            {
                isCardHolderNameValid = true;
                txtCardHolderName.BackColor = Color.White;
                picCardHolderNameWarning.Visible = false;
            }
            ValidatePayment();
        }
        private void txtCardNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtCardNumber.Text.Length != 16 || !txtCardNumber.Text.All(char.IsDigit))
            {
                isCardNumberValid = false;
                txtCardNumber.BackColor = Color.Pink;
                picCardNumberWarning.Visible = true;
                toolTip.SetToolTip(picCardNumberWarning, "Card number must be 16 digits.");
            }
            else
            {
                isCardNumberValid = true;
                txtCardNumber.BackColor = Color.White;
                picCardNumberWarning.Visible = false;
            }
            ValidatePayment();
        }
        private void dtpExpiryDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpExpiryDate.Value.Date <= DateTime.Now.Date)
            {
                isExpiryDateValid = false;
                dtpExpiryDate.BackColor = Color.Pink;
                picExpiryDateWarning.Visible = true;
                toolTip.SetToolTip(picExpiryDateWarning, "Expiry date must be in the future.");
            }
            else
            {
                isExpiryDateValid = true;
                dtpExpiryDate.BackColor = Color.White;
                picExpiryDateWarning.Visible = false;
            }
            ValidatePayment();
        }
        private void txtCVV_TextChanged(object sender, EventArgs e)
        {
            if (txtCVV.Text.Length != 3 || !txtCVV.Text.All(char.IsDigit))
            {
                isCVVValid = false;
                txtCVV.BackColor = Color.Pink;
                picCVVWarning.Visible = true;
                toolTip.SetToolTip(picCVVWarning, "CVV must be 3 digits.");
            }
            else
            {
                isCVVValid = true;
                txtCVV.BackColor = Color.White;
                picCVVWarning.Visible = false;
            }
            ValidatePayment();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NavigationHelper.Navigate(this, new frmSeatSelection());
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

        
        public class SelectedSeat
        {
            public string SeatNumber { get; set; }
            public string SeatType { get; set; }
            public decimal Price { get; set; }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            NavigationHelper.Navigate(this, new frmMainMenu());
        }

        private void dgvSeatSummary_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
