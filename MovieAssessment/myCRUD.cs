using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MovieAssessment
{
    public class myCRUD
    {
        Database myDatabase = new Database();
        private SqlConnection Connection = new SqlConnection(); 
        private SqlCommand Command = new SqlCommand();
        private SqlDataAdapter da;
        private SqlDataAdapter dac;
        private SqlDataAdapter dar;


        public myCRUD()
        {
            string connectionString = myDatabase.connectionString;
            Connection.ConnectionString = connectionString;
            Command.Connection = Connection;
            


        }

        public DataTable ReadEntriesMovies()
        {
                                           
            DataTable dt = new DataTable();

            da = new SqlDataAdapter(@"SELECT * FROM Movies order by MovieID", Connection);
                Connection.Open();                
                //open a connection to Database             
                da.Fill(dt);
            //fills the datatable from SQL    


            

           

            Connection.Close(); 
                //closes the connection           
          //  }     
            return dt; 


        }
        public DataTable ReadEntriesCust()
        {
            DataTable dtc = new DataTable();

            dac = new SqlDataAdapter(@"SELECT * FROM Customer order by CustID", Connection);
            //{                //connects into the Datbase and gets the SQL    
            dac.Fill(dtc);
            //fills the datatable from SQL
            return dtc;
        }

        public DataTable ReadEntriesRent()
        {

            DataTable dtr = new DataTable();

            dar = new SqlDataAdapter(@"SELECT * FROM CustomerAndMoviesRented order by RMID", Connection);
            //{                //connect into the Database and get the SQL    
            dar.Fill(dtr);
            //fills datatable from the SQL 

            return dtr;
        }

        public DataTable MoviesRentOut()
        {

            DataTable dtr = new DataTable();

            dar = new SqlDataAdapter(@"SELECT * FROM MoviesOut order by RMID", Connection);
            //{                //connect into the Database and get the SQL    
            dar.Fill(dtr);
            //fills datatable from the SQL 

            return dtr;
        }
    }
}
