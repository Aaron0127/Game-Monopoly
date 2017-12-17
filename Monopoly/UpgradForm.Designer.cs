namespace Monopoly
{
    partial class UpgradForm
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
            this.UpgradBox = new System.Windows.Forms.TextBox();
            this.UpgradeButton = new System.Windows.Forms.Button();
            this.NotUpgradeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpgradBox
            // 
            this.UpgradBox.Location = new System.Drawing.Point(203, 37);
            this.UpgradBox.Multiline = true;
            this.UpgradBox.Name = "UpgradBox";
            this.UpgradBox.Size = new System.Drawing.Size(396, 152);
            this.UpgradBox.TabIndex = 0;
            // 
            // UpgradeButton
            // 
            this.UpgradeButton.Location = new System.Drawing.Point(87, 259);
            this.UpgradeButton.Name = "UpgradeButton";
            this.UpgradeButton.Size = new System.Drawing.Size(217, 65);
            this.UpgradeButton.TabIndex = 1;
            this.UpgradeButton.Text = "Upgrade";
            this.UpgradeButton.UseVisualStyleBackColor = true;
            this.UpgradeButton.Click += new System.EventHandler(this.UpgradeButton_Click);
            // 
            // NotUpgradeButton
            // 
            this.NotUpgradeButton.Location = new System.Drawing.Point(505, 259);
            this.NotUpgradeButton.Name = "NotUpgradeButton";
            this.NotUpgradeButton.Size = new System.Drawing.Size(217, 65);
            this.NotUpgradeButton.TabIndex = 2;
            this.NotUpgradeButton.Text = "Not Upgrade";
            this.NotUpgradeButton.UseVisualStyleBackColor = true;
            this.NotUpgradeButton.Click += new System.EventHandler(this.NotUpgradeButton_Click);
            // 
            // UpgradForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 448);
            this.Controls.Add(this.NotUpgradeButton);
            this.Controls.Add(this.UpgradeButton);
            this.Controls.Add(this.UpgradBox);
            this.Name = "UpgradForm";
            this.Text = "UpgradForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UpgradBox;
        private System.Windows.Forms.Button UpgradeButton;
        private System.Windows.Forms.Button NotUpgradeButton;
    }
}