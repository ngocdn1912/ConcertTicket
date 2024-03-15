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

namespace ConcertTicket
{
    public partial class frmEmployee : UserControl
    {
        public frmEmployee()
        {
            InitializeComponent();
            cbbGender.Items.Add("Male");
            cbbGender.Items.Add("Female");
            txtEmployeeID.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred! " + ex.Message);
            }

        }
        public void GetData()
        {
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
            using (SqlConnection myConnection = new SqlConnection(strConnect))
            {
                myConnection.Open();

                //Dùng câu lệnh sql
                string strCommand = "Select * from Employee";
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    string strSearch = "'%" + txtSearch.Text + "%'";
                    strCommand += " where EmployeeName like " + strSearch;
                    strCommand += " or [Address] like " + strSearch;
                    strCommand += " or PhoneNumber like " + strSearch;
                }
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);
                DataSet ds = new DataSet();
                da.Fill(ds, "Employee");
                int count = ds.Tables["Employee"].Rows.Count;
                lblRecords.Text = "Records: " + count.ToString();
                dgvEmployeeList.DataSource = ds.Tables["Employee"];
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            txtEmployeeID.Text = string.Empty;
            txtEmployeeName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            cbbGender.SelectedIndex = -1;

        }

        private void dgvEmployeeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dgvEmployeeList.Rows[e.RowIndex];
                    GetCurrentRow(dr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred! " + ex.Message);
            }
        }


        private void dgvEmployeeList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dgvEmployeeList.Rows[e.RowIndex];
                    GetCurrentRow(dr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred! " + ex.Message);
            }
        }

        private void GetCurrentRow(DataGridViewRow dr)
        {
            if (dr.Cells["EmployeeID"].Value != null)
            {
                txtEmployeeID.Text = dr.Cells["EmployeeID"].Value.ToString();
            }
            else
            {
                txtEmployeeID.Text = string.Empty; 
            }

            if (dr.Cells["EmployeeName"].Value != null)
            {
                txtEmployeeName.Text = dr.Cells["EmployeeName"].Value.ToString();
            }
            else
            {
                txtEmployeeName.Text = string.Empty;
            }

            if (dr.Cells["PhoneNumber"].Value != null)
            {
                txtPhoneNumber.Text = dr.Cells["PhoneNumber"].Value.ToString();
            }
            else
            {
                txtPhoneNumber.Text = string.Empty;
            }

            if (dr.Cells["Address"].Value != null)
            {
                txtAddress.Text = dr.Cells["Address"].Value.ToString();
            }
            else
            {
                txtAddress.Text = string.Empty;
            }

            if (dr.Cells["Gender"].Value != null)
            {
                cbbGender.Text = dr.Cells["Gender"].Value.ToString();
            }
            else
            {
                cbbGender.SelectedIndex = -1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtEmployeeID.Text))
                {
                    MessageBox.Show("Please select a record to update. You must choose an existing record to update.", "Record Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; 
                }
                if (string.IsNullOrEmpty(txtEmployeeName.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text) || string.IsNullOrEmpty(txtAddress.Text) ||  string.IsNullOrEmpty(cbbGender.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                    return; 
                }
                DialogResult result = MessageBox.Show("Are you sure you want to update a record?", "Confirm Updation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    UpdateData();
                    GetData();
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred1! " + ex.Message);
            }

        }
        private void UpdateData()
        {
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
            using (SqlConnection myConnection = new SqlConnection(strConnect))
            {
                myConnection.Open();
                string strCommand = "EmployeeUpdate";
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add(new SqlParameter("EmployeeName", SqlDbType.NVarChar));
                myCommand.Parameters["EmployeeName"].Value = this.txtEmployeeName.Text;
                myCommand.Parameters.Add(new SqlParameter("PhoneNumber", SqlDbType.VarChar));
                myCommand.Parameters["PhoneNumber"].Value = this.txtPhoneNumber.Text;
                myCommand.Parameters.Add(new SqlParameter("Address", SqlDbType.NVarChar));
                myCommand.Parameters["Address"].Value = this.txtAddress.Text;
                myCommand.Parameters.Add(new SqlParameter("Gender", SqlDbType.NVarChar));
                myCommand.Parameters["Gender"].Value = this.cbbGender.Text;
                myCommand.Parameters.Add(new SqlParameter("EmployeeID", SqlDbType.Int));
                myCommand.Parameters["EmployeeID"].Value = int.Parse(this.txtEmployeeID.Text);
                int row_effectd = myCommand.ExecuteNonQuery();
                if (row_effectd > 0)
                {
                    MessageBox.Show("Updated " + row_effectd.ToString() + " Employee with ID is " + myCommand.Parameters["EmployeeID"].Value.ToString());
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtEmployeeName.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(cbbGender.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return; 
                }
                if (!string.IsNullOrEmpty(txtEmployeeID.Text))
                {
                    DialogResult result1 = MessageBox.Show("You have an Employee ID entered. Do you want to clear it and add a new record?", "Confirm Addition", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result1 == DialogResult.No)
                    {
                        return; 
                    }
                    else
                    {
                        ClearData();
                    }
                }
                else
                {
                    DialogResult result2 = MessageBox.Show("Are you sure you want to add a record?", "Confirm Addition", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result2 == DialogResult.Yes)
                    {
                        AddData();
                        GetData();
                        ClearData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred! " + ex.Message);
            }

        }

        private void AddData()
        {
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
            using (SqlConnection myConnection = new SqlConnection(strConnect))
            {
                myConnection.Open();
                string strCommand = "EmployeeAdd";
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add(new SqlParameter("EmployeeName", SqlDbType.NVarChar));
                myCommand.Parameters["EmployeeName"].Value = this.txtEmployeeName.Text;
                myCommand.Parameters.Add(new SqlParameter("PhoneNumber", SqlDbType.VarChar));
                myCommand.Parameters["PhoneNumber"].Value = this.txtPhoneNumber.Text;
                myCommand.Parameters.Add(new SqlParameter("Address", SqlDbType.NVarChar));
                myCommand.Parameters["Address"].Value = this.txtAddress.Text;
                myCommand.Parameters.Add(new SqlParameter("Gender", SqlDbType.NVarChar));
                myCommand.Parameters["Gender"].Value = this.cbbGender.Text;
                myCommand.Parameters.Add(new SqlParameter("EmployeeID", SqlDbType.Int));
                myCommand.Parameters["EmployeeID"].Direction = ParameterDirection.Output;
                int row_effectd = myCommand.ExecuteNonQuery();
                if (row_effectd > 0)
                {
                    MessageBox.Show("Added " + row_effectd.ToString() + " Employee with ID is " + myCommand.Parameters["EmployeeID"].Value.ToString());
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtEmployeeID.Text))
                {
                    DeleteData();
                    GetData();
                    ClearData();
                }
                else
                    MessageBox.Show("You haven't selected a record. Please select a record to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred! " + ex.Message);
            }

        }
        private void DeleteData()
        {
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
            using (SqlConnection myConnection = new SqlConnection(strConnect))
            {
                myConnection.Open();

                //Dùng câu lệnh sql
                string strCommand = "Delete Employee where EmployeeID = @EmployeeID";
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                myCommand.CommandType = CommandType.Text;
                myCommand.Parameters.Add(new SqlParameter("EmployeeID", SqlDbType.Int));
                myCommand.Parameters["EmployeeID"].Value = int.Parse(this.txtEmployeeID.Text.ToString());
                int row_effectd = myCommand.ExecuteNonQuery();
                if (row_effectd > 0)
                {
                    MessageBox.Show("Deleted " + row_effectd.ToString() + " Employee with ID is " + myCommand.Parameters["EmployeeID"].Value.ToString());
                }
            }
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            GetData();
        }


        private void lblSearchFor_Click(object sender, EventArgs e)
        {
            lblSearchFor.Visible = false;
            txtSearch.Focus();
        }
    }
}
