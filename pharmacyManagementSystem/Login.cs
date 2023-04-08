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
using MetroFramework.Forms;
using Guna.UI;

namespace pharmacyManagementSystem
{
    public partial class Login : MetroForm
    {
        private DataAccess Da
        {
            get;
            set;
        }
        //private Administrator Admin { get; set; }
        //DataTable dt ;
        public Login()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            //this.PopulateGeidView();
            Da.PopulateGrideView();
        }
       /* public void PopulateGeidView(string sql = "select * from userTable")//default value , optional parameter
        {
       
            this.dt = this.Da.ExecuteQuery(sql);
          //  this.dgvMovies.AutoGenerateColumns = false;
            ///this.d   DataSource = ds.Tables[0];
           
        }*/

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = "select * from userTable Where Id='" + this.idTxtBox.Text + "' and Password = '" + this.passTxtBox.Text+ "'";

                //this.PopulateGeidView(sql);
                Da.PopulateGrideView(sql) ;
                
                if (Da.Dt.Rows.Count > 0)
                {
                    byte index = 0;
                    while (index < Da.Dt.Rows.Count)
                    {
                      
                        if (Da.Dt.Rows[index][1].ToString().Equals("Admin"))
                        {
                            MessageBox.Show("Welcome " + Da.Dt.Rows[index][5]);
                            this.Hide();//cascate Closing

                            //Administrator admin = new Administrator();
                            /*Administrator admin = new Administrator();
                            admin.Show();*/

                            Admin admin = new Admin(this);//this in indicating current form
                            admin.Show();

                            //AddUser a = new AddUser(this);
                            this.reserBtn_Click(sender,e);
                           
                        }
                        else if (Da.Dt.Rows[index][1].ToString().Equals("Pharmacist"))
                        {
                            MessageBox.Show("Welcome " + Da.Dt.Rows[index][5]);
                            this.Hide();
                            Pharmacist pharma = new Pharmacist(this);
                            pharma.Show();
                            this.reserBtn_Click(sender, e);
                        }
                        index++;
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Password!");
                    this.reserBtn_Click(sender, e);
                }
            }
            catch (Exception ex)//      className objName = new className()
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reserBtn_Click(object sender, EventArgs e)
        {
            this.idTxtBox.Clear();
            this.passTxtBox.Clear();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
