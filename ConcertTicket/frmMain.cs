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
    public partial class frmMain : Form
    {
        frmArtist objfArtist = new frmArtist();
        frmEmployee objfEmployee = new frmEmployee();
        frmTicketCategory objfTicketCategory = new frmTicketCategory();
        frmVenue objfVenue = new frmVenue();
        frmCustomer objfCustomer = new frmCustomer();
        frmConcert objfConcert = new frmConcert();
        frmTicket objfTicket = new frmTicket();
        frmOrder objfOrder = new frmOrder();
        public frmMain(int EmployeeID)
        {
            InitializeComponent();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            objfArtist.Dock = DockStyle.Fill;
            pnlmain.Controls.Add(objfArtist);
            objfEmployee.Dock = DockStyle.Fill;
            pnlmain.Controls.Add(objfEmployee);
            objfTicketCategory.Dock = DockStyle.Fill;
            pnlmain.Controls.Add(objfTicketCategory);
            objfVenue.Dock = DockStyle.Fill;
            pnlmain.Controls.Add(objfVenue);
            objfCustomer.Dock = DockStyle.Fill;
            pnlmain.Controls.Add(objfCustomer);
            objfConcert.Dock = DockStyle.Fill;
            pnlmain.Controls.Add(objfConcert);
            objfTicket.Dock = DockStyle.Fill;
            pnlmain.Controls.Add(objfTicket);
            objfOrder.Dock = DockStyle.Fill;
            pnlmain.Controls.Add(objfOrder);
        }

        private void btnArtist_Click(object sender, EventArgs e)
        {
            pnlmove.Location = btnArtist.Location;
            objfArtist.Visible = true;
            objfEmployee.Visible = false;
            objfTicketCategory.Visible = false;
            objfVenue.Visible = false;
            objfCustomer.Visible = false;
            objfConcert.Visible = false;
            objfTicket.Visible = false;
            objfOrder.Visible = false;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            pnlmove.Location = btnEmployee.Location;
            objfEmployee.Visible = true;
            objfArtist.Visible = false;
            objfTicketCategory.Visible = false;
            objfVenue.Visible = false;
            objfCustomer.Visible = false;
            objfConcert.Visible = false;
            objfTicket.Visible = false;
            objfOrder.Visible = false;
        }

        private void btnTicketCategory_Click(object sender, EventArgs e)
        {
            pnlmove.Location = btnTicketCategory.Location;
            objfTicketCategory.Visible = true;
            objfArtist.Visible = false;
            objfEmployee.Visible = false;
            objfVenue.Visible = false;
            objfCustomer.Visible = false;
            objfConcert.Visible = false;
            objfTicket.Visible = false;
        }

        private void btnVenue_Click(object sender, EventArgs e)
        {
            pnlmove.Location = btnVenue.Location;
            objfVenue.Visible = true;
            objfTicketCategory.Visible = false;
            objfArtist.Visible = false;
            objfEmployee.Visible = false;
            objfCustomer.Visible = false;
            objfConcert.Visible = false;
            objfTicket.Visible = false;
            objfOrder.Visible = false;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            pnlmove.Location = btnCustomer.Location;
            objfCustomer.Visible = true;
            objfVenue.Visible = false;
            objfTicketCategory.Visible = false;
            objfArtist.Visible = false;
            objfEmployee.Visible = false;
            objfConcert.Visible = false;
            objfTicket.Visible = false;
            objfOrder.Visible = false;
        }

        private void btnConcert_Click(object sender, EventArgs e)
        {
            pnlmove.Location = btnConcert.Location;
            objfConcert.Visible = true;
            objfCustomer.Visible = false;
            objfVenue.Visible = false;
            objfTicketCategory.Visible = false;
            objfArtist.Visible = false;
            objfEmployee.Visible = false;
            objfTicket.Visible = false;
            objfOrder.Visible = false;
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            pnlmove.Location = btnTicket.Location;
            objfTicket.Visible = true;
            objfConcert.Visible = false;
            objfCustomer.Visible = false;
            objfVenue.Visible = false;
            objfTicketCategory.Visible = false;
            objfArtist.Visible = false;
            objfEmployee.Visible = false;
            objfOrder.Visible = false;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            pnlmove.Location = btnOrder.Location;
            objfOrder.Visible = true;
            objfTicket.Visible = false;
            objfConcert.Visible = false;
            objfCustomer.Visible = false;
            objfVenue.Visible = false;
            objfTicketCategory.Visible = false;
            objfArtist.Visible = false;
            objfEmployee.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
