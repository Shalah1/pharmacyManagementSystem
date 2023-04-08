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

namespace pharmacyManagementSystem
{
    public partial class Admin : MetroForm
    {
        private Login L { get; set; }
       private DataAccess Da { get; set; }

      //  SqlConnection sqlcon = new SqlConnection("Data Source=MASHAYEAKHLAP\\SQLEXPRESS;Initial Catalog=PharmacyManagementSystem;Persist Security Info=True;User ID=sa;Password=goodboy123");
        public Admin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
           // Da.PopulateGrideView();
            
        }
        public Admin(Login l):this()
        {
            //InitializeComponent();
            this.L = l;
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.L.Show();//login shows
        }

        private void DashBoard_Click(object sender, EventArgs e)//view infor btn
        {
            // Admin_Load(sender,e);
            DashBoard.Visible = true;
            Da.PopulateGrideView();
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.DataSource = Da.Dt;
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //now its time to validate our panels
                //here we will use String class and this class has a mehthod called IsNullOrEmpty. 
                //if idTxtBox is empty then it will return true otherwise our insertion operation will be done
                if (this.isValide())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }

                string sql = "insert into userTable values('" + this.idTxtBox.Text + "','" + this.roleComboBox.Text + "','" + this.emailTxtBox.Text + "','" + this.passwordTxtBox.Text + "','" + this.dobDateTimePicker.Text + "','" + this.nameTxtBox.Text + "')";
                int rowCount = this.Da.ExecuteDMLOperation(sql);//calling that mehtod and storing it an int type vari. as its returning int 

                //validation
                if (rowCount == 1)//as we know insertion operation returns only 1 row thats why we are using this
                {
                    MessageBox.Show("Data inserted successfully!");
                    Da.PopulateGrideView();//to show directly inserted data in our table 
                }
                else
                {
                    MessageBox.Show("Data insertion failed!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("An Error occoured :" + exception.Message);
            }
        }
        

        private void searchBtn_Click(object sender, EventArgs e)
        {
            //for filtering 
            //string sql = "select * from userTable where User_Name = '" + this.searchTxtBox.Text.ToString() + "%'";
            string sql2 = @"select * FROM userTable
                          where Id LIKE '" + this.searchTxtBtn.Text.ToString() + "%' ";

            Da.PopulateGrideView(sql2);
            this.dgvUsers.DataSource = Da.Dt;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {

                var id = this.dgvUsers.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvUsers.CurrentRow.Cells[5].Value.ToString();
                //MessageBox.Show(name); 
                string sql = "delete from userTable where Id ='" + id + "'";
                int rowCount = Da.ExecuteDMLOperation(sql);
                if (rowCount == 1)
                {
                    MessageBox.Show(name+ " Deleted!!");
                    this.dgvUsers.DataSource = Da.Dt;
                    Da.PopulateGrideView();
                }
                else
                {
                    MessageBox.Show("Cant delete.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occoured" + ex.Message);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValide())
                {
                    MessageBox.Show("Please Fill all informations");
                    return;
                }
                var qeuary = "select * from userTable where Id ='" + this.idTxtBox.Text + "' ";
                var count = this.Da.ExecuteQuery(qeuary);
                if (count.Rows.Count == 1)
                {
                    //if yes -> that means this id is there we can update that
                    //update
                    var sql = @"update userTable
                             set User_Role = '" + this.roleComboBox.Text + @"', 
                             Email = '" + this.emailTxtBox.Text + @"',
                             Password ='" + this.passwordTxtBox.Text + @"',
                             Date_Of_Birth ='" + this.dobDateTimePicker.Text + @"',
                             User_Name ='" + this.nameTxtBox.Text + @"'
                             where Id = '" + this.idTxtBox.Text + "' ";
                    //performing DML operation
                    int rowCount = Da.ExecuteDMLOperation(sql);

                    if (rowCount == 1)
                    {
                        MessageBox.Show("Data Updated Successfully.");

                    }
                    else
                    {
                        MessageBox.Show("Data Upgration failed.");

                    }
                }
             /*   else if (count.Rows.Count == 0)
                {
                    //this condition means no this id is not there we can perform insertion operation
                    //insert
                    string sql = "insert into userTable values('" + this.idTxtBox.Text + "','" + this.roleComboBox.Text + "','" + this.emailTxtBox.Text + "','" + this.passwordTxtBox.Text + "','" + this.dobDateTimePicker.Text + "','" + this.nameTxtBox.Text + "')";
                    int rowCount = Da.ExecuteDMLOperation(sql);

                    if (rowCount == 1)
                    {
                        MessageBox.Show("Data Inserted Successfully.");

                    }
                    else
                    {
                        MessageBox.Show("Data insertion failed.");

                    }
                }*/
                Da.PopulateGrideView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured." + ex.Message);
            }
        }
        private bool isValide()
        {
            if (String.IsNullOrEmpty(this.idTxtBox.Text) || String.IsNullOrEmpty(this.roleComboBox.Text) ||
                String.IsNullOrEmpty(this.emailTxtBox.Text) || String.IsNullOrEmpty(this.passwordTxtBox.Text) ||
                String.IsNullOrEmpty(this.dobDateTimePicker.Text) || String.IsNullOrEmpty(this.nameTxtBox.Text) ||
                
                //checking spaces

                 String.IsNullOrWhiteSpace(this.idTxtBox.Text) || String.IsNullOrWhiteSpace(this.roleComboBox.Text) ||
                  String.IsNullOrWhiteSpace(this.emailTxtBox.Text) || String.IsNullOrWhiteSpace(this.passwordTxtBox.Text) ||
                   String.IsNullOrWhiteSpace(this.dobDateTimePicker.Text) || String.IsNullOrWhiteSpace(this.nameTxtBox.Text))
            {
                return true;
            }
            else
                return false;
        }

        private void dgvUsers_DoubleClick(object sender, EventArgs e)
        {
            this.idTxtBox.Text = this.dgvUsers.CurrentRow.Cells["Id"].Value.ToString();
            this.roleComboBox.Text = this.dgvUsers.CurrentRow.Cells["User_Role"].Value.ToString();
            this.emailTxtBox.Text = this.dgvUsers.CurrentRow.Cells["Email"].Value.ToString();
            this.passwordTxtBox.Text = this.dgvUsers.CurrentRow.Cells["Password"].Value.ToString();
            this.dobDateTimePicker.Text = this.dgvUsers.CurrentRow.Cells["Date_Of_Birth"].Value.ToString();
            this.nameTxtBox.Text = this.dgvUsers.CurrentRow.Cells["User_Name"].Value.ToString();

            this.idTxtBox.ReadOnly = true;
        }

        private void resetUserBtn_Click(object sender, EventArgs e)
        {
            this.idTxtBox.Clear();
            this.roleComboBox.SelectedIndex = -1;
            this.emailTxtBox.Clear();
            this.passwordTxtBox.Clear();
            this.dobDateTimePicker.Refresh();
            this.nameTxtBox.Clear();
            this.searchTxtBtn.Clear();
            //this.idTxtBox.Clear();
        }

        public void PopulateGrideView(string sql = "select * from sellTable")//optional parameter
        {
            Da.Dt = Da.ExecuteQuery(sql);
        }

        private void sellHistoryBtn_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.PopulateGrideView();
            this.sellsDGV.AutoGenerateColumns = false;
            this.sellsDGV.DataSource = Da.Dt;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            sellHistoryBtn_Click(sender,e);
            DashBoard_Click(sender,e);
        }
    }
}
