namespace ROITEMBASIC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.t1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.t2 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ch1 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.ch2 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.t3 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.t4 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ch3 = new System.Windows.Forms.CheckBox();
            this.ch4 = new System.Windows.Forms.CheckBox();
            this.t5 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // t1
            // 
            this.t1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t1.Location = new System.Drawing.Point(12, 68);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(225, 519);
            this.t1.TabIndex = 0;
            this.t1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 593);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate Accessory ID and Name";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb1
            // 
            this.tb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb1.Location = new System.Drawing.Point(12, 24);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(225, 23);
            this.tb1.TabIndex = 2;
            this.tb1.TextChanged += new System.EventHandler(this.tb1_TextChanged);
            this.tb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "View ID Start";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sprite Names";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 593);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "Generate itemInfo.lua";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // t2
            // 
            this.t2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t2.Location = new System.Drawing.Point(243, 68);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(225, 519);
            this.t2.TabIndex = 6;
            this.t2.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Display Names";
            // 
            // tb2
            // 
            this.tb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb2.Location = new System.Drawing.Point(243, 24);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(225, 23);
            this.tb2.TabIndex = 8;
            this.tb2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Item ID Start";
            // 
            // ch1
            // 
            this.ch1.AutoSize = true;
            this.ch1.Location = new System.Drawing.Point(839, 68);
            this.ch1.Name = "ch1";
            this.ch1.Size = new System.Drawing.Size(128, 19);
            this.ch1.TabIndex = 10;
            this.ch1.Text = "Costume Headgear";
            this.ch1.UseVisualStyleBackColor = true;
            this.ch1.CheckedChanged += new System.EventHandler(this.ch1_CheckedChanged);
            // 
            // cb1
            // 
            this.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "Upper",
            "Middle",
            "Lower",
            "Upper, Middle",
            "Middle, Lower",
            "Upper, Lower",
            "Upper, Middle, Lower"});
            this.cb1.Location = new System.Drawing.Point(839, 149);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(128, 23);
            this.cb1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(839, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Headgear Position";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(839, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Defense";
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(839, 105);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(128, 23);
            this.tb3.TabIndex = 14;
            this.tb3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb3_KeyPress);
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(839, 193);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(128, 23);
            this.tb4.TabIndex = 15;
            this.tb4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb4_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(839, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Weight";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(839, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Armor Level";
            // 
            // cb2
            // 
            this.cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb2.FormattingEnabled = true;
            this.cb2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cb2.Location = new System.Drawing.Point(839, 237);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(128, 23);
            this.cb2.TabIndex = 18;
            // 
            // ch2
            // 
            this.ch2.AutoSize = true;
            this.ch2.Location = new System.Drawing.Point(839, 266);
            this.ch2.Name = "ch2";
            this.ch2.Size = new System.Drawing.Size(75, 19);
            this.ch2.TabIndex = 19;
            this.ch2.Text = "Refinable";
            this.ch2.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            this.cb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb3.FormattingEnabled = true;
            this.cb3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cb3.Location = new System.Drawing.Point(839, 306);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(128, 23);
            this.cb3.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(839, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Slot Count";
            // 
            // t3
            // 
            this.t3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t3.Location = new System.Drawing.Point(474, 69);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(359, 138);
            this.t3.TabIndex = 22;
            this.t3.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(474, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Item Description";
            // 
            // t4
            // 
            this.t4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t4.Location = new System.Drawing.Point(474, 238);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(359, 138);
            this.t4.TabIndex = 24;
            this.t4.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(839, 576);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 41);
            this.button3.TabIndex = 26;
            this.button3.Text = "Generate All";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(474, 593);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(359, 24);
            this.button4.TabIndex = 27;
            this.button4.Text = "Generate ItemDB";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ch3
            // 
            this.ch3.AutoSize = true;
            this.ch3.Location = new System.Drawing.Point(474, 213);
            this.ch3.Name = "ch3";
            this.ch3.Size = new System.Drawing.Size(129, 19);
            this.ch3.TabIndex = 28;
            this.ch3.Text = "Item Description #2";
            this.ch3.UseVisualStyleBackColor = true;
            this.ch3.CheckedChanged += new System.EventHandler(this.ch3_CheckedChanged);
            // 
            // ch4
            // 
            this.ch4.AutoSize = true;
            this.ch4.Location = new System.Drawing.Point(474, 382);
            this.ch4.Name = "ch4";
            this.ch4.Size = new System.Drawing.Size(83, 19);
            this.ch4.TabIndex = 30;
            this.ch4.Text = "Item Script";
            this.ch4.UseVisualStyleBackColor = true;
            this.ch4.CheckedChanged += new System.EventHandler(this.ch4_CheckedChanged);
            // 
            // t5
            // 
            this.t5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t5.Location = new System.Drawing.Point(474, 407);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(359, 180);
            this.t5.TabIndex = 29;
            this.t5.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 629);
            this.Controls.Add(this.ch4);
            this.Controls.Add(this.t5);
            this.Controls.Add(this.ch3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ch2);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.ch1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "EZ Item Generator v1 by mharkeke";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox t1;
        private Button button1;
        private TextBox tb1;
        private Label label1;
        private Label label2;
        private Button button2;
        private RichTextBox t2;
        private Label label3;
        private TextBox tb2;
        private Label label4;
        private CheckBox ch1;
        private ComboBox cb1;
        private Label label5;
        private Label label6;
        private TextBox tb3;
        private TextBox tb4;
        private Label label7;
        private Label label8;
        private ComboBox cb2;
        private CheckBox ch2;
        private ComboBox cb3;
        private Label label9;
        private RichTextBox t3;
        private Label label10;
        private RichTextBox t4;
        private Button button3;
        private Button button4;
        private CheckBox ch3;
        private CheckBox ch4;
        private RichTextBox t5;
    }
}