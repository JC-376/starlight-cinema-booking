namespace Cinema_Booking_System
{
    partial class frmPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblCinemaBookingSystem = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCardHolderName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBookingSummary = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSeatSummary = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalPriceValue = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblSeatsValue = new System.Windows.Forms.Label();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.lblTimeValue = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDateValue = new System.Windows.Forms.Label();
            this.lblSeats = new System.Windows.Forms.Label();
            this.lblMovieTitleValue = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.picCardNumberWarning = new System.Windows.Forms.PictureBox();
            this.picShootingStars = new System.Windows.Forms.PictureBox();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.picCardHolderNameWarning = new System.Windows.Forms.PictureBox();
            this.picExpiryDateWarning = new System.Windows.Forms.PictureBox();
            this.picCVVWarning = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpBookingSummary.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeatSummary)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCardNumberWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShootingStars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCardHolderNameWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExpiryDateWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCVVWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumber.Location = new System.Drawing.Point(16, 104);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(180, 25);
            this.txtCardNumber.TabIndex = 1;
            this.txtCardNumber.TextChanged += new System.EventHandler(this.txtCardNumber_TextChanged);
            // 
            // txtCVV
            // 
            this.txtCVV.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVV.Location = new System.Drawing.Point(16, 226);
            this.txtCVV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(180, 25);
            this.txtCVV.TabIndex = 3;
            this.txtCVV.TextChanged += new System.EventHandler(this.txtCVV_TextChanged);
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnConfirmPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmPayment.FlatAppearance.BorderSize = 0;
            this.btnConfirmPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmPayment.ForeColor = System.Drawing.Color.White;
            this.btnConfirmPayment.Location = new System.Drawing.Point(17, 453);
            this.btnConfirmPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(235, 57);
            this.btnConfirmPayment.TabIndex = 4;
            this.btnConfirmPayment.Text = "Confirm Payment";
            this.btnConfirmPayment.UseVisualStyleBackColor = false;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.picShootingStars);
            this.panel1.Controls.Add(this.picLogout);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.lblCinemaBookingSystem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 567);
            this.panel1.TabIndex = 5;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(19, 107);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(254, 56);
            this.btnHome.TabIndex = 22;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(19, 513);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(263, 41);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblCinemaBookingSystem
            // 
            this.lblCinemaBookingSystem.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblCinemaBookingSystem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCinemaBookingSystem.ForeColor = System.Drawing.Color.White;
            this.lblCinemaBookingSystem.Location = new System.Drawing.Point(40, 27);
            this.lblCinemaBookingSystem.Name = "lblCinemaBookingSystem";
            this.lblCinemaBookingSystem.Size = new System.Drawing.Size(264, 31);
            this.lblCinemaBookingSystem.TabIndex = 0;
            this.lblCinemaBookingSystem.Text = "Cinema Booking System";
            this.lblCinemaBookingSystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.grpBookingSummary);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.btnConfirmPayment);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(293, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(752, 567);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picCVVWarning);
            this.groupBox3.Controls.Add(this.picExpiryDateWarning);
            this.groupBox3.Controls.Add(this.picCardHolderNameWarning);
            this.groupBox3.Controls.Add(this.picCardNumberWarning);
            this.groupBox3.Controls.Add(this.txtCVV);
            this.groupBox3.Controls.Add(this.dtpExpiryDate);
            this.groupBox3.Controls.Add(this.txtCardNumber);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtCardHolderName);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(510, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 270);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payment Details";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpiryDate.Location = new System.Drawing.Point(16, 164);
            this.dtpExpiryDate.MinDate = new System.DateTime(2024, 12, 28, 15, 27, 42, 0);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(180, 25);
            this.dtpExpiryDate.TabIndex = 2;
            this.dtpExpiryDate.Value = new System.DateTime(2024, 12, 28, 15, 27, 42, 0);
            this.dtpExpiryDate.ValueChanged += new System.EventHandler(this.dtpExpiryDate_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "CVV";
            // 
            // txtCardHolderName
            // 
            this.txtCardHolderName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardHolderName.Location = new System.Drawing.Point(16, 47);
            this.txtCardHolderName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCardHolderName.Name = "txtCardHolderName";
            this.txtCardHolderName.Size = new System.Drawing.Size(180, 25);
            this.txtCardHolderName.TabIndex = 0;
            this.txtCardHolderName.TextChanged += new System.EventHandler(this.txtCardHolderName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Expiry Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Cardholder Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Card Number";
            // 
            // grpBookingSummary
            // 
            this.grpBookingSummary.Controls.Add(this.groupBox1);
            this.grpBookingSummary.Controls.Add(this.groupBox2);
            this.grpBookingSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBookingSummary.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBookingSummary.Location = new System.Drawing.Point(17, 15);
            this.grpBookingSummary.Margin = new System.Windows.Forms.Padding(4);
            this.grpBookingSummary.Name = "grpBookingSummary";
            this.grpBookingSummary.Padding = new System.Windows.Forms.Padding(4);
            this.grpBookingSummary.Size = new System.Drawing.Size(486, 428);
            this.grpBookingSummary.TabIndex = 30;
            this.grpBookingSummary.TabStop = false;
            this.grpBookingSummary.Text = "Booking Summary";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSeatSummary);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 213);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(470, 208);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seat Details";
            // 
            // dgvSeatSummary
            // 
            this.dgvSeatSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeatSummary.Location = new System.Drawing.Point(8, 18);
            this.dgvSeatSummary.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSeatSummary.Name = "dgvSeatSummary";
            this.dgvSeatSummary.ReadOnly = true;
            this.dgvSeatSummary.RowHeadersWidth = 51;
            this.dgvSeatSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeatSummary.Size = new System.Drawing.Size(454, 182);
            this.dgvSeatSummary.TabIndex = 36;
            this.dgvSeatSummary.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSeatSummary_CellFormatting);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalPriceValue);
            this.groupBox2.Controls.Add(this.lblTotalPrice);
            this.groupBox2.Controls.Add(this.lblSeatsValue);
            this.groupBox2.Controls.Add(this.lblMovieTitle);
            this.groupBox2.Controls.Add(this.lblTimeValue);
            this.groupBox2.Controls.Add(this.lblDate);
            this.groupBox2.Controls.Add(this.lblTime);
            this.groupBox2.Controls.Add(this.lblDateValue);
            this.groupBox2.Controls.Add(this.lblSeats);
            this.groupBox2.Controls.Add(this.lblMovieTitleValue);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(470, 182);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movie Details";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblTotalPriceValue
            // 
            this.lblTotalPriceValue.AutoSize = true;
            this.lblTotalPriceValue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPriceValue.Location = new System.Drawing.Point(199, 150);
            this.lblTotalPriceValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPriceValue.Name = "lblTotalPriceValue";
            this.lblTotalPriceValue.Size = new System.Drawing.Size(90, 16);
            this.lblTotalPriceValue.TabIndex = 9;
            this.lblTotalPriceValue.Text = "[Total Price]";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(13, 150);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(84, 16);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // lblSeatsValue
            // 
            this.lblSeatsValue.AutoSize = true;
            this.lblSeatsValue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeatsValue.Location = new System.Drawing.Point(199, 117);
            this.lblSeatsValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeatsValue.Name = "lblSeatsValue";
            this.lblSeatsValue.Size = new System.Drawing.Size(118, 16);
            this.lblSeatsValue.TabIndex = 8;
            this.lblSeatsValue.Text = "[Selected Seats]";
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieTitle.Location = new System.Drawing.Point(13, 23);
            this.lblMovieTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(51, 16);
            this.lblMovieTitle.TabIndex = 0;
            this.lblMovieTitle.Text = "Movie:";
            // 
            // lblTimeValue
            // 
            this.lblTimeValue.AutoSize = true;
            this.lblTimeValue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeValue.Location = new System.Drawing.Point(199, 85);
            this.lblTimeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeValue.Name = "lblTimeValue";
            this.lblTimeValue.Size = new System.Drawing.Size(50, 16);
            this.lblTimeValue.TabIndex = 7;
            this.lblTimeValue.Text = "[Time]";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(13, 52);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 16);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(13, 85);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(44, 16);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time:";
            // 
            // lblDateValue
            // 
            this.lblDateValue.AutoSize = true;
            this.lblDateValue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateValue.Location = new System.Drawing.Point(199, 52);
            this.lblDateValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateValue.Name = "lblDateValue";
            this.lblDateValue.Size = new System.Drawing.Size(48, 16);
            this.lblDateValue.TabIndex = 6;
            this.lblDateValue.Text = "[Date]";
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeats.Location = new System.Drawing.Point(13, 117);
            this.lblSeats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(49, 16);
            this.lblSeats.TabIndex = 3;
            this.lblSeats.Text = "Seats:";
            // 
            // lblMovieTitleValue
            // 
            this.lblMovieTitleValue.AutoEllipsis = true;
            this.lblMovieTitleValue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieTitleValue.Location = new System.Drawing.Point(199, 23);
            this.lblMovieTitleValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovieTitleValue.Name = "lblMovieTitleValue";
            this.lblMovieTitleValue.Size = new System.Drawing.Size(248, 18);
            this.lblMovieTitleValue.TabIndex = 5;
            this.lblMovieTitleValue.Text = "[Movie Title]";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(15, 514);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 42);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picCardNumberWarning
            // 
            this.picCardNumberWarning.Image = global::Cinema_Booking_System.Properties.Resources.exclamation;
            this.picCardNumberWarning.Location = new System.Drawing.Point(199, 104);
            this.picCardNumberWarning.Name = "picCardNumberWarning";
            this.picCardNumberWarning.Size = new System.Drawing.Size(25, 25);
            this.picCardNumberWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCardNumberWarning.TabIndex = 38;
            this.picCardNumberWarning.TabStop = false;
            // 
            // picShootingStars
            // 
            this.picShootingStars.Image = ((System.Drawing.Image)(resources.GetObject("picShootingStars.Image")));
            this.picShootingStars.Location = new System.Drawing.Point(1, 27);
            this.picShootingStars.Margin = new System.Windows.Forms.Padding(4);
            this.picShootingStars.Name = "picShootingStars";
            this.picShootingStars.Size = new System.Drawing.Size(49, 33);
            this.picShootingStars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShootingStars.TabIndex = 9;
            this.picShootingStars.TabStop = false;
            // 
            // picLogout
            // 
            this.picLogout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogout.Image = ((System.Drawing.Image)(resources.GetObject("picLogout.Image")));
            this.picLogout.Location = new System.Drawing.Point(19, 513);
            this.picLogout.Margin = new System.Windows.Forms.Padding(4);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(50, 45);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogout.TabIndex = 9;
            this.picLogout.TabStop = false;
            // 
            // picCardHolderNameWarning
            // 
            this.picCardHolderNameWarning.Image = global::Cinema_Booking_System.Properties.Resources.exclamation;
            this.picCardHolderNameWarning.Location = new System.Drawing.Point(199, 47);
            this.picCardHolderNameWarning.Name = "picCardHolderNameWarning";
            this.picCardHolderNameWarning.Size = new System.Drawing.Size(25, 25);
            this.picCardHolderNameWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCardHolderNameWarning.TabIndex = 42;
            this.picCardHolderNameWarning.TabStop = false;
            // 
            // picExpiryDateWarning
            // 
            this.picExpiryDateWarning.Image = global::Cinema_Booking_System.Properties.Resources.exclamation;
            this.picExpiryDateWarning.Location = new System.Drawing.Point(199, 164);
            this.picExpiryDateWarning.Name = "picExpiryDateWarning";
            this.picExpiryDateWarning.Size = new System.Drawing.Size(25, 25);
            this.picExpiryDateWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExpiryDateWarning.TabIndex = 43;
            this.picExpiryDateWarning.TabStop = false;
            // 
            // picCVVWarning
            // 
            this.picCVVWarning.Image = global::Cinema_Booking_System.Properties.Resources.exclamation;
            this.picCVVWarning.Location = new System.Drawing.Point(199, 226);
            this.picCVVWarning.Name = "picCVVWarning";
            this.picCVVWarning.Size = new System.Drawing.Size(25, 25);
            this.picCVVWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCVVWarning.TabIndex = 44;
            this.picCVVWarning.TabStop = false;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPayment";
            this.Text = "Payment Form";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpBookingSummary.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeatSummary)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCardNumberWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShootingStars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCardHolderNameWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExpiryDateWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCVVWarning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Button btnConfirmPayment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picShootingStars;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblCinemaBookingSystem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCardHolderName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpBookingSummary;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalPriceValue;
        private System.Windows.Forms.Label lblSeatsValue;
        private System.Windows.Forms.Label lblTimeValue;
        private System.Windows.Forms.Label lblDateValue;
        private System.Windows.Forms.Label lblMovieTitleValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSeatSummary;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox picCardNumberWarning;
        private System.Windows.Forms.PictureBox picCVVWarning;
        private System.Windows.Forms.PictureBox picExpiryDateWarning;
        private System.Windows.Forms.PictureBox picCardHolderNameWarning;
    }
}