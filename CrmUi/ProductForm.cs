using CrmBl.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUi
{
    public partial class ProductForm : Form
    {
        public Product Product { get; set; }

        public ProductForm()
        {
            InitializeComponent();
        }

        private void productInputButton_Click(object sender, EventArgs e)
        {
            Product = new Product()
            {
                Name = productNameTextBox.Text,
                Price = priceNumericUpDown.Value,
                Count = Convert.ToInt32(countNumericUpDown.Value)
            };
            Close();
        }
    }
}
