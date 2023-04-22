namespace Supermarket_mvp.Views
{
    partial class MainView
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
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            BtnPurchase = new Button();
            label1 = new Label();
            BtnProducts = new Button();
            BtnCustomers = new Button();
            BtnCategories = new Button();
            BtnExit = new Button();
            BtnPayMode = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(BtnPurchase);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BtnProducts);
            panel1.Controls.Add(BtnCustomers);
            panel1.Controls.Add(BtnCategories);
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtnPayMode);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 717);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(0, 625);
            label3.Name = "label3";
            label3.Size = new Size(197, 15);
            label3.TabIndex = 9;
            label3.Text = "--------------------------------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(194, 32);
            label2.TabIndex = 8;
            label2.Text = "SUPERMARKET";
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.vender;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(12, 529);
            button2.Name = "button2";
            button2.Size = new Size(172, 71);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = true;
            // 
            // BtnPurchase
            // 
            BtnPurchase.BackgroundImage = Properties.Resources.cesta_de_la_compra;
            BtnPurchase.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPurchase.Location = new Point(12, 452);
            BtnPurchase.Name = "BtnPurchase";
            BtnPurchase.Size = new Size(172, 71);
            BtnPurchase.TabIndex = 6;
            BtnPurchase.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 434);
            label1.Name = "label1";
            label1.Size = new Size(197, 15);
            label1.TabIndex = 2;
            label1.Text = "--------------------------------------";
            // 
            // BtnProducts
            // 
            BtnProducts.BackgroundImage = Properties.Resources.products;
            BtnProducts.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProducts.Location = new Point(12, 360);
            BtnProducts.Name = "BtnProducts";
            BtnProducts.Size = new Size(172, 71);
            BtnProducts.TabIndex = 5;
            BtnProducts.UseVisualStyleBackColor = true;
            // 
            // BtnCustomers
            // 
            BtnCustomers.BackgroundImage = Properties.Resources.objetivo;
            BtnCustomers.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCustomers.Location = new Point(12, 283);
            BtnCustomers.Name = "BtnCustomers";
            BtnCustomers.Size = new Size(172, 71);
            BtnCustomers.TabIndex = 4;
            BtnCustomers.UseVisualStyleBackColor = true;
            // 
            // BtnCategories
            // 
            BtnCategories.BackgroundImage = Properties.Resources.aplicacion;
            BtnCategories.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCategories.Location = new Point(12, 206);
            BtnCategories.Name = "BtnCategories";
            BtnCategories.Size = new Size(172, 71);
            BtnCategories.TabIndex = 3;
            BtnCategories.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            BtnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnExit.BackgroundImage = Properties.Resources.salida;
            BtnExit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnExit.Location = new Point(0, 643);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(200, 71);
            BtnExit.TabIndex = 2;
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // BtnPayMode
            // 
            BtnPayMode.BackgroundImage = Properties.Resources.buy;
            BtnPayMode.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPayMode.Location = new Point(12, 129);
            BtnPayMode.Name = "BtnPayMode";
            BtnPayMode.Size = new Size(172, 71);
            BtnPayMode.TabIndex = 1;
            BtnPayMode.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sell;
            pictureBox1.Location = new Point(3, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 717);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "SuperMarket";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnPayMode;
        private PictureBox pictureBox1;
        private Button BtnExit;
        private Button BtnCategories;
        private Button BtnCustomers;
        private Button BtnProducts;
        private Button button2;
        private Button BtnPurchase;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}