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
    public partial class frmOrder : UserControl
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewOrder objfNewOrder = new frmNewOrder();
            objfNewOrder.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmOrderDetail objfOrderDetail = new frmOrderDetail();
            objfOrderDetail.ShowDialog();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
            using (SqlConnection myConnection = new SqlConnection(strConnect))
            {
                myConnection.Open();
                string strCommand = "Select * from v_Order_full";
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);
                DataSet ds = new DataSet();
                da.Fill(ds, "Order");
                int count = ds.Tables["Order"].Rows.Count;
                lblRecords.Text = "Records: " + count.ToString();
                dgvOrderList.DataSource = ds.Tables["Order"];
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
            GetData();
        }

        private void DeleteData()
        {
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();

            using (SqlConnection myConnection = new SqlConnection(strConnect))
            {
                myConnection.Open();

                // Kiểm tra xem có dòng nào được chọn trong DataGridView không
                if (dgvOrderList.SelectedRows.Count > 0)
                {
                    // Lấy giá trị OrderID từ cột OrderID của dòng hiện tại
                    int orderIDToDelete = Convert.ToInt32(dgvOrderList.SelectedRows[0].Cells["OrderID"].Value);
                    DialogResult result = MessageBox.Show("Are you sure you want to delete Order with ID " + orderIDToDelete.ToString() + "?", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        string strCommand = "DeleteOrder";
                        SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                        myCommand.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số OrderID và gán giá trị từ dòng hiện tại
                        myCommand.Parameters.Add(new SqlParameter("@OrderID", SqlDbType.Int));
                        myCommand.Parameters["@OrderID"].Value = orderIDToDelete;

                        int row_effectd = myCommand.ExecuteNonQuery();
                        if (row_effectd > 0)
                        {
                            MessageBox.Show("Deleted Order with ID is " + orderIDToDelete.ToString());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.");
                }
            }
        }
    }
}
