using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieAssessment
{
    public partial class Form1 : Form
    {

        myCRUD CRUD = new myCRUD();
        Database myDatabase = new Database();
        public Form1()
        {
            InitializeComponent();
            LoadDB();
        }

        private void LoadDB()
        {

            dgvMovies.DataSource = CRUD.ReadEntriesMovies();
            dgvCustomer.DataSource = CRUD.ReadEntriesCust();
            dgvRentals.DataSource = CRUD.ReadEntriesRent();
        }

        private void dgvMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //show movies data in DataGridView
                string newvalue = dgvMovies.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
               
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                //show data in the text boxes
                tbxMID.Text = dgvMovies.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbxRating.Text = dgvMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbxTitle.Text = dgvMovies.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbxYear.Text = dgvMovies.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbxCost.Text = dgvMovies.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbxCopies.Text = dgvMovies.Rows[e.RowIndex].Cells[5].Value.ToString();
                tbxPlot.Text = dgvMovies.Rows[e.RowIndex].Cells[6].Value.ToString();
                tbxGenre.Text = dgvMovies.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch
            { }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //show data in DataGridView
                string newvalue = dgvCustomer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                //send data to text box
                tbxCID.Text = dgvCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbxFirst.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbxLast.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbxAddress.Text = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbxPhone.Text = dgvCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
               
            }
            catch
            { }
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            // this adds the parameters in the code so data will be added to database
            string NewEntry = "INSERT INTO Customer (FirstName, LastName, Address, Phone) VALUES ( @FirstName, @LastName, @Address, @Phone)";
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = myDatabase.connectionString;
            using (SqlCommand newdata = new SqlCommand(NewEntry, Con))
            {
                newdata.Parameters.AddWithValue("@FirstName", tbxFirst.Text);
                newdata.Parameters.AddWithValue("@LastName", tbxLast.Text);
                newdata.Parameters.AddWithValue("@Address", tbxAddress.Text);
                newdata.Parameters.AddWithValue("@Phone", tbxPhone.Text);

                Con.Open(); //open connection to database
                           
                            
                newdata.ExecuteNonQuery(); //Run the Query
                MessageBox.Show("Data has been entered :)");
            }
            //Run the load database method
            LoadDB();
        }

        private void btnUpdateCust_Click(object sender, EventArgs e)
        {
            // this updates the parameters in the code so data in the database will be updated
            string NewEntry = "UPDATE Customer set FirstName=@FirstName, LastName=@LastName, Address=@Address, Phone=@Phone WHERE CustID=@CustID";
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = myDatabase.connectionString;
            using (SqlCommand updatecustomerdata = new SqlCommand(NewEntry, Con))
            {
                updatecustomerdata.Parameters.AddWithValue("@FirstName", tbxFirst.Text);
                updatecustomerdata.Parameters.AddWithValue("@LastName", tbxLast.Text);
                updatecustomerdata.Parameters.AddWithValue("@Address", tbxAddress.Text);
                updatecustomerdata.Parameters.AddWithValue("@Phone", tbxPhone.Text);
                updatecustomerdata.Parameters.AddWithValue("@CustID", tbxCID.Text);
                Con.Open(); //open database


                updatecustomerdata.ExecuteNonQuery(); //Run Query
                MessageBox.Show("Data has been updated :)");
            }
            //Run load database method
            LoadDB();
        }

        private void btnDeleteCust_Click(object sender, EventArgs e)
        {
            // this deletes the parameters in the code so that data in the database is deleted.
            string NewEntry = "DELETE Customer WHERE CustID=@CustID";
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = myDatabase.connectionString;
            using (SqlCommand deletecustomerdata = new SqlCommand(NewEntry, Con))
            {
                deletecustomerdata.Parameters.AddWithValue("@CustID", tbxCID.Text);
                
                Con.Open(); //open connection to my database.

                deletecustomerdata.ExecuteNonQuery(); //Run Query
                MessageBox.Show("Data has been deleted :)");
            }
            // Runs my database method
            LoadDB();
        }


        //
        //
        // Lines onwards are for the Movies CRUD
        //
        //


        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            //adds data from Movie Textboxes to Database
            string NewEntry = "INSERT INTO Movies (Title, Genre, Plot, Year, Rating, Copies, Rental_Cost) VALUES ( @Title, @Genre, @Plot, @Year, @Rating, @Copies, @Rental_Cost)";
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = myDatabase.connectionString;
            using (SqlCommand newmoviesdata = new SqlCommand(NewEntry, Con))
            {
                newmoviesdata.Parameters.AddWithValue("@Title", tbxTitle.Text);
                newmoviesdata.Parameters.AddWithValue("@Genre", tbxGenre.Text);
                newmoviesdata.Parameters.AddWithValue("@Plot", tbxPlot.Text);
                newmoviesdata.Parameters.AddWithValue("@Year", tbxYear.Text);
                newmoviesdata.Parameters.AddWithValue("@Rating", tbxRating.Text);
                newmoviesdata.Parameters.AddWithValue("@Copies", tbxCopies.Text);
                newmoviesdata.Parameters.AddWithValue("@Rental_Cost", tbxCost.Text);

                Con.Open(); //open a connection to database

                newmoviesdata.ExecuteNonQuery(); //Run Query
                MessageBox.Show("Data has been entered :)");
            }
                // Runs my Load Database Method
            LoadDB();
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {

            MessageBox.Show(UpdateMovie());
           
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            // Deletes data after highlighting the movie then click = true on "Delete Movie" button.
            string NewEntry = "DELETE Movies WHERE MovieID=@MovieID";
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = myDatabase.connectionString;
            using (SqlCommand deletemoviesdata = new SqlCommand(NewEntry, Con))
            {
                deletemoviesdata.Parameters.AddWithValue("@MovieID", tbxMID.Text);

                Con.Open(); //opens connection to MovieDB

                deletemoviesdata.ExecuteNonQuery(); //Runs Query
                MessageBox.Show("Data has been deleted :)");
            }
                //Runs Load Database method.
            LoadDB();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            string NewEntry = "INSERT INTO RentedMovies (MovieIDFK, CustIDFK, DateRented) VALUES ( @MovieIDFK, @CustIDFK, @DateRented )";

            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = myDatabase.connectionString;
            DateTime currentdate = DateTime.Today;

            using (SqlCommand newrenteddata = new SqlCommand(NewEntry, Con))
            {
                newrenteddata.Parameters.AddWithValue("@MovieIDFK", tbxMID.Text);
                newrenteddata.Parameters.AddWithValue("@CustIDFK", tbxCID.Text);
                newrenteddata.Parameters.AddWithValue("@DateRented", currentdate);
                
                 
                Con.Open(); //opens connection to database

                newrenteddata.ExecuteNonQuery(); //Run the Query
                MessageBox.Show("Data has been entered :)");
            }
            // Runs Load Database method
            LoadDB();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //After highlighting movie when Return button = clicked will return movie and show date of when it was returned
            string NewEntry = "UPDATE RentedMovies set DateReturned=@DateReturned WHERE RMID=@RMID";
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = myDatabase.connectionString;

            //Shows date the Movie was returned
            DateTime currentdate = DateTime.Today;

            using (SqlCommand updatereturndata = new SqlCommand(NewEntry, Con))
            {
                updatereturndata.Parameters.AddWithValue("@RMID", tbxRID.Text);
                updatereturndata.Parameters.AddWithValue("@DateReturned", currentdate);
                
                Con.Open(); //opens connection database

                updatereturndata.ExecuteNonQuery(); //Run Query
                MessageBox.Show("Data has been updated :)");
            }
            // Runs Load Database method.
            LoadDB();
        }

        private void dgvRentals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //shows data in my textboxes
                string newvalue = dgvRentals.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                //shows output on header
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                //add data to textboxes
                tbxRID.Text = dgvRentals.Rows[e.RowIndex].Cells[0].Value.ToString();
                

            }
            catch
            { }
        }

       public string UpdateMovie() //Testing Method only
        {
            string NewEntry = "UPDATE Movies set Title=@Title, Genre=@Genre, Plot=@Plot, Year=@Year, Rating=@Rating, Copies=@Copies, Rental_Cost=@Rental_Cost WHERE MovieID=@MovieID";
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = myDatabase.connectionString;
            using (SqlCommand updatemoviesdata = new SqlCommand(NewEntry, Con))
            {
                updatemoviesdata.Parameters.AddWithValue("@Title", tbxTitle.Text);
                updatemoviesdata.Parameters.AddWithValue("@Genre", tbxGenre.Text);
                updatemoviesdata.Parameters.AddWithValue("@Plot", tbxPlot.Text);
                updatemoviesdata.Parameters.AddWithValue("@Year", tbxYear.Text);
                updatemoviesdata.Parameters.AddWithValue("@Rating", tbxRating.Text);
                updatemoviesdata.Parameters.AddWithValue("@Copies", tbxCopies.Text);
                updatemoviesdata.Parameters.AddWithValue("@Rental_Cost", tbxCost.Text);
                updatemoviesdata.Parameters.AddWithValue("@MovieID", tbxMID.Text);
                Con.Open(); 

                updatemoviesdata.ExecuteNonQuery(); //Runs Query
                
            }
        //Runs Load Database method.
        LoadDB();
            return "Movie Data has been updated :)";
        }

        private void btn_MoviesRented_Click(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void btn_MovieOut_Click(object sender, EventArgs e)
        {
            dgvRentals.DataSource = CRUD.MoviesRentOut();
        }
    }
}
