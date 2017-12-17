namespace Monopoly
{
    partial class PropertyPopupFrom
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
            this.PropertyNameTextBox = new System.Windows.Forms.TextBox();
            this.BuyBotton = new System.Windows.Forms.Button();
            this.NotBuyBotton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PropertyNameTextBox
            // 
            this.PropertyNameTextBox.Location = new System.Drawing.Point(113, 51);
            this.PropertyNameTextBox.Multiline = true;
            this.PropertyNameTextBox.Name = "PropertyNameTextBox";
            this.PropertyNameTextBox.Size = new System.Drawing.Size(329, 126);
            this.PropertyNameTextBox.TabIndex = 0;
            // 
            // BuyBotton
            // 
            this.BuyBotton.Location = new System.Drawing.Point(113, 215);
            this.BuyBotton.Name = "BuyBotton";
            this.BuyBotton.Size = new System.Drawing.Size(141, 61);
            this.BuyBotton.TabIndex = 1;
            this.BuyBotton.Text = "Buy";
            this.BuyBotton.UseVisualStyleBackColor = true;
            this.BuyBotton.Click += new System.EventHandler(this.BuyBotton_Click);
            // 
            // NotBuyBotton
            // 
            this.NotBuyBotton.Location = new System.Drawing.Point(301, 215);
            this.NotBuyBotton.Name = "NotBuyBotton";
            this.NotBuyBotton.Size = new System.Drawing.Size(141, 61);
            this.NotBuyBotton.TabIndex = 2;
            this.NotBuyBotton.Text = "Not Buy";
            this.NotBuyBotton.UseVisualStyleBackColor = true;
            this.NotBuyBotton.Click += new System.EventHandler(this.NotBuyBotton_Click);
            // 
            // PropertyPopupFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 340);
            this.Controls.Add(this.NotBuyBotton);
            this.Controls.Add(this.BuyBotton);
            this.Controls.Add(this.PropertyNameTextBox);
            this.Name = "PropertyPopupFrom";
            this.Text = "PopupFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PropertyNameTextBox;
        private System.Windows.Forms.Button BuyBotton;
        private System.Windows.Forms.Button NotBuyBotton;
    }
}