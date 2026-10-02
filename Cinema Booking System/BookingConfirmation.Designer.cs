namespace Cinema_Booking_System
{
    partial class frmBookingConfirmation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookingConfirmation));
            this.grpBookingConfirmation = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDuration = new System.Windows.Forms.Label();
            this.btnGenerateTicket = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.btnConfirmBooking = new System.Windows.Forms.Button();
            this.lblSeats = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSeatSummary2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewBookings = new System.Windows.Forms.Button();
            this.btnBookMovies = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblCinemaBooking = new System.Windows.Forms.Label();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.picShootingStars = new System.Windows.Forms.PictureBox();
            this.grpBookingConfirmation.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeatSummary2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShootingStars)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBookingConfirmation
            // 
            this.grpBookingConfirmation.Controls.Add(this.btnCancel);
            this.grpBookingConfirmation.Controls.Add(this.btnBack);
            this.grpBookingConfirmation.Controls.Add(this.lblDuration);
            this.grpBookingConfirmation.Controls.Add(this.btnGenerateTicket);
            this.grpBookingConfirmation.Controls.Add(this.label17);
            this.grpBookingConfirmation.Controls.Add(this.btnConfirmBooking);
            this.grpBookingConfirmation.Controls.Add(this.lblSeats);
            this.grpBookingConfirmation.Controls.Add(this.lblTime);
            this.grpBookingConfirmation.Controls.Add(this.lblMovieName);
            this.grpBookingConfirmation.Controls.Add(this.lblPhoneNumber);
            this.grpBookingConfirmation.Controls.Add(this.label12);
            this.grpBookingConfirmation.Controls.Add(this.lblEmailAddress);
            this.grpBookingConfirmation.Controls.Add(this.label10);
            this.grpBookingConfirmation.Controls.Add(this.panel7);
            this.grpBookingConfirmation.Controls.Add(this.lblFullName);
            this.grpBookingConfirmation.Controls.Add(this.label8);
            this.grpBookingConfirmation.Controls.Add(this.panel6);
            this.grpBookingConfirmation.Controls.Add(this.panel5);
            this.grpBookingConfirmation.Controls.Add(this.label5);
            this.grpBookingConfirmation.Controls.Add(this.label4);
            this.grpBookingConfirmation.Controls.Add(this.label3);
            this.grpBookingConfirmation.Controls.Add(this.label1);
            this.grpBookingConfirmation.Controls.Add(this.dgvSeatSummary2);
            this.grpBookingConfirmation.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBookingConfirmation.Location = new System.Drawing.Point(301, 13);
            this.grpBookingConfirmation.Margin = new System.Windows.Forms.Padding(4);
            this.grpBookingConfirmation.Name = "grpBookingConfirmation";
            this.grpBookingConfirmation.Padding = new System.Windows.Forms.Padding(4);
            this.grpBookingConfirmation.Size = new System.Drawing.Size(738, 545);
            this.grpBookingConfirmation.TabIndex = 24;
            this.grpBookingConfirmation.TabStop = false;
            this.grpBookingConfirmation.Text = "Booking Details";
            this.grpBookingConfirmation.Enter += new System.EventHandler(this.grpBookingConfirmation_Enter);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(117, 488);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(187, 49);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(447, 488);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(187, 49);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDuration
            // 
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(161, 68);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(192, 23);
            this.lblDuration.TabIndex = 57;
            this.lblDuration.Text = "[100 min]";
            // 
            // btnGenerateTicket
            // 
            this.btnGenerateTicket.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGenerateTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateTicket.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateTicket.ForeColor = System.Drawing.Color.White;
            this.btnGenerateTicket.Location = new System.Drawing.Point(217, 431);
            this.btnGenerateTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateTicket.Name = "btnGenerateTicket";
            this.btnGenerateTicket.Size = new System.Drawing.Size(187, 49);
            this.btnGenerateTicket.TabIndex = 30;
            this.btnGenerateTicket.Text = "Generate Ticket";
            this.btnGenerateTicket.UseVisualStyleBackColor = false;
            this.btnGenerateTicket.Click += new System.EventHandler(this.btnGenerateTicket_Click);
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(11, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 23);
            this.label17.TabIndex = 56;
            this.label17.Text = "Duration:";
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnConfirmBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmBooking.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmBooking.ForeColor = System.Drawing.Color.White;
            this.btnConfirmBooking.Location = new System.Drawing.Point(22, 431);
            this.btnConfirmBooking.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.Size = new System.Drawing.Size(187, 49);
            this.btnConfirmBooking.TabIndex = 29;
            this.btnConfirmBooking.Text = "Confirm Booking";
            this.btnConfirmBooking.UseVisualStyleBackColor = false;
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);
            // 
            // lblSeats
            // 
            this.lblSeats.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeats.Location = new System.Drawing.Point(161, 141);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(192, 23);
            this.lblSeats.TabIndex = 55;
            this.lblSeats.Text = "[A1, A2, A3]";
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(161, 103);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(192, 23);
            this.lblTime.TabIndex = 54;
            this.lblTime.Text = "[Time]";
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoEllipsis = true;
            this.lblMovieName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.Location = new System.Drawing.Point(161, 33);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(192, 23);
            this.lblMovieName.TabIndex = 53;
            this.lblMovieName.Text = "[Movie Name]";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(519, 113);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(133, 20);
            this.lblPhoneNumber.TabIndex = 52;
            this.lblPhoneNumber.Text = "[Contact Number]";
            this.lblPhoneNumber.MouseEnter += new System.EventHandler(this.lblPhoneNumber_MouseEnter);
            this.lblPhoneNumber.MouseLeave += new System.EventHandler(this.lblPhoneNumber_MouseLeave);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(393, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 48);
            this.label12.TabIndex = 51;
            this.label12.Text = "Phone Number:\r\n(Optional)";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoEllipsis = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.Location = new System.Drawing.Point(464, 71);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(237, 20);
            this.lblEmailAddress.TabIndex = 50;
            this.lblEmailAddress.Text = "[Email Address]";
            this.lblEmailAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(393, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 23);
            this.label10.TabIndex = 49;
            this.label10.Text = "Email:";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lblPrice);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(15, 366);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(289, 40);
            this.panel7.TabIndex = 48;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(163, 6);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(73, 23);
            this.lblPrice.TabIndex = 43;
            this.lblPrice.Text = "[Value]";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 23);
            this.label6.TabIndex = 42;
            this.label6.Text = "Total Price:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoEllipsis = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(468, 33);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(232, 23);
            this.lblFullName.TabIndex = 47;
            this.lblFullName.Text = "[Full Name]";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(393, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 23);
            this.label8.TabIndex = 46;
            this.label8.Text = "Name:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel6.Location = new System.Drawing.Point(371, 17);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 169);
            this.panel6.TabIndex = 45;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Location = new System.Drawing.Point(10, 181);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(720, 5);
            this.panel5.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 23);
            this.label5.TabIndex = 41;
            this.label5.Text = "Selected Seats:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 40;
            this.label4.Text = "Showtime:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Movie:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "Summary of Seats";
            // 
            // dgvSeatSummary2
            // 
            this.dgvSeatSummary2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeatSummary2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeatSummary2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSeatSummary2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSeatSummary2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSeatSummary2.Location = new System.Drawing.Point(15, 224);
            this.dgvSeatSummary2.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSeatSummary2.Name = "dgvSeatSummary2";
            this.dgvSeatSummary2.ReadOnly = true;
            this.dgvSeatSummary2.RowHeadersVisible = false;
            this.dgvSeatSummary2.RowHeadersWidth = 51;
            this.dgvSeatSummary2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeatSummary2.Size = new System.Drawing.Size(682, 135);
            this.dgvSeatSummary2.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnViewBookings);
            this.panel1.Controls.Add(this.btnBookMovies);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.picLogout);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.picShootingStars);
            this.panel1.Controls.Add(this.lblCinemaBooking);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 567);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnViewBookings
            // 
            this.btnViewBookings.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnViewBookings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewBookings.FlatAppearance.BorderSize = 0;
            this.btnViewBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBookings.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBookings.ForeColor = System.Drawing.Color.White;
            this.btnViewBookings.Location = new System.Drawing.Point(19, 282);
            this.btnViewBookings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewBookings.Name = "btnViewBookings";
            this.btnViewBookings.Size = new System.Drawing.Size(254, 53);
            this.btnViewBookings.TabIndex = 23;
            this.btnViewBookings.Text = "View Bookings";
            this.btnViewBookings.UseVisualStyleBackColor = false;
            this.btnViewBookings.Click += new System.EventHandler(this.btnViewBookings_Click);
            // 
            // btnBookMovies
            // 
            this.btnBookMovies.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBookMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookMovies.FlatAppearance.BorderSize = 0;
            this.btnBookMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookMovies.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookMovies.ForeColor = System.Drawing.Color.White;
            this.btnBookMovies.Location = new System.Drawing.Point(19, 194);
            this.btnBookMovies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBookMovies.Name = "btnBookMovies";
            this.btnBookMovies.Size = new System.Drawing.Size(254, 53);
            this.btnBookMovies.TabIndex = 22;
            this.btnBookMovies.Text = "Book Movies";
            this.btnBookMovies.UseVisualStyleBackColor = false;
            this.btnBookMovies.Click += new System.EventHandler(this.btnBookMovies_Click);
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
            this.btnHome.TabIndex = 21;
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
            this.btnLogout.TabIndex = 19;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblCinemaBooking
            // 
            this.lblCinemaBooking.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblCinemaBooking.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCinemaBooking.ForeColor = System.Drawing.Color.White;
            this.lblCinemaBooking.Location = new System.Drawing.Point(40, 27);
            this.lblCinemaBooking.Name = "lblCinemaBooking";
            this.lblCinemaBooking.Size = new System.Drawing.Size(264, 31);
            this.lblCinemaBooking.TabIndex = 17;
            this.lblCinemaBooking.Text = "Cinema Booking System";
            this.lblCinemaBooking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.picLogout.TabIndex = 20;
            this.picLogout.TabStop = false;
            // 
            // picShootingStars
            // 
            this.picShootingStars.Image = ((System.Drawing.Image)(resources.GetObject("picShootingStars.Image")));
            this.picShootingStars.Location = new System.Drawing.Point(1, 27);
            this.picShootingStars.Margin = new System.Windows.Forms.Padding(4);
            this.picShootingStars.Name = "picShootingStars";
            this.picShootingStars.Size = new System.Drawing.Size(49, 33);
            this.picShootingStars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShootingStars.TabIndex = 18;
            this.picShootingStars.TabStop = false;
            // 
            // frmBookingConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.grpBookingConfirmation);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBookingConfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking Confirmation Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBookingConfirmation_FormClosing);
            this.Load += new System.EventHandler(this.frmBookingConfirmation_Load);
            this.grpBookingConfirmation.ResumeLayout(false);
            this.grpBookingConfirmation.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeatSummary2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShootingStars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBookingConfirmation;
        private System.Windows.Forms.DataGridView dgvSeatSummary2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnConfirmBooking;
        private System.Windows.Forms.Button btnGenerateTicket;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox picShootingStars;
        private System.Windows.Forms.Label lblCinemaBooking;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnViewBookings;
        private System.Windows.Forms.Button btnBookMovies;
        private System.Windows.Forms.Button btnCancel;
    }
}