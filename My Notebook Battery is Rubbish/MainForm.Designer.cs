namespace MyNotebookBatteryisRubbish
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.start = new System.Windows.Forms.Button();
            this.statop = new System.Windows.Forms.ComboBox();
            this.actop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stuffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frc = new System.Windows.Forms.CheckBox();
            this.pert = new System.Windows.Forms.TextBox();
            this.perl = new System.Windows.Forms.Label();
            this.prvntsys = new System.Windows.Forms.RadioButton();
            this.prvntss = new System.Windows.Forms.RadioButton();
            this.allowss = new System.Windows.Forms.RadioButton();
            this.prvntscrn = new System.Windows.Forms.RadioButton();
            this.upd = new System.Windows.Forms.Timer(this.components);
            this.stat = new System.Windows.Forms.Label();
            this.wtsh = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(259, 79);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // statop
            // 
            this.statop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statop.FormattingEnabled = true;
            this.statop.Items.AddRange(new object[] {
            "Power Line Status : Offline",
            "Remaining In Battery Life"});
            this.statop.Location = new System.Drawing.Point(96, 27);
            this.statop.Name = "statop";
            this.statop.Size = new System.Drawing.Size(157, 21);
            this.statop.TabIndex = 1;
            this.statop.SelectedIndexChanged += new System.EventHandler(this.statop_SelectedIndexChanged);
            // 
            // actop
            // 
            this.actop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actop.FormattingEnabled = true;
            this.actop.Items.AddRange(new object[] {
            "Suspend",
            "Hibernate"});
            this.actop.Location = new System.Drawing.Point(96, 54);
            this.actop.Name = "actop";
            this.actop.Size = new System.Drawing.Size(157, 21);
            this.actop.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "When";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Make Windows";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stuffToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(394, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stuffToolStripMenuItem
            // 
            this.stuffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extraOptionsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.stuffToolStripMenuItem.Name = "stuffToolStripMenuItem";
            this.stuffToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.stuffToolStripMenuItem.Text = "Extra";
            // 
            // extraOptionsToolStripMenuItem
            // 
            this.extraOptionsToolStripMenuItem.Name = "extraOptionsToolStripMenuItem";
            this.extraOptionsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.extraOptionsToolStripMenuItem.Text = "Extra Options";
            this.extraOptionsToolStripMenuItem.Click += new System.EventHandler(this.extraOptionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // frc
            // 
            this.frc.AutoSize = true;
            this.frc.Location = new System.Drawing.Point(259, 56);
            this.frc.Name = "frc";
            this.frc.Size = new System.Drawing.Size(82, 17);
            this.frc.TabIndex = 6;
            this.frc.Text = "Force Mode";
            this.frc.UseVisualStyleBackColor = true;
            // 
            // pert
            // 
            this.pert.Location = new System.Drawing.Point(259, 27);
            this.pert.Name = "pert";
            this.pert.ReadOnly = true;
            this.pert.Size = new System.Drawing.Size(28, 20);
            this.pert.TabIndex = 7;
            this.pert.Visible = false;
            // 
            // perl
            // 
            this.perl.AutoSize = true;
            this.perl.Location = new System.Drawing.Point(287, 30);
            this.perl.Name = "perl";
            this.perl.Size = new System.Drawing.Size(18, 13);
            this.perl.TabIndex = 8;
            this.perl.Text = "%";
            this.perl.Visible = false;
            // 
            // prvntsys
            // 
            this.prvntsys.AutoSize = true;
            this.prvntsys.Location = new System.Drawing.Point(402, 36);
            this.prvntsys.Name = "prvntsys";
            this.prvntsys.Size = new System.Drawing.Size(155, 17);
            this.prvntsys.TabIndex = 11;
            this.prvntsys.Text = "Prevent System from Sleep";
            this.prvntsys.UseVisualStyleBackColor = true;
            this.prvntsys.CheckedChanged += new System.EventHandler(this.prvntsys_CheckedChanged);
            // 
            // prvntss
            // 
            this.prvntss.AutoSize = true;
            this.prvntss.Location = new System.Drawing.Point(402, 82);
            this.prvntss.Name = "prvntss";
            this.prvntss.Size = new System.Drawing.Size(212, 17);
            this.prvntss.TabIndex = 12;
            this.prvntss.Text = "Prevent System and Screen from Sleep";
            this.prvntss.UseVisualStyleBackColor = true;
            this.prvntss.CheckedChanged += new System.EventHandler(this.prvntss_CheckedChanged);
            // 
            // allowss
            // 
            this.allowss.AutoSize = true;
            this.allowss.Checked = true;
            this.allowss.Location = new System.Drawing.Point(402, 105);
            this.allowss.Name = "allowss";
            this.allowss.Size = new System.Drawing.Size(187, 17);
            this.allowss.TabIndex = 13;
            this.allowss.TabStop = true;
            this.allowss.Text = "Allow System and Screen to Sleep";
            this.allowss.UseVisualStyleBackColor = true;
            this.allowss.CheckedChanged += new System.EventHandler(this.allowss_CheckedChanged);
            // 
            // prvntscrn
            // 
            this.prvntscrn.AutoSize = true;
            this.prvntscrn.Location = new System.Drawing.Point(402, 59);
            this.prvntscrn.Name = "prvntscrn";
            this.prvntscrn.Size = new System.Drawing.Size(153, 17);
            this.prvntscrn.TabIndex = 14;
            this.prvntscrn.Text = "Prevent Screen from Sleep";
            this.prvntscrn.UseVisualStyleBackColor = true;
            this.prvntscrn.CheckedChanged += new System.EventHandler(this.prvntscrn_CheckedChanged);
            // 
            // upd
            // 
            this.upd.Enabled = true;
            this.upd.Interval = 1000;
            this.upd.Tick += new System.EventHandler(this.upd_Tick);
            // 
            // stat
            // 
            this.stat.AutoSize = true;
            this.stat.Location = new System.Drawing.Point(12, 129);
            this.stat.Name = "stat";
            this.stat.Size = new System.Drawing.Size(11, 13);
            this.stat.TabIndex = 15;
            this.stat.Text = "|";
            // 
            // wtsh
            // 
            this.wtsh.Interval = 1000;
            this.wtsh.Tick += new System.EventHandler(this.wtsh_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(15, 168);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(39, 31);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "My Notebook Battery is Rubbish";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mainf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 152);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.stat);
            this.Controls.Add(this.prvntscrn);
            this.Controls.Add(this.allowss);
            this.Controls.Add(this.prvntss);
            this.Controls.Add(this.prvntsys);
            this.Controls.Add(this.perl);
            this.Controls.Add(this.pert);
            this.Controls.Add(this.frc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.actop);
            this.Controls.Add(this.statop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "mainf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Notebook Battery is Rubbish";
            this.Resize += new System.EventHandler(this.mainf_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.ComboBox statop;
        private System.Windows.Forms.ComboBox actop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stuffToolStripMenuItem;
        private System.Windows.Forms.CheckBox frc;
        private System.Windows.Forms.TextBox pert;
        private System.Windows.Forms.Label perl;
        private System.Windows.Forms.RadioButton prvntsys;
        private System.Windows.Forms.RadioButton prvntss;
        private System.Windows.Forms.RadioButton allowss;
        private System.Windows.Forms.RadioButton prvntscrn;
        private System.Windows.Forms.Timer upd;
        private System.Windows.Forms.Label stat;
        private System.Windows.Forms.Timer wtsh;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem extraOptionsToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

