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
    public partial class frmArtist : UserControl
    {
        public frmArtist()
        {
            InitializeComponent();
            txtArtistID.Enabled = false;
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
            try
            {
                string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
                using (SqlConnection myConnection = new SqlConnection(strConnect))
                {
                    myConnection.Open();
                    string strCommand = "Select * from Artist";
                    if (!string.IsNullOrEmpty(txtSearch.Text))
                    {
                        string strSearch = "'%" + txtSearch.Text + "%'";
                        strCommand += " where ArtistName like " + strSearch;
                        strCommand += " or MusicGenre like " + strSearch;
                        strCommand += " or PhoneNumber like " + strSearch;
                    }
                    SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                    SqlDataAdapter da = new SqlDataAdapter(myCommand);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Artist");
                    int count = ds.Tables["Artist"].Rows.Count;
                    lblRecords.Text = "Records: " + count.ToString();
                    dgvArtistList.DataSource = ds.Tables["Artist"];
                }
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

        private void ClearData()
        {
            txtArtistID.Text = string.Empty;
            txtArtistName.Text = string.Empty;
            txtMusicGenre.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
        }

        private void dgvArtistList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dgvArtistList.Rows[e.RowIndex];
                    GetCurrentRow(dr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred! " + ex.Message);
            }

        }

        private void dgvArtistList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dgvArtistList.Rows[e.RowIndex];
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
            if (dr.Cells["ArtistID"].Value != null)
            {
                txtArtistID.Text = dr.Cells["ArtistID"].Value.ToString();
            }
            else
            {
                txtArtistID.Text = string.Empty;  
            }

            if (dr.Cells["ArtistName"].Value != null)
            {
                txtArtistName.Text = dr.Cells["ArtistName"].Value.ToString();
            }
            else
            {
                txtArtistName.Text = string.Empty;
            }
            if (dr.Cells["MusicGenre"].Value != null)
            {
                txtMusicGenre.Text = dr.Cells["MusicGenre"].Value.ToString();
            }
            else
            {
                txtMusicGenre.Text = string.Empty;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtArtistName.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text) || string.IsNullOrEmpty(txtMusicGenre.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return; 
                }
                if (!string.IsNullOrEmpty(txtArtistID.Text))
                {
                    DialogResult result1 = MessageBox.Show("You have an Artist ID entered. Do you want to clear it and add a new record?", "Confirm Addition", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
                string strCommand = "ArtistAdd";
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add(new SqlParameter("ArtistName", SqlDbType.NVarChar));
                myCommand.Parameters["ArtistName"].Value = this.txtArtistName.Text;
                myCommand.Parameters.Add(new SqlParameter("MusicGenre", SqlDbType.NVarChar));
                myCommand.Parameters["MusicGenre"].Value = this.txtMusicGenre.Text;
                myCommand.Parameters.Add(new SqlParameter("PhoneNumber", SqlDbType.NVarChar));
                myCommand.Parameters["PhoneNumber"].Value = this.txtPhoneNumber.Text;
                myCommand.Parameters.Add(new SqlParameter("ArtistID", SqlDbType.Int));
                myCommand.Parameters["ArtistID"].Direction = ParameterDirection.Output;
                int row_effectd = myCommand.ExecuteNonQuery();
                if (row_effectd > 0)
                {
                    MessageBox.Show("Added " + row_effectd.ToString() + " Artist with ID is " + myCommand.Parameters["ArtistID"].Value.ToString());
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtArtistID.Text))
                {
                    MessageBox.Show("Please select a record to update. You must choose an existing record to update.", "Record Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
                if (string.IsNullOrEmpty(txtArtistName.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text) || string.IsNullOrEmpty(txtMusicGenre.Text))
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
        
        private void UpdateData()
        {
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
            using (SqlConnection myConnection = new SqlConnection(strConnect))
            {
                myConnection.Open();
                string strCommand = "ArtistUpdate";
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add(new SqlParameter("ArtistName", SqlDbType.NVarChar));
                myCommand.Parameters["ArtistName"].Value = this.txtArtistName.Text;
                myCommand.Parameters.Add(new SqlParameter("PhoneNumber", SqlDbType.NVarChar));
                myCommand.Parameters["PhoneNumber"].Value = this.txtPhoneNumber.Text;
                myCommand.Parameters.Add(new SqlParameter("MusicGenre", SqlDbType.NVarChar));
                myCommand.Parameters["MusicGenre"].Value = this.txtMusicGenre.Text;
                myCommand.Parameters.Add(new SqlParameter("ArtistID", SqlDbType.Int));
                myCommand.Parameters["ArtistID"].Value = int.Parse(this.txtArtistID.Text.ToString());
                int row_effectd = myCommand.ExecuteNonQuery();
                if (row_effectd > 0)
                {
                    MessageBox.Show("Updated " + row_effectd.ToString() + " Artist with ID is " + myCommand.Parameters["ArtistID"].Value.ToString());
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtArtistID.Text))
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
                string strCommand = "Delete Artist where ArtistID = @ArtistID";
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                myCommand.CommandType = CommandType.Text;
                myCommand.Parameters.Add(new SqlParameter("ArtistID", SqlDbType.Int));
                myCommand.Parameters["ArtistID"].Value = int.Parse(this.txtArtistID.Text.ToString());
                int row_effectd = myCommand.ExecuteNonQuery();
                if (row_effectd > 0)
                {
                    MessageBox.Show("Deleted " + row_effectd.ToString() + " Artist with ID is " + myCommand.Parameters["ArtistID"].Value.ToString());
                }
            }
        }

        private void frmArtist_Load(object sender, EventArgs e)
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

