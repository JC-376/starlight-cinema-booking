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
using Microsoft.VisualBasic;
using System.Globalization;
using System.Data.SqlTypes;
using System.IdentityModel;

namespace Cinema_Booking_System
{
    public partial class frmMovieSelection : Form
    {
        private const string EXAMPLEDB = "CinemaDatabase2.mdb";
        private const string CONNECTION_STRING = @"Provider=Microsoft Jet 4.0 OLE DB Provider;Data Source = " + EXAMPLEDB + ";";

        private bool isValid = false; 

        public frmMovieSelection()
        {
            InitializeComponent();
            this.CenterToScreen();

            UpdateButtonState();

            LoadMovie(); //Retrieve and display movie details

            //adds genre to cmbGenreFilter
            string[] genre_array = { "None", "Action", "Action Comedy", "Adventure", "Adventure Comedy", "Animation", "Biography", "Comedy", "Crime",
                                     "Dark Comedy", "Documentary", "Drama", "Family", "Fantasy", "Historical", "Horror", "Musical", "Mystery",
                                     "Psychological Thriller", "Romance", "Science Fiction", "Sport", "Superhero", "Thriller", "War", "Western" };
            cmbGenreFilter.Items.AddRange(genre_array);

            //adds sort by options to cmbSortBy
            string[] sortoptions_array = { "None", "Title (A-Z)", "Title (Z-A)", "Release Date (Newest First)", "Release Date (Oldest First)", 
                                           "Duration (Shortest First)", "Duration (Longest First)" };
            cmbSortBy.Items.AddRange(sortoptions_array);

            //adds age rating to cmbAgeRating
            string[] agerating_array = { "None", "U", "T", "PG", "12A", "12", "15", "18" };
            cmbAgeRating.Items.AddRange(agerating_array);

            //adds languages to cmbLanguage
            string[] language_array = { "None", "Danish", "English", "French", "German", "Hindi", "Italian", "Japanese", "Korean", "Malayalam", "Mandarin",
                                        "Persian", "Portuguese", "Spanish", "Telegu", "Turkish" };
            cmbLanguage.Items.AddRange(language_array);
        }
        private void frmMovieSelection_FormClosing(object sender, FormClosingEventArgs e) 
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

        private void frmMovieSelection_Load(object sender, EventArgs e)
        {
            //checks if the user is logged in
            if (!UserSession.IsLoggedIn)
            {
                MessageBox.Show("You must be logged in to view this page.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NavigationHelper.Navigate(this, new frmLogin());
            }
        }
        private void UpdateButtonState()
        {
            btnSelectMovie.Enabled = isValid;
        }
        
        private void pnlMovieSelection_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSelectMovie_Click(object sender, EventArgs e)
        {
            if(isValid && UserSession.SelectedMovie.MovieId != -1 && UserSession.SelectedMovie != null)
            {
                MessageBox.Show("Selected movie successfully", "Cinema Booking System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NavigationHelper.Navigate(this, new frmShowtimesSelection());
            }
            else
            {
                MessageBox.Show("Please select a movie first before you proceed.", "Movie not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }

        private void LoadMovie()
        {
            //retrieve all records from the movies table
            string sSqlString = "SELECT * FROM Movies";
            DisplayData(DatabaseUtils.ExecuteSqlNonQuery(sSqlString));

            //default the option buttons so that no filter is selected
            rdoNone.Checked = true;
        }

        private void DisplayData(DataTable _dt)
        {
            //define number of columns and set headers
            dgvMovieDetails.ColumnCount = 8;
            dgvMovieDetails.Columns[0].Name = "Movie Id";
            dgvMovieDetails.Columns[1].Name = "Title";
            dgvMovieDetails.Columns[2].Name = "Genre";
            dgvMovieDetails.Columns[3].Name = "Duration (min)";
            dgvMovieDetails.Columns[4].Name = "Release Date";
            dgvMovieDetails.Columns[5].Name = "Director";
            dgvMovieDetails.Columns[6].Name = "Age Rating";
            dgvMovieDetails.Columns[7].Name = "Language";

            //clear grid
            dgvMovieDetails.Rows.Clear();

            //loop around each row in the data retreived from the query
            for (int i = 0; i <= _dt.Rows.Count - 1; i++)
            {
                //add a new row to the grid
                int n = dgvMovieDetails.Rows.Add();

                //add fields to each row, if string fields are null, display blank
                dgvMovieDetails.Rows[n].Cells[0].Value = _dt.Rows[i][0];
                dgvMovieDetails.Rows[n].Cells[1].Value = _dt.Rows[i][1].ToString();
                dgvMovieDetails.Rows[n].Cells[2].Value = _dt.Rows[i][2].ToString();
                dgvMovieDetails.Rows[n].Cells[3].Value = _dt.Rows[i][3]; //no " ToString() " because Duration is a integer type not string
                dgvMovieDetails.Rows[n].Cells[4].Value = Convert.ToDateTime(_dt.Rows[i][4]).ToString("dd/MM/yyyy");
                dgvMovieDetails.Rows[n].Cells[5].Value = _dt.Rows[i][5].ToString();
                dgvMovieDetails.Rows[n].Cells[6].Value = _dt.Rows[i][6].ToString();
                dgvMovieDetails.Rows[n].Cells[7].Value = _dt.Rows[i][7].ToString();
            }
        }

        private void rdoNone_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNone.Checked)
            {
                //CALL EXISTING METHOD TO POPULATE
                string sSqlString = "SELECT * FROM Movies;";
                DisplayData(DatabaseUtils.ExecuteSqlNonQuery(sSqlString));
            }
        }

        private void rdoAgeRating_CheckedChanged(object sender, EventArgs e)
        {
            //if age rating radio button is selected, ask the user for the rating and retrive matching movies
            if (rdoAgeRating.Checked)
            {
                string sReply = Interaction.InputBox("Enter the rating here:", "Please enter an age rating", "", 0, 0);
                string sSqlString = "SELECT * FROM Movies ts WHERE ts.AgeRating = '" + sReply.Trim() + "';";
                DisplayData(DatabaseUtils.ExecuteSqlNonQuery(sSqlString));
            }
        }

        private void rdoDirector_CheckedChanged(object sender, EventArgs e)
        {
            //if director radio button is selected, ask the user for name of director and retrive matching movies made by the director
            if (rdoDirector.Checked)
            {
                string sReply = Interaction.InputBox("Enter the name of the director here:", "Please enter an rating", "", 0, 0);
                string sSqlString = "SELECT * FROM Movies ts WHERE ts.Director LIKE '%" + sReply.Trim() + "%';";
                DisplayData(DatabaseUtils.ExecuteSqlNonQuery(sSqlString));
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sReply = txtSearch.Text.ToLower();
            string sSqlString = "SELECT * FROM Movies ts WHERE ts.Title LIKE ?";

            using(OleDbConnection cnn = new OleDbConnection(CONNECTION_STRING))
            {
                using(OleDbCommand cmd = new OleDbCommand(sSqlString, cnn))
                {
                    cmd.Parameters.AddWithValue("?", "%" + sReply.Trim() + "%");
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    cnn.Open();
                    da.Fill(dt);
                    DisplayData(dt);
                }
            }

        }

        private void cmbGenreFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checks that an actual item is selected (not -1) so it doesnt get affected by the ClearFilter event handler
            if (cmbGenreFilter.SelectedIndex >= 0)
            {
                string genreOption = cmbGenreFilter.SelectedItem.ToString();
                if(genreOption == "None")
                {
                    string genre_None = "SELECT * FROM Movies";
                    DisplayData(DatabaseUtils.ExecuteSqlNonQuery(genre_None));
                }
                else
                {
                    FilterMoviesByGenre(genreOption);
                }
            }
        }

        private void cmbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checks that an actual item is selected (not -1) so it doesnt get affected by the ClearFilter event handler
            if (cmbSortBy.SelectedIndex >= 0) 
            {
                string sortOption = cmbSortBy.SelectedItem.ToString();
                if(sortOption == "None")
                {
                    string sort_None = "SELECT * FROM Movies";
                    SortMoviesBy(sort_None);
                }
                else
                {
                    SortMoviesBy(sortOption);
                }
            }
        }        

        private void lblBackToMainMenu_Click(object sender, EventArgs e)
        {
            NavigationHelper.Navigate(this, new frmMainMenu());
        }

        private void FilterMoviesByGenre(string genreOption)
        {
            string sSqlString = "SELECT * FROM Movies ts WHERE ts.Genre LIKE ?";

            using(OleDbConnection cnn = new OleDbConnection(CONNECTION_STRING))
            {
                using(OleDbCommand cmd = new OleDbCommand(sSqlString, cnn))
                {
                    cmd.Parameters.AddWithValue("?", "%" + genreOption + "%");

                    OleDbDataAdapter da = new OleDbDataAdapter(cmd); //adding a parameterized value to the SQL query
                    DataTable dt = new DataTable();

                    try
                    {
                        cnn.Open();
                        da.Fill(dt);

                        DisplayData(dt);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        private void SortMoviesBy(string sortOption)
        {
            string sSqlString;

            switch (sortOption)
            {
                case "Title (A-Z)":
                    sSqlString = "SELECT * FROM Movies ORDER BY Title ASC";
                    break;

                case "Title (Z-A)":
                    sSqlString = "SELECT * FROM Movies ORDER BY Title DESC";
                    break;

                case "Release Date (Newest First)":
                    sSqlString = "SELECT * FROM Movies ORDER BY ReleaseDate DESC";
                    break;

                case "Release Date (Oldest First)":
                    sSqlString = "SELECT * FROM Movies ORDER BY ReleaseDate ASC";
                    break;

                case "Duration (Shortest First)":
                    sSqlString = "SELECT * FROM Movies ORDER BY Duration ASC";
                    break;

                case "Duration (Longest First)":
                    sSqlString = "SELECT * FROM Movies ORDER BY Duration DESC";
                    break;

                default:
                    MessageBox.Show("Invalid sort option selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            DisplayData(DatabaseUtils.ExecuteSqlNonQuery(sSqlString));
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            //reset all the filters
            rdoNone.Checked = true;
            cmbGenreFilter.SelectedIndex = -1;
            cmbSortBy.SelectedIndex = -1;
            txtSearch.Clear();
            cmbAgeRating.SelectedIndex = -1;
            cmbLanguage.SelectedIndex = -1;


            string query = "SELECT * FROM Movies";

            using (OleDbConnection cnn = new OleDbConnection(CONNECTION_STRING))
            {
                using (OleDbCommand cmd = new OleDbCommand(query, cnn))
                {
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd); //adding a parameterized value to the SQL query
                    DataTable dt = new DataTable();
                    try
                    {
                        cnn.Open();
                        da.Fill(dt);
                        DisplayData(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }       

        private void cmbAgeRating_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checks that an actual item is selected (not -1) so it doesnt get affected by the ClearFilter event handler
            if (cmbAgeRating.SelectedIndex >= 0)
            {
                string ageRatingOption = cmbAgeRating.SelectedItem.ToString();
                if (ageRatingOption == "None")
                {
                    string ageRating_None = "SELECT * FROM Movies";
                    DisplayData(DatabaseUtils.ExecuteSqlNonQuery(ageRating_None));
                }
                else
                {
                    string sSqlString = "SELECT * FROM Movies WHERE AgeRating = '" + ageRatingOption + "';";
                    DisplayData(DatabaseUtils.ExecuteSqlNonQuery(sSqlString));
                }
            }
            
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checks that an actual item is selected (not -1) so it doesnt get affected by the ClearFilter event handler
            if (cmbLanguage.SelectedIndex >= 0)
            {
                string languageOption = cmbLanguage.SelectedItem.ToString();
                if (languageOption == "None")
                {
                    string language_None = "SELECT * FROM Movies";
                    DisplayData(DatabaseUtils.ExecuteSqlNonQuery(language_None));
                }
                else
                {
                    string sSqlString = "SELECT * FROM Movies WHERE [Language] = '" + languageOption + "';";
                    DisplayData(DatabaseUtils.ExecuteSqlNonQuery(sSqlString));
                }
            }
            
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

        private void picLogout_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdoDuration_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDuration.Checked)
            {
                string sReply_MinDuration = Interaction.InputBox("Enter the minimum duration here:", "Please enter the minimum duration", "", 0, 0);
                string sReply_MaxDuration = Interaction.InputBox("Enter the maximum duration here:", "Please enter the maximum duration", "", 0, 0);

                string sSqlString = $"SELECT * FROM Movies WHERE Duration BETWEEN {sReply_MinDuration} AND {sReply_MaxDuration};";
                DisplayData(DatabaseUtils.ExecuteSqlNonQuery(sSqlString));
            }
        }

        private void dgvMovieDetails_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void dgvMovieDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Ensures that the clicked row index is valid (not the header row or outside the bounds of the DataGridView).
                //Ensures the selected row is not the blank row for adding new data, which contains null values.
                if (e.RowIndex >= 0 && dgvMovieDetails.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    string selectedId = dgvMovieDetails.Rows[e.RowIndex].Cells[0].Value.ToString(); //stores users selected movieId in the variable "selectedId"
                    txtDisplayMovieId.Text = selectedId;

                    //stores movie details in UserSession so it can be accessed globally
                    int movieid = Convert.ToInt32(selectedId);
                    string title = dgvMovieDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string genre = dgvMovieDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
                    int duration = Convert.ToInt32(dgvMovieDetails.Rows[e.RowIndex].Cells[3].Value.ToString());
                    string releasedate = dgvMovieDetails.Rows[e.RowIndex].Cells[4].Value.ToString();
                    string director = dgvMovieDetails.Rows[e.RowIndex].Cells[5].Value.ToString();
                    string agerating = dgvMovieDetails.Rows[e.RowIndex].Cells[6].Value.ToString();
                    string language = dgvMovieDetails.Rows[e.RowIndex].Cells[7].Value.ToString();

                    UserSession.SelectedMovie = new Movie
                    (
                        movieid,
                        title,
                        genre,
                        duration,
                        releasedate,
                        director,
                        agerating,
                        language
                    );
                    isValid = true;
                    UpdateButtonState();

                    MessageBox.Show($"Movie Details" +
                        $"\nMovie ID: {UserSession.SelectedMovie.MovieId}\nTitle: {UserSession.SelectedMovie.Title}\nGenre: {UserSession.SelectedMovie.Genre}\nDuration: {UserSession.SelectedMovie.Duration}" +
                        $"\nRelease Date: {UserSession.SelectedMovie.ReleaseDate}\nDirector: {UserSession.SelectedMovie.Director}\nAge Rating: {UserSession.SelectedMovie.AgeRating}" +
                        $"\nLanguage: {UserSession.SelectedMovie.Language}", "Movie selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid row clicked");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UserSession.RestartBooking();
            NavigationHelper.Navigate(this,new frmMainMenu());
        }
    } 
    
}
