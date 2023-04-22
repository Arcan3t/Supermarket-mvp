namespace Supermarket_mvp.Views
{
    partial class CustomerView
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageCustomerList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgCustomer = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageCustomerDetails = new TabPage();
            TxtCustomerDNumber = new TextBox();
            label9 = new Label();
            TxtCustomerEmail = new TextBox();
            label8 = new Label();
            TxtCustomerPNumber = new TextBox();
            label7 = new Label();
            TxtCustomerBirthday = new TextBox();
            label6 = new Label();
            TxtCustomerLName = new TextBox();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtCustomerAddress = new TextBox();
            label5 = new Label();
            TxtCustomerFName = new TextBox();
            label4 = new Label();
            TxtCustomerId = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCustomerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomer).BeginInit();
            tabPageCustomerDetails.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 94);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.objetivo;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(129, 28);
            label1.Name = "label1";
            label1.Size = new Size(258, 37);
            label1.TabIndex = 0;
            label1.Text = "CUSTOMER MODE";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPageCustomerList);
            tabControl1.Controls.Add(tabPageCustomerDetails);
            tabControl1.Location = new Point(3, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(797, 349);
            tabControl1.TabIndex = 3;
            // 
            // tabPageCustomerList
            // 
            tabPageCustomerList.Controls.Add(BtnClose);
            tabPageCustomerList.Controls.Add(BtnDelete);
            tabPageCustomerList.Controls.Add(BtnEdit);
            tabPageCustomerList.Controls.Add(BtnNew);
            tabPageCustomerList.Controls.Add(DgCustomer);
            tabPageCustomerList.Controls.Add(BtnSearch);
            tabPageCustomerList.Controls.Add(TxtSearch);
            tabPageCustomerList.Controls.Add(label2);
            tabPageCustomerList.Location = new Point(4, 24);
            tabPageCustomerList.Name = "tabPageCustomerList";
            tabPageCustomerList.Padding = new Padding(3);
            tabPageCustomerList.Size = new Size(789, 321);
            tabPageCustomerList.TabIndex = 0;
            tabPageCustomerList.Text = "Customer List";
            tabPageCustomerList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(577, 248);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(207, 59);
            BtnClose.TabIndex = 23;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(577, 183);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(207, 59);
            BtnDelete.TabIndex = 22;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(577, 118);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(207, 59);
            BtnEdit.TabIndex = 21;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(577, 53);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(207, 59);
            BtnNew.TabIndex = 20;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgCustomer
            // 
            DgCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCustomer.Location = new Point(5, 48);
            DgCustomer.Name = "DgCustomer";
            DgCustomer.ReadOnly = true;
            DgCustomer.RowTemplate.Height = 25;
            DgCustomer.Size = new Size(566, 271);
            DgCustomer.TabIndex = 19;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(506, 2);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(65, 40);
            BtnSearch.TabIndex = 18;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(5, 19);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to Search";
            TxtSearch.Size = new Size(495, 23);
            TxtSearch.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(5, 1);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 16;
            label2.Text = "Search Customer";
            // 
            // tabPageCustomerDetails
            // 
            tabPageCustomerDetails.Controls.Add(TxtCustomerDNumber);
            tabPageCustomerDetails.Controls.Add(label9);
            tabPageCustomerDetails.Controls.Add(TxtCustomerEmail);
            tabPageCustomerDetails.Controls.Add(label8);
            tabPageCustomerDetails.Controls.Add(TxtCustomerPNumber);
            tabPageCustomerDetails.Controls.Add(label7);
            tabPageCustomerDetails.Controls.Add(TxtCustomerBirthday);
            tabPageCustomerDetails.Controls.Add(label6);
            tabPageCustomerDetails.Controls.Add(TxtCustomerLName);
            tabPageCustomerDetails.Controls.Add(BtnCancel);
            tabPageCustomerDetails.Controls.Add(BtnSave);
            tabPageCustomerDetails.Controls.Add(TxtCustomerAddress);
            tabPageCustomerDetails.Controls.Add(label5);
            tabPageCustomerDetails.Controls.Add(TxtCustomerFName);
            tabPageCustomerDetails.Controls.Add(label4);
            tabPageCustomerDetails.Controls.Add(TxtCustomerId);
            tabPageCustomerDetails.Controls.Add(label3);
            tabPageCustomerDetails.Location = new Point(4, 24);
            tabPageCustomerDetails.Name = "tabPageCustomerDetails";
            tabPageCustomerDetails.Padding = new Padding(3);
            tabPageCustomerDetails.Size = new Size(789, 321);
            tabPageCustomerDetails.TabIndex = 1;
            tabPageCustomerDetails.Text = "Customer Details";
            tabPageCustomerDetails.UseVisualStyleBackColor = true;
            // 
            // TxtCustomerDNumber
            // 
            TxtCustomerDNumber.Location = new Point(8, 111);
            TxtCustomerDNumber.Name = "TxtCustomerDNumber";
            TxtCustomerDNumber.PlaceholderText = "Customer Document Number";
            TxtCustomerDNumber.Size = new Size(279, 23);
            TxtCustomerDNumber.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(8, 93);
            label9.Name = "label9";
            label9.Size = new Size(172, 15);
            label9.TabIndex = 33;
            label9.Text = "Customer Document Number";
            // 
            // TxtCustomerEmail
            // 
            TxtCustomerEmail.Location = new Point(362, 182);
            TxtCustomerEmail.Name = "TxtCustomerEmail";
            TxtCustomerEmail.PlaceholderText = "Customer Email";
            TxtCustomerEmail.Size = new Size(279, 23);
            TxtCustomerEmail.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(362, 164);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 31;
            label8.Text = "Customer Email";
            // 
            // TxtCustomerPNumber
            // 
            TxtCustomerPNumber.Location = new Point(362, 111);
            TxtCustomerPNumber.Name = "TxtCustomerPNumber";
            TxtCustomerPNumber.PlaceholderText = "000 0000000";
            TxtCustomerPNumber.Size = new Size(279, 23);
            TxtCustomerPNumber.TabIndex = 30;
            TxtCustomerPNumber.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(362, 93);
            label7.Name = "label7";
            label7.Size = new Size(148, 15);
            label7.TabIndex = 29;
            label7.Text = "Customer Phone Number";
            // 
            // TxtCustomerBirthday
            // 
            TxtCustomerBirthday.Location = new Point(362, 40);
            TxtCustomerBirthday.Name = "TxtCustomerBirthday";
            TxtCustomerBirthday.PlaceholderText = "DD/MM/YYYY HH:MM:SS (a.m. - p.m.)";
            TxtCustomerBirthday.Size = new Size(279, 23);
            TxtCustomerBirthday.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(362, 22);
            label6.Name = "label6";
            label6.Size = new Size(111, 15);
            label6.TabIndex = 27;
            label6.Text = "Customer Birthday";
            // 
            // TxtCustomerLName
            // 
            TxtCustomerLName.Location = new Point(146, 182);
            TxtCustomerLName.Name = "TxtCustomerLName";
            TxtCustomerLName.PlaceholderText = "Last Name";
            TxtCustomerLName.Size = new Size(132, 23);
            TxtCustomerLName.TabIndex = 26;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(542, 252);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(99, 46);
            BtnCancel.TabIndex = 25;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(362, 252);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(99, 46);
            BtnSave.TabIndex = 24;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtCustomerAddress
            // 
            TxtCustomerAddress.Location = new Point(8, 253);
            TxtCustomerAddress.Name = "TxtCustomerAddress";
            TxtCustomerAddress.PlaceholderText = "Customer Address";
            TxtCustomerAddress.Size = new Size(279, 23);
            TxtCustomerAddress.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(8, 235);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 22;
            label5.Text = "Customer Address";
            // 
            // TxtCustomerFName
            // 
            TxtCustomerFName.Location = new Point(8, 182);
            TxtCustomerFName.Name = "TxtCustomerFName";
            TxtCustomerFName.PlaceholderText = "First Name";
            TxtCustomerFName.Size = new Size(132, 23);
            TxtCustomerFName.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(8, 164);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 20;
            label4.Text = "Customer Name";
            // 
            // TxtCustomerId
            // 
            TxtCustomerId.Location = new Point(8, 40);
            TxtCustomerId.Name = "TxtCustomerId";
            TxtCustomerId.ReadOnly = true;
            TxtCustomerId.Size = new Size(279, 23);
            TxtCustomerId.TabIndex = 19;
            TxtCustomerId.Text = "0";
            TxtCustomerId.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(8, 22);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 18;
            label3.Text = "Customer ID";
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CustomerView";
            Text = "Customer Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCustomerList.ResumeLayout(false);
            tabPageCustomerList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomer).EndInit();
            tabPageCustomerDetails.ResumeLayout(false);
            tabPageCustomerDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageCustomerList;
        private TabPage tabPageCustomerDetails;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgCustomer;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtCustomerAddress;
        private Label label5;
        private TextBox TxtCustomerFName;
        private Label label4;
        private TextBox TxtCustomerId;
        private Label label3;
        private TextBox TxtCustomerLName;
        private TextBox TxtCustomerBirthday;
        private Label label6;
        private TextBox TxtCustomerEmail;
        private Label label8;
        private TextBox TxtCustomerPNumber;
        private Label label7;
        private TextBox TxtCustomerDNumber;
        private Label label9;
    }
}