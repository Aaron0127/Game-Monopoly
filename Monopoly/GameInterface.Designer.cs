namespace Monopoly
{
    partial class GameInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameInterface));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.plaeryName1 = new System.Windows.Forms.Label();
            this.Player1FundBox = new System.Windows.Forms.TextBox();
            this.plaeryName2 = new System.Windows.Forms.Label();
            this.Player2FundBox = new System.Windows.Forms.TextBox();
            this.rolledDice = new System.Windows.Forms.TextBox();
            this.rollDiceButton = new System.Windows.Forms.Button();
            this.endTurnButton = new System.Windows.Forms.Button();
            this.propertyButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.panelBoard = new System.Windows.Forms.Panel();
            this.stopMusicButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.Table.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.plaeryName1);
            this.flowLayoutPanel1.Controls.Add(this.Player1FundBox);
            this.flowLayoutPanel1.Controls.Add(this.plaeryName2);
            this.flowLayoutPanel1.Controls.Add(this.Player2FundBox);
            this.flowLayoutPanel1.Controls.Add(this.stopMusicButton);
            this.flowLayoutPanel1.Controls.Add(this.rolledDice);
            this.flowLayoutPanel1.Controls.Add(this.rollDiceButton);
            this.flowLayoutPanel1.Controls.Add(this.endTurnButton);
            this.flowLayoutPanel1.Controls.Add(this.propertyButton);
            this.flowLayoutPanel1.Controls.Add(this.saveButton);
            this.flowLayoutPanel1.Controls.Add(this.quitButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1547, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(449, 1353);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // plaeryName1
            // 
            this.plaeryName1.AutoSize = true;
            this.plaeryName1.Location = new System.Drawing.Point(3, 0);
            this.plaeryName1.Margin = new System.Windows.Forms.Padding(3, 0, 18, 0);
            this.plaeryName1.Name = "plaeryName1";
            this.plaeryName1.Size = new System.Drawing.Size(116, 32);
            this.plaeryName1.TabIndex = 7;
            this.plaeryName1.Text = "player 1";
            // 
            // Player1FundBox
            // 
            this.Player1FundBox.Enabled = false;
            this.Player1FundBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1FundBox.Location = new System.Drawing.Point(140, 3);
            this.Player1FundBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Player1FundBox.Name = "Player1FundBox";
            this.Player1FundBox.Size = new System.Drawing.Size(276, 38);
            this.Player1FundBox.TabIndex = 4;
            // 
            // plaeryName2
            // 
            this.plaeryName2.AutoSize = true;
            this.plaeryName2.Location = new System.Drawing.Point(3, 41);
            this.plaeryName2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.plaeryName2.Name = "plaeryName2";
            this.plaeryName2.Size = new System.Drawing.Size(116, 32);
            this.plaeryName2.TabIndex = 8;
            this.plaeryName2.Text = "player 2";
            // 
            // Player2FundBox
            // 
            this.Player2FundBox.Enabled = false;
            this.Player2FundBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2FundBox.Location = new System.Drawing.Point(142, 44);
            this.Player2FundBox.Margin = new System.Windows.Forms.Padding(23, 3, 3, 0);
            this.Player2FundBox.Name = "Player2FundBox";
            this.Player2FundBox.Size = new System.Drawing.Size(274, 38);
            this.Player2FundBox.TabIndex = 5;
            // 
            // rolledDice
            // 
            this.rolledDice.AcceptsReturn = true;
            this.rolledDice.Location = new System.Drawing.Point(3, 136);
            this.rolledDice.Multiline = true;
            this.rolledDice.Name = "rolledDice";
            this.rolledDice.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rolledDice.Size = new System.Drawing.Size(450, 564);
            this.rolledDice.TabIndex = 0;
            // 
            // rollDiceButton
            // 
            this.rollDiceButton.Location = new System.Drawing.Point(3, 735);
            this.rollDiceButton.Margin = new System.Windows.Forms.Padding(3, 32, 3, 3);
            this.rollDiceButton.Name = "rollDiceButton";
            this.rollDiceButton.Size = new System.Drawing.Size(446, 100);
            this.rollDiceButton.TabIndex = 1;
            this.rollDiceButton.Text = "Draw Dice";
            this.rollDiceButton.UseVisualStyleBackColor = true;
            this.rollDiceButton.Click += new System.EventHandler(this.rollDiceButton_Click);
            // 
            // endTurnButton
            // 
            this.endTurnButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.endTurnButton.AutoSize = true;
            this.endTurnButton.Location = new System.Drawing.Point(3, 858);
            this.endTurnButton.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.endTurnButton.Name = "endTurnButton";
            this.endTurnButton.Size = new System.Drawing.Size(446, 100);
            this.endTurnButton.TabIndex = 2;
            this.endTurnButton.Text = "End Turn";
            this.endTurnButton.UseVisualStyleBackColor = true;
            this.endTurnButton.Click += new System.EventHandler(this.endTurnButton_Click);
            // 
            // propertyButton
            // 
            this.propertyButton.Location = new System.Drawing.Point(3, 981);
            this.propertyButton.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.propertyButton.Name = "propertyButton";
            this.propertyButton.Size = new System.Drawing.Size(446, 100);
            this.propertyButton.TabIndex = 6;
            this.propertyButton.Text = "Property Management";
            this.propertyButton.UseVisualStyleBackColor = true;
            this.propertyButton.Click += new System.EventHandler(this.propertyButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(3, 1104);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(450, 100);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quitButton.AutoSize = true;
            this.quitButton.Location = new System.Drawing.Point(3, 1227);
            this.quitButton.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(446, 100);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // Table
            // 
            this.Table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Table.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Table.ColumnCount = 2;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.27273F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.Table.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.Table.Controls.Add(this.panelBoard, 0, 0);
            this.Table.Location = new System.Drawing.Point(-19, 0);
            this.Table.Name = "Table";
            this.Table.RowCount = 1;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1359F));
            this.Table.Size = new System.Drawing.Size(1999, 1359);
            this.Table.TabIndex = 0;
            // 
            // panelBoard
            // 
            this.panelBoard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBoard.BackgroundImage")));
            this.panelBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBoard.Location = new System.Drawing.Point(25, 3);
            this.panelBoard.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(1516, 1353);
            this.panelBoard.TabIndex = 2;
            this.panelBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBoard_Paint);
            this.panelBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBoard_MouseDown);
            this.panelBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBoard_MouseMove);
            // 
            // stopMusicButton
            // 
            this.stopMusicButton.Location = new System.Drawing.Point(3, 85);
            this.stopMusicButton.Name = "stopMusicButton";
            this.stopMusicButton.Size = new System.Drawing.Size(221, 45);
            this.stopMusicButton.TabIndex = 10;
            this.stopMusicButton.Text = "Stop Music";
            this.stopMusicButton.UseVisualStyleBackColor = true;
            this.stopMusicButton.Click += new System.EventHandler(this.stopMusicButton_Click);
            // 
            // GameInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(2040, 1398);
            this.Controls.Add(this.Table);
            this.Name = "GameInterface";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "GameInterface";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.Table.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel Table;
        private System.Windows.Forms.TextBox rolledDice;
        private System.Windows.Forms.Button rollDiceButton;
        private System.Windows.Forms.Button endTurnButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Panel panelBoard;
        private System.Windows.Forms.TextBox Player1FundBox;
        private System.Windows.Forms.TextBox Player2FundBox;
        private System.Windows.Forms.Label plaeryName1;
        private System.Windows.Forms.Label plaeryName2;
        private System.Windows.Forms.Button propertyButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button stopMusicButton;
    }
}