using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pharmacyManagementSystem
{
    class DataAccess
    {
        /*we know how to communicate with dataBase.we will create
    those database things as a field also we will create properties for that
    ......*/
        /*now lets do that*/
        /*  //1.creating the connection with database
             SqlConnection sqlcon = new SqlConnection("Data Source=MASHAYEAKHLAP\\SQLEXPRESS;Initial Catalog=mythirdbd;Persist Security Info=True;User ID=sa;Password=goodboy123");
             //open that connection
             sqlcon.Open();


             //2.creating an editor for writting query;
             //for that we have a sqlCommand 
             SqlCommand sqlcom = new SqlCommand("select * from PracticeTable", sqlcon);


             //3.to execut our query we have a adapter class and we need to add our sqlcommand class obj as a parameter
             SqlDataAdapter sda = new SqlDataAdapter(sqlcom);


             //now 4. for storing our data we have a dataset/datatable class
             DataSet ds = new DataSet();/ or i can use DataTable dt = new DataTable();
         
           
              sqlcon.Close();*/


        private SqlConnection sqlcon;
        public SqlConnection Sqlcon //auto implemented property 
        {
            get 
            {
                return this.sqlcon;
            }
            set
            {
                this.sqlcon = value;
            }
        }
        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get
            {
                return this.sqlcom;
            }
            set
            {
                this.sqlcom = value;
            }
        }
        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get
            {
                return this.sda;
            }
            set
            {
                this.sda = value;
            }
        }
        // this DataTable can be used via the DataSet object.
        private DataTable dt;
        public DataTable Dt
        {
            get
            {
                return this.dt;
            }
            set
            {
                this.dt = value;
            }
        }
        //constructor
        //4 steps 
        public DataAccess()
        {
            //step 1 , connection
            //calling property
            this.Sqlcon = new SqlConnection("Data Source=MASHAYEAKHLAP\\SQLEXPRESS;Initial Catalog=PharmacyManagementSystem;Persist Security Info=True;User ID=sa;Password=goodboy123");
            this.Sqlcon.Open();
        }

        // step 2 , text editor for writting the query
        private void CommandText(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
        }

        //step 3 and 4, to execute that query
        public DataTable ExecuteQuery(string sql)
        {
            this.CommandText(sql);
            //adapter
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Dt = new DataTable();
            //according to our query we will get one table not multiple
            //now we will put our result in dataTable
            this.Sda.Fill(this.Dt);//storing in dataTable
            return Dt;
        }

        public void PopulateGrideView(string sql = "select * from userTable")//optional parameter
        {
            Dt = this.ExecuteQuery(sql);
        }

        //now its time to perform to DML operation (data manipulation) so we will see this. 
        //well, we know that whenever we insert any row in our sql it returns only 1 rows
        // that means At a time we can insert only one row.
        // we will cerate a int type method

        public int ExecuteDMLOperation(string sql)//this sql can be any thing like insert, delete....
        {
            //now we will call our own created method called CommanText()and pass that sql
            this.CommandText(sql);
            //now there is a method called ExecuteNonQuery() of sqlcom and this method completes our DML operation and it returns int type
            int executeQuery = this.Sqlcom.ExecuteNonQuery();
            return executeQuery;
        }
  
    }
}
