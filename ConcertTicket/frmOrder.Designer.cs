namespace ConcertTicket
{
    partial class frmOrder
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
            this.bunifuElipse10 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.bunifuElipse11 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.bunifuElipse12 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.bunifuElipse13 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnView = new System.Windows.Forms.Button();
            this.bunifuElipse14 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cbbSearchFor = new System.Windows.Forms.ComboBox();
            this.bunifuElipse15 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cbbValue = new System.Windows.Forms.ComboBox();
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse8 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse10
            // 
            this.bunifuElipse10.ElipseRadius = 8;
            this.bunifuElipse10.TargetControl = this.btnAdd;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.LightPink;
            this.btnAdd.Location = new System.Drawing.Point(804, 44);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 40);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "+ Create New ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bunifuElipse11
            // 
            this.bunifuElipse11.ElipseRadius = 8;
            this.bunifuElipse11.TargetControl = this.btnDelete;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.LightPink;
            this.btnDelete.Location = new System.Drawing.Point(804, 541);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 40);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete ";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bunifuElipse12
            // 
            this.bunifuElipse12.ElipseRadius = 8;
            this.bunifuElipse12.TargetControl = this.btnSearch;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.LightPink;
            this.btnSearch.Location = new System.Drawing.Point(488, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 35);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // bunifuElipse13
            // 
            this.bunifuElipse13.ElipseRadius = 8;
            this.bunifuElipse13.TargetControl = this.btnView;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Black;
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnView.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.LightPink;
            this.btnView.Location = new System.Drawing.Point(621, 541);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(140, 40);
            this.btnView.TabIndex = 37;
            this.btnView.Text = "View Details";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // bunifuElipse14
            // 
            this.bunifuElipse14.ElipseRadius = 8;
            this.bunifuElipse14.TargetControl = this.cbbSearchFor;
            // 
            // cbbSearchFor
            // 
            this.cbbSearchFor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbSearchFor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSearchFor.FormattingEnabled = true;
            this.cbbSearchFor.ItemHeight = 20;
            this.cbbSearchFor.Location = new System.Drawing.Point(40, 51);
            this.cbbSearchFor.Name = "cbbSearchFor";
            this.cbbSearchFor.Size = new System.Drawing.Size(149, 28);
            this.cbbSearchFor.TabIndex = 32;
            // 
            // bunifuElipse15
            // 
            this.bunifuElipse15.ElipseRadius = 8;
            this.bunifuElipse15.TargetControl = this.cbbValue;
            // 
            // cbbValue
            // 
            this.cbbValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbValue.FormattingEnabled = true;
            this.cbbValue.ItemHeight = 20;
            this.cbbValue.Location = new System.Drawing.Point(211, 51);
            this.cbbValue.Name = "cbbValue";
            this.cbbValue.Size = new System.Drawing.Size(255, 28);
            this.cbbValue.TabIndex = 39;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 20;
            this.bunifuElipse5.TargetControl = this.panel4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightPink;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cbbValue);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnView);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.cbbSearchFor);
            this.panel4.Controls.Add(this.lblOrderID);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.lblRecords);
            this.panel4.Controls.Add(this.dgvOrderList);
            this.panel4.Location = new System.Drawing.Point(40, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(983, 612);
            this.panel4.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Value: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(36, 28);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(83, 20);
            this.lblOrderID.TabIndex = 35;
            this.lblOrderID.Text = "Search for: ";
            this.lblOrderID.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(36, 520);
            this.lblRecords.Margin = new System.Windows.Forms.Padding(0);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(70, 20);
            this.lblRecords.TabIndex = 26;
            this.lblRecords.Text = "Records: ";
            this.lblRecords.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Location = new System.Drawing.Point(40, 106);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.RowHeadersWidth = 51;
            this.dgvOrderList.RowTemplate.Height = 24;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(904, 406);
            this.dgvOrderList.TabIndex = 15;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuElipse8
            // 
            this.bunifuElipse8.ElipseRadius = 8;
            this.bunifuElipse8.TargetControl = this.dgvOrderList;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.Controls.Add(this.panel4);
            this.Name = "frmOrder";
            this.Size = new System.Drawing.Size(1064, 696);
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse10;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse11;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse12;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse13;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse14;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse15;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse8;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbbSearchFor;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbValue;
    }
}
