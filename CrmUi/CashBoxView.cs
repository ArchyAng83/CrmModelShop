using CrmBl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUi
{
    class CashBoxView
    {
        CashDesk cashDesk;

        public Label CashDeskName { get; set; }
        public NumericUpDown Price { get; set; }
        public ProgressBar QueueLenght { get; set; }
        public Label LeaveCustomersCount { get; set; }

        public CashBoxView(CashDesk cashDesk, int number, int x, int y)
        {
            this.cashDesk = cashDesk;


            CashDeskName = new Label();
            LeaveCustomersCount = new Label();
            Price = new NumericUpDown();
            QueueLenght = new ProgressBar();

            CashDeskName.AutoSize = true;
            CashDeskName.Location = new System.Drawing.Point(x, y);
            CashDeskName.Name = "label1" + number;
            CashDeskName.Size = new System.Drawing.Size(38, 13);
            CashDeskName.TabIndex = number;
            CashDeskName.Text = cashDesk.ToString();
            
            Price.Location = new System.Drawing.Point(x + 70, y);
            Price.Name = "numericUpDown";
            Price.Size = new System.Drawing.Size(120, 22);
            Price.TabIndex = number;
            Price.Maximum = 1000000000000000000;

            QueueLenght.Location = new System.Drawing.Point(x + 220, y);
            QueueLenght.Maximum = cashDesk.MaxQueueLenght;
            QueueLenght.Name = "progressBar" + number;
            QueueLenght.Size = new System.Drawing.Size(100, 23);
            QueueLenght.TabIndex = number;
            QueueLenght.Value = 0;

            LeaveCustomersCount.AutoSize = true;
            LeaveCustomersCount.Location = new System.Drawing.Point(x + 350, y);
            LeaveCustomersCount.Name = "label2" + number;
            LeaveCustomersCount.Size = new System.Drawing.Size(38, 13);
            LeaveCustomersCount.TabIndex = number;
            LeaveCustomersCount.Text = "";

            cashDesk.CheckClosed += CashDesk_CheckClosed;
        }

        private void CashDesk_CheckClosed(object sender, Check e)
        {
            Price.Invoke((Action)delegate
            {
                Price.Value += e.Price;
                QueueLenght.Value = cashDesk.Count;
                LeaveCustomersCount.Text = cashDesk.ExitCustomer.ToString();
            });
        }
    }
}
