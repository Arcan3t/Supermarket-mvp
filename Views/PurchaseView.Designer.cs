namespace Supermarket_mvp.Views
{
    partial class PurchaseView
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
            BtnClose = new Button();
            groupBox1 = new GroupBox();
            label7 = new Label();
            TxtStock = new TextBox();
            label6 = new Label();
            TxtId = new TextBox();
            label5 = new Label();
            TxtName = new TextBox();
            label4 = new Label();
            TxtPrice = new TextBox();
            label3 = new Label();
            TxtQuantity = new TextBox();
            label2 = new Label();
            DgPurchase = new DataGridView();
            BtnPurchase = new Button();
            groupBox2 = new GroupBox();
            Price = new Label();
            Product = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPurchase).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 94);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cesta_de_la_compra1;
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
            label1.Size = new Size(253, 37);
            label1.TabIndex = 0;
            label1.Text = "PURCHASE MODE";
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(595, 383);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(207, 65);
            BtnClose.TabIndex = 16;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(TxtStock);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(TxtId);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TxtName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtPrice);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtQuantity);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(DgPurchase);
            groupBox1.Controls.Add(BtnPurchase);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(586, 348);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Purchase Box";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(360, 164);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 30;
            label7.Text = "PRODUCT STOCK";
            // 
            // TxtStock
            // 
            TxtStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            TxtStock.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxtStock.Location = new Point(360, 182);
            TxtStock.Name = "TxtStock";
            TxtStock.PlaceholderText = "Stock";
            TxtStock.ReadOnly = true;
            TxtStock.Size = new Size(220, 23);
            TxtStock.TabIndex = 29;
            TxtStock.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(357, 32);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 28;
            label6.Text = "PRODUCT ID";
            // 
            // TxtId
            // 
            TxtId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            TxtId.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxtId.Location = new Point(357, 50);
            TxtId.Name = "TxtId";
            TxtId.PlaceholderText = "ID";
            TxtId.ReadOnly = true;
            TxtId.Size = new Size(220, 23);
            TxtId.TabIndex = 27;
            TxtId.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(359, 76);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 26;
            label5.Text = "PRODUCT NAME";
            // 
            // TxtName
            // 
            TxtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            TxtName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxtName.Location = new Point(359, 94);
            TxtName.Name = "TxtName";
            TxtName.PlaceholderText = "Name";
            TxtName.ReadOnly = true;
            TxtName.Size = new Size(220, 23);
            TxtName.TabIndex = 25;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(361, 120);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 24;
            label4.Text = "PRODUCT PRICE";
            // 
            // TxtPrice
            // 
            TxtPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            TxtPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPrice.Location = new Point(361, 138);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.PlaceholderText = "Price";
            TxtPrice.ReadOnly = true;
            TxtPrice.Size = new Size(220, 23);
            TxtPrice.TabIndex = 23;
            TxtPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(360, 238);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 22;
            label3.Text = "QUANTITY TO BUY";
            // 
            // TxtQuantity
            // 
            TxtQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            TxtQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxtQuantity.Location = new Point(360, 256);
            TxtQuantity.Name = "TxtQuantity";
            TxtQuantity.PlaceholderText = "Quantity";
            TxtQuantity.Size = new Size(220, 23);
            TxtQuantity.TabIndex = 21;
            TxtQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 32);
            label2.Name = "label2";
            label2.Size = new Size(176, 15);
            label2.TabIndex = 20;
            label2.Text = "SELECT THE PRODUCT TO BUY";
            // 
            // DgPurchase
            // 
            DgPurchase.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgPurchase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgPurchase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPurchase.Location = new Point(6, 50);
            DgPurchase.Name = "DgPurchase";
            DgPurchase.ReadOnly = true;
            DgPurchase.RowTemplate.Height = 25;
            DgPurchase.Size = new Size(347, 292);
            DgPurchase.TabIndex = 19;
            // 
            // BtnPurchase
            // 
            BtnPurchase.Anchor = AnchorStyles.Right;
            BtnPurchase.Image = Properties.Resources.verificar;
            BtnPurchase.Location = new Point(360, 283);
            BtnPurchase.Name = "BtnPurchase";
            BtnPurchase.Size = new Size(221, 59);
            BtnPurchase.TabIndex = 17;
            BtnPurchase.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.Controls.Add(Price);
            groupBox2.Controls.Add(Product);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(595, 100);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(207, 277);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Invoice";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Price.Location = new Point(6, 76);
            Price.Name = "Price";
            Price.Size = new Size(38, 15);
            Price.TabIndex = 2;
            Price.Text = "PRICE";
            // 
            // Product
            // 
            Product.AutoSize = true;
            Product.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Product.Location = new Point(6, 50);
            Product.Name = "Product";
            Product.Size = new Size(60, 15);
            Product.TabIndex = 1;
            Product.Text = "PRODUCT";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(6, 19);
            label8.Name = "label8";
            label8.Size = new Size(98, 15);
            label8.TabIndex = 0;
            label8.Text = "SUPERMARKET";
            // 
            // PurchaseView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 460);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(BtnClose);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "PurchaseView";
            Text = "Purchase";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPurchase).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button BtnClose;
        private GroupBox groupBox1;
        private Button BtnPurchase;
        private GroupBox groupBox2;
        private DataGridView DgPurchase;
        private Label label2;
        private Label label5;
        private TextBox TxtName;
        private Label label4;
        private TextBox TxtPrice;
        private Label label3;
        private TextBox TxtQuantity;
        private Label label6;
        private TextBox TxtId;
        private Label label7;
        private TextBox TxtStock;
        private Label Price;
        private Label Product;
        private Label label8;
    }
}