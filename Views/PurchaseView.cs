using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class PurchaseView : Form, IProductView
    {
        public PurchaseView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            BtnClose.Click += delegate { this.Close(); };
        }
        private void AssociateAndRaiseViewEvents()
        {
            DgPurchase.Click += delegate
            {
                TxtId.Text = DgPurchase.CurrentRow.Cells[0].Value.ToString();
                TxtName.Text = DgPurchase.CurrentRow.Cells[1].Value.ToString();
                TxtPrice.Text = DgPurchase.CurrentRow.Cells[2].Value.ToString();
                TxtStock.Text = DgPurchase.CurrentRow.Cells[3].Value.ToString();
            };

            BtnPurchase.Click += delegate
            {
                try
                {
                    if (int.Parse(TxtQuantity.Text) > int.Parse(TxtStock.Text))
                    {
                        MessageBox.Show("Select a quantity less than stock", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (int.Parse(TxtQuantity.Text) <= 0)
                    {
                        MessageBox.Show("The quantities to buy must be greater than 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Successful purchase", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Product.Text = TxtName.Text;
                        int total = int.Parse(TxtPrice.Text) * int.Parse(TxtQuantity.Text);
                        Price.Text = total.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PLEASE SELECT THE PRODUCT TO BUY", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
        }
        public string ProductId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ProductPrice { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ProductStock { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ProductCategory { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsEdit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsSuccessful { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IProductView.ProductName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetProductListBildingSource(BindingSource productList)
        {
            DgPurchase.DataSource = productList;
        }

        private static PurchaseView instance;
        public static PurchaseView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PurchaseView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
    }
}
