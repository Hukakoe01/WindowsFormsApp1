namespace Program_for_value
{
    partial class convert_value
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
            this.window_for_user_output = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.window_for_output_by_date = new System.Windows.Forms.RichTextBox();
            this.box_for_in_value = new System.Windows.Forms.ComboBox();
            this.box_for_out_value = new System.Windows.Forms.ComboBox();
            this.box_much_value = new System.Windows.Forms.TextBox();
            this.вашаВалютаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рубльToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.долорToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.евроToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.белорусскийРубльToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.value_in = new System.Windows.Forms.ToolStripTextBox();
            this.сколькоУВасВалютыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.how_much_value = new System.Windows.Forms.ToolStripTextBox();
            this.вКакуюПеревестиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рубльToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.долорToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.евроToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.белоруссToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.value_out = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            // window_for_user_output
            // 
            this.window_for_user_output.Location = new System.Drawing.Point(34, 88);
            this.window_for_user_output.Name = "window_for_user_output";
            this.window_for_user_output.Size = new System.Drawing.Size(347, 163);
            this.window_for_user_output.TabIndex = 3;
            this.window_for_user_output.Text = "";
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
            // window_for_output_by_date
            // 
            this.window_for_output_by_date.Location = new System.Drawing.Point(685, 88);
            this.window_for_output_by_date.Name = "window_for_output_by_date";
            this.window_for_output_by_date.Size = new System.Drawing.Size(250, 163);
            this.window_for_output_by_date.TabIndex = 6;
            this.window_for_output_by_date.Text = "";
            // 
            // box_for_in_value
            // 
            this.box_for_in_value.FormattingEnabled = true;
            this.box_for_in_value.Items.AddRange(new object[] {
            "RUB",
            "USD",
            "EUR"});
            this.box_for_in_value.Location = new System.Drawing.Point(34, 28);
            this.box_for_in_value.Name = "box_for_in_value";
            this.box_for_in_value.Size = new System.Drawing.Size(121, 21);
            this.box_for_in_value.TabIndex = 7;
            this.box_for_in_value.Text = "ваша валюта";
            // 
            // box_for_out_value
            // 
            this.box_for_out_value.FormattingEnabled = true;
            this.box_for_out_value.Items.AddRange(new object[] {
            "RUB",
            "USD",
            "EUR"});
            this.box_for_out_value.Location = new System.Drawing.Point(267, 28);
            this.box_for_out_value.Name = "box_for_out_value";
            this.box_for_out_value.Size = new System.Drawing.Size(121, 21);
            this.box_for_out_value.TabIndex = 8;
            this.box_for_out_value.Text = "в какую переводить";
            // 
            // box_much_value
            // 
            this.box_much_value.Location = new System.Drawing.Point(161, 28);
            this.box_much_value.Name = "box_much_value";
            this.box_much_value.Size = new System.Drawing.Size(100, 20);
            this.box_much_value.TabIndex = 9;
            // 
            // вашаВалютаToolStripMenuItem
            // 
            this.вашаВалютаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рубльToolStripMenuItem,
            this.долорToolStripMenuItem,
            this.евроToolStripMenuItem,
            this.белорусскийРубльToolStripMenuItem,
            this.value_in});
            this.вашаВалютаToolStripMenuItem.Name = "вашаВалютаToolStripMenuItem";
            this.вашаВалютаToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.вашаВалютаToolStripMenuItem.Text = "ваша валюта";
            // 
            // рубльToolStripMenuItem
            // 
            this.рубльToolStripMenuItem.Name = "рубльToolStripMenuItem";
            this.рубльToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.рубльToolStripMenuItem.Text = "рубль";
            this.рубльToolStripMenuItem.Click += new System.EventHandler(this.RUBToolStripMenuItem_Click);
            // 
            // долорToolStripMenuItem
            // 
            this.долорToolStripMenuItem.Name = "долорToolStripMenuItem";
            this.долорToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.долорToolStripMenuItem.Text = "долор";
            this.долорToolStripMenuItem.Click += new System.EventHandler(this.USDToolStripMenuItem_Click);
            // 
            // евроToolStripMenuItem
            // 
            this.евроToolStripMenuItem.Name = "евроToolStripMenuItem";
            this.евроToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.евроToolStripMenuItem.Text = "евро";
            this.евроToolStripMenuItem.Click += new System.EventHandler(this.EURToolStripMenuItem_Click);
            // 
            // белорусскийРубльToolStripMenuItem
            // 
            this.белорусскийРубльToolStripMenuItem.Name = "белорусскийРубльToolStripMenuItem";
            this.белорусскийРубльToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.белорусскийРубльToolStripMenuItem.Text = "крипта";
            this.белорусскийРубльToolStripMenuItem.Click += new System.EventHandler(this.EOSToolStripMenuItem_Click);
            // 
            // value_in
            // 
            this.value_in.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.value_in.Name = "value_in";
            this.value_in.Size = new System.Drawing.Size(100, 23);
            // 
            // сколькоУВасВалютыToolStripMenuItem
            // 
            this.сколькоУВасВалютыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.how_much_value});
            this.сколькоУВасВалютыToolStripMenuItem.Name = "сколькоУВасВалютыToolStripMenuItem";
            this.сколькоУВасВалютыToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.сколькоУВасВалютыToolStripMenuItem.Text = "сколько у вас валюты";
            // 
            // how_much_value
            // 
            this.how_much_value.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.how_much_value.Name = "how_much_value";
            this.how_much_value.Size = new System.Drawing.Size(100, 23);
            // 
            // вКакуюПеревестиToolStripMenuItem
            // 
            this.вКакуюПеревестиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рубльToolStripMenuItem1,
            this.долорToolStripMenuItem1,
            this.евроToolStripMenuItem1,
            this.белоруссToolStripMenuItem,
            this.value_out});
            this.вКакуюПеревестиToolStripMenuItem.Name = "вКакуюПеревестиToolStripMenuItem";
            this.вКакуюПеревестиToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.вКакуюПеревестиToolStripMenuItem.Text = "в какую перевести";
            // 
            // рубльToolStripMenuItem1
            // 
            this.рубльToolStripMenuItem1.Name = "рубльToolStripMenuItem1";
            this.рубльToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.рубльToolStripMenuItem1.Text = "рубль";
            this.рубльToolStripMenuItem1.Click += new System.EventHandler(this.RUBToolStripMenuItem1_Click);
            // 
            // долорToolStripMenuItem1
            // 
            this.долорToolStripMenuItem1.Name = "долорToolStripMenuItem1";
            this.долорToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.долорToolStripMenuItem1.Text = "долор";
            this.долорToolStripMenuItem1.Click += new System.EventHandler(this.USDToolStripMenuItem1_Click);
            // 
            // евроToolStripMenuItem1
            // 
            this.евроToolStripMenuItem1.Name = "евроToolStripMenuItem1";
            this.евроToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.евроToolStripMenuItem1.Text = "евро";
            this.евроToolStripMenuItem1.Click += new System.EventHandler(this.EURToolStripMenuItem1_Click);
            // 
            // белоруссToolStripMenuItem
            // 
            this.белоруссToolStripMenuItem.Name = "белоруссToolStripMenuItem";
            this.белоруссToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.белоруссToolStripMenuItem.Text = "крипта";
            this.белоруссToolStripMenuItem.Click += new System.EventHandler(this.EOSToolStripMenuItem1_Click);
            // 
            // value_out
            // 
            this.value_out.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.value_out.Name = "value_out";
            this.value_out.Size = new System.Drawing.Size(100, 23);
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
            // convert_value
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 369);
            this.Controls.Add(this.box_much_value);
            this.Controls.Add(this.box_for_out_value);
            this.Controls.Add(this.box_for_in_value);
            this.Controls.Add(this.window_for_output_by_date);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.window_for_user_output);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "convert_value";
            this.Text = "convert_value";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox window_for_user_output;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.RichTextBox window_for_output_by_date;
        private System.Windows.Forms.ComboBox box_for_in_value;
        private System.Windows.Forms.ComboBox box_for_out_value;
        private System.Windows.Forms.TextBox box_much_value;
        private System.Windows.Forms.ToolStripMenuItem вашаВалютаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рубльToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem долорToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem евроToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem белорусскийРубльToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox value_in;
        private System.Windows.Forms.ToolStripMenuItem сколькоУВасВалютыToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox how_much_value;
        private System.Windows.Forms.ToolStripMenuItem вКакуюПеревестиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рубльToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem долорToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem евроToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem белоруссToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox value_out;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}
