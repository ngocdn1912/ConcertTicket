using System;

namespace ConcertTicket
{
    partial class frmConcert
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
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.cbbArtistSearch = new System.Windows.Forms.ComboBox();
            this.cbbVenueSearch = new System.Windows.Forms.ComboBox();
            this.lblArtistSearch = new System.Windows.Forms.Label();
            this.lblVenueSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtConcertID = new System.Windows.Forms.TextBox();
            this.cbbVenue = new System.Windows.Forms.ComboBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblVenue = new System.Windows.Forms.Label();
            this.lblConcertDate = new System.Windows.Forms.Label();
            this.lblConcertName = new System.Windows.Forms.Label();
            this.lblConcert = new System.Windows.Forms.Label();
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblRecords = new System.Windows.Forms.Label();
            this.dgvConcertList = new System.Windows.Forms.DataGridView();
            this.lblConcertList = new System.Windows.Forms.Label();
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblConcertID = new System.Windows.Forms.Label();
            this.txtConcertName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpConcertDate = new System.Windows.Forms.DateTimePicker();
            this.cbbArtist = new System.Windows.Forms.ComboBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse7 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse8 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse9 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse10 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse11 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse12 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse14 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse15 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse16 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse17 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse18 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse19 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse20 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConcertList)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel2.Controls.Add(this.cbbArtistSearch);
            this.panel2.Controls.Add(this.cbbVenueSearch);
            this.panel2.Controls.Add(this.lblArtistSearch);
            this.panel2.Controls.Add(this.lblVenueSearch);
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
            this.lblSearchFor.Location = new System.Drawing.Point(251, 70);
            this.lblSearchFor.Name = "lblSearchFor";
            this.lblSearchFor.Size = new System.Drawing.Size(220, 17);
            this.lblSearchFor.TabIndex = 33;
            this.lblSearchFor.Text = "Search for ConcertName/ConcertDate";
            this.lblSearchFor.Click += new System.EventHandler(this.lblSearchFor_Click);
            // 
            // cbbArtistSearch
            // 
            this.cbbArtistSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbArtistSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbArtistSearch.FormattingEnabled = true;
            this.cbbArtistSearch.ItemHeight = 20;
            this.cbbArtistSearch.Location = new System.Drawing.Point(91, 65);
            this.cbbArtistSearch.Name = "cbbArtistSearch";
            this.cbbArtistSearch.Size = new System.Drawing.Size(152, 28);
            this.cbbArtistSearch.TabIndex = 11;
            // 
            // cbbVenueSearch
            // 
            this.cbbVenueSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbVenueSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbVenueSearch.FormattingEnabled = true;
            this.cbbVenueSearch.ItemHeight = 20;
            this.cbbVenueSearch.Location = new System.Drawing.Point(91, 24);
            this.cbbVenueSearch.Name = "cbbVenueSearch";
            this.cbbVenueSearch.Size = new System.Drawing.Size(414, 28);
            this.cbbVenueSearch.TabIndex = 32;
            // 
            // lblArtistSearch
            // 
            this.lblArtistSearch.AutoSize = true;
            this.lblArtistSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistSearch.Location = new System.Drawing.Point(28, 71);
            this.lblArtistSearch.Margin = new System.Windows.Forms.Padding(0);
            this.lblArtistSearch.Name = "lblArtistSearch";
            this.lblArtistSearch.Size = new System.Drawing.Size(51, 20);
            this.lblArtistSearch.TabIndex = 31;
            this.lblArtistSearch.Text = "Artist: ";
            this.lblArtistSearch.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblVenueSearch
            // 
            this.lblVenueSearch.AutoSize = true;
            this.lblVenueSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenueSearch.Location = new System.Drawing.Point(28, 27);
            this.lblVenueSearch.Margin = new System.Windows.Forms.Padding(0);
            this.lblVenueSearch.Name = "lblVenueSearch";
            this.lblVenueSearch.Size = new System.Drawing.Size(52, 20);
            this.lblVenueSearch.TabIndex = 30;
            this.lblVenueSearch.Text = "Venue:";
            this.lblVenueSearch.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.LightPink;
            this.btnSearch.Location = new System.Drawing.Point(511, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 32);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(249, 67);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(256, 24);
            this.txtSearch.TabIndex = 12;
            // 
            // txtConcertID
            // 
            this.txtConcertID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConcertID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcertID.Location = new System.Drawing.Point(21, 90);
            this.txtConcertID.Name = "txtConcertID";
            this.txtConcertID.Size = new System.Drawing.Size(319, 24);
            this.txtConcertID.TabIndex = 1;
            // 
            // cbbVenue
            // 
            this.cbbVenue.DropDownHeight = 100;
            this.cbbVenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbVenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbVenue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbVenue.FormattingEnabled = true;
            this.cbbVenue.IntegralHeight = false;
            this.cbbVenue.ItemHeight = 23;
            this.cbbVenue.Location = new System.Drawing.Point(20, 285);
            this.cbbVenue.Name = "cbbVenue";
            this.cbbVenue.Size = new System.Drawing.Size(320, 31);
            this.cbbVenue.TabIndex = 4;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.Location = new System.Drawing.Point(17, 334);
            this.lblArtist.Margin = new System.Windows.Forms.Padding(0);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(51, 20);
            this.lblArtist.TabIndex = 23;
            this.lblArtist.Text = "Artist: ";
            this.lblArtist.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.Location = new System.Drawing.Point(16, 262);
            this.lblVenue.Margin = new System.Windows.Forms.Padding(0);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(52, 20);
            this.lblVenue.TabIndex = 22;
            this.lblVenue.Text = "Venue:";
            this.lblVenue.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblConcertDate
            // 
            this.lblConcertDate.AutoSize = true;
            this.lblConcertDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcertDate.Location = new System.Drawing.Point(17, 192);
            this.lblConcertDate.Margin = new System.Windows.Forms.Padding(0);
            this.lblConcertDate.Name = "lblConcertDate";
            this.lblConcertDate.Size = new System.Drawing.Size(95, 20);
            this.lblConcertDate.TabIndex = 21;
            this.lblConcertDate.Text = "ConcertDate:";
            this.lblConcertDate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblConcertName
            // 
            this.lblConcertName.AutoSize = true;
            this.lblConcertName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcertName.Location = new System.Drawing.Point(17, 129);
            this.lblConcertName.Margin = new System.Windows.Forms.Padding(0);
            this.lblConcertName.Name = "lblConcertName";
            this.lblConcertName.Size = new System.Drawing.Size(107, 20);
            this.lblConcertName.TabIndex = 20;
            this.lblConcertName.Text = "ConcertName: ";
            this.lblConcertName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblConcert
            // 
            this.lblConcert.AutoSize = true;
            this.lblConcert.Font = new System.Drawing.Font("Carattere", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcert.Location = new System.Drawing.Point(2, 2);
            this.lblConcert.Name = "lblConcert";
            this.lblConcert.Size = new System.Drawing.Size(83, 39);
            this.lblConcert.TabIndex = 19;
            this.lblConcert.Text = "Concert";
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
            this.panel4.Controls.Add(this.dgvConcertList);
            this.panel4.Controls.Add(this.lblConcertList);
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
            // dgvConcertList
            // 
            this.dgvConcertList.BackgroundColor = System.Drawing.Color.White;
            this.dgvConcertList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConcertList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConcertList.Location = new System.Drawing.Point(14, 73);
            this.dgvConcertList.Name = "dgvConcertList";
            this.dgvConcertList.RowHeadersWidth = 51;
            this.dgvConcertList.RowTemplate.Height = 24;
            this.dgvConcertList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConcertList.Size = new System.Drawing.Size(604, 382);
            this.dgvConcertList.TabIndex = 14;
            this.dgvConcertList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConcertList_CellClick);
            this.dgvConcertList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConcertList_RowEnter);
            // 
            // lblConcertList
            // 
            this.lblConcertList.AutoSize = true;
            this.lblConcertList.Font = new System.Drawing.Font("Carattere", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcertList.Location = new System.Drawing.Point(3, 4);
            this.lblConcertList.Name = "lblConcertList";
            this.lblConcertList.Size = new System.Drawing.Size(127, 39);
            this.lblConcertList.TabIndex = 20;
            this.lblConcertList.Text = "Concert List";
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 20;
            this.bunifuElipse6.TargetControl = this.panel3;
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
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblConcertID
            // 
            this.lblConcertID.AutoSize = true;
            this.lblConcertID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcertID.Location = new System.Drawing.Point(17, 67);
            this.lblConcertID.Margin = new System.Windows.Forms.Padding(0);
            this.lblConcertID.Name = "lblConcertID";
            this.lblConcertID.Size = new System.Drawing.Size(82, 20);
            this.lblConcertID.TabIndex = 18;
            this.lblConcertID.Text = "ConcertID: ";
            this.lblConcertID.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtConcertName
            // 
            this.txtConcertName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConcertName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcertName.Location = new System.Drawing.Point(21, 152);
            this.txtConcertName.Name = "txtConcertName";
            this.txtConcertName.Size = new System.Drawing.Size(319, 24);
            this.txtConcertName.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.Controls.Add(this.dtpConcertDate);
            this.panel1.Controls.Add(this.cbbArtist);
            this.panel1.Controls.Add(this.txtConcertID);
            this.panel1.Controls.Add(this.cbbVenue);
            this.panel1.Controls.Add(this.lblArtist);
            this.panel1.Controls.Add(this.lblVenue);
            this.panel1.Controls.Add(this.lblConcertDate);
            this.panel1.Controls.Add(this.lblConcertName);
            this.panel1.Controls.Add(this.lblConcert);
            this.panel1.Controls.Add(this.lblConcertID);
            this.panel1.Controls.Add(this.txtConcertName);
            this.panel1.Location = new System.Drawing.Point(23, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 471);
            this.panel1.TabIndex = 1;
            // 
            // dtpConcertDate
            // 
            this.dtpConcertDate.CalendarForeColor = System.Drawing.Color.White;
            this.dtpConcertDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpConcertDate.CalendarTitleBackColor = System.Drawing.Color.LightPink;
            this.dtpConcertDate.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpConcertDate.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dtpConcertDate.CustomFormat = "dd/MM/yyyy h:mm tt";
            this.dtpConcertDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpConcertDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpConcertDate.Location = new System.Drawing.Point(20, 215);
            this.dtpConcertDate.Name = "dtpConcertDate";
            this.dtpConcertDate.Size = new System.Drawing.Size(320, 30);
            this.dtpConcertDate.TabIndex = 3;
            this.dtpConcertDate.Value = new System.DateTime(2023, 11, 6, 14, 48, 25, 0);
            // 
            // cbbArtist
            // 
            this.cbbArtist.DropDownHeight = 100;
            this.cbbArtist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbArtist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbArtist.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbArtist.FormattingEnabled = true;
            this.cbbArtist.IntegralHeight = false;
            this.cbbArtist.ItemHeight = 23;
            this.cbbArtist.Location = new System.Drawing.Point(20, 357);
            this.cbbArtist.Name = "cbbArtist";
            this.cbbArtist.Size = new System.Drawing.Size(320, 31);
            this.cbbArtist.TabIndex = 5;
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
            // bunifuElipse7
            // 
            this.bunifuElipse7.ElipseRadius = 8;
            this.bunifuElipse7.TargetControl = this.btnSearch;
            // 
            // bunifuElipse8
            // 
            this.bunifuElipse8.ElipseRadius = 8;
            this.bunifuElipse8.TargetControl = this.dgvConcertList;
            // 
            // bunifuElipse9
            // 
            this.bunifuElipse9.ElipseRadius = 8;
            this.bunifuElipse9.TargetControl = this.cbbArtistSearch;
            // 
            // bunifuElipse10
            // 
            this.bunifuElipse10.ElipseRadius = 8;
            this.bunifuElipse10.TargetControl = this.cbbVenueSearch;
            // 
            // bunifuElipse11
            // 
            this.bunifuElipse11.ElipseRadius = 4;
            this.bunifuElipse11.TargetControl = this.txtConcertID;
            // 
            // bunifuElipse12
            // 
            this.bunifuElipse12.ElipseRadius = 4;
            this.bunifuElipse12.TargetControl = this.txtConcertName;
            // 
            // bunifuElipse14
            // 
            this.bunifuElipse14.ElipseRadius = 4;
            this.bunifuElipse14.TargetControl = this.cbbArtist;
            // 
            // bunifuElipse15
            // 
            this.bunifuElipse15.ElipseRadius = 4;
            this.bunifuElipse15.TargetControl = this.cbbVenue;
            // 
            // bunifuElipse16
            // 
            this.bunifuElipse16.ElipseRadius = 8;
            this.bunifuElipse16.TargetControl = this.btnAdd;
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
            // bunifuElipse19
            // 
            this.bunifuElipse19.ElipseRadius = 8;
            this.bunifuElipse19.TargetControl = this.btnUpdate;
            // 
            // bunifuElipse20
            // 
            this.bunifuElipse20.ElipseRadius = 4;
            this.bunifuElipse20.TargetControl = this.dtpConcertDate;
            // 
            // frmConcert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "frmConcert";
            this.Size = new System.Drawing.Size(1064, 696);
            this.Load += new System.EventHandler(this.frmConcert_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConcertList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtConcertID;
        private System.Windows.Forms.ComboBox cbbVenue;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Label lblConcertDate;
        private System.Windows.Forms.Label lblConcertName;
        private System.Windows.Forms.Label lblConcert;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridView dgvConcertList;
        private System.Windows.Forms.Label lblConcertList;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblConcertID;
        private System.Windows.Forms.TextBox txtConcertName;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.ComboBox cbbArtist;
        private System.Windows.Forms.ComboBox cbbArtistSearch;
        private System.Windows.Forms.ComboBox cbbVenueSearch;
        private System.Windows.Forms.Label lblArtistSearch;
        private System.Windows.Forms.Label lblVenueSearch;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse7;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse8;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse9;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse10;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse11;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse12;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse14;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse15;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse16;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse17;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse18;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse19;
        private System.Windows.Forms.DateTimePicker dtpConcertDate;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse20;
        private System.Windows.Forms.Label lblSearchFor;
    }
}
