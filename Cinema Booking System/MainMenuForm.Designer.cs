namespace Cinema_Booking_System
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.lblCinemaBookingSystem = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBookMovies = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picShootingStars = new System.Windows.Forms.PictureBox();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLatestMovies = new System.Windows.Forms.Label();
            this.lstLatestMovies = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShootingStars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCinemaBookingSystem
            // 
            this.lblCinemaBookingSystem.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblCinemaBookingSystem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCinemaBookingSystem.ForeColor = System.Drawing.Color.White;
            this.lblCinemaBookingSystem.Location = new System.Drawing.Point(30, 22);
            this.lblCinemaBookingSystem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCinemaBookingSystem.Name = "lblCinemaBookingSystem";
            this.lblCinemaBookingSystem.Size = new System.Drawing.Size(198, 25);
            this.lblCinemaBookingSystem.TabIndex = 0;
            this.lblCinemaBookingSystem.Text = "Cinema Booking System";
            this.lblCinemaBookingSystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCinemaBookingSystem.Click += new System.EventHandler(this.lblCinemaBookingSystem_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(26, 91);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(170, 55);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(26, 170);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(170, 55);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnBookMovies
            // 
            this.btnBookMovies.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBookMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookMovies.FlatAppearance.BorderSize = 0;
            this.btnBookMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookMovies.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookMovies.ForeColor = System.Drawing.Color.White;
            this.btnBookMovies.Location = new System.Drawing.Point(26, 257);
            this.btnBookMovies.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookMovies.Name = "btnBookMovies";
            this.btnBookMovies.Size = new System.Drawing.Size(170, 55);
            this.btnBookMovies.TabIndex = 3;
            this.btnBookMovies.Text = "Book Movies";
            this.btnBookMovies.UseVisualStyleBackColor = false;
            this.btnBookMovies.Click += new System.EventHandler(this.btnBookMovies_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.picShootingStars);
            this.panel1.Controls.Add(this.picLogout);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.lblCinemaBookingSystem);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.btnBookMovies);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 461);
            this.panel1.TabIndex = 4;
            // 
            // picShootingStars
            // 
            this.picShootingStars.Image = ((System.Drawing.Image)(resources.GetObject("picShootingStars.Image")));
            this.picShootingStars.Location = new System.Drawing.Point(1, 22);
            this.picShootingStars.Name = "picShootingStars";
            this.picShootingStars.Size = new System.Drawing.Size(37, 27);
            this.picShootingStars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShootingStars.TabIndex = 9;
            this.picShootingStars.TabStop = false;
            // 
            // picLogout
            // 
            this.picLogout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogout.Image = ((System.Drawing.Image)(resources.GetObject("picLogout.Image")));
            this.picLogout.Location = new System.Drawing.Point(14, 417);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(38, 37);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogout.TabIndex = 9;
            this.picLogout.TabStop = false;
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
            this.btnLogout.Location = new System.Drawing.Point(14, 417);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(197, 33);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblLatestMovies);
            this.panel2.Controls.Add(this.lstLatestMovies);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(220, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 461);
            this.panel2.TabIndex = 5;
            // 
            // lblLatestMovies
            // 
            this.lblLatestMovies.AutoSize = true;
            this.lblLatestMovies.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatestMovies.Location = new System.Drawing.Point(12, 266);
            this.lblLatestMovies.Name = "lblLatestMovies";
            this.lblLatestMovies.Size = new System.Drawing.Size(107, 17);
            this.lblLatestMovies.TabIndex = 8;
            this.lblLatestMovies.Text = "Latest Movies";
            // 
            // lstLatestMovies
            // 
            this.lstLatestMovies.BackColor = System.Drawing.Color.MidnightBlue;
            this.lstLatestMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstLatestMovies.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLatestMovies.ForeColor = System.Drawing.Color.White;
            this.lstLatestMovies.FormattingEnabled = true;
            this.lstLatestMovies.ItemHeight = 17;
            this.lstLatestMovies.Items.AddRange(new object[] {
            "Venom: The Last Dance",
            "Gladiator 2",
            "Blink Twice",
            "Uglies",
            "Rebel Ridge",
            "Longlegs",
            "The Fall Guy",
            "Monster",
            "Spaceman",
            "Megamind vs. the Doom Syndic",
            "Civil War"});
            this.lstLatestMovies.Location = new System.Drawing.Point(15, 297);
            this.lstLatestMovies.Name = "lstLatestMovies";
            this.lstLatestMovies.ScrollAlwaysVisible = true;
            this.lstLatestMovies.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstLatestMovies.Size = new System.Drawing.Size(260, 72);
            this.lstLatestMovies.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.richTextBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(15, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(537, 226);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picShootingStars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCinemaBookingSystem;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBookMovies;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblLatestMovies;
        private System.Windows.Forms.ListBox lstLatestMovies;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.PictureBox picShootingStars;
    }
}

