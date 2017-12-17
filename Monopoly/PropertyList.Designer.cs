namespace Monopoly
{
    partial class PropertyList
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.propertyListP1 = new System.Windows.Forms.TextBox();
            this.propertyListP2 = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.propertyListP1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.propertyListP2, 1, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1554, 1095);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // propertyListP1
            // 
            this.propertyListP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyListP1.Location = new System.Drawing.Point(3, 3);
            this.propertyListP1.Multiline = true;
            this.propertyListP1.Name = "propertyListP1";
            this.propertyListP1.Size = new System.Drawing.Size(771, 1089);
            this.propertyListP1.TabIndex = 0;
            // 
            // propertyListP2
            // 
            this.propertyListP2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyListP2.Location = new System.Drawing.Point(780, 3);
            this.propertyListP2.Multiline = true;
            this.propertyListP2.Name = "propertyListP2";
            this.propertyListP2.Size = new System.Drawing.Size(771, 1089);
            this.propertyListP2.TabIndex = 1;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(691, 1113);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(195, 93);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // PropertyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1578, 1208);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "PropertyList";
            this.Text = "PropertyList";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TextBox propertyListP1;
        private System.Windows.Forms.TextBox propertyListP2;
        private System.Windows.Forms.Button closeButton;
    }
}