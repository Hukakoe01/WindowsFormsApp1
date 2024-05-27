namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.вашаВалютаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рубльToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.долорToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.евроToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.белорусскийРубльToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.сколькоУВасВалютыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.вКакуюПеревестиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рубльToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.долорToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.евроToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.белоруссToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "посчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вашаВалютаToolStripMenuItem,
            this.сколькоУВасВалютыToolStripMenuItem,
            this.вКакуюПеревестиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(968, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // вашаВалютаToolStripMenuItem
            // 
            this.вашаВалютаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рубльToolStripMenuItem,
            this.долорToolStripMenuItem,
            this.евроToolStripMenuItem,
            this.белорусскийРубльToolStripMenuItem,
            this.toolStripTextBox2});
            this.вашаВалютаToolStripMenuItem.Name = "вашаВалютаToolStripMenuItem";
            this.вашаВалютаToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.вашаВалютаToolStripMenuItem.Text = "ваша валюта";
            // 
            // рубльToolStripMenuItem
            // 
            this.рубльToolStripMenuItem.Name = "рубльToolStripMenuItem";
            this.рубльToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.рубльToolStripMenuItem.Text = "рубль";
            this.рубльToolStripMenuItem.Click += new System.EventHandler(this.рубльToolStripMenuItem_Click);
            // 
            // долорToolStripMenuItem
            // 
            this.долорToolStripMenuItem.Name = "долорToolStripMenuItem";
            this.долорToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.долорToolStripMenuItem.Text = "долор";
            this.долорToolStripMenuItem.Click += new System.EventHandler(this.долорToolStripMenuItem_Click);
            // 
            // евроToolStripMenuItem
            // 
            this.евроToolStripMenuItem.Name = "евроToolStripMenuItem";
            this.евроToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.евроToolStripMenuItem.Text = "евро";
            this.евроToolStripMenuItem.Click += new System.EventHandler(this.евроToolStripMenuItem_Click);
            // 
            // белорусскийРубльToolStripMenuItem
            // 
            this.белорусскийРубльToolStripMenuItem.Name = "белорусскийРубльToolStripMenuItem";
            this.белорусскийРубльToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.белорусскийРубльToolStripMenuItem.Text = "крипта";
            this.белорусскийРубльToolStripMenuItem.Click += new System.EventHandler(this.белорусскийРубльToolStripMenuItem_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            // 
            // сколькоУВасВалютыToolStripMenuItem
            // 
            this.сколькоУВасВалютыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.сколькоУВасВалютыToolStripMenuItem.Name = "сколькоУВасВалютыToolStripMenuItem";
            this.сколькоУВасВалютыToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.сколькоУВасВалютыToolStripMenuItem.Text = "сколько у вас валюты";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // вКакуюПеревестиToolStripMenuItem
            // 
            this.вКакуюПеревестиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рубльToolStripMenuItem1,
            this.долорToolStripMenuItem1,
            this.евроToolStripMenuItem1,
            this.белоруссToolStripMenuItem,
            this.toolStripTextBox3});
            this.вКакуюПеревестиToolStripMenuItem.Name = "вКакуюПеревестиToolStripMenuItem";
            this.вКакуюПеревестиToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.вКакуюПеревестиToolStripMenuItem.Text = "в какую перевести";
            // 
            // рубльToolStripMenuItem1
            // 
            this.рубльToolStripMenuItem1.Name = "рубльToolStripMenuItem1";
            this.рубльToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.рубльToolStripMenuItem1.Text = "рубль";
            this.рубльToolStripMenuItem1.Click += new System.EventHandler(this.рубльToolStripMenuItem1_Click);
            // 
            // долорToolStripMenuItem1
            // 
            this.долорToolStripMenuItem1.Name = "долорToolStripMenuItem1";
            this.долорToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.долорToolStripMenuItem1.Text = "долор";
            this.долорToolStripMenuItem1.Click += new System.EventHandler(this.долорToolStripMenuItem1_Click);
            // 
            // евроToolStripMenuItem1
            // 
            this.евроToolStripMenuItem1.Name = "евроToolStripMenuItem1";
            this.евроToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.евроToolStripMenuItem1.Text = "евро";
            this.евроToolStripMenuItem1.Click += new System.EventHandler(this.евроToolStripMenuItem1_Click);
            // 
            // белоруссToolStripMenuItem
            // 
            this.белоруссToolStripMenuItem.Name = "белоруссToolStripMenuItem";
            this.белоруссToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.белоруссToolStripMenuItem.Text = "крипта";
            this.белоруссToolStripMenuItem.Click += new System.EventHandler(this.белоруссToolStripMenuItem_Click);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(34, 88);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(347, 163);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(396, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(508, 88);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(685, 88);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(250, 163);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 369);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вашаВалютаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рубльToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem долорToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem евроToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem белорусскийРубльToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сколькоУВасВалютыToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem вКакуюПеревестиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рубльToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem долорToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem евроToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem белоруссToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}
