namespace CrmUi
{
    partial class SellerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.sellerNameTextBox = new System.Windows.Forms.TextBox();
            this.sellerInputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя";
            // 
            // sellerNameTextBox
            // 
            this.sellerNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sellerNameTextBox.Location = new System.Drawing.Point(93, 10);
            this.sellerNameTextBox.Name = "sellerNameTextBox";
            this.sellerNameTextBox.Size = new System.Drawing.Size(193, 22);
            this.sellerNameTextBox.TabIndex = 1;
            // 
            // sellerInputButton
            // 
            this.sellerInputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sellerInputButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.sellerInputButton.Location = new System.Drawing.Point(207, 217);
            this.sellerInputButton.Name = "sellerInputButton";
            this.sellerInputButton.Size = new System.Drawing.Size(75, 23);
            this.sellerInputButton.TabIndex = 2;
            this.sellerInputButton.Text = "OK";
            this.sellerInputButton.UseVisualStyleBackColor = true;
            this.sellerInputButton.Click += new System.EventHandler(this.sellerInputButton_Click);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 252);
            this.Controls.Add(this.sellerInputButton);
            this.Controls.Add(this.sellerNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "SellerForm";
            this.Text = "SellerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sellerNameTextBox;
        private System.Windows.Forms.Button sellerInputButton;
    }
}