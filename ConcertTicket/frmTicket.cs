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
    public partial class frmTicket : UserControl
    {
        public frmTicket()
        {
            InitializeComponent();
            txtTicketID.Enabled = false;
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
                string strCommand = "Select TicketID, Price, RemainingTickets, ConcertID, CategoryID from Ticket";
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    string strSearch = "'%" + txtSearch.Text + "%'";
                    strCommand += " WHERE (Price LIKE " + strSearch;
                    strCommand += " OR RemainingTickets LIKE " + strSearch+")";
                }

                if (cbbConcertSearch.SelectedValue.ToString() != "0")
                {
                    if (!string.IsNullOrEmpty(txtSearch.Text))
                    {
                        strCommand += " AND ConcertID = '" + cbbConcertSearch.SelectedValue.ToString() + "'";
                    }
                    else
                    {
                        strCommand += " WHERE ConcertID = '" + cbbConcertSearch.SelectedValue.ToString() + "'";
                    }
                }

                if (cbbCategorySearch.SelectedValue.ToString() != "0")
                {
                    if (!string.IsNullOrEmpty(txtSearch.Text))
                    {
                        strCommand += " AND CategoryID = '" + cbbCategorySearch.SelectedValue.ToString() + "'";
                    }
                    else
                    {
                        if (cbbConcertSearch.SelectedValue.ToString() != "0")
                        {
                        strCommand += " AND CategoryID = '" + cbbCategorySearch.SelectedValue.ToString() + "'";
                        }
                        else
                        {
                            strCommand += " Where CategoryID = '" + cbbCategorySearch.SelectedValue.ToString() + "'";
                        }
                    }
                }
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);
                DataSet ds = new DataSet();
                da.Fill(ds, "Ticket");
                int count = ds.Tables["Ticket"].Rows.Count;
                lblRecords.Text = "Records: " + count.ToString();
                dgvTicketList.DataSource = ds.Tables["Ticket"];
            }
        }

        private void frmTicket_Load(object sender, EventArgs e)
        {
            LoadcbbConcertSearch();
            LoadcbbCategorySearch();
            LoadcbbConcert();
            LoadcbbCategory();
            GetData();
        }
        private void LoadcbbCategory()
        {
            try
            {
                string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
                using (SqlConnection myConnection = new SqlConnection(strConnect))
                {
                    myConnection.Open();
                    string strCommand = "Select * from TicketCategory";
                    SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                    SqlDataAdapter da = new SqlDataAdapter(myCommand);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Category");
                    cbbCategory.DataSource = ds.Tables["Category"];
                    cbbCategory.DisplayMember = "CategoryName";
                    cbbCategory.ValueMember = "CategoryID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred! " + ex.Message);
            }
        }

        private void LoadcbbConcert()
        {
            try
            {
                string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
                using (SqlConnection myConnection = new SqlConnection(strConnect))
                {
                    myConnection.Open();
                    string strCommand = "Select * from Concert";
                    SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                    SqlDataAdapter da = new SqlDataAdapter(myCommand);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Concert");
                    cbbConcert.DataSource = ds.Tables["Concert"];
                    cbbConcert.DisplayMember = "ConcertName";
                    cbbConcert.ValueMember = "ConcertID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred! " + ex.Message);
            }
        }

        private void LoadcbbCategorySearch()
        {
            try
            {
                string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
                using (SqlConnection myConnection = new SqlConnection(strConnect))
                {
                    myConnection.Open();
                    string strCommand = "Select * from v_Category_all";
                    SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                    SqlDataAdapter da = new SqlDataAdapter(myCommand);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Category");
                    cbbCategorySearch.DataSource = ds.Tables["Category"];
                    cbbCategorySearch.DisplayMember = "CategoryName";
                    cbbCategorySearch.ValueMember = "CategoryID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred! " + ex.Message);
            }
        }

        private void LoadcbbConcertSearch()
        {
            try
            {
                string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
                using (SqlConnection myConnection = new SqlConnection(strConnect))
                {
                    myConnection.Open();
                    string strCommand = "Select * from v_Concert_all";
                    SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                    SqlDataAdapter da = new SqlDataAdapter(myCommand);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Concert");
                    cbbConcertSearch.DataSource = ds.Tables["Concert"];
                    cbbConcertSearch.DisplayMember = "ConcertName";
                    cbbConcertSearch.ValueMember = "ConcertID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred! " + ex.Message);
            }
        }

        private void dgvTicketList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dgvTicketList.Rows[e.RowIndex];
                    GetCurrentRow(dr);
                }
            }
            catch 
            {
                
            }

        }

        private void dgvTicketList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dgvTicketList.Rows[e.RowIndex];
                    GetCurrentRow(dr);
                }
            }
            catch 
            {
                
            }

        }

        private void GetCurrentRow(DataGridViewRow dr)
        {
            if (dr.Cells["TicketID"].Value != null)
            {
                txtTicketID.Text = dr.Cells["TicketID"].Value.ToString();
            }
            else
            {
                txtTicketID.Text = string.Empty;
            }

            if (dr.Cells["Price"].Value != null)
            {
                txtPrice.Text = ((decimal)dr.Cells["Price"].Value).ToString();
            }
            else
            {
                txtPrice.Text = string.Empty;
            }
            if (dr.Cells["RemainingTickets"].Value != null)
            {
                txtRemainingTickets.Text = dr.Cells["RemainingTickets"].Value.ToString();
            }
            else
            {
                txtRemainingTickets.Text = string.Empty;
            }
            if (dr.Cells["ConcertID"].Value != null)
            {
                cbbConcert.SelectedValue = dr.Cells["ConcertID"].Value.ToString();
            }
            else
            {
                cbbConcert.SelectedIndex = -1;
            }
            if (dr.Cells["CategoryID"].Value != null)
            {
                cbbCategory.SelectedValue = dr.Cells["CategoryID"].Value.ToString();
            }
            else
            {
                cbbCategory.SelectedIndex = -1;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            txtTicketID.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtRemainingTickets.Text = string.Empty;
            cbbConcert.SelectedIndex = -1;
            cbbCategory.SelectedIndex = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtTicketID.Text))
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
                string strCommand = "Delete Ticket where TicketID = @TicketID";
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                myCommand.CommandType = CommandType.Text;
                myCommand.Parameters.Add(new SqlParameter("TicketID", SqlDbType.Int));
                myCommand.Parameters["TicketID"].Value = int.Parse(this.txtTicketID.Text.ToString());
                int row_effectd = myCommand.ExecuteNonQuery();
                if (row_effectd > 0)
                {
                    MessageBox.Show("Deleted " + row_effectd.ToString() + " Ticket with ID is " + myCommand.Parameters["TicketID"].Value.ToString());
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtRemainingTickets.Text) || string.IsNullOrEmpty(cbbConcert.Text) || string.IsNullOrEmpty(cbbCategory.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (!string.IsNullOrEmpty(txtTicketID.Text))
                {
                    DialogResult result1 = MessageBox.Show("You have an Ticket ID entered. Do you want to clear it and add a new record?", "Confirm Addition", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
                string strCommand = "TicketAdd";
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add(new SqlParameter("Price", SqlDbType.Decimal));
                myCommand.Parameters["Price"].Value = decimal.Parse(this.txtPrice.Text);
                myCommand.Parameters.Add(new SqlParameter("RemainingTickets", SqlDbType.Int));
                myCommand.Parameters["RemainingTickets"].Value = int.Parse(this.txtRemainingTickets.Text);
                myCommand.Parameters.Add(new SqlParameter("ConcertID", SqlDbType.Int));
                myCommand.Parameters["ConcertID"].Value = int.Parse(this.cbbConcert.SelectedValue.ToString());
                myCommand.Parameters.Add(new SqlParameter("CategoryID", SqlDbType.Int));
                myCommand.Parameters["CategoryID"].Value = int.Parse(this.cbbCategory.SelectedValue.ToString());
                myCommand.Parameters.Add(new SqlParameter("TicketID", SqlDbType.Int));
                myCommand.Parameters["TicketID"].Direction = ParameterDirection.Output;
                int row_effectd = myCommand.ExecuteNonQuery();
                if (row_effectd > 0)
                {
                    MessageBox.Show("Added " + row_effectd.ToString() + " Ticket with ID is " + myCommand.Parameters["TicketID"].Value.ToString());
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTicketID.Text))
                {
                    MessageBox.Show("Please select a record to update. You must choose an existing record to update.", "Record Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
                if ( string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(cbbConcert.Text) || string.IsNullOrEmpty(cbbCategory.Text))
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
                string strCommand = "TicketUpdate";
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add(new SqlParameter("Price", SqlDbType.Decimal));
                myCommand.Parameters["Price"].Value = decimal.Parse(this.txtPrice.Text);
                myCommand.Parameters.Add(new SqlParameter("RemainingTickets", SqlDbType.Int));
                myCommand.Parameters["RemainingTickets"].Value =int.Parse(this.txtRemainingTickets.Text);
                myCommand.Parameters.Add(new SqlParameter("ConcertID", SqlDbType.Int));
                myCommand.Parameters["ConcertID"].Value = int.Parse(this.cbbConcert.SelectedValue.ToString());
                myCommand.Parameters.Add(new SqlParameter("CategoryID", SqlDbType.Int));
                myCommand.Parameters["CategoryID"].Value = int.Parse(this.cbbCategory.SelectedValue.ToString());
                myCommand.Parameters.Add(new SqlParameter("TicketID", SqlDbType.Int));
                myCommand.Parameters["TicketID"].Value = int.Parse(this.txtTicketID.Text);
                int row_effectd = myCommand.ExecuteNonQuery();
                if (row_effectd > 0)
                {
                    MessageBox.Show("Updated " + row_effectd.ToString() + " Ticket with ID is " + myCommand.Parameters["TicketID"].Value.ToString());
                }
            }

        }

        private void lblSearchFor_Click(object sender, EventArgs e)
        {
            lblSearchFor.Visible = false;
            txtSearch.Focus();
        }
    }
}
