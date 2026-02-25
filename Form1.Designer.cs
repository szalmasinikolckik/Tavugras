namespace Tavugras_FanniNikol
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.cityFilter = new System.Windows.Forms.TextBox();
            this.winnerCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.validJumpLabel = new System.Windows.Forms.Label();
            this.averageDistanceLabel = new System.Windows.Forms.Label();
            this.largestDistanceLabel = new System.Windows.Forms.Label();
            this.radioGroupBox = new System.Windows.Forms.GroupBox();
            this.averageDistanceRadio = new System.Windows.Forms.RadioButton();
            this.largestDistanceRadio = new System.Windows.Forms.RadioButton();
            this.addButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winnerCount)).BeginInit();
            this.panel1.SuspendLayout();
            this.radioGroupBox.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameBox.Location = new System.Drawing.Point(74, 61);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(157, 26);
            this.nameBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameLabel.Location = new System.Drawing.Point(17, 64);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(40, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Név:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(17, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Város:";
            // 
            // cityBox
            // 
            this.cityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cityBox.Location = new System.Drawing.Point(74, 105);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(157, 26);
            this.cityBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(17, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Eredmények";
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.resultBox.Location = new System.Drawing.Point(21, 181);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(210, 26);
            this.resultBox.TabIndex = 5;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(47, 33);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(215, 212);
            this.listBox.TabIndex = 6;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.winnerCount);
            this.groupBox.Controls.Add(this.cityFilter);
            this.groupBox.Controls.Add(this.listBox);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox.Location = new System.Drawing.Point(480, 75);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(299, 363);
            this.groupBox.TabIndex = 7;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Versenyzők adatai";
            // 
            // cityFilter
            // 
            this.cityFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cityFilter.Location = new System.Drawing.Point(170, 269);
            this.cityFilter.Name = "cityFilter";
            this.cityFilter.Size = new System.Drawing.Size(118, 26);
            this.cityFilter.TabIndex = 7;
            this.cityFilter.TextChanged += new System.EventHandler(this.cityFilter_TextChanged);
            // 
            // winnerCount
            // 
            this.winnerCount.Location = new System.Drawing.Point(170, 317);
            this.winnerCount.Name = "winnerCount";
            this.winnerCount.Size = new System.Drawing.Size(118, 23);
            this.winnerCount.TabIndex = 8;
            this.winnerCount.ValueChanged += new System.EventHandler(this.winnerCount_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(43, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Szűrés (Város):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(23, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Díjazottak száma:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.largestDistanceLabel);
            this.panel1.Controls.Add(this.averageDistanceLabel);
            this.panel1.Controls.Add(this.validJumpLabel);
            this.panel1.Location = new System.Drawing.Point(21, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 169);
            this.panel1.TabIndex = 8;
            // 
            // validJumpLabel
            // 
            this.validJumpLabel.AutoSize = true;
            this.validJumpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.validJumpLabel.Location = new System.Drawing.Point(20, 31);
            this.validJumpLabel.Name = "validJumpLabel";
            this.validJumpLabel.Size = new System.Drawing.Size(190, 20);
            this.validJumpLabel.TabIndex = 5;
            this.validJumpLabel.Text = "Érvényes ugrások száma:";
            // 
            // averageDistanceLabel
            // 
            this.averageDistanceLabel.AutoSize = true;
            this.averageDistanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.averageDistanceLabel.Location = new System.Drawing.Point(20, 75);
            this.averageDistanceLabel.Name = "averageDistanceLabel";
            this.averageDistanceLabel.Size = new System.Drawing.Size(130, 20);
            this.averageDistanceLabel.TabIndex = 6;
            this.averageDistanceLabel.Text = "Átlagos távolság:";
            // 
            // largestDistanceLabel
            // 
            this.largestDistanceLabel.AutoSize = true;
            this.largestDistanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.largestDistanceLabel.Location = new System.Drawing.Point(20, 111);
            this.largestDistanceLabel.Name = "largestDistanceLabel";
            this.largestDistanceLabel.Size = new System.Drawing.Size(164, 20);
            this.largestDistanceLabel.TabIndex = 7;
            this.largestDistanceLabel.Text = "Legnagyobb távolság:";
            // 
            // radioGroupBox
            // 
            this.radioGroupBox.Controls.Add(this.largestDistanceRadio);
            this.radioGroupBox.Controls.Add(this.averageDistanceRadio);
            this.radioGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioGroupBox.Location = new System.Drawing.Point(249, 89);
            this.radioGroupBox.Name = "radioGroupBox";
            this.radioGroupBox.Size = new System.Drawing.Size(213, 151);
            this.radioGroupBox.TabIndex = 9;
            this.radioGroupBox.TabStop = false;
            this.radioGroupBox.Text = "Toplista";
            // 
            // averageDistanceRadio
            // 
            this.averageDistanceRadio.AutoSize = true;
            this.averageDistanceRadio.Location = new System.Drawing.Point(16, 37);
            this.averageDistanceRadio.Name = "averageDistanceRadio";
            this.averageDistanceRadio.Size = new System.Drawing.Size(146, 21);
            this.averageDistanceRadio.TabIndex = 0;
            this.averageDistanceRadio.TabStop = true;
            this.averageDistanceRadio.Text = "Átlagos táv alapján";
            this.averageDistanceRadio.UseVisualStyleBackColor = true;
            // 
            // largestDistanceRadio
            // 
            this.largestDistanceRadio.AutoSize = true;
            this.largestDistanceRadio.Location = new System.Drawing.Point(16, 83);
            this.largestDistanceRadio.Name = "largestDistanceRadio";
            this.largestDistanceRadio.Size = new System.Drawing.Size(178, 21);
            this.largestDistanceRadio.TabIndex = 1;
            this.largestDistanceRadio.TabStop = true;
            this.largestDistanceRadio.Text = "Legnagyobb táv alapján";
            this.largestDistanceRadio.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addButton.Location = new System.Drawing.Point(21, 224);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(79, 28);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Rögzítés";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 11;
            this.menuStrip.Text = "Fájl";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.radioGroupBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winnerCount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.radioGroupBox.ResumeLayout(false);
            this.radioGroupBox.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.NumericUpDown winnerCount;
        private System.Windows.Forms.TextBox cityFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label largestDistanceLabel;
        private System.Windows.Forms.Label averageDistanceLabel;
        private System.Windows.Forms.Label validJumpLabel;
        private System.Windows.Forms.GroupBox radioGroupBox;
        private System.Windows.Forms.RadioButton largestDistanceRadio;
        private System.Windows.Forms.RadioButton averageDistanceRadio;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

