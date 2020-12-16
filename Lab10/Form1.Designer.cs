namespace Lab10
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.akcjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTARTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rESETUJToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zAKOŃCZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.randomFrom = new System.Windows.Forms.TextBox();
            this.randomTo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RandomNumberLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberGuess = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.greenBox1 = new System.Windows.Forms.PictureBox();
            this.greenBox2 = new System.Windows.Forms.PictureBox();
            this.greenBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.greenBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.akcjaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(426, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // akcjaToolStripMenuItem
            // 
            this.akcjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTARTToolStripMenuItem,
            this.rESETUJToolStripMenuItem,
            this.zAKOŃCZToolStripMenuItem});
            this.akcjaToolStripMenuItem.Name = "akcjaToolStripMenuItem";
            this.akcjaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.akcjaToolStripMenuItem.Text = "Akcja";
            // 
            // sTARTToolStripMenuItem
            // 
            this.sTARTToolStripMenuItem.Name = "sTARTToolStripMenuItem";
            this.sTARTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sTARTToolStripMenuItem.Text = "START";
            this.sTARTToolStripMenuItem.Click += new System.EventHandler(this.sTARTToolStripMenuItem_Click);
            // 
            // rESETUJToolStripMenuItem
            // 
            this.rESETUJToolStripMenuItem.Name = "rESETUJToolStripMenuItem";
            this.rESETUJToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rESETUJToolStripMenuItem.Text = "RESETUJ";
            this.rESETUJToolStripMenuItem.Click += new System.EventHandler(this.rESETUJToolStripMenuItem_Click);
            // 
            // zAKOŃCZToolStripMenuItem
            // 
            this.zAKOŃCZToolStripMenuItem.Name = "zAKOŃCZToolStripMenuItem";
            this.zAKOŃCZToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zAKOŃCZToolStripMenuItem.Text = "ZAKOŃCZ";
            this.zAKOŃCZToolStripMenuItem.Click += new System.EventHandler(this.zAKOŃCZToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.randomTo);
            this.panel1.Controls.Add(this.randomFrom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 97);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj przedzial zgadywanych liczb";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // randomFrom
            // 
            this.randomFrom.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.randomFrom.Location = new System.Drawing.Point(241, 46);
            this.randomFrom.Name = "randomFrom";
            this.randomFrom.Size = new System.Drawing.Size(71, 20);
            this.randomFrom.TabIndex = 1;
            this.randomFrom.Text = "1";
            this.randomFrom.TextChanged += new System.EventHandler(this.randomFrom_TextChanged);
            // 
            // randomTo
            // 
            this.randomTo.Location = new System.Drawing.Point(331, 46);
            this.randomTo.Name = "randomTo";
            this.randomTo.Size = new System.Drawing.Size(71, 20);
            this.randomTo.TabIndex = 2;
            this.randomTo.Text = "10";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.greenBox3);
            this.panel2.Controls.Add(this.greenBox2);
            this.panel2.Controls.Add(this.greenBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.numberGuess);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.RandomNumberLabel);
            this.panel2.Location = new System.Drawing.Point(5, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 163);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            // 
            // RandomNumberLabel
            // 
            this.RandomNumberLabel.AutoSize = true;
            this.RandomNumberLabel.Location = new System.Drawing.Point(116, 26);
            this.RandomNumberLabel.Name = "RandomNumberLabel";
            this.RandomNumberLabel.Size = new System.Drawing.Size(151, 13);
            this.RandomNumberLabel.TabIndex = 0;
            this.RandomNumberLabel.Text = "Zgadywana liczba z przedzialu";
            this.RandomNumberLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Wpisz liczbe";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numberGuess
            // 
            this.numberGuess.Location = new System.Drawing.Point(141, 82);
            this.numberGuess.Name = "numberGuess";
            this.numberGuess.Size = new System.Drawing.Size(100, 20);
            this.numberGuess.TabIndex = 2;
            this.numberGuess.TextChanged += new System.EventHandler(this.numberGuess_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sprawdz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Liczba szans";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // greenBox1
            // 
            this.greenBox1.BackColor = System.Drawing.Color.Green;
            this.greenBox1.Location = new System.Drawing.Point(141, 123);
            this.greenBox1.Name = "greenBox1";
            this.greenBox1.Size = new System.Drawing.Size(28, 23);
            this.greenBox1.TabIndex = 5;
            this.greenBox1.TabStop = false;
            // 
            // greenBox2
            // 
            this.greenBox2.BackColor = System.Drawing.Color.Green;
            this.greenBox2.Location = new System.Drawing.Point(184, 123);
            this.greenBox2.Name = "greenBox2";
            this.greenBox2.Size = new System.Drawing.Size(28, 23);
            this.greenBox2.TabIndex = 6;
            this.greenBox2.TabStop = false;
            // 
            // greenBox3
            // 
            this.greenBox3.BackColor = System.Drawing.Color.Green;
            this.greenBox3.Location = new System.Drawing.Point(227, 123);
            this.greenBox3.Name = "greenBox3";
            this.greenBox3.Size = new System.Drawing.Size(28, 23);
            this.greenBox3.TabIndex = 7;
            this.greenBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 214);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sebastian Ziolkowski";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.greenBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem akcjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTARTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rESETUJToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zAKOŃCZToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox randomTo;
        private System.Windows.Forms.TextBox randomFrom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label RandomNumberLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox numberGuess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox greenBox3;
        private System.Windows.Forms.PictureBox greenBox2;
        private System.Windows.Forms.PictureBox greenBox1;
    }
}

