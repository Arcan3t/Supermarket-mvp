namespace Supermarket_mvp.Views
{
    partial class ProviderView
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
            tabPageProviderList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgProvider = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageProviderDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtProviderName = new TextBox();
            label4 = new Label();
            TxtProviderId = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProviderList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProvider).BeginInit();
            tabPageProviderDetail.SuspendLayout();
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
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.providers;
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
            label1.Size = new Size(262, 37);
            label1.TabIndex = 0;
            label1.Text = "PROVIDERS MODE";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProviderList);
            tabControl1.Controls.Add(tabPageProviderDetail);
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 348);
            tabControl1.TabIndex = 2;
            // 
            // tabPageProviderList
            // 
            tabPageProviderList.Controls.Add(BtnClose);
            tabPageProviderList.Controls.Add(BtnDelete);
            tabPageProviderList.Controls.Add(BtnEdit);
            tabPageProviderList.Controls.Add(BtnNew);
            tabPageProviderList.Controls.Add(DgProvider);
            tabPageProviderList.Controls.Add(BtnSearch);
            tabPageProviderList.Controls.Add(TxtSearch);
            tabPageProviderList.Controls.Add(label2);
            tabPageProviderList.Location = new Point(4, 24);
            tabPageProviderList.Name = "tabPageProviderList";
            tabPageProviderList.Padding = new Padding(3);
            tabPageProviderList.Size = new Size(792, 320);
            tabPageProviderList.TabIndex = 0;
            tabPageProviderList.Text = "Provider List";
            tabPageProviderList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(577, 254);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(207, 59);
            BtnClose.TabIndex = 15;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(577, 189);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(207, 59);
            BtnDelete.TabIndex = 14;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(577, 124);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(207, 59);
            BtnEdit.TabIndex = 13;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(577, 59);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(207, 59);
            BtnNew.TabIndex = 12;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgProvider
            // 
            DgProvider.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProvider.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProvider.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProvider.Location = new Point(8, 54);
            DgProvider.Name = "DgProvider";
            DgProvider.ReadOnly = true;
            DgProvider.RowTemplate.Height = 25;
            DgProvider.Size = new Size(563, 259);
            DgProvider.TabIndex = 11;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(506, 8);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(65, 40);
            BtnSearch.TabIndex = 10;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(8, 25);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to Search";
            TxtSearch.Size = new Size(492, 23);
            TxtSearch.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(8, 7);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 8;
            label2.Text = "Search Pay Mode";
            // 
            // tabPageProviderDetail
            // 
            tabPageProviderDetail.Controls.Add(BtnCancel);
            tabPageProviderDetail.Controls.Add(BtnSave);
            tabPageProviderDetail.Controls.Add(TxtProviderName);
            tabPageProviderDetail.Controls.Add(label4);
            tabPageProviderDetail.Controls.Add(TxtProviderId);
            tabPageProviderDetail.Controls.Add(label3);
            tabPageProviderDetail.Location = new Point(4, 24);
            tabPageProviderDetail.Name = "tabPageProviderDetail";
            tabPageProviderDetail.Padding = new Padding(3);
            tabPageProviderDetail.Size = new Size(792, 320);
            tabPageProviderDetail.TabIndex = 1;
            tabPageProviderDetail.Text = "Provider Detail";
            tabPageProviderDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(146, 253);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(99, 46);
            BtnCancel.TabIndex = 15;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(29, 253);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(99, 46);
            BtnSave.TabIndex = 14;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtProviderName
            // 
            TxtProviderName.Location = new Point(8, 90);
            TxtProviderName.Name = "TxtProviderName";
            TxtProviderName.PlaceholderText = "Pay Mode Name";
            TxtProviderName.Size = new Size(279, 23);
            TxtProviderName.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(8, 72);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 12;
            label4.Text = "Provider Name";
            // 
            // TxtProviderId
            // 
            TxtProviderId.Location = new Point(8, 31);
            TxtProviderId.Name = "TxtProviderId";
            TxtProviderId.ReadOnly = true;
            TxtProviderId.Size = new Size(279, 23);
            TxtProviderId.TabIndex = 11;
            TxtProviderId.Text = "0";
            TxtProviderId.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(8, 13);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 10;
            label3.Text = "Provider ID";
            // 
            // ProviderView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProviderView";
            Text = "Provider Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProviderList.ResumeLayout(false);
            tabPageProviderList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProvider).EndInit();
            tabPageProviderDetail.ResumeLayout(false);
            tabPageProviderDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageProviderList;
        private TabPage tabPageProviderDetail;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgProvider;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProviderName;
        private Label label4;
        private TextBox TxtProviderId;
        private Label label3;
    }
}