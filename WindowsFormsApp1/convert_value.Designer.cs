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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "посчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // window_for_user_output
            // 
            this.window_for_user_output.Location = new System.Drawing.Point(34, 106);
            this.window_for_user_output.Name = "window_for_user_output";
            this.window_for_user_output.Size = new System.Drawing.Size(354, 163);
            this.window_for_user_output.TabIndex = 3;
            this.window_for_user_output.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(508, 58);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // window_for_output_by_date
            // 
            this.window_for_output_by_date.Location = new System.Drawing.Point(684, 61);
            this.window_for_output_by_date.Name = "window_for_output_by_date";
            this.window_for_output_by_date.Size = new System.Drawing.Size(272, 163);
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
            this.box_for_in_value.Location = new System.Drawing.Point(34, 61);
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
            this.box_for_out_value.Location = new System.Drawing.Point(267, 60);
            this.box_for_out_value.Name = "box_for_out_value";
            this.box_for_out_value.Size = new System.Drawing.Size(121, 21);
            this.box_for_out_value.TabIndex = 8;
            this.box_for_out_value.Text = "в какую переводить";
            // 
            // box_much_value
            // 
            this.box_much_value.Location = new System.Drawing.Point(161, 61);
            this.box_much_value.Name = "box_much_value";
            this.box_much_value.Size = new System.Drawing.Size(100, 20);
            this.box_much_value.TabIndex = 9;
            // 
            // convert_value
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 342);
            this.Controls.Add(this.box_much_value);
            this.Controls.Add(this.box_for_out_value);
            this.Controls.Add(this.box_for_in_value);
            this.Controls.Add(this.window_for_output_by_date);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.window_for_user_output);
            this.Controls.Add(this.button1);
            this.Name = "convert_value";
            this.Text = "convert_value";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}
