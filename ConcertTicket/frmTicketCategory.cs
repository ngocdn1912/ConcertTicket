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
    public partial class frmTicketCategory : UserControl
    {
        public frmTicketCategory()
        {
            InitializeComponent();
            txtCategoryID.Enabled = false;
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
                if (string.IsNullOrEmpty(txtCategoryName.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (!string.IsNullOrEmpty(txtCategoryID.Text))
                {
                    DialogResult result1 = MessageBox.Show("You have an Category ID entered. Do you want to clear it and add a new record?", "Confirm Addition", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
                if (string.IsNullOrEmpty(txtCategoryID.Text))
                {
                    MessageBox.Show("Please select a record to update. You must choose an existing record to update.", "Record Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
                if (string.IsNullOrEmpty(txtCategoryName.Text))
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
                if (!string.IsNullOrEmpty(txtCategoryID.Text))
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

        private void dgvCategoryList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dgvCategoryList.Rows[e.RowIndex];
                    GetCurrentRow(dr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred! " + ex.Message);
            }

        }

        private void dgvCategoryList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dgvCategoryList.Rows[e.RowIndex];
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
            if (dr.Cells["CategoryID"].Value != null)
            {
                txtCategoryID.Text = dr.Cells["CategoryID"].Value.ToString();
            }
            else
            {
                txtCategoryID.Text = string.Empty;
            }

            if (dr.Cells["CategoryName"].Value != null)
            {
                txtCategoryName.Text = dr.Cells["CategoryName"].Value.ToString();
            }
            else
            {
                txtCategoryName.Text = string.Empty;
            }

        }

        public void GetData()
        {
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
            using (SqlConnection myConnection = new SqlConnection(strConnect))
            {
                myConnection.Open();
                string strCommand = "Select * from TicketCategory";
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    string strSearch = "'%" + txtSearch.Text + "%'";
                    strCommand += " where CategoryName like " + strSearch;
                }
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);
                DataSet ds = new DataSet();
                da.Fill(ds, "Category");
                int count = ds.Tables["Category"].Rows.Count;
                lblRecords.Text = "Records: " + count.ToString();
                dgvCategoryList.DataSource = ds.Tables["Category"];
            }
        }
        private void AddData()
        {
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
            using (SqlConnection myConnection = new SqlConnection(strConnect))
            {
                myConnection.Open();
                string strCommand = "CategoryAdd";
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add(new SqlParameter("CategoryName", SqlDbType.NVarChar));
                myCommand.Parameters["CategoryName"].Value = this.txtCategoryName.Text;
                myCommand.Parameters.Add(new SqlParameter("CategoryID", SqlDbType.Int));
                myCommand.Parameters["CategoryID"].Direction = ParameterDirection.Output;
                int row_effectd = myCommand.ExecuteNonQuery();
                if (row_effectd > 0)
                {
                    MessageBox.Show("Added " + row_effectd.ToString() + " Category with ID is " + myCommand.Parameters["CategoryID"].Value.ToString());
                }
            }
        }
        private void UpdateData()
        {
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
            using (SqlConnection myConnection = new SqlConnection(strConnect))
            {
                myConnection.Open();
                string strCommand = "CategoryUpdate";
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add(new SqlParameter("CategoryName", SqlDbType.NVarChar));
                myCommand.Parameters["CategoryName"].Value = this.txtCategoryName.Text;
                myCommand.Parameters.Add(new SqlParameter("CategoryID", SqlDbType.NVarChar));
                myCommand.Parameters["CategoryID"].Value = int.Parse(this.txtCategoryID.Text.ToString());
                int row_effectd = myCommand.ExecuteNonQuery();
                if (row_effectd > 0)
                {
                    MessageBox.Show("Updated " + row_effectd.ToString() + " Category with ID is " + myCommand.Parameters["CategoryID"].Value.ToString());
                }
            }
        }
        private void DeleteData()
        {
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
            using (SqlConnection myConnection = new SqlConnection(strConnect))
            {
                myConnection.Open();
                string strCommand = "Delete TicketCategory where CategoryID = @CategoryID";
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                myCommand.CommandType = CommandType.Text;
                myCommand.Parameters.Add(new SqlParameter("CategoryID", SqlDbType.Int));
                myCommand.Parameters["CategoryID"].Value = int.Parse(txtCategoryID.Text.ToString());
                int row_effectd = myCommand.ExecuteNonQuery();
                if (row_effectd > 0)
                {
                    MessageBox.Show("Deleted " + row_effectd.ToString() + " Category with ID is " + myCommand.Parameters["CategoryID"].Value.ToString());
                }
            }
        }
        private void ClearData()
        {
            txtCategoryID.Text = string.Empty;
            txtCategoryName.Text = string.Empty;
        }

        private void frmTicketCategory_Load(object sender, EventArgs e)
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
