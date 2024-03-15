namespace ConcertTicket
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlmenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlmove = new System.Windows.Forms.Panel();
            this.btnVenue = new System.Windows.Forms.Button();
            this.btnTicketCategory = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnConcert = new System.Windows.Forms.Button();
            this.btnArtist = new System.Windows.Forms.Button();
            this.pnlreport = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlmain = new System.Windows.Forms.Panel();
            this.pnlmenu.SuspendLayout();
            this.pnlreport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlmenu
            // 
            this.pnlmenu.BackColor = System.Drawing.Color.Black;
            this.pnlmenu.Controls.Add(this.btnLogout);
            this.pnlmenu.Controls.Add(this.pnlmove);
            this.pnlmenu.Controls.Add(this.btnVenue);
            this.pnlmenu.Controls.Add(this.btnTicketCategory);
            this.pnlmenu.Controls.Add(this.btnTicket);
            this.pnlmenu.Controls.Add(this.btnOrder);
            this.pnlmenu.Controls.Add(this.btnEmployee);
            this.pnlmenu.Controls.Add(this.btnCustomer);
            this.pnlmenu.Controls.Add(this.btnConcert);
            this.pnlmenu.Controls.Add(this.btnArtist);
            this.pnlmenu.Controls.Add(this.pnlreport);
            this.pnlmenu.Controls.Add(this.pictureBox1);
            this.pnlmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlmenu.Location = new System.Drawing.Point(0, 0);
            this.pnlmenu.Name = "pnlmenu";
            this.pnlmenu.Size = new System.Drawing.Size(200, 720);
            this.pnlmenu.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Pink;
            this.btnLogout.Location = new System.Drawing.Point(0, 674);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 40);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlmove
            // 
            this.pnlmove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlmove.BackColor = System.Drawing.Color.LightPink;
            this.pnlmove.Location = new System.Drawing.Point(0, 202);
            this.pnlmove.Name = "pnlmove";
            this.pnlmove.Size = new System.Drawing.Size(8, 40);
            this.pnlmove.TabIndex = 2;
            // 
            // btnVenue
            // 
            this.btnVenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVenue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVenue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenue.ForeColor = System.Drawing.Color.LightPink;
            this.btnVenue.Location = new System.Drawing.Point(0, 503);
            this.btnVenue.Name = "btnVenue";
            this.btnVenue.Size = new System.Drawing.Size(200, 40);
            this.btnVenue.TabIndex = 8;
            this.btnVenue.Text = "Venue";
            this.btnVenue.UseVisualStyleBackColor = true;
            this.btnVenue.Click += new System.EventHandler(this.btnVenue_Click);
            // 
            // btnTicketCategory
            // 
            this.btnTicketCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTicketCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTicketCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicketCategory.ForeColor = System.Drawing.Color.LightPink;
            this.btnTicketCategory.Location = new System.Drawing.Point(0, 460);
            this.btnTicketCategory.Name = "btnTicketCategory";
            this.btnTicketCategory.Size = new System.Drawing.Size(200, 40);
            this.btnTicketCategory.TabIndex = 7;
            this.btnTicketCategory.Text = "Ticket Category";
            this.btnTicketCategory.UseVisualStyleBackColor = true;
            this.btnTicketCategory.Click += new System.EventHandler(this.btnTicketCategory_Click);
            // 
            // btnTicket
            // 
            this.btnTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTicket.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket.ForeColor = System.Drawing.Color.LightPink;
            this.btnTicket.Location = new System.Drawing.Point(0, 417);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(200, 40);
            this.btnTicket.TabIndex = 6;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.LightPink;
            this.btnOrder.Location = new System.Drawing.Point(0, 374);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(200, 40);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.LightPink;
            this.btnEmployee.Location = new System.Drawing.Point(0, 331);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(200, 40);
            this.btnEmployee.TabIndex = 4;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.LightPink;
            this.btnCustomer.Location = new System.Drawing.Point(0, 288);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(200, 40);
            this.btnCustomer.TabIndex = 3;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnConcert
            // 
            this.btnConcert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConcert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConcert.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcert.ForeColor = System.Drawing.Color.LightPink;
            this.btnConcert.Location = new System.Drawing.Point(0, 245);
            this.btnConcert.Name = "btnConcert";
            this.btnConcert.Size = new System.Drawing.Size(200, 40);
            this.btnConcert.TabIndex = 2;
            this.btnConcert.Text = "Concert";
            this.btnConcert.UseVisualStyleBackColor = true;
            this.btnConcert.Click += new System.EventHandler(this.btnConcert_Click);
            // 
            // btnArtist
            // 
            this.btnArtist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArtist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArtist.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtist.ForeColor = System.Drawing.Color.LightPink;
            this.btnArtist.Location = new System.Drawing.Point(0, 202);
            this.btnArtist.Name = "btnArtist";
            this.btnArtist.Size = new System.Drawing.Size(200, 40);
            this.btnArtist.TabIndex = 1;
            this.btnArtist.Text = "Artist";
            this.btnArtist.UseVisualStyleBackColor = true;
            this.btnArtist.Click += new System.EventHandler(this.btnArtist_Click);
            // 
            // pnlreport
            // 
            this.pnlreport.Controls.Add(this.btnReport);
            this.pnlreport.Location = new System.Drawing.Point(0, 546);
            this.pnlreport.Name = "pnlreport";
            this.pnlreport.Size = new System.Drawing.Size(200, 122);
            this.pnlreport.TabIndex = 9;
            // 
            // btnReport
            // 
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.LightPink;
            this.btnReport.Location = new System.Drawing.Point(0, 0);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(200, 40);
            this.btnReport.TabIndex = 9;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::ConcertTicket.Properties.Resources.Black_White_Elegant_Play_Piano_Music_Studio_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this;
            // 
            // pnlmain
            // 
            this.pnlmain.Location = new System.Drawing.Point(204, 12);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(1064, 696);
            this.pnlmain.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlmain);
            this.Controls.Add(this.pnlmenu);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlmenu.ResumeLayout(false);
            this.pnlreport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlmenu;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnVenue;
        private System.Windows.Forms.Button btnTicketCategory;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel pnlreport;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnArtist;
        private System.Windows.Forms.Button btnConcert;
        private System.Windows.Forms.Panel pnlmove;
        private System.Windows.Forms.Panel pnlmain;
    }
}