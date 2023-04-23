namespace Supermarket_mvp.Views
{
    partial class SellView
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
            label7 = new Label();
            TxtStock = new TextBox();
            label5 = new Label();
            TxtName = new TextBox();
            label4 = new Label();
            TxtPrice = new TextBox();
            BtnSell = new Button();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 94);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.vender1;
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
            label1.Size = new Size(168, 37);
            label1.TabIndex = 0;
            label1.Text = "SELL MODE";
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(236, 258);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(207, 60);
            BtnClose.TabIndex = 19;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(11, 122);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 42;
            label7.Text = "PRODUCT STOCK";
            // 
            // TxtStock
            // 
            TxtStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            TxtStock.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxtStock.Location = new Point(11, 140);
            TxtStock.Name = "TxtStock";
            TxtStock.PlaceholderText = "Stock";
            TxtStock.Size = new Size(432, 23);
            TxtStock.TabIndex = 41;
            TxtStock.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(11, 34);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 38;
            label5.Text = "PRODUCT NAME";
            // 
            // TxtName
            // 
            TxtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            TxtName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxtName.Location = new Point(11, 52);
            TxtName.Name = "TxtName";
            TxtName.PlaceholderText = "Name";
            TxtName.Size = new Size(432, 23);
            TxtName.TabIndex = 37;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(11, 78);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 36;
            label4.Text = "PRODUCT PRICE";
            // 
            // TxtPrice
            // 
            TxtPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            TxtPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPrice.Location = new Point(11, 96);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.PlaceholderText = "Price";
            TxtPrice.Size = new Size(432, 23);
            TxtPrice.TabIndex = 35;
            TxtPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // BtnSell
            // 
            BtnSell.Anchor = AnchorStyles.Right;
            BtnSell.Image = Properties.Resources.descuento;
            BtnSell.Location = new Point(11, 259);
            BtnSell.Name = "BtnSell";
            BtnSell.Size = new Size(207, 59);
            BtnSell.TabIndex = 31;
            BtnSell.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(BtnClose);
            groupBox1.Controls.Add(TxtStock);
            groupBox1.Controls.Add(BtnSell);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TxtPrice);
            groupBox1.Controls.Add(TxtName);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 336);
            groupBox1.TabIndex = 43;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sell Box";
            // 
            // SellView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SellView";
            Text = "Sell";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button BtnClose;
        private Label label7;
        private TextBox TxtStock;
        private Label label5;
        private TextBox TxtName;
        private Label label4;
        private TextBox TxtPrice;
        private Button BtnSell;
        private GroupBox groupBox1;
    }
}