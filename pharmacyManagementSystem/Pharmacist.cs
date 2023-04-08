using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace pharmacyManagementSystem
{
    public partial class Pharmacist : MetroForm
    {
        private Login L { get; set; }
        private DataAccess Da { get; set; }

        private Admin admin { get; set; }
        public Pharmacist()
        {
            InitializeComponent();
            this.Da = new DataAccess();
           // Da.PopulateGrideView();
        }
        public Pharmacist(Login l) :this()
        {
            //InitializeComponent();
            this.L = l;
        }
        private void Pharmacist_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Logout Done!!");
            this.L.Show();
        }
        public void PopulateGrideView(string sql = "select * from medicineTable")//optional parameter
        {
            Da.Dt = Da.ExecuteQuery(sql);
        }
        private void viewMedicineBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
               // this.dgvPharmacist.Rows.Clear();
                viewMedicineBtn.Visible = true;
                var sql = "select * from medicineTable";
                this.PopulateGrideView(sql);
                /*this.dgvPharmacist.AutoGenerateColumns = false;
                this.dgvPharmacist.DataSource = Da.Dt;*/
                this.dgvPharmacist.Rows.Clear();

                foreach (DataRow item in this.Da.Dt.Rows)
                {
                    int n = dgvPharmacist.Rows.Add();

                    dgvPharmacist.Rows[n].Cells[0].Value = false;
                    dgvPharmacist.Rows[n].Cells[1].Value = item["Id"].ToString();
                    dgvPharmacist.Rows[n].Cells[2].Value = item["Mname"].ToString();
                    dgvPharmacist.Rows[n].Cells[3].Value = item["Mnumber"].ToString();
                    dgvPharmacist.Rows[n].Cells[4].Value = item["ManufacturingDate"].ToString();
                    dgvPharmacist.Rows[n].Cells[5].Value = item["ExpiredDate"].ToString();
                    dgvPharmacist.Rows[n].Cells[6].Value = item["Quantity"].ToString();
                    dgvPharmacist.Rows[n].Cells[7].Value = item["PricePerUnit"].ToString();

                }
            
            }   
            catch (Exception ex)
            {
                MessageBox.Show("An error occured." + ex.Message);
            }
          
        }

        //adding meding 
        private void addMedicineBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //now its time to validate our panels
                //here we will user String class and this class has a mehthod called IsNullOrEmpty. 
                //if idTxtBox is empty then it will return true otherwise our insertion operation will be done
                if (this.isValide())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }

                string sql = "insert into medicineTable values('" + this.mediIdTxtBox.Text + "','" + this.mediNameTxtBox.Text + "','" + this.mediNumberTxtBox.Text + "','" + this.manufactureTimePicker.Text + "','" + this.expiredTimePicker.Text + "','" + this.quantityTxtBox.Text + "','"+this.priceTxtBox.Text+"')";
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
      

        private bool isValide()
        {
            if (String.IsNullOrEmpty(this.mediIdTxtBox.Text) || String.IsNullOrEmpty(this.mediNameTxtBox.Text) ||
                String.IsNullOrEmpty(this.mediNumberTxtBox.Text) || String.IsNullOrEmpty(this.manufactureTimePicker.Text) ||
                String.IsNullOrEmpty(this.expiredTimePicker.Text) || String.IsNullOrEmpty(this.quantityTxtBox.Text) ||
                 String.IsNullOrEmpty(this.priceTxtBox.Text) ||

                 //checking spaces

                 String.IsNullOrWhiteSpace(this.mediIdTxtBox.Text) || String.IsNullOrWhiteSpace(this.mediNameTxtBox.Text) ||
                  String.IsNullOrWhiteSpace(this.mediNumberTxtBox.Text) || String.IsNullOrWhiteSpace(this.manufactureTimePicker.Text) ||
                   String.IsNullOrWhiteSpace(this.expiredTimePicker.Text) || String.IsNullOrWhiteSpace(this.quantityTxtBox.Text) ||
                   String.IsNullOrEmpty(this.priceTxtBox.Text))
            {
                return true;
            }
            else
                return false;
        }

        private void dgvPharmacist_DoubleClick(object sender, EventArgs e)
        {
            this.mediIdTxtBox.Text = this.dgvPharmacist.CurrentRow.Cells["Id"].Value.ToString();
            this.mediNameTxtBox.Text = this.dgvPharmacist.CurrentRow.Cells["Mname"].Value.ToString();
            this.mediNumberTxtBox.Text = this.dgvPharmacist.CurrentRow.Cells["Mnumber"].Value.ToString();
            this.manufactureTimePicker.Text = this.dgvPharmacist.CurrentRow.Cells["ManufacturingDate"].Value.ToString();
            this.expiredTimePicker.Text = this.dgvPharmacist.CurrentRow.Cells["ExpiredDate"].Value.ToString();
            this.quantityTxtBox.Text = this.dgvPharmacist.CurrentRow.Cells["Quantity"].Value.ToString();
            this.priceTxtBox.Text = this.dgvPharmacist.CurrentRow.Cells["PricePerUnit"].Value.ToString();
            //this.sPriceTxtBox.Text = this.dgvPharmacist.CurrentRow.Cells["PricePerUnit"].Value.ToString();

            this.mediIdTxtBox.ReadOnly = true;

          

        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValide())
                {
                    MessageBox.Show("Please Fill all informations");
                    return;
                }
                var qeuary = "select * from medicineTable where Id ='" + this.mediIdTxtBox.Text + "' ";
                var count = this.Da.ExecuteQuery(qeuary);
                if (count.Rows.Count == 1)
                {
                    //if yes -> that means this id is there we can update that
                    //update
                    var sql = @"update medicineTable
                             set Mname = '" + this.mediNameTxtBox.Text + @"', 
                             Mnumber = '" + this.mediNumberTxtBox.Text + @"',
                             ManufacturingDate ='" + this.manufactureTimePicker.Text + @"',
                             ExpiredDate ='" + this.expiredTimePicker.Text + @"',
                             Quantity ='" + this.quantityTxtBox.Text + @"',
                             PricePerUnit ='" + this.priceTxtBox.Text + @"'
                             where Id = '" + this.mediIdTxtBox.Text + "' ";
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
                else if (count.Rows.Count == 0)
                {
                    //this condition means no this id is not there we can perform insertion operation
                    //insert
                    string sql = "insert into medicineTable values('" + this.mediIdTxtBox.Text + "','" + this.mediNameTxtBox.Text + "','" + this.mediNumberTxtBox.Text + "','" + this.manufactureTimePicker.Text + "','" + this.expiredTimePicker.Text + "','" + this.quantityTxtBox.Text + "','" + priceTxtBox + "')";
                    int rowCount = Da.ExecuteDMLOperation(sql);

                    if (rowCount == 1)
                    {
                        MessageBox.Show("Data Inserted Successfully.");

                    }
                    else
                    {
                        MessageBox.Show("Data insertion failed.");

                    }
                }
                Da.PopulateGrideView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured." + ex.Message);
            }
        }

        private void sellMedicineBtn_Click(object sender, EventArgs e)
        {
            

            try 
            {


                // for (int i = 0; i < this.sellInfoDGV.Rows.Count - 1; i)
                byte index = 0;
                while (index < (this.sellInfoDGV.Rows.Count - 1))
                {
                   // SqlCommand sqlcom = new SqlCommand(@"insert into sellTable (Mname,ManufacturingDate ,ExpiredDate,Quantity,PricePerUnit,TotalPrice) values ('" + dataGridView2.Rows[i].Cells[0].Value + "','" + dataGridView2.Rows[i].Cells[1].Value + "','" + dataGridView2.Rows[i].Cells[2].Value + "','" + dataGridView2.Rows[i].Cells[3].Value + "','" + dataGridView2.Rows[i].Cells[4].Value + "','" + dataGridView2.Rows[i].Cells[5].Value + "')", sqlcon);
                     
                    
                    var sql = "insert into sellTable (Mname,Quantity,PricePerUnit,TotalPrice) values ('" + this.sellInfoDGV.Rows[index].Cells[0].Value + "','" + this.sellInfoDGV.Rows[index].Cells[1].Value + "','" + this.sellInfoDGV.Rows[index].Cells[2].Value + "','" + this.sellInfoDGV.Rows[index].Cells[3].Value + "')";


                    /*   sqlcon.Open();
                       sqlcom.ExecuteNonQuery();
                       sqlcon.Close();*/
                    int rowCount = Da.ExecuteDMLOperation(sql);
                    if (rowCount == 1) 
                    {
                        MessageBox.Show("Your operation is done.You can see this infomation in your sells table");
                        break;
                    }
                    
                    Da.PopulateGrideView();

                    index++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occoured!"+ex.Message);
            }

        }

       
        private void sPriceTxtBox_TextChanged(object sender, EventArgs e)
        {
           /* this.sPriceTxtBox.Show();*/
        }

        private void resetEverythingBtn_Click(object sender, EventArgs e)
        {
            this.mediIdTxtBox.Clear();
            this.mediNameTxtBox.Clear();
            this.mediNumberTxtBox.Clear();
            this.manufactureTimePicker.Refresh();
            this.expiredTimePicker.Refresh();
            this.quantityTxtBox.Clear();
            this.priceTxtBox.Clear();
            /*this.sPriceTxtBox.Clear();
            this.sQuantityTxtBox.Clear();*/
            //this.sTotalPriceTxtBox.Clear();
        }
      
        private void mediDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {

                var id = this.dgvPharmacist.CurrentRow.Cells[1].Value.ToString();
                var name = this.dgvPharmacist.CurrentRow.Cells[2].Value.ToString();
                //MessageBox.Show(name);
                string sql = "delete from medicineTable where Id ='" + id + "'";
                int rowCount = Da.ExecuteDMLOperation(sql);
                if (rowCount == 1)
                {
                    MessageBox.Show(name + " Deleted!!");
                   // this.dgvPharmacist.DataSource = Da.Dt;
                    //this.PopulateGrideView();
                    //this.dgvPharmacist.Rows.Clear();
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

        private void copyBtn_Click(object sender, EventArgs e)
        {
          
            this.sellInfoDGV.Rows.Clear();



            foreach (DataGridViewRow item in dgvPharmacist.Rows)
            {

               // item.Cells[6].Value = 0;

                if ((bool)item.Cells[0].Value == true)
                {
                    int n = this.sellInfoDGV.Rows.Add();

                    

                    // selectDVGmedicine.Rows[n].Cells[0].Value = item.Cells[1].Value.ToString();
                    this.sellInfoDGV.Rows[n].Cells[0].Value = item.Cells[2].Value.ToString();
                    //selectDVGmedicine.Rows[n].Cells[2].Value = item.Cells[3].Value.ToString();
                    this.sellInfoDGV.Rows[n].Cells[1].Value = 0;
                    this.sellInfoDGV.Rows[n].Cells[2].Value = item.Cells[7].Value.ToString();


                }
            }
        }

        private void dgvPharmacist_MouseClick(object sender, MouseEventArgs e)
        {
            if ((bool)dgvPharmacist.SelectedRows[0].Cells[0].Value == false)
            {
                dgvPharmacist.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                dgvPharmacist.SelectedRows[0].Cells[0].Value = false;
            }
        }

        private void dgvPharmacist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.mediIdTxtBox.Text = this.dgvPharmacist.CurrentRow.Cells["Id"].Value.ToString();
            this.mediNameTxtBox.Text = this.dgvPharmacist.CurrentRow.Cells["Mname"].Value.ToString();
            this.mediNumberTxtBox.Text = this.dgvPharmacist.CurrentRow.Cells["Mnumber"].Value.ToString();
            this.manufactureTimePicker.Text = this.dgvPharmacist.CurrentRow.Cells["ManufacturingDate"].Value.ToString();
            this.expiredTimePicker.Text = this.dgvPharmacist.CurrentRow.Cells["ExpiredDate"].Value.ToString();
            this.quantityTxtBox.Text = this.dgvPharmacist.CurrentRow.Cells["Quantity"].Value.ToString();
            this.priceTxtBox.Text = this.dgvPharmacist.CurrentRow.Cells["PricePerUnit"].Value.ToString();
        }
       
        private void sellInfoDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           /* var sql = "update medicineTable set Quantity = this.sellInfoDGV.CurrentRow.Cells'[" + Quantity + "] - '" + this.sellInfoDGV.CurrentRow.Cells["sQuantity"] +  where  Medicine Name =  '"+ this.sellInfoDGV.CurrentRow.Cells["Mname"] "';
                 var condition1 = Convert.ToInt16(this.sQuantityTxtBox.Text);
                 var condition2 = Convert.ToInt16(this.Da.Dt.Rows[0][5]);

                 if (condition1 > condition2)
                 {
                     MessageBox.Show("Overflow quentity taken.");

                 }*/
            /*else
            {*/
                foreach (DataGridViewRow item in this.sellInfoDGV.Rows)
                {
                    item.Cells["TotalPrice"].Value = Convert.ToInt32(item.Cells["sQuantity"].Value) * Convert.ToInt32(item.Cells["sPricePerUnit"].Value);
               // item.Cells["TotalPrice"].Value = Convert.ToInt32(item.Cells["Quantity"].Value) * Convert.ToInt32(item.Cells["PricePerUnit"].Value);
                }
           
            

        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {
            viewMedicineBtn_Click(sender,e);
        }
    }
}
