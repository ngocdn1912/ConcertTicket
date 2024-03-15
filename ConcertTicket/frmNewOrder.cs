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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ConcertTicket
{
    public partial class frmNewOrder : Form
    {
        public frmNewOrder()
        {
            InitializeComponent();
            txtOrderID.Enabled = false;
            cbbCustomer.Enabled = false;
            dtpOrderDate.Enabled = false;
            dtpOrderDate.Value = DateTime.Now;
            txtTicketID.Enabled = false;
            txtRemainingTickets.Enabled = false;
            txtPrice.Enabled = false;
            txtTotalCost.Enabled = false;
            DisabledTiket();
        }

        private void DisabledTiket()
        {
            cbbConcert.Enabled = false;
            cbbCategory.Enabled = false;
            nudQuantity.Enabled = false;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
            btnPrint.Enabled = false;
            dgvOrderDetail.Enabled = false;
            txtArtist.Enabled = false;
            txtVenue.Enabled =false;
            txtConcertDate.Enabled = false;
        }
        private void EnabledTicket()
        {
            cbbConcert.Enabled = true;
            cbbCategory.Enabled = true;
            nudQuantity.Enabled = true;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnClear.Enabled = true;
            btnPrint.Enabled = true;
            dgvOrderDetail.Enabled = true;
        }

        private void frmNewOrder_Load(object sender, EventArgs e)
        {
            LoadcbbEmployee();
        }

        private void LoadcbbEmployee()
        {
            try
            {
                string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
                using (SqlConnection myConnection = new SqlConnection(strConnect))
                {
                    myConnection.Open();
                    string strCommand = "Select * from Employee";
                    SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                    SqlDataAdapter da = new SqlDataAdapter(myCommand);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Employee");
                    cbbEmployee.DataSource = ds.Tables["Employee"];
                    cbbEmployee.DisplayMember = "EmployeeName";
                    cbbEmployee.ValueMember = "EmployeeID";
                    cbbEmployee.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred! " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCustomerPhone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();

                using (SqlConnection myConnection = new SqlConnection(strConnect))
                {
                    myConnection.Open();
                    string strCommand = "Select * from Customer where PhoneNumber = @CustomerPhone";
                    SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                    myCommand.CommandType = CommandType.Text;
                    myCommand.Parameters.Add(new SqlParameter("@CustomerPhone", SqlDbType.VarChar));
                    myCommand.Parameters["@CustomerPhone"].Value = this.txtCustomerPhone.Text;

                    SqlDataAdapter da = new SqlDataAdapter(myCommand);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Customer");

                    if (ds.Tables["Customer"].Rows.Count > 0)
                    {
                        cbbCustomer.DataSource = ds.Tables["Customer"];
                        cbbCustomer.DisplayMember = "CustomerName";
                        cbbCustomer.ValueMember = "CustomerID";
                    }
                    else
                    {
                        cbbCustomer.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred! " + ex.Message);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cbbCustomer.Text))
                {
                    MessageBox.Show("Customer information is missing. Please fill in all the required fields.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                     CreateOrder();
                     DisabledOrder();
                     EnabledTicket();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred! " + ex.Message);
            }

        }

        private void DisabledOrder()
        {
            txtCustomerPhone.Enabled = false;
            cbbEmployee.Enabled = false;
            btnCreate.Enabled = false;
        }

        private void CreateOrder()
        {
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
            using (SqlConnection myConnection = new SqlConnection(strConnect))
            {
                myConnection.Open();
                string strCommand = "CreateOrder";
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add(new SqlParameter("OrderTime", SqlDbType.DateTime));
                myCommand.Parameters["OrderTime"].Value = DateTime.Parse(this.dtpOrderDate.Value.ToString());
                myCommand.Parameters.Add(new SqlParameter("CustomerID", SqlDbType.Int));
                myCommand.Parameters["CustomerID"].Value = int.Parse(this.cbbCustomer.SelectedValue.ToString());
                myCommand.Parameters.Add(new SqlParameter("EmployeeID", SqlDbType.Int));
                myCommand.Parameters["EmployeeID"].Value = int.Parse(this.cbbEmployee.SelectedValue.ToString());
                myCommand.Parameters.Add(new SqlParameter("OrderID", SqlDbType.Int));
                myCommand.Parameters["OrderID"].Direction = ParameterDirection.Output;
                int row_effectd = myCommand.ExecuteNonQuery();
                if (row_effectd > 0)
                {
                    MessageBox.Show("Created " + row_effectd.ToString() + " Order with ID is " + myCommand.Parameters["OrderID"].Value.ToString() + ". Please add tickets to the order.");
                    txtOrderID.Text = myCommand.Parameters["OrderID"].Value.ToString();
                }
            }
        }

        private void cbbConcert_DropDown(object sender, EventArgs e)
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

        private void cbbCategory_DropDown(object sender, EventArgs e)
        {
            try
            {
                string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
                using (SqlConnection myConnection = new SqlConnection(strConnect))
                {
                    myConnection.Open();
                    string strCommand = "Select Ticket.CategoryID, TicketCategory.CategoryName" +
                        " from Ticket join TicketCategory" +
                        " on Ticket.CategoryID = TicketCategory.CategoryID" +
                        " where Ticket.ConcertID = @ConcertID";
                    SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                    myCommand.CommandType = CommandType.Text;
                    myCommand.Parameters.Add(new SqlParameter("ConcertID", SqlDbType.Int));
                    myCommand.Parameters["ConcertID"].Value = int.Parse(this.cbbConcert.SelectedValue.ToString());
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

        private void ClearTicket()
        {
            txtTicketID.Text = string.Empty;
            txtRemainingTickets.Text = string.Empty;
            cbbCategory.SelectedIndex = -1;
            txtPrice.Text = string.Empty;
            nudQuantity.Value = 1;
            txtArtist.Text = string.Empty;
            txtVenue.Text = string.Empty;
            txtConcertDate.Text = string.Empty;
        }


        private void cbbConcert_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearTicket();
            try
            {
                if (!string.IsNullOrEmpty(cbbConcert.Text) && cbbConcert.SelectedValue.GetType() == typeof(int))
                {
                    string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
                    using (SqlConnection myConnection = new SqlConnection(strConnect))
                    {
                        myConnection.Open();
                        string strCommand = "SELECT Concert.ConcertID, Concert.ConcertName, Concert.ConcertDate, " +
                                            "Venue.VenueName, Artist.ArtistName " +
                                            "FROM Concert " +
                                            "JOIN Venue ON Concert.VenueID = Venue.VenueID " +
                                            "JOIN Artist ON Concert.ArtistID = Artist.ArtistID " +
                                            "WHERE Concert.ConcertID = @ConcertID";

                        SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                        myCommand.CommandType = CommandType.Text;
                        myCommand.Parameters.Add(new SqlParameter("@ConcertID", SqlDbType.Int));
                        myCommand.Parameters["@ConcertID"].Value = int.Parse(this.cbbConcert.SelectedValue.ToString());

                        SqlDataAdapter da = new SqlDataAdapter(myCommand);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "Concert");

                        if (ds.Tables["Concert"].Rows.Count > 0)
                        {
                            DataRow concertRow = ds.Tables["Concert"].Rows[0];
                            txtVenue.Text = concertRow["VenueName"].ToString();
                            txtArtist.Text = concertRow["ArtistName"].ToString();
                            // Format the date as needed, e.g., assuming ConcertDate is of type DateTime
                            DateTime concertDate = (DateTime)concertRow["ConcertDate"];
                            txtConcertDate.Text = concertDate.ToString("dd/MM/yyyy h:mm tt");
                            // You may want to update other controls with concert information.
                        }
                        else
                        {
                            // Handle the case where no data is found for the given ConcertID.
                            // For example, clear the text boxes or show a message.
                            txtVenue.Text = "";
                            txtArtist.Text = "";
                            txtConcertDate.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred1! " + ex.Message);
            }
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cbbCategory.Text) && cbbCategory.SelectedValue.GetType() == typeof(int))
                {
                    string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
                    using (SqlConnection myConnection = new SqlConnection(strConnect))
                    {
                        myConnection.Open();
                        string strCommand = "Select * from Ticket" +
                            " where ConcertID = @ConcertID" +
                            " and CategoryID = @CategoryID";
                        SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                        myCommand.CommandType = CommandType.Text;
                        myCommand.Parameters.Add(new SqlParameter("ConcertID", SqlDbType.Int));
                        myCommand.Parameters["ConcertID"].Value = int.Parse(this.cbbConcert.SelectedValue.ToString());
                        myCommand.Parameters.Add(new SqlParameter("CategoryID", SqlDbType.Int));
                        myCommand.Parameters["CategoryID"].Value = int.Parse(this.cbbCategory.SelectedValue.ToString());
                        SqlDataAdapter da = new SqlDataAdapter(myCommand);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "Ticket");
                        if (ds.Tables["Ticket"].Rows.Count > 0)
                        {
                            txtTicketID.Text = ds.Tables["Ticket"].Rows[0]["TicketID"].ToString();
                            txtRemainingTickets.Text = ds.Tables["Ticket"].Rows[0]["RemainingTickets"].ToString();
                            txtPrice.Text = ds.Tables["Ticket"].Rows[0]["Price"].ToString();
                            nudQuantity.Maximum = int.Parse(txtRemainingTickets.Text);
                        }
                    }
                }
            }
                        catch (Exception ex)
            {
                MessageBox.Show("An error occurred1! " + ex.Message);
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrderDetail();
            GetOrderDetail();
            UpdateTotalCost();
            Clear();
        }

        private void GetOrderDetail()
        {
            try
            {
                string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
                using (SqlConnection myConnection = new SqlConnection(strConnect))
                {
                    myConnection.Open();
                    string strCommand = "GetOrderDetail";
                    SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.Add(new SqlParameter("OrderID", SqlDbType.Int));
                    myCommand.Parameters["OrderID"].Value = int.Parse(this.txtOrderID.Text);
                    SqlDataAdapter da = new SqlDataAdapter(myCommand);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "OrderDetail");
                    dgvOrderDetail.DataSource = ds.Tables["OrderDetail"];
                    int count = ds.Tables["OrderDetail"].Rows.Count;
                    lblRecords.Text = "Records: " + count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred! " + ex.Message);
            }

        }

        private void UpdateTotalCost()
        {
            try
            {
                string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
                using (SqlConnection myConnection = new SqlConnection(strConnect))
                {
                    myConnection.Open();
                    string strCommand = "Select * from [Order] where OrderID = @OrderID";
                    SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                    myCommand.CommandType = CommandType.Text;
                    myCommand.Parameters.Add(new SqlParameter("OrderID", SqlDbType.Int));
                    myCommand.Parameters["OrderID"].Value = int.Parse(this.txtOrderID.Text);
                    SqlDataAdapter da = new SqlDataAdapter(myCommand);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "TotalCost");
                    txtTotalCost.Text = ds.Tables["TotalCost"].Rows[0]["Total"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred! " + ex.Message);
            }

        }

    private void AddOrderDetail()
        {
            try
            {
                string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
                using (SqlConnection myConnection = new SqlConnection(strConnect))
                {
                    myConnection.Open();
                    string strCommand = "AddOrderDetail";
                    SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.Add(new SqlParameter("OrderID", SqlDbType.Int));
                    myCommand.Parameters["OrderID"].Value = int.Parse(this.txtOrderID.Text);
                    myCommand.Parameters.Add(new SqlParameter("TicketID", SqlDbType.Int));
                    myCommand.Parameters["TicketID"].Value = int.Parse(this.txtTicketID.Text);
                    myCommand.Parameters.Add(new SqlParameter("Quantity", SqlDbType.Int));
                    myCommand.Parameters["Quantity"].Value = int.Parse(this.nudQuantity.Text);
                    int row_effectd = myCommand.ExecuteNonQuery();
                    if (row_effectd > 0)
                    {
                        MessageBox.Show("Ticket added to the order successfully.");
                    }
                    else
                    {
                        MessageBox.Show("This ticket is already in the order");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred! " + ex.Message);
            }

}

private void dgvOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dgvOrderDetail.Rows[e.RowIndex];
                    GetCurrentRow(dr);
                }
            }
            catch
            {
            }

        }

        private void dgvOrderDetail_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dgvOrderDetail.Rows[e.RowIndex];
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

            if (dr.Cells["RemainingTickets"].Value != null)
            {
                txtRemainingTickets.Text = dr.Cells["RemainingTickets"].Value.ToString();
            }
            else
            {
                txtRemainingTickets.Text = string.Empty;
            }
            if (dr.Cells["ConcertName"].Value != null)
            {
                cbbConcert.Text = dr.Cells["ConcertName"].Value.ToString();
            }
            else
            {
                cbbConcert.SelectedIndex = -1;
            }
            if (dr.Cells["CategoryName"].Value != null)
            {
                cbbCategory.Text = dr.Cells["CategoryName"].Value.ToString();
            }
            else
            {
                cbbCategory.SelectedIndex = -1;
            }
            if (dr.Cells["Quantity"].Value != null)
            {
                nudQuantity.Text = dr.Cells["Quantity"].Value.ToString();
            }
            else
            {
                nudQuantity.Text = string.Empty;
            }
            if (dr.Cells["Price"].Value != null)
            {
                txtPrice.Text = dr.Cells["Price"].Value.ToString();
            }
            else
            {
                txtPrice.Text = string.Empty;
            }
            cbbCategory.Enabled = false;
            cbbConcert.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTicketID.Text))
            {
                MessageBox.Show("Please select a record to update. You must choose an existing record to update.", "Record Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
            }
            UpdateOrderDetail();
            GetOrderDetail();
            UpdateTotalCost();
            Clear(); 
        }

        private void Clear()
        {
            cbbConcert.SelectedIndex = -1;
            cbbConcert.Enabled = true;
            cbbCategory.Enabled = true;
        }

        private void UpdateOrderDetail()
        {
            try
            {
                string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
                using (SqlConnection myConnection = new SqlConnection(strConnect))
                {
                    myConnection.Open();
                    string strCommand = "UpdateOrderDetail";
                    SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.Add(new SqlParameter("OrderID", SqlDbType.Int));
                    myCommand.Parameters["OrderID"].Value = int.Parse(this.txtOrderID.Text);
                    myCommand.Parameters.Add(new SqlParameter("TicketID", SqlDbType.Int));
                    myCommand.Parameters["TicketID"].Value = int.Parse(this.txtTicketID.Text);
                    myCommand.Parameters.Add(new SqlParameter("Quantity", SqlDbType.Int));
                    myCommand.Parameters["Quantity"].Value = int.Parse(this.nudQuantity.Text);
                    int row_effectd = myCommand.ExecuteNonQuery();
                    if (row_effectd > 0)
                    {
                        MessageBox.Show("Ticket updated to the order successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred! " + ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteOrderDetail();
            GetOrderDetail();
            UpdateTotalCost();
            Clear();
        }

        private void DeleteOrderDetail()
        {
            try
            {
                string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
                using (SqlConnection myConnection = new SqlConnection(strConnect))
                {
                    myConnection.Open();
                    string strCommand = "DeleteOrderDetail";
                    SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.Add(new SqlParameter("OrderID", SqlDbType.Int));
                    myCommand.Parameters["OrderID"].Value = int.Parse(this.txtOrderID.Text);
                    myCommand.Parameters.Add(new SqlParameter("TicketID", SqlDbType.Int));
                    myCommand.Parameters["TicketID"].Value = int.Parse(this.txtTicketID.Text);
                    int row_effectd = myCommand.ExecuteNonQuery();
                    if (row_effectd > 0)
                    {
                        MessageBox.Show("Ticket deleted to the order successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred! " + ex.Message);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Clear();
            dgvOrderDetail.DataSource = nameof(dgvOrderDetail);
            DisabledTiket();
            txtCustomerPhone.Enabled = true;
            cbbEmployee.Enabled = true;
            txtTotalCost.Text = string.Empty;
            txtCustomerPhone.Text = string.Empty;
            cbbEmployee.SelectedIndex = -1;
            btnCreate.Enabled = true;
            lblRecords.Text = "Records:";
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer objf = new AddCustomer();
            objf.ShowDialog();
        }
    }
}
