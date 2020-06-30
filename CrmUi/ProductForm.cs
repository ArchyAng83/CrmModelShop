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
            Product = product ?? new Product();
            productNameTextBox.Text = Product.Name;
            priceNumericUpDown.Value = Product.Price;
            countNumericUpDown.Value = Product.Count;
        }

        private void productInputButton_Click(object sender, EventArgs e)
        {
            Product = Product ?? new Product();
            Product.Name = productNameTextBox.Text;
            Product.Price = priceNumericUpDown.Value;
            Product.Count = Convert.ToInt32(countNumericUpDown.Value);
            
            Close();
        }
    }
}
