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
    public partial class frmConcert : UserControl
    {
        public frmConcert()
        {
            InitializeComponent();
            txtConcertID.Enabled = false;
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

        private void GetData()
        {
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
            using (SqlConnection myConnection = new SqlConnection(strConnect))
            {
                myConnection.Open();
                string strCommand = "Select * from Concert";
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    string strSearch = "'%" + txtSearch.Text + "%'";
                    strCommand += " WHERE ConcertName LIKE " + strSearch;
                    strCommand += " OR ConcertDate LIKE " + strSearch;
                }

                if (cbbVenueSearch.SelectedValue.ToString() != "0")
                {
                    if (!string.IsNullOrEmpty(txtSearch.Text))
                    {
                        strCommand += " AND VenueID = '" + cbbVenueSearch.SelectedValue.ToString() + "'";
                    }
                    else
                    {
                        strCommand += " WHERE VenueID = '" + cbbVenueSearch.SelectedValue.ToString() + "'";
                    }
                }

                if (cbbArtistSearch.SelectedValue.ToString() != "0")
                {
                    if (!string.IsNullOrEmpty(txtSearch.Text) || cbbVenueSearch.SelectedValue.ToString() != "0")
                    {
                        strCommand += " AND ArtistID = '" + cbbArtistSearch.SelectedValue.ToString() + "'";
                    }
                    else
                    {
                        strCommand += " WHERE ArtistID = '" + cbbArtistSearch.SelectedValue.ToString() + "'";
                    }
                }
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);
                DataSet ds = new DataSet();
                da.Fill(ds, "Concert");
                int count = ds.Tables["Concert"].Rows.Count;
                lblRecords.Text = "Records: " + count.ToString();
                dgvConcertList.DataSource = ds.Tables["Concert"];
            }

        }

        private void frmConcert_Load(object sender, EventArgs e)
        {
            LoadcbbVenueSearch();
            LoadcbbArtistSearch();
            LoadcbbVenue();
            LoadcbbArtist();
            GetData();
        }

        private void LoadcbbArtist()
        {
            try
            {
                string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
                using (SqlConnection myConnection = new SqlConnection(strConnect))
                {
                    myConnection.Open();
                    string strCommand = "Select * from Artist";
                    SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                    SqlDataAdapter da = new SqlDataAdapter(myCommand);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Artist");
                    cbbArtist.DataSource = ds.Tables["Artist"];
                    cbbArtist.DisplayMember = "ArtistName";
                    cbbArtist.ValueMember = "ArtistID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred! " + ex.Message);
            }
        }

        private void LoadcbbVenue()
        {
            try
            {
                string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
                using (SqlConnection myConnection = new SqlConnection(strConnect))
                {
                    myConnection.Open();
                    string strCommand = "Select * from Venue";
                    SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                    SqlDataAdapter da = new SqlDataAdapter(myCommand);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Venue");
                    cbbVenue.DataSource = ds.Tables["Venue"];
                    cbbVenue.DisplayMember = "VenueName";
                    cbbVenue.ValueMember = "VenueID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred! " + ex.Message);
            }
        }

        private void LoadcbbArtistSearch()
        {
            try
            {
                string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
                using (SqlConnection myConnection = new SqlConnection(strConnect))
                {
                    myConnection.Open();
                    string strCommand = "Select * from v_Artist_all";
                    SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                    SqlDataAdapter da = new SqlDataAdapter(myCommand);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Artist");
                    cbbArtistSearch.DataSource = ds.Tables["Artist"];
                    cbbArtistSearch.DisplayMember = "ArtistName";
                    cbbArtistSearch.ValueMember = "ArtistID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred! " + ex.Message);
            }
        }

        private void LoadcbbVenueSearch()
        {
            try
            {
                string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
                using (SqlConnection myConnection = new SqlConnection(strConnect))
                {
                    myConnection.Open();
                    string strCommand = "Select * from v_Venue_all";
                    SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                    SqlDataAdapter da = new SqlDataAdapter(myCommand);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Venue");
                    cbbVenueSearch.DataSource = ds.Tables["Venue"];
                    cbbVenueSearch.DisplayMember = "VenueName";
                    cbbVenueSearch.ValueMember = "VenueID";
                }
            }
            catch 
            {
                
            }
        }

        private void dgvConcertList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dgvConcertList.Rows[e.RowIndex];
                    GetCurrentRow(dr);
                }
            }
            catch 
            {
            }

        }

        private void dgvConcertList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dgvConcertList.Rows[e.RowIndex];
                    GetCurrentRow(dr);
                }
            }
            catch 
            {
            }

        }

        private void GetCurrentRow(DataGridViewRow dr)
        {
            if (dr.Cells["ConcertID"].Value != null)
            {
                txtConcertID.Text = dr.Cells["ConcertID"].Value.ToString();
            }
            else
            {
                txtConcertID.Text = string.Empty;
            }

            if (dr.Cells["ConcertName"].Value != null)
            {
                txtConcertName.Text = dr.Cells["ConcertName"].Value.ToString();
            }
            else
            {
                txtConcertName.Text = string.Empty;
            }
            if (dr.Cells["ConcertDate"].Value != null)
            {
                dtpConcertDate.Text = dr.Cells["ConcertDate"].Value.ToString();
            }
            else
            {
                dtpConcertDate.Value= DateTime.Now;
            }
            if (dr.Cells["VenueID"].Value != null)
            {
                cbbVenue.SelectedValue = dr.Cells["VenueID"].Value.ToString();
            }
            else
            {
                cbbVenue.SelectedIndex=-1;
            }
            if (dr.Cells["ArtistID"].Value != null)
            {
                cbbArtist.SelectedValue = dr.Cells["ArtistID"].Value.ToString();
            }
            else
            {
                cbbArtist.SelectedIndex=-1;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtConcertName.Text) || string.IsNullOrEmpty(dtpConcertDate.Text) || string.IsNullOrEmpty(cbbArtist.Text) || string.IsNullOrEmpty(cbbVenue.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (!string.IsNullOrEmpty(txtConcertID.Text))
                {
                    DialogResult result1 = MessageBox.Show("You have an Concert ID entered. Do you want to clear it and add a new record?", "Confirm Addition", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
                if (string.IsNullOrEmpty(txtConcertID.Text))
                {
                    MessageBox.Show("Please select a record to update. You must choose an existing record to update.", "Record Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
                if (string.IsNullOrEmpty(txtConcertName.Text) || string.IsNullOrEmpty(dtpConcertDate.Text) || string.IsNullOrEmpty(cbbArtist.Text) || string.IsNullOrEmpty(cbbVenue.Text))
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        private void AddData()
        {
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
            using (SqlConnection myConnection = new SqlConnection(strConnect))
            {
                myConnection.Open();
                string strCommand = "ConcertAdd";
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add(new SqlParameter("ConcertName", SqlDbType.NVarChar));
                myCommand.Parameters["ConcertName"].Value = this.txtConcertName.Text;
                myCommand.Parameters.Add(new SqlParameter("ConcertDate", SqlDbType.DateTime));
                myCommand.Parameters["ConcertDate"].Value = DateTime.Parse(this.dtpConcertDate.Value.ToString());
                myCommand.Parameters.Add(new SqlParameter("VenueID", SqlDbType.Int));
                myCommand.Parameters["VenueID"].Value = int.Parse(this.cbbVenue.SelectedValue.ToString());
                myCommand.Parameters.Add(new SqlParameter("ArtistID", SqlDbType.Int));
                myCommand.Parameters["ArtistID"].Value = int.Parse(this.cbbArtist.SelectedValue.ToString());
                myCommand.Parameters.Add(new SqlParameter("ConcertID", SqlDbType.Int));
                myCommand.Parameters["ConcertID"].Direction = ParameterDirection.Output;
                int row_effectd = myCommand.ExecuteNonQuery();
                if (row_effectd > 0)
                {
                    MessageBox.Show("Added " + row_effectd.ToString() + " Concert with ID is " + myCommand.Parameters["ConcertID"].Value.ToString());
                }
            }
        }
        private void UpdateData()
        {
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
            using (SqlConnection myConnection = new SqlConnection(strConnect))
            {
                myConnection.Open();
                string strCommand = "ConcertUpdate";
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add(new SqlParameter("ConcertName", SqlDbType.NVarChar));
                myCommand.Parameters["ConcertName"].Value = this.txtConcertName.Text;
                myCommand.Parameters.Add(new SqlParameter("ConcertDate", SqlDbType.DateTime));
                myCommand.Parameters["ConcertDate"].Value = DateTime.Parse(this.dtpConcertDate.Value.ToString());
                myCommand.Parameters.Add(new SqlParameter("VenueID", SqlDbType.Int));
                myCommand.Parameters["VenueID"].Value = int.Parse(this.cbbVenue.SelectedValue.ToString());
                myCommand.Parameters.Add(new SqlParameter("ArtistID", SqlDbType.Int));
                myCommand.Parameters["ArtistID"].Value = int.Parse(this.cbbArtist.SelectedValue.ToString());
                myCommand.Parameters.Add(new SqlParameter("ConcertID", SqlDbType.Int));
                myCommand.Parameters["ConcertID"].Value = int.Parse(this.txtConcertID.Text);
                int row_effectd = myCommand.ExecuteNonQuery();
                if (row_effectd > 0)
                {
                    MessageBox.Show("Updated " + row_effectd.ToString() + " Concert with ID is " + myCommand.Parameters["ConcertID"].Value.ToString());
                }
            }
        }
        private void DeleteData()
        {
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
            using (SqlConnection myConnection = new SqlConnection(strConnect))
            {
                myConnection.Open();
                string strCommand = "Delete Concert where ConcertID = @ConcertID";
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                myCommand.CommandType = CommandType.Text;
                myCommand.Parameters.Add(new SqlParameter("ConcertID", SqlDbType.Int));
                myCommand.Parameters["ConcertID"].Value = int.Parse(this.txtConcertID.Text.ToString());
                int row_effectd = myCommand.ExecuteNonQuery();
                if (row_effectd > 0)
                {
                    MessageBox.Show("Deleted " + row_effectd.ToString() + " Concert with ID is " + myCommand.Parameters["ConcertID"].Value.ToString());
                }
            }
        }
        private void ClearData()
        {
            txtConcertID.Text = string.Empty;
            txtConcertName.Text = string.Empty;
            dtpConcertDate.Value = DateTime.Now;
            cbbArtist.SelectedIndex = -1;
            cbbVenue.SelectedIndex = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtConcertID.Text))
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

        private void lblSearchFor_Click(object sender, EventArgs e)
        {
            lblSearchFor.Visible = false;
            txtSearch.Focus();
        }
    }
}
