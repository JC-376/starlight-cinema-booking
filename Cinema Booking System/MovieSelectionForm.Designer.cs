namespace Cinema_Booking_System
{
    partial class frmMovieSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovieSelection));
            this.pnlMovieSelection = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picShootingStars = new System.Windows.Forms.PictureBox();
            this.lblCinemaBookingSystem = new System.Windows.Forms.Label();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchMovies = new System.Windows.Forms.Label();
            this.cmbGenreFilter = new System.Windows.Forms.ComboBox();
            this.cmbSortBy = new System.Windows.Forms.ComboBox();
            this.lblGenreFilter = new System.Windows.Forms.Label();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.btnSelectMovie = new System.Windows.Forms.Button();
            this.dgvMovieDetails = new System.Windows.Forms.DataGridView();
            this.grpFilterBy = new System.Windows.Forms.GroupBox();
            this.rdoDuration = new System.Windows.Forms.RadioButton();
            this.rdoDirector = new System.Windows.Forms.RadioButton();
            this.rdoNone = new System.Windows.Forms.RadioButton();
            this.rdoAgeRating = new System.Windows.Forms.RadioButton();
            this.lblBackToMainMenu = new System.Windows.Forms.Label();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.cmbAgeRating = new System.Windows.Forms.ComboBox();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.txtDisplayMovieId = new System.Windows.Forms.TextBox();
            this.lblDisplayMovieId = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlMovieSelection.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShootingStars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieDetails)).BeginInit();
            this.grpFilterBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMovieSelection
            // 
            this.pnlMovieSelection.Controls.Add(this.panel1);
            this.pnlMovieSelection.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMovieSelection.Location = new System.Drawing.Point(0, 0);
            this.pnlMovieSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMovieSelection.Name = "pnlMovieSelection";
            this.pnlMovieSelection.Size = new System.Drawing.Size(293, 567);
            this.pnlMovieSelection.TabIndex = 2;
            this.pnlMovieSelection.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMovieSelection_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.picShootingStars);
            this.panel1.Controls.Add(this.lblCinemaBookingSystem);
            this.panel1.Controls.Add(this.picLogout);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 567);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // picShootingStars
            // 
            this.picShootingStars.Image = ((System.Drawing.Image)(resources.GetObject("picShootingStars.Image")));
            this.picShootingStars.Location = new System.Drawing.Point(1, 27);
            this.picShootingStars.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picShootingStars.Name = "picShootingStars";
            this.picShootingStars.Size = new System.Drawing.Size(49, 33);
            this.picShootingStars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShootingStars.TabIndex = 15;
            this.picShootingStars.TabStop = false;
            // 
            // lblCinemaBookingSystem
            // 
            this.lblCinemaBookingSystem.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblCinemaBookingSystem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCinemaBookingSystem.ForeColor = System.Drawing.Color.White;
            this.lblCinemaBookingSystem.Location = new System.Drawing.Point(40, 27);
            this.lblCinemaBookingSystem.Name = "lblCinemaBookingSystem";
            this.lblCinemaBookingSystem.Size = new System.Drawing.Size(264, 31);
            this.lblCinemaBookingSystem.TabIndex = 14;
            this.lblCinemaBookingSystem.Text = "Cinema Booking System";
            this.lblCinemaBookingSystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogout
            // 
            this.picLogout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogout.Image = ((System.Drawing.Image)(resources.GetObject("picLogout.Image")));
            this.picLogout.Location = new System.Drawing.Point(19, 513);
            this.picLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(50, 45);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogout.TabIndex = 13;
            this.picLogout.TabStop = false;
            this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
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
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(321, 47);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(193, 28);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearchMovies
            // 
            this.lblSearchMovies.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchMovies.Location = new System.Drawing.Point(317, 21);
            this.lblSearchMovies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchMovies.Name = "lblSearchMovies";
            this.lblSearchMovies.Size = new System.Drawing.Size(165, 23);
            this.lblSearchMovies.TabIndex = 19;
            this.lblSearchMovies.Text = "Search Movies:";
            // 
            // cmbGenreFilter
            // 
            this.cmbGenreFilter.AllowDrop = true;
            this.cmbGenreFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbGenreFilter.FormattingEnabled = true;
            this.cmbGenreFilter.Location = new System.Drawing.Point(321, 110);
            this.cmbGenreFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGenreFilter.Name = "cmbGenreFilter";
            this.cmbGenreFilter.Size = new System.Drawing.Size(193, 24);
            this.cmbGenreFilter.TabIndex = 20;
            this.cmbGenreFilter.Text = "Genre";
            this.cmbGenreFilter.SelectedIndexChanged += new System.EventHandler(this.cmbGenreFilter_SelectedIndexChanged);
            // 
            // cmbSortBy
            // 
            this.cmbSortBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSortBy.FormattingEnabled = true;
            this.cmbSortBy.Location = new System.Drawing.Point(321, 165);
            this.cmbSortBy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSortBy.Name = "cmbSortBy";
            this.cmbSortBy.Size = new System.Drawing.Size(193, 24);
            this.cmbSortBy.TabIndex = 21;
            this.cmbSortBy.Text = "Sort By";
            this.cmbSortBy.SelectedIndexChanged += new System.EventHandler(this.cmbSortBy_SelectedIndexChanged);
            // 
            // lblGenreFilter
            // 
            this.lblGenreFilter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreFilter.Location = new System.Drawing.Point(319, 82);
            this.lblGenreFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenreFilter.Name = "lblGenreFilter";
            this.lblGenreFilter.Size = new System.Drawing.Size(141, 23);
            this.lblGenreFilter.TabIndex = 22;
            this.lblGenreFilter.Text = "Genre Filter:";
            // 
            // lblSortBy
            // 
            this.lblSortBy.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortBy.Location = new System.Drawing.Point(319, 138);
            this.lblSortBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(97, 23);
            this.lblSortBy.TabIndex = 23;
            this.lblSortBy.Text = "Sort By:";
            // 
            // btnSelectMovie
            // 
            this.btnSelectMovie.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSelectMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectMovie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectMovie.ForeColor = System.Drawing.Color.White;
            this.btnSelectMovie.Location = new System.Drawing.Point(315, 466);
            this.btnSelectMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectMovie.Name = "btnSelectMovie";
            this.btnSelectMovie.Size = new System.Drawing.Size(267, 62);
            this.btnSelectMovie.TabIndex = 1;
            this.btnSelectMovie.Text = "Select Movie";
            this.btnSelectMovie.UseVisualStyleBackColor = false;
            this.btnSelectMovie.Click += new System.EventHandler(this.btnSelectMovie_Click);
            // 
            // dgvMovieDetails
            // 
            this.dgvMovieDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovieDetails.Location = new System.Drawing.Point(300, 293);
            this.dgvMovieDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMovieDetails.Name = "dgvMovieDetails";
            this.dgvMovieDetails.RowHeadersWidth = 51;
            this.dgvMovieDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovieDetails.Size = new System.Drawing.Size(729, 167);
            this.dgvMovieDetails.TabIndex = 24;
            this.dgvMovieDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovieDetails_CellClick);
            this.dgvMovieDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovieDetails_CellContentClick);
            // 
            // grpFilterBy
            // 
            this.grpFilterBy.Controls.Add(this.rdoDuration);
            this.grpFilterBy.Controls.Add(this.rdoDirector);
            this.grpFilterBy.Controls.Add(this.rdoNone);
            this.grpFilterBy.Controls.Add(this.rdoAgeRating);
            this.grpFilterBy.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFilterBy.Location = new System.Drawing.Point(791, 21);
            this.grpFilterBy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpFilterBy.Name = "grpFilterBy";
            this.grpFilterBy.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpFilterBy.Size = new System.Drawing.Size(239, 177);
            this.grpFilterBy.TabIndex = 25;
            this.grpFilterBy.TabStop = false;
            this.grpFilterBy.Text = "Filter By";
            // 
            // rdoDuration
            // 
            this.rdoDuration.AutoSize = true;
            this.rdoDuration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDuration.Location = new System.Drawing.Point(24, 95);
            this.rdoDuration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoDuration.Name = "rdoDuration";
            this.rdoDuration.Size = new System.Drawing.Size(101, 24);
            this.rdoDuration.TabIndex = 35;
            this.rdoDuration.TabStop = true;
            this.rdoDuration.Text = "Duration";
            this.rdoDuration.UseVisualStyleBackColor = true;
            this.rdoDuration.CheckedChanged += new System.EventHandler(this.rdoDuration_CheckedChanged);
            // 
            // rdoDirector
            // 
            this.rdoDirector.AutoSize = true;
            this.rdoDirector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDirector.Location = new System.Drawing.Point(24, 64);
            this.rdoDirector.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoDirector.Name = "rdoDirector";
            this.rdoDirector.Size = new System.Drawing.Size(98, 24);
            this.rdoDirector.TabIndex = 25;
            this.rdoDirector.TabStop = true;
            this.rdoDirector.Text = "Director";
            this.rdoDirector.UseVisualStyleBackColor = true;
            this.rdoDirector.CheckedChanged += new System.EventHandler(this.rdoDirector_CheckedChanged);
            // 
            // rdoNone
            // 
            this.rdoNone.AutoSize = true;
            this.rdoNone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoNone.Location = new System.Drawing.Point(24, 146);
            this.rdoNone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoNone.Name = "rdoNone";
            this.rdoNone.Size = new System.Drawing.Size(73, 24);
            this.rdoNone.TabIndex = 24;
            this.rdoNone.TabStop = true;
            this.rdoNone.Text = "None";
            this.rdoNone.UseVisualStyleBackColor = true;
            this.rdoNone.CheckedChanged += new System.EventHandler(this.rdoNone_CheckedChanged);
            this.rdoNone.Click += new System.EventHandler(this.rdoNone_CheckedChanged);
            // 
            // rdoAgeRating
            // 
            this.rdoAgeRating.AutoSize = true;
            this.rdoAgeRating.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoAgeRating.Location = new System.Drawing.Point(24, 33);
            this.rdoAgeRating.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoAgeRating.Name = "rdoAgeRating";
            this.rdoAgeRating.Size = new System.Drawing.Size(121, 24);
            this.rdoAgeRating.TabIndex = 20;
            this.rdoAgeRating.TabStop = true;
            this.rdoAgeRating.Text = "Age Rating";
            this.rdoAgeRating.UseVisualStyleBackColor = true;
            this.rdoAgeRating.CheckedChanged += new System.EventHandler(this.rdoAgeRating_CheckedChanged);
            // 
            // lblBackToMainMenu
            // 
            this.lblBackToMainMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblBackToMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBackToMainMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackToMainMenu.ForeColor = System.Drawing.Color.White;
            this.lblBackToMainMenu.Location = new System.Drawing.Point(316, 530);
            this.lblBackToMainMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBackToMainMenu.Name = "lblBackToMainMenu";
            this.lblBackToMainMenu.Size = new System.Drawing.Size(265, 30);
            this.lblBackToMainMenu.TabIndex = 26;
            this.lblBackToMainMenu.Text = "Back to Main Menu?";
            this.lblBackToMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBackToMainMenu.Click += new System.EventHandler(this.lblBackToMainMenu_Click);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnClearFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilter.ForeColor = System.Drawing.Color.White;
            this.btnClearFilter.Location = new System.Drawing.Point(320, 210);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(196, 43);
            this.btnClearFilter.TabIndex = 27;
            this.btnClearFilter.Text = "Clear";
            this.btnClearFilter.UseVisualStyleBackColor = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // cmbAgeRating
            // 
            this.cmbAgeRating.FormattingEnabled = true;
            this.cmbAgeRating.Location = new System.Drawing.Point(801, 220);
            this.cmbAgeRating.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAgeRating.Name = "cmbAgeRating";
            this.cmbAgeRating.Size = new System.Drawing.Size(139, 24);
            this.cmbAgeRating.TabIndex = 30;
            this.cmbAgeRating.Text = "Age Rating";
            this.cmbAgeRating.SelectedIndexChanged += new System.EventHandler(this.cmbAgeRating_SelectedIndexChanged);
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(801, 260);
            this.cmbLanguage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(139, 24);
            this.cmbLanguage.TabIndex = 34;
            this.cmbLanguage.Text = "Language";
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage_SelectedIndexChanged);
            // 
            // txtDisplayMovieId
            // 
            this.txtDisplayMovieId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayMovieId.ForeColor = System.Drawing.Color.Black;
            this.txtDisplayMovieId.Location = new System.Drawing.Point(547, 48);
            this.txtDisplayMovieId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDisplayMovieId.Name = "txtDisplayMovieId";
            this.txtDisplayMovieId.Size = new System.Drawing.Size(193, 28);
            this.txtDisplayMovieId.TabIndex = 35;
            // 
            // lblDisplayMovieId
            // 
            this.lblDisplayMovieId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayMovieId.Location = new System.Drawing.Point(543, 21);
            this.lblDisplayMovieId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayMovieId.Name = "lblDisplayMovieId";
            this.lblDisplayMovieId.Size = new System.Drawing.Size(175, 23);
            this.lblDisplayMovieId.TabIndex = 36;
            this.lblDisplayMovieId.Text = "Display MovieId:";
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
            // frmMovieSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.lblDisplayMovieId);
            this.Controls.Add(this.txtDisplayMovieId);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.cmbAgeRating);
            this.Controls.Add(this.btnClearFilter);
            this.Controls.Add(this.lblBackToMainMenu);
            this.Controls.Add(this.grpFilterBy);
            this.Controls.Add(this.dgvMovieDetails);
            this.Controls.Add(this.lblSortBy);
            this.Controls.Add(this.lblGenreFilter);
            this.Controls.Add(this.cmbSortBy);
            this.Controls.Add(this.cmbGenreFilter);
            this.Controls.Add(this.lblSearchMovies);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pnlMovieSelection);
            this.Controls.Add(this.btnSelectMovie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMovieSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Selection Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMovieSelection_FormClosing);
            this.Load += new System.EventHandler(this.frmMovieSelection_Load);
            this.pnlMovieSelection.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picShootingStars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieDetails)).EndInit();
            this.grpFilterBy.ResumeLayout(false);
            this.grpFilterBy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlMovieSelection;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchMovies;
        private System.Windows.Forms.ComboBox cmbGenreFilter;
        private System.Windows.Forms.ComboBox cmbSortBy;
        private System.Windows.Forms.Label lblGenreFilter;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.Button btnSelectMovie;
        private System.Windows.Forms.DataGridView dgvMovieDetails;
        private System.Windows.Forms.GroupBox grpFilterBy;
        private System.Windows.Forms.RadioButton rdoNone;
        private System.Windows.Forms.RadioButton rdoAgeRating;
        private System.Windows.Forms.RadioButton rdoDirector;
        private System.Windows.Forms.Label lblBackToMainMenu;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.ComboBox cmbAgeRating;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox picShootingStars;
        private System.Windows.Forms.Label lblCinemaBookingSystem;
        private System.Windows.Forms.RadioButton rdoDuration;
        private System.Windows.Forms.TextBox txtDisplayMovieId;
        private System.Windows.Forms.Label lblDisplayMovieId;
        private System.Windows.Forms.Button btnHome;
    }
}