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
    public partial class frmVenue : UserControl
    {
        public frmVenue()
        {
            InitializeComponent();
            txtVenueID.Enabled = false;
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
                if (string.IsNullOrEmpty(txtVenueName.Text)||string.IsNullOrEmpty(txtAddress.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (!string.IsNullOrEmpty(txtVenueID.Text))
                {
                    DialogResult result1 = MessageBox.Show("You have an Venue ID entered. Do you want to clear it and add a new record?", "Confirm Addition", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
                if (string.IsNullOrEmpty(txtVenueID.Text))
                {
                    MessageBox.Show("Please select a record to update. You must choose an existing record to update.", "Record Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
                if (string.IsNullOrEmpty(txtVenueName.Text)|| string.IsNullOrEmpty(txtAddress.Text))
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
                if (!string.IsNullOrEmpty(txtVenueID.Text))
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

        private void dgvVenueList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dgvVenueList.Rows[e.RowIndex];
                    GetCurrentRow(dr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred! " + ex.Message);
            }

        }

        private void dgvVenueList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dgvVenueList.Rows[e.RowIndex];
                    GetCurrentRow(dr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred! " + ex.Message);
            }

        }

        private void frmVenue_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetCurrentRow(DataGridViewRow dr)
        {
            if (dr.Cells["VenueID"].Value != null)
            {
                txtVenueID.Text = dr.Cells["VenueID"].Value.ToString();
            }
            else
            {
                txtVenueID.Text = string.Empty;
            }

            if (dr.Cells["VenueName"].Value != null)
            {
                txtVenueName.Text = dr.Cells["VenueName"].Value.ToString();
            }
            else
            {
                txtVenueName.Text = string.Empty;
            }
            if (dr.Cells["Address"].Value != null)
            {
                txtAddress.Text = dr.Cells["Address"].Value.ToString();
            }
            else
            {
                txtAddress.Text = string.Empty;
            }

        }

        public void GetData()
        {
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
            using (SqlConnection myConnection = new SqlConnection(strConnect))
            {
                myConnection.Open();
                string strCommand = "Select * from Venue";
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    string strSearch = "'%" + txtSearch.Text + "%'";
                    strCommand += " where VenueName like " + strSearch;
                    strCommand += " or Address like " + strSearch;
                }
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);
                DataSet ds = new DataSet();
                da.Fill(ds, "Venue");
                int count = ds.Tables["Venue"].Rows.Count;
                lblRecords.Text = "Records: " + count.ToString();
                dgvVenueList.DataSource = ds.Tables["Venue"];
            }
        }
        private void AddData()
        {
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
            using (SqlConnection myConnection = new SqlConnection(strConnect))
            {
                myConnection.Open();
                string strCommand = "VenueAdd";
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add(new SqlParameter("VenueName", SqlDbType.NVarChar));
                myCommand.Parameters["VenueName"].Value = this.txtVenueName.Text;
                myCommand.Parameters.Add(new SqlParameter("Address", SqlDbType.NVarChar));
                myCommand.Parameters["Address"].Value = this.txtAddress.Text;
                myCommand.Parameters.Add(new SqlParameter("VenueID", SqlDbType.Int));
                myCommand.Parameters["VenueID"].Direction = ParameterDirection.Output;
                int row_effectd = myCommand.ExecuteNonQuery();
                if (row_effectd > 0)
                {
                    MessageBox.Show("Added " + row_effectd.ToString() + " Venue with ID is " + myCommand.Parameters["VenueID"].Value.ToString());
                }
            }
        }
        private void UpdateData()
        {
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
            using (SqlConnection myConnection = new SqlConnection(strConnect))
            {
                myConnection.Open();
                string strCommand = "VenueUpdate";
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add(new SqlParameter("VenueName", SqlDbType.NVarChar));
                myCommand.Parameters["VenueName"].Value = this.txtVenueName.Text;
                myCommand.Parameters.Add(new SqlParameter("Address", SqlDbType.NVarChar));
                myCommand.Parameters["Address"].Value = this.txtAddress.Text;
                myCommand.Parameters.Add(new SqlParameter("VenueID", SqlDbType.NVarChar));
                myCommand.Parameters["VenueID"].Value = int.Parse(this.txtVenueID.Text.ToString());
                int row_effectd = myCommand.ExecuteNonQuery();
                if (row_effectd > 0)
                {
                    MessageBox.Show("Updated " + row_effectd.ToString() + " Venue with ID is " + myCommand.Parameters["VenueID"].Value.ToString());
                }
            }
        }
        private void DeleteData()
        {
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
            using (SqlConnection myConnection = new SqlConnection(strConnect))
            {
                myConnection.Open();
                string strCommand = "Delete Venue where VenueID = @VenueID";
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                myCommand.CommandType = CommandType.Text;
                myCommand.Parameters.Add(new SqlParameter("VenueID", SqlDbType.Int));
                myCommand.Parameters["VenueID"].Value = int.Parse(this.txtVenueID.Text.ToString());
                int row_effectd = myCommand.ExecuteNonQuery();
                if (row_effectd > 0)
                {
                    MessageBox.Show("Deleted " + row_effectd.ToString() + " Venue with ID is " + myCommand.Parameters["VenueID"].Value.ToString());
                }
            }
        }
        private void ClearData()
        {
            txtVenueID.Text = string.Empty;
            txtVenueName.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }

        private void lblSearchFor_Click(object sender, EventArgs e)
        {
            lblSearchFor.Visible = false;
            txtSearch.Focus();
        }
    }
}
