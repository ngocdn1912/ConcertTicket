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
    public partial class frmCustomer : UserControl
    {
        public frmCustomer()
        {
            InitializeComponent();
            txtCustomerID.Enabled = false;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCustomerName.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (!string.IsNullOrEmpty(txtCustomerID.Text))
                {
                    DialogResult result1 = MessageBox.Show("You have an Customer ID entered. Do you want to clear it and add a new record?", "Confirm Addition", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCustomerID.Text))
                {
                    MessageBox.Show("Please select a record to update. You must choose an existing record to update.", "Record Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
                if (string.IsNullOrEmpty(txtCustomerName.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text))
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
                MessageBox.Show("An error occurred! " + ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCustomerID.Text))
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();

        }

        private void dgvCustomerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dgvCustomerList.Rows[e.RowIndex];
                    GetCurrentRow(dr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred! " + ex.Message);
            }

        }

        private void dgvCustomerList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dgvCustomerList.Rows[e.RowIndex];
                    GetCurrentRow(dr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred! " + ex.Message);
            }

        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            GetData();
        }
        private void GetCurrentRow(DataGridViewRow dr)
        {
            if (dr.Cells["CustomerID"].Value != null)
            {
                txtCustomerID.Text = dr.Cells["CustomerID"].Value.ToString();
            }
            else
            {
                txtCustomerID.Text = string.Empty;
            }

            if (dr.Cells["CustomerName"].Value != null)
            {
                txtCustomerName.Text = dr.Cells["CustomerName"].Value.ToString();
            }
            else
            {
                txtCustomerName.Text = string.Empty;
            }
            if (dr.Cells["PhoneNumber"].Value != null)
            {
                txtPhoneNumber.Text = dr.Cells["PhoneNumber"].Value.ToString();
            }
            else
            {
                txtPhoneNumber.Text = string.Empty;
            }

        }

        public void GetData()
        {
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
            using (SqlConnection myConnection = new SqlConnection(strConnect))
            {
                myConnection.Open();
                string strCommand = "Select * from Customer";
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    string strSearch = "'%" + txtSearch.Text + "%'";
                    strCommand += " where CustomerName like " + strSearch;
                    strCommand += " or PhoneNumber like " + strSearch;
                }
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);
                DataSet ds = new DataSet();
                da.Fill(ds, "Customer");
                int count = ds.Tables["Customer"].Rows.Count;
                lblRecords.Text = "Records: " + count.ToString();
                dgvCustomerList.DataSource = ds.Tables["Customer"];
            }
        }
        private void AddData()
        {
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
            using (SqlConnection myConnection = new SqlConnection(strConnect))
            {
                myConnection.Open();
                string strCommand = "CustomerAdd";
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add(new SqlParameter("CustomerName", SqlDbType.NVarChar));
                myCommand.Parameters["CustomerName"].Value = this.txtCustomerName.Text;
                myCommand.Parameters.Add(new SqlParameter("PhoneNumber", SqlDbType.VarChar));
                myCommand.Parameters["PhoneNumber"].Value = this.txtPhoneNumber.Text;
                myCommand.Parameters.Add(new SqlParameter("CustomerID", SqlDbType.Int));
                myCommand.Parameters["CustomerID"].Direction = ParameterDirection.Output;
                int row_effectd = myCommand.ExecuteNonQuery();
                if (row_effectd > 0)
                {
                    MessageBox.Show("Added " + row_effectd.ToString() + " Customer with ID is " + myCommand.Parameters["CustomerID"].Value.ToString());
                }
            }
        }
        private void UpdateData()
        {
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
            using (SqlConnection myConnection = new SqlConnection(strConnect))
            {
                myConnection.Open();
                string strCommand = "CustomerUpdate";
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add(new SqlParameter("CustomerName", SqlDbType.NVarChar));
                myCommand.Parameters["CustomerName"].Value = this.txtCustomerName.Text;
                myCommand.Parameters.Add(new SqlParameter("PhoneNumber", SqlDbType.VarChar));
                myCommand.Parameters["PhoneNumber"].Value = this.txtPhoneNumber.Text;
                myCommand.Parameters.Add(new SqlParameter("CustomerID", SqlDbType.NVarChar));
                myCommand.Parameters["CustomerID"].Value = int.Parse(this.txtCustomerID.Text.ToString());
                int row_effectd = myCommand.ExecuteNonQuery();
                if (row_effectd > 0)
                {
                    MessageBox.Show("Updated " + row_effectd.ToString() + " Customer with ID is " + myCommand.Parameters["CustomerID"].Value.ToString());
                }
            }
        }
        private void DeleteData()
        {
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
            using (SqlConnection myConnection = new SqlConnection(strConnect))
            {
                myConnection.Open();
                string strCommand = "Delete Customer where CustomerID = @CustomerID";
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                myCommand.CommandType = CommandType.Text;
                myCommand.Parameters.Add(new SqlParameter("CustomerID", SqlDbType.Int));
                myCommand.Parameters["CustomerID"].Value = int.Parse(this.txtCustomerID.Text.ToString());
                int row_effectd = myCommand.ExecuteNonQuery();
                if (row_effectd > 0)
                {
                    MessageBox.Show("Deleted " + row_effectd.ToString() + " Customer with ID is " + myCommand.Parameters["CustomerID"].Value.ToString());
                }
            }
        }
        private void ClearData()
        {
            txtCustomerID.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
        }

        private void lblSearchFor_Click(object sender, EventArgs e)
        {
            lblSearchFor.Visible = false;
            txtSearch.Focus();
        }
    }
}
