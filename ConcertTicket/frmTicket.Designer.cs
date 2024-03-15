namespace ConcertTicket
{
    partial class frmTicket
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTicketID = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRemainingTickets = new System.Windows.Forms.Label();
            this.txtRemainingTickets = new System.Windows.Forms.TextBox();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.txtTicketID = new System.Windows.Forms.TextBox();
            this.cbbConcert = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblConcert = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTicket = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.bunifuElipse7 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.bunifuElipse8 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgvTicketList = new System.Windows.Forms.DataGridView();
            this.bunifuElipse9 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cbbCategorySearch = new System.Windows.Forms.ComboBox();
            this.bunifuElipse10 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cbbConcertSearch = new System.Windows.Forms.ComboBox();
            this.bunifuElipse11 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse12 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse13 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse14 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse15 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse16 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.bunifuElipse17 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse18 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.bunifuElipse19 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.lblCateogrySearch = new System.Windows.Forms.Label();
            this.lblConcertSearch = new System.Windows.Forms.Label();
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblTicketList = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketList)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.LightPink;
            this.btnClear.Location = new System.Drawing.Point(200, 82);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 40);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTicketID
            // 
            this.lblTicketID.AutoSize = true;
            this.lblTicketID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketID.Location = new System.Drawing.Point(17, 67);
            this.lblTicketID.Margin = new System.Windows.Forms.Padding(0);
            this.lblTicketID.Name = "lblTicketID";
            this.lblTicketID.Size = new System.Drawing.Size(70, 20);
            this.lblTicketID.TabIndex = 18;
            this.lblTicketID.Text = "TicketID: ";
            this.lblTicketID.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(21, 157);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(319, 24);
            this.txtPrice.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.Controls.Add(this.lblRemainingTickets);
            this.panel1.Controls.Add(this.txtRemainingTickets);
            this.panel1.Controls.Add(this.cbbCategory);
            this.panel1.Controls.Add(this.txtTicketID);
            this.panel1.Controls.Add(this.cbbConcert);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.lblConcert);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblTicket);
            this.panel1.Controls.Add(this.lblTicketID);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Location = new System.Drawing.Point(23, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 471);
            this.panel1.TabIndex = 1;
            // 
            // lblRemainingTickets
            // 
            this.lblRemainingTickets.AutoSize = true;
            this.lblRemainingTickets.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingTickets.Location = new System.Drawing.Point(17, 194);
            this.lblRemainingTickets.Margin = new System.Windows.Forms.Padding(0);
            this.lblRemainingTickets.Name = "lblRemainingTickets";
            this.lblRemainingTickets.Size = new System.Drawing.Size(128, 20);
            this.lblRemainingTickets.TabIndex = 31;
            this.lblRemainingTickets.Text = "RemainingTickets:";
            this.lblRemainingTickets.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtRemainingTickets
            // 
            this.txtRemainingTickets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRemainingTickets.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemainingTickets.Location = new System.Drawing.Point(21, 217);
            this.txtRemainingTickets.Name = "txtRemainingTickets";
            this.txtRemainingTickets.Size = new System.Drawing.Size(319, 24);
            this.txtRemainingTickets.TabIndex = 4;
            // 
            // cbbCategory
            // 
            this.cbbCategory.DropDownHeight = 100;
            this.cbbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbCategory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.IntegralHeight = false;
            this.cbbCategory.ItemHeight = 23;
            this.cbbCategory.Location = new System.Drawing.Point(21, 347);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(319, 31);
            this.cbbCategory.TabIndex = 6;
            // 
            // txtTicketID
            // 
            this.txtTicketID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTicketID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketID.Location = new System.Drawing.Point(21, 90);
            this.txtTicketID.Name = "txtTicketID";
            this.txtTicketID.Size = new System.Drawing.Size(319, 24);
            this.txtTicketID.TabIndex = 1;
            // 
            // cbbConcert
            // 
            this.cbbConcert.DropDownHeight = 100;
            this.cbbConcert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbConcert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbConcert.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbConcert.FormattingEnabled = true;
            this.cbbConcert.IntegralHeight = false;
            this.cbbConcert.ItemHeight = 23;
            this.cbbConcert.Location = new System.Drawing.Point(21, 282);
            this.cbbConcert.Name = "cbbConcert";
            this.cbbConcert.Size = new System.Drawing.Size(319, 31);
            this.cbbConcert.TabIndex = 5;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(17, 324);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(76, 20);
            this.lblCategory.TabIndex = 23;
            this.lblCategory.Text = "Category: ";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblConcert
            // 
            this.lblConcert.AutoSize = true;
            this.lblConcert.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcert.Location = new System.Drawing.Point(17, 259);
            this.lblConcert.Margin = new System.Windows.Forms.Padding(0);
            this.lblConcert.Name = "lblConcert";
            this.lblConcert.Size = new System.Drawing.Size(63, 20);
            this.lblConcert.TabIndex = 22;
            this.lblConcert.Text = "Concert:";
            this.lblConcert.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(17, 134);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 21;
            this.lblPrice.Text = "Price:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Font = new System.Drawing.Font("Carattere", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicket.Location = new System.Drawing.Point(2, 2);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(71, 39);
            this.lblTicket.TabIndex = 19;
            this.lblTicket.Text = "Ticket";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.panel1;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 8;
            this.bunifuElipse3.TargetControl = this.txtSearch;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(263, 67);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(237, 24);
            this.txtSearch.TabIndex = 13;
            // 
            // bunifuElipse7
            // 
            this.bunifuElipse7.ElipseRadius = 8;
            this.bunifuElipse7.TargetControl = this.btnSearch;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.LightPink;
            this.btnSearch.Location = new System.Drawing.Point(506, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 32);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // bunifuElipse8
            // 
            this.bunifuElipse8.ElipseRadius = 8;
            this.bunifuElipse8.TargetControl = this.dgvTicketList;
            // 
            // dgvTicketList
            // 
            this.dgvTicketList.BackgroundColor = System.Drawing.Color.White;
            this.dgvTicketList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTicketList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicketList.Location = new System.Drawing.Point(14, 73);
            this.dgvTicketList.Name = "dgvTicketList";
            this.dgvTicketList.RowHeadersWidth = 51;
            this.dgvTicketList.RowTemplate.Height = 24;
            this.dgvTicketList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTicketList.Size = new System.Drawing.Size(604, 382);
            this.dgvTicketList.TabIndex = 15;
            this.dgvTicketList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTicketList_CellClick);
            this.dgvTicketList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTicketList_RowEnter);
            // 
            // bunifuElipse9
            // 
            this.bunifuElipse9.ElipseRadius = 8;
            this.bunifuElipse9.TargetControl = this.cbbCategorySearch;
            // 
            // cbbCategorySearch
            // 
            this.cbbCategorySearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbCategorySearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCategorySearch.FormattingEnabled = true;
            this.cbbCategorySearch.ItemHeight = 20;
            this.cbbCategorySearch.Location = new System.Drawing.Point(108, 65);
            this.cbbCategorySearch.Name = "cbbCategorySearch";
            this.cbbCategorySearch.Size = new System.Drawing.Size(149, 28);
            this.cbbCategorySearch.TabIndex = 12;
            // 
            // bunifuElipse10
            // 
            this.bunifuElipse10.ElipseRadius = 8;
            this.bunifuElipse10.TargetControl = this.cbbConcertSearch;
            // 
            // cbbConcertSearch
            // 
            this.cbbConcertSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbConcertSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbConcertSearch.FormattingEnabled = true;
            this.cbbConcertSearch.ItemHeight = 20;
            this.cbbConcertSearch.Location = new System.Drawing.Point(108, 27);
            this.cbbConcertSearch.Name = "cbbConcertSearch";
            this.cbbConcertSearch.Size = new System.Drawing.Size(392, 28);
            this.cbbConcertSearch.TabIndex = 11;
            // 
            // bunifuElipse11
            // 
            this.bunifuElipse11.ElipseRadius = 4;
            this.bunifuElipse11.TargetControl = this.txtTicketID;
            // 
            // bunifuElipse12
            // 
            this.bunifuElipse12.ElipseRadius = 30;
            this.bunifuElipse12.TargetControl = this;
            // 
            // bunifuElipse13
            // 
            this.bunifuElipse13.ElipseRadius = 4;
            this.bunifuElipse13.TargetControl = this.txtPrice;
            // 
            // bunifuElipse14
            // 
            this.bunifuElipse14.ElipseRadius = 4;
            this.bunifuElipse14.TargetControl = this.cbbCategory;
            // 
            // bunifuElipse15
            // 
            this.bunifuElipse15.ElipseRadius = 4;
            this.bunifuElipse15.TargetControl = this.cbbConcert;
            // 
            // bunifuElipse16
            // 
            this.bunifuElipse16.ElipseRadius = 8;
            this.bunifuElipse16.TargetControl = this.btnAdd;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.LightPink;
            this.btnAdd.Location = new System.Drawing.Point(36, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 40);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bunifuElipse17
            // 
            this.bunifuElipse17.ElipseRadius = 8;
            this.bunifuElipse17.TargetControl = this.btnClear;
            // 
            // bunifuElipse18
            // 
            this.bunifuElipse18.ElipseRadius = 8;
            this.bunifuElipse18.TargetControl = this.btnDelete;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.LightPink;
            this.btnDelete.Location = new System.Drawing.Point(36, 82);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 40);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bunifuElipse19
            // 
            this.bunifuElipse19.ElipseRadius = 8;
            this.bunifuElipse19.TargetControl = this.btnUpdate;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.LightPink;
            this.btnUpdate.Location = new System.Drawing.Point(200, 22);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 40);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 20;
            this.bunifuElipse4.TargetControl = this.panel2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightPink;
            this.panel2.Controls.Add(this.lblSearchFor);
            this.panel2.Controls.Add(this.cbbCategorySearch);
            this.panel2.Controls.Add(this.cbbConcertSearch);
            this.panel2.Controls.Add(this.lblCateogrySearch);
            this.panel2.Controls.Add(this.lblConcertSearch);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Location = new System.Drawing.Point(407, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 114);
            this.panel2.TabIndex = 3;
            // 
            // lblSearchFor
            // 
            this.lblSearchFor.AutoSize = true;
            this.lblSearchFor.BackColor = System.Drawing.Color.White;
            this.lblSearchFor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblSearchFor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchFor.ForeColor = System.Drawing.Color.Gray;
            this.lblSearchFor.Location = new System.Drawing.Point(266, 70);
            this.lblSearchFor.Name = "lblSearchFor";
            this.lblSearchFor.Size = new System.Drawing.Size(197, 17);
            this.lblSearchFor.TabIndex = 32;
            this.lblSearchFor.Text = "Search for Price/RemainingTickets";
            this.lblSearchFor.Click += new System.EventHandler(this.lblSearchFor_Click);
            // 
            // lblCateogrySearch
            // 
            this.lblCateogrySearch.AutoSize = true;
            this.lblCateogrySearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCateogrySearch.Location = new System.Drawing.Point(29, 71);
            this.lblCateogrySearch.Margin = new System.Windows.Forms.Padding(0);
            this.lblCateogrySearch.Name = "lblCateogrySearch";
            this.lblCateogrySearch.Size = new System.Drawing.Size(76, 20);
            this.lblCateogrySearch.TabIndex = 31;
            this.lblCateogrySearch.Text = "Category: ";
            this.lblCateogrySearch.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblConcertSearch
            // 
            this.lblConcertSearch.AutoSize = true;
            this.lblConcertSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcertSearch.Location = new System.Drawing.Point(29, 30);
            this.lblConcertSearch.Margin = new System.Windows.Forms.Padding(0);
            this.lblConcertSearch.Name = "lblConcertSearch";
            this.lblConcertSearch.Size = new System.Drawing.Size(63, 20);
            this.lblConcertSearch.TabIndex = 30;
            this.lblConcertSearch.Text = "Concert:";
            this.lblConcertSearch.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 20;
            this.bunifuElipse5.TargetControl = this.panel4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightPink;
            this.panel4.Controls.Add(this.lblRecords);
            this.panel4.Controls.Add(this.dgvTicketList);
            this.panel4.Controls.Add(this.lblTicketList);
            this.panel4.Location = new System.Drawing.Point(407, 172);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(635, 498);
            this.panel4.TabIndex = 4;
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(10, 461);
            this.lblRecords.Margin = new System.Windows.Forms.Padding(0);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(70, 20);
            this.lblRecords.TabIndex = 26;
            this.lblRecords.Text = "Records: ";
            this.lblRecords.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTicketList
            // 
            this.lblTicketList.AutoSize = true;
            this.lblTicketList.Font = new System.Drawing.Font("Carattere", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketList.Location = new System.Drawing.Point(3, 4);
            this.lblTicketList.Name = "lblTicketList";
            this.lblTicketList.Size = new System.Drawing.Size(115, 39);
            this.lblTicketList.TabIndex = 20;
            this.lblTicketList.Text = "Ticket List";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightPink;
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Location = new System.Drawing.Point(23, 528);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 142);
            this.panel3.TabIndex = 2;
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 20;
            this.bunifuElipse6.TargetControl = this.panel3;
            // 
            // frmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "frmTicket";
            this.Size = new System.Drawing.Size(1064, 696);
            this.Load += new System.EventHandler(this.frmTicket_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTicketID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.TextBox txtTicketID;
        private System.Windows.Forms.ComboBox cbbConcert;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblConcert;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTicket;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbConcertSearch;
        private System.Windows.Forms.Label lblConcertSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridView dgvTicketList;
        private System.Windows.Forms.Label lblTicketList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse7;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse8;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse9;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse10;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse11;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse12;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse13;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse14;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse15;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse16;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse17;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse18;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse19;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private System.Windows.Forms.Label lblRemainingTickets;
        private System.Windows.Forms.TextBox txtRemainingTickets;
        private System.Windows.Forms.ComboBox cbbCategorySearch;
        private System.Windows.Forms.Label lblCateogrySearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchFor;
    }
}
