namespace Cinema_Booking_System
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLoginAccount = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCinemaBookingSystem = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBookMovies = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCreateAccount = new System.Windows.Forms.Label();
            this.lblDontHaveAnAccount = new System.Windows.Forms.Label();
            this.picShootingStars = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShootingStars)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(347, 161);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(260, 22);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(347, 335);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(261, 60);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLoginAccount
            // 
            this.lblLoginAccount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginAccount.Location = new System.Drawing.Point(343, 82);
            this.lblLoginAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginAccount.Name = "lblLoginAccount";
            this.lblLoginAccount.Size = new System.Drawing.Size(155, 23);
            this.lblLoginAccount.TabIndex = 3;
            this.lblLoginAccount.Text = "Login Account";
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(343, 137);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(119, 22);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(343, 207);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(119, 22);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(347, 231);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(260, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkShowPassword.Location = new System.Drawing.Point(347, 262);
            this.chkShowPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(121, 20);
            this.chkShowPassword.TabIndex = 2;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblCinemaBookingSystem);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.btnBookMovies);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 567);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.picShootingStars);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 567);
            this.panel2.TabIndex = 8;
            // 
            // lblCinemaBookingSystem
            // 
            this.lblCinemaBookingSystem.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblCinemaBookingSystem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCinemaBookingSystem.ForeColor = System.Drawing.Color.White;
            this.lblCinemaBookingSystem.Location = new System.Drawing.Point(16, 38);
            this.lblCinemaBookingSystem.Name = "lblCinemaBookingSystem";
            this.lblCinemaBookingSystem.Size = new System.Drawing.Size(264, 31);
            this.lblCinemaBookingSystem.TabIndex = 4;
            this.lblCinemaBookingSystem.Text = "Cinema Booking System";
            this.lblCinemaBookingSystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(36, 220);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(227, 68);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnBookMovies
            // 
            this.btnBookMovies.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBookMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookMovies.FlatAppearance.BorderSize = 0;
            this.btnBookMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookMovies.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookMovies.ForeColor = System.Drawing.Color.White;
            this.btnBookMovies.Location = new System.Drawing.Point(36, 327);
            this.btnBookMovies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBookMovies.Name = "btnBookMovies";
            this.btnBookMovies.Size = new System.Drawing.Size(227, 68);
            this.btnBookMovies.TabIndex = 7;
            this.btnBookMovies.Text = "Book Movies";
            this.btnBookMovies.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(36, 123);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 68);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(641, 335);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(261, 60);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblCreateAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCreateAccount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAccount.ForeColor = System.Drawing.Color.White;
            this.lblCreateAccount.Location = new System.Drawing.Point(347, 431);
            this.lblCreateAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(261, 29);
            this.lblCreateAccount.TabIndex = 5;
            this.lblCreateAccount.Text = "Create Account";
            this.lblCreateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCreateAccount.Click += new System.EventHandler(this.lblCreateAccount_Click);
            // 
            // lblDontHaveAnAccount
            // 
            this.lblDontHaveAnAccount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDontHaveAnAccount.ForeColor = System.Drawing.Color.Black;
            this.lblDontHaveAnAccount.Location = new System.Drawing.Point(347, 410);
            this.lblDontHaveAnAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDontHaveAnAccount.Name = "lblDontHaveAnAccount";
            this.lblDontHaveAnAccount.Size = new System.Drawing.Size(261, 21);
            this.lblDontHaveAnAccount.TabIndex = 21;
            this.lblDontHaveAnAccount.Text = "Don\'t have an Account?";
            this.lblDontHaveAnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picShootingStars
            // 
            this.picShootingStars.Image = ((System.Drawing.Image)(resources.GetObject("picShootingStars.Image")));
            this.picShootingStars.Location = new System.Drawing.Point(1, 27);
            this.picShootingStars.Margin = new System.Windows.Forms.Padding(4);
            this.picShootingStars.Name = "picShootingStars";
            this.picShootingStars.Size = new System.Drawing.Size(49, 33);
            this.picShootingStars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShootingStars.TabIndex = 17;
            this.picShootingStars.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cinema Booking System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.lblCreateAccount);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblDontHaveAnAccount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLoginAccount);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUsername);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picShootingStars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLoginAccount;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCinemaBookingSystem;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBookMovies;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCreateAccount;
        private System.Windows.Forms.Label lblDontHaveAnAccount;
        private System.Windows.Forms.PictureBox picShootingStars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHome;
    }
}