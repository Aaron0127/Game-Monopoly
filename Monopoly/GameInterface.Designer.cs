using System;

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
        /// 

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameInterface));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.plaeryName1 = new System.Windows.Forms.Label();
            this.Player1FundBox = new System.Windows.Forms.TextBox();
            this.plaeryName2 = new System.Windows.Forms.Label();
            this.Player2FundBox = new System.Windows.Forms.TextBox();
            this.stopMusicButton = new System.Windows.Forms.Button();
            this.rolledDice = new System.Windows.Forms.TextBox();
            this.rollDiceButton = new System.Windows.Forms.Button();
            this.endTurnButton = new System.Windows.Forms.Button();
            this.propertyButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.panelBoard = new System.Windows.Forms.Panel();
            this.Short = new System.Windows.Forms.Label();
            this.Pennsylva = new System.Windows.Forms.Label();
            this.North_Carolina = new System.Windows.Forms.Label();
            this.Pacific = new System.Windows.Forms.Label();
            this.Marvin = new System.Windows.Forms.Label();
            this.Ventinor = new System.Windows.Forms.Label();
            this.Water = new System.Windows.Forms.Label();
            this.Atlantic = new System.Windows.Forms.Label();
            this.BAndO = new System.Windows.Forms.Label();
            this.Illnois = new System.Windows.Forms.Label();
            this.Indiana = new System.Windows.Forms.Label();
            this.Kentucky = new System.Windows.Forms.Label();
            this.NewYork = new System.Windows.Forms.Label();
            this.Tennessee = new System.Windows.Forms.Label();
            this.ST_James = new System.Windows.Forms.Label();
            this.Pennsylvania = new System.Windows.Forms.Label();
            this.Oriental = new System.Windows.Forms.Label();
            this.Virginia = new System.Windows.Forms.Label();
            this.States = new System.Windows.Forms.Label();
            this.Electric = new System.Windows.Forms.Label();
            this.ST_Charles = new System.Windows.Forms.Label();
            this.Connecticut = new System.Windows.Forms.Label();
            this.Vermont = new System.Windows.Forms.Label();
            this.RailRoad = new System.Windows.Forms.Label();
            this.Baltic = new System.Windows.Forms.Label();
            this.Mediteranean = new System.Windows.Forms.Label();
            this.toolTipLabel = new System.Windows.Forms.ToolTip(this.components);
            this.Park_place = new System.Windows.Forms.Label();
            this.Boardwalk = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.Table.SuspendLayout();
            this.panelBoard.SuspendLayout();
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
            this.panelBoard.Controls.Add(this.Boardwalk);
            this.panelBoard.Controls.Add(this.Park_place);
            this.panelBoard.Controls.Add(this.Short);
            this.panelBoard.Controls.Add(this.Pennsylva);
            this.panelBoard.Controls.Add(this.North_Carolina);
            this.panelBoard.Controls.Add(this.Pacific);
            this.panelBoard.Controls.Add(this.Marvin);
            this.panelBoard.Controls.Add(this.Ventinor);
            this.panelBoard.Controls.Add(this.Water);
            this.panelBoard.Controls.Add(this.Atlantic);
            this.panelBoard.Controls.Add(this.BAndO);
            this.panelBoard.Controls.Add(this.Illnois);
            this.panelBoard.Controls.Add(this.Indiana);
            this.panelBoard.Controls.Add(this.Kentucky);
            this.panelBoard.Controls.Add(this.NewYork);
            this.panelBoard.Controls.Add(this.Tennessee);
            this.panelBoard.Controls.Add(this.ST_James);
            this.panelBoard.Controls.Add(this.Pennsylvania);
            this.panelBoard.Controls.Add(this.Oriental);
            this.panelBoard.Controls.Add(this.Virginia);
            this.panelBoard.Controls.Add(this.States);
            this.panelBoard.Controls.Add(this.Electric);
            this.panelBoard.Controls.Add(this.ST_Charles);
            this.panelBoard.Controls.Add(this.Connecticut);
            this.panelBoard.Controls.Add(this.Vermont);
            this.panelBoard.Controls.Add(this.RailRoad);
            this.panelBoard.Controls.Add(this.Baltic);
            this.panelBoard.Controls.Add(this.Mediteranean);
            this.panelBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBoard.Location = new System.Drawing.Point(25, 3);
            this.panelBoard.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(1516, 1353);
            this.panelBoard.TabIndex = 2;
            this.panelBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBoard_Paint);
            // 
            // Short
            // 
            this.Short.BackColor = System.Drawing.Color.Transparent;
            this.Short.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Short.Location = new System.Drawing.Point(1314, 624);
            this.Short.Name = "Short";
            this.Short.Size = new System.Drawing.Size(199, 108);
            this.Short.TabIndex = 12;
            this.Short.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Short.UseMnemonic = false;
            this.Short.MouseHover += new System.EventHandler(this.Short_MouseHover);
            // 
            // Pennsylva
            // 
            this.Pennsylva.BackColor = System.Drawing.Color.Transparent;
            this.Pennsylva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pennsylva.Location = new System.Drawing.Point(1320, 516);
            this.Pennsylva.Name = "Pennsylva";
            this.Pennsylva.Size = new System.Drawing.Size(199, 108);
            this.Pennsylva.TabIndex = 11;
            this.Pennsylva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Pennsylva.UseMnemonic = false;
            this.Pennsylva.MouseHover += new System.EventHandler(this.Pennsylva_MouseHover);
            // 
            // North_Carolina
            // 
            this.North_Carolina.BackColor = System.Drawing.Color.Transparent;
            this.North_Carolina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.North_Carolina.Location = new System.Drawing.Point(1314, 296);
            this.North_Carolina.Name = "North_Carolina";
            this.North_Carolina.Size = new System.Drawing.Size(199, 100);
            this.North_Carolina.TabIndex = 10;
            this.North_Carolina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.North_Carolina.UseMnemonic = false;
            this.North_Carolina.MouseHover += new System.EventHandler(this.North_Carolina_MouseHover);
            // 
            // Pacific
            // 
            this.Pacific.BackColor = System.Drawing.Color.Transparent;
            this.Pacific.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pacific.Location = new System.Drawing.Point(1314, 181);
            this.Pacific.Name = "Pacific";
            this.Pacific.Size = new System.Drawing.Size(199, 108);
            this.Pacific.TabIndex = 9;
            this.Pacific.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Pacific.UseMnemonic = false;
            this.Pacific.MouseHover += new System.EventHandler(this.Pacific_MouseHover);
            // 
            // Marvin
            // 
            this.Marvin.BackColor = System.Drawing.Color.Transparent;
            this.Marvin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Marvin.Location = new System.Drawing.Point(1191, 3);
            this.Marvin.Name = "Marvin";
            this.Marvin.Size = new System.Drawing.Size(116, 176);
            this.Marvin.TabIndex = 8;
            this.Marvin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Marvin.UseMnemonic = false;
            this.Marvin.MouseHover += new System.EventHandler(this.Marvin_MouseHover);
            // 
            // Ventinor
            // 
            this.Ventinor.BackColor = System.Drawing.Color.Transparent;
            this.Ventinor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ventinor.Location = new System.Drawing.Point(941, 6);
            this.Ventinor.Name = "Ventinor";
            this.Ventinor.Size = new System.Drawing.Size(116, 164);
            this.Ventinor.TabIndex = 7;
            this.Ventinor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Ventinor.UseMnemonic = false;
            this.Ventinor.MouseHover += new System.EventHandler(this.Ventinor_MouseHover);
            // 
            // Water
            // 
            this.Water.BackColor = System.Drawing.Color.Transparent;
            this.Water.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Water.Location = new System.Drawing.Point(1063, 6);
            this.Water.Name = "Water";
            this.Water.Size = new System.Drawing.Size(116, 164);
            this.Water.TabIndex = 6;
            this.Water.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Water.UseMnemonic = false;
            this.Water.MouseHover += new System.EventHandler(this.Water_MouseHover);
            // 
            // Atlantic
            // 
            this.Atlantic.BackColor = System.Drawing.Color.Transparent;
            this.Atlantic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Atlantic.Location = new System.Drawing.Point(819, 6);
            this.Atlantic.Name = "Atlantic";
            this.Atlantic.Size = new System.Drawing.Size(116, 164);
            this.Atlantic.TabIndex = 6;
            this.Atlantic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Atlantic.UseMnemonic = false;
            this.Atlantic.MouseHover += new System.EventHandler(this.Atlantic_MouseHover);
            // 
            // BAndO
            // 
            this.BAndO.BackColor = System.Drawing.Color.Transparent;
            this.BAndO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAndO.Location = new System.Drawing.Point(697, 6);
            this.BAndO.Name = "BAndO";
            this.BAndO.Size = new System.Drawing.Size(116, 164);
            this.BAndO.TabIndex = 5;
            this.BAndO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BAndO.UseMnemonic = false;
            this.BAndO.MouseHover += new System.EventHandler(this.BAndO_MouseHover);
            // 
            // Illnois
            // 
            this.Illnois.BackColor = System.Drawing.Color.Transparent;
            this.Illnois.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Illnois.Location = new System.Drawing.Point(575, 6);
            this.Illnois.Name = "Illnois";
            this.Illnois.Size = new System.Drawing.Size(116, 164);
            this.Illnois.TabIndex = 4;
            this.Illnois.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Illnois.UseMnemonic = false;
            this.Illnois.MouseHover += new System.EventHandler(this.Illnois_MouseHover);
            // 
            // Indiana
            // 
            this.Indiana.BackColor = System.Drawing.Color.Transparent;
            this.Indiana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Indiana.Location = new System.Drawing.Point(452, 6);
            this.Indiana.Name = "Indiana";
            this.Indiana.Size = new System.Drawing.Size(116, 164);
            this.Indiana.TabIndex = 3;
            this.Indiana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Indiana.UseMnemonic = false;
            this.Indiana.MouseHover += new System.EventHandler(this.Indiana_MouseHover);
            // 
            // Kentucky
            // 
            this.Kentucky.BackColor = System.Drawing.Color.Transparent;
            this.Kentucky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kentucky.Location = new System.Drawing.Point(215, 6);
            this.Kentucky.Name = "Kentucky";
            this.Kentucky.Size = new System.Drawing.Size(116, 164);
            this.Kentucky.TabIndex = 2;
            this.Kentucky.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Kentucky.UseMnemonic = false;
            this.Kentucky.MouseHover += new System.EventHandler(this.Kentucky_MouseHover);
            // 
            // NewYork
            // 
            this.NewYork.BackColor = System.Drawing.Color.Transparent;
            this.NewYork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewYork.Location = new System.Drawing.Point(6, 181);
            this.NewYork.Name = "NewYork";
            this.NewYork.Size = new System.Drawing.Size(199, 100);
            this.NewYork.TabIndex = 2;
            this.NewYork.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NewYork.UseMnemonic = false;
            this.NewYork.MouseHover += new System.EventHandler(this.NewYork_MouseHover);
            // 
            // Tennessee
            // 
            this.Tennessee.BackColor = System.Drawing.Color.Transparent;
            this.Tennessee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tennessee.Location = new System.Drawing.Point(3, 296);
            this.Tennessee.Name = "Tennessee";
            this.Tennessee.Size = new System.Drawing.Size(199, 100);
            this.Tennessee.TabIndex = 2;
            this.Tennessee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tennessee.UseMnemonic = false;
            this.Tennessee.MouseHover += new System.EventHandler(this.Tennessee_MouseHover);
            // 
            // ST_James
            // 
            this.ST_James.BackColor = System.Drawing.Color.Transparent;
            this.ST_James.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ST_James.Location = new System.Drawing.Point(6, 524);
            this.ST_James.Name = "ST_James";
            this.ST_James.Size = new System.Drawing.Size(199, 100);
            this.ST_James.TabIndex = 2;
            this.ST_James.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ST_James.UseMnemonic = false;
            this.ST_James.MouseHover += new System.EventHandler(this.ST_James_MouseHover);
            // 
            // Pennsylvania
            // 
            this.Pennsylvania.BackColor = System.Drawing.Color.Transparent;
            this.Pennsylvania.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pennsylvania.Location = new System.Drawing.Point(6, 624);
            this.Pennsylvania.Name = "Pennsylvania";
            this.Pennsylvania.Size = new System.Drawing.Size(199, 100);
            this.Pennsylvania.TabIndex = 1;
            this.Pennsylvania.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Pennsylvania.UseMnemonic = false;
            this.Pennsylvania.MouseHover += new System.EventHandler(this.Pennsylvania_MouseHover);
            // 
            // Oriental
            // 
            this.Oriental.BackColor = System.Drawing.Color.Transparent;
            this.Oriental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Oriental.Location = new System.Drawing.Point(579, 1175);
            this.Oriental.Name = "Oriental";
            this.Oriental.Size = new System.Drawing.Size(112, 178);
            this.Oriental.TabIndex = 0;
            this.Oriental.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Oriental.UseMnemonic = false;
            this.Oriental.MouseHover += new System.EventHandler(this.Oriental_MouseHover);
            // 
            // Virginia
            // 
            this.Virginia.BackColor = System.Drawing.Color.Transparent;
            this.Virginia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Virginia.Location = new System.Drawing.Point(-6, 735);
            this.Virginia.Name = "Virginia";
            this.Virginia.Size = new System.Drawing.Size(199, 100);
            this.Virginia.TabIndex = 0;
            this.Virginia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Virginia.UseMnemonic = false;
            this.Virginia.MouseHover += new System.EventHandler(this.Virginia_MouseHover);
            // 
            // States
            // 
            this.States.BackColor = System.Drawing.Color.Transparent;
            this.States.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.States.Location = new System.Drawing.Point(-6, 846);
            this.States.Name = "States";
            this.States.Size = new System.Drawing.Size(199, 100);
            this.States.TabIndex = 0;
            this.States.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.States.UseMnemonic = false;
            this.States.MouseHover += new System.EventHandler(this.States_MouseHover);
            // 
            // Electric
            // 
            this.Electric.BackColor = System.Drawing.Color.Transparent;
            this.Electric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Electric.Location = new System.Drawing.Point(3, 964);
            this.Electric.Name = "Electric";
            this.Electric.Size = new System.Drawing.Size(199, 100);
            this.Electric.TabIndex = 0;
            this.Electric.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Electric.UseMnemonic = false;
            this.Electric.MouseHover += new System.EventHandler(this.Electric_MouseHover);
            // 
            // ST_Charles
            // 
            this.ST_Charles.BackColor = System.Drawing.Color.Transparent;
            this.ST_Charles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ST_Charles.Location = new System.Drawing.Point(6, 1064);
            this.ST_Charles.Name = "ST_Charles";
            this.ST_Charles.Size = new System.Drawing.Size(199, 100);
            this.ST_Charles.TabIndex = 0;
            this.ST_Charles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ST_Charles.UseMnemonic = false;
            this.ST_Charles.MouseHover += new System.EventHandler(this.ST_Charles_MouseHover);
            // 
            // Connecticut
            // 
            this.Connecticut.BackColor = System.Drawing.Color.Transparent;
            this.Connecticut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Connecticut.Location = new System.Drawing.Point(209, 1175);
            this.Connecticut.Name = "Connecticut";
            this.Connecticut.Size = new System.Drawing.Size(122, 178);
            this.Connecticut.TabIndex = 0;
            this.Connecticut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Connecticut.UseMnemonic = false;
            this.Connecticut.MouseHover += new System.EventHandler(this.Connecticut_MouseHover);
            // 
            // Vermont
            // 
            this.Vermont.BackColor = System.Drawing.Color.Transparent;
            this.Vermont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vermont.Location = new System.Drawing.Point(337, 1175);
            this.Vermont.Name = "Vermont";
            this.Vermont.Size = new System.Drawing.Size(112, 178);
            this.Vermont.TabIndex = 0;
            this.Vermont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Vermont.UseMnemonic = false;
            this.Vermont.MouseHover += new System.EventHandler(this.Vermont_MouseHover);
            // 
            // RailRoad
            // 
            this.RailRoad.BackColor = System.Drawing.Color.Transparent;
            this.RailRoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RailRoad.Location = new System.Drawing.Point(711, 1178);
            this.RailRoad.Name = "RailRoad";
            this.RailRoad.Size = new System.Drawing.Size(112, 178);
            this.RailRoad.TabIndex = 0;
            this.RailRoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RailRoad.UseMnemonic = false;
            this.RailRoad.MouseHover += new System.EventHandler(this.RailRoad_MouseHover);
            // 
            // Baltic
            // 
            this.Baltic.BackColor = System.Drawing.Color.Transparent;
            this.Baltic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Baltic.Location = new System.Drawing.Point(955, 1175);
            this.Baltic.Name = "Baltic";
            this.Baltic.Size = new System.Drawing.Size(112, 178);
            this.Baltic.TabIndex = 0;
            this.Baltic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Baltic.UseMnemonic = false;
            this.Baltic.MouseHover += new System.EventHandler(this.Baltic_MouseHover);
            // 
            // Mediteranean
            // 
            this.Mediteranean.BackColor = System.Drawing.Color.Transparent;
            this.Mediteranean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mediteranean.Location = new System.Drawing.Point(1191, 1175);
            this.Mediteranean.Name = "Mediteranean";
            this.Mediteranean.Size = new System.Drawing.Size(112, 178);
            this.Mediteranean.TabIndex = 0;
            this.Mediteranean.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Mediteranean.UseMnemonic = false;
            this.Mediteranean.MouseHover += new System.EventHandler(this.Mediteranean_MouseHover);
            // 
            // Park_place
            // 
            this.Park_place.BackColor = System.Drawing.Color.Transparent;
            this.Park_place.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Park_place.Location = new System.Drawing.Point(1314, 850);
            this.Park_place.Name = "Park_place";
            this.Park_place.Size = new System.Drawing.Size(199, 108);
            this.Park_place.TabIndex = 13;
            this.Park_place.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Park_place.UseMnemonic = false;
            this.Park_place.MouseHover += new System.EventHandler(this.Park_place_MouseHover);
            // 
            // Boardwalk
            // 
            this.Boardwalk.BackColor = System.Drawing.Color.Transparent;
            this.Boardwalk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boardwalk.Location = new System.Drawing.Point(1314, 1060);
            this.Boardwalk.Name = "Boardwalk";
            this.Boardwalk.Size = new System.Drawing.Size(199, 108);
            this.Boardwalk.TabIndex = 14;
            this.Boardwalk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Boardwalk.UseMnemonic = false;
            this.Boardwalk.MouseHover += new System.EventHandler(this.Boardwalk_MouseHover);
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
            this.Text = "Monopoly";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.Table.ResumeLayout(false);
            this.panelBoard.ResumeLayout(false);
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
        private System.Windows.Forms.Label Mediteranean;
        private System.Windows.Forms.ToolTip toolTipLabel;
        private System.Windows.Forms.Label Baltic;
        private System.Windows.Forms.Label Oriental;
        private System.Windows.Forms.Label Connecticut;
        private System.Windows.Forms.Label Vermont;
        private System.Windows.Forms.Label RailRoad;
        private System.Windows.Forms.Label Electric;
        private System.Windows.Forms.Label ST_Charles;
        private System.Windows.Forms.Label Virginia;
        private System.Windows.Forms.Label States;
        private System.Windows.Forms.Label Pennsylvania;
        private System.Windows.Forms.Label NewYork;
        private System.Windows.Forms.Label Tennessee;
        private System.Windows.Forms.Label ST_James;
        private System.Windows.Forms.Label Kentucky;
        private System.Windows.Forms.Label Illnois;
        private System.Windows.Forms.Label Indiana;
        private System.Windows.Forms.Label Ventinor;
        private System.Windows.Forms.Label Water;
        private System.Windows.Forms.Label Atlantic;
        private System.Windows.Forms.Label BAndO;
        private System.Windows.Forms.Label Marvin;
        private System.Windows.Forms.Label Pacific;
        private System.Windows.Forms.Label Short;
        private System.Windows.Forms.Label Pennsylva;
        private System.Windows.Forms.Label North_Carolina;
        private System.Windows.Forms.Label Boardwalk;
        private System.Windows.Forms.Label Park_place;
    }
}