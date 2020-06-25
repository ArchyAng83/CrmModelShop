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
    public partial class SellerForm : Form
    {
        public Seller Seller { get; set; }

        public SellerForm()
        {
            InitializeComponent();
        }

        public SellerForm(Seller seller) : this()
        {
            Seller = seller;
            sellerNameTextBox.Text = seller.Name;
        }

        private void sellerInputButton_Click(object sender, EventArgs e)
        {
            var s = Seller ?? new Seller();
            s.Name = sellerNameTextBox.Text;
            Close();
        }
    }
}
