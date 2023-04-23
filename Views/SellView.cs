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
    public partial class SellView : Form
    {
        public SellView()
        {
            InitializeComponent();

            BtnClose.Click += delegate { this.Close(); };

            BtnSell.Click += delegate
            {
                try
                {
                    if (int.Parse(TxtStock.Text) == 0)
                    {
                        MessageBox.Show("Enter an amount greater than 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (int.Parse(TxtPrice.Text) == 0)
                    {
                        MessageBox.Show("Enter a price greater than 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (TxtName.Text == "")
                    {
                        MessageBox.Show("Please enter the name of the product to sell", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Successful sell", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtName.Text = "";
                        TxtPrice.Text = "";
                        TxtStock.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PLEASE FILL IN ALL THE FIELDS WELL", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

        }
    }
}
