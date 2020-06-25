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

        public ProductForm(Product product) : this()
        {
            Product = product;
            productNameTextBox.Text = Product.Name;
            priceNumericUpDown.Value = Product.Price;
            countNumericUpDown.Value = Product.Count;
        }

        private void productInputButton_Click(object sender, EventArgs e)
        {
            var p = Product ?? new Product();
            p.Name = productNameTextBox.Text;
            p.Price = priceNumericUpDown.Value;
            p.Count = Convert.ToInt32(countNumericUpDown.Value);
            
            Close();
        }
    }
}
