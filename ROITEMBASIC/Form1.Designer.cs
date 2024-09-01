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
            t1 = new RichTextBox();
            tb1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            t2 = new RichTextBox();
            label3 = new Label();
            tb2 = new TextBox();
            label4 = new Label();
            ch1 = new CheckBox();
            label6 = new Label();
            tb3 = new TextBox();
            tb4 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            cb2 = new ComboBox();
            ch2 = new CheckBox();
            t3 = new RichTextBox();
            label10 = new Label();
            t4 = new RichTextBox();
            button3 = new Button();
            ch3 = new CheckBox();
            ch4 = new CheckBox();
            t5 = new RichTextBox();
            button5 = new Button();
            label11 = new Label();
            label12 = new Label();
            postb = new RichTextBox();
            slottb = new RichTextBox();
            label13 = new Label();
            label14 = new Label();
            SuspendLayout();
            // 
            // t1
            // 
            t1.BorderStyle = BorderStyle.None;
            t1.Location = new Point(12, 68);
            t1.Name = "t1";
            t1.Size = new Size(225, 519);
            t1.TabIndex = 0;
            t1.Text = "";
            t1.TextChanged += t1_TextChanged;
            // 
            // tb1
            // 
            tb1.BorderStyle = BorderStyle.FixedSingle;
            tb1.Location = new Point(12, 24);
            tb1.Name = "tb1";
            tb1.Size = new Size(225, 23);
            tb1.TabIndex = 2;
            tb1.TextChanged += tb1_TextChanged;
            tb1.KeyPress += tb1_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 3;
            label1.Text = "View ID Start";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 4;
            label2.Text = "Sprite Names";
            // 
            // t2
            // 
            t2.BorderStyle = BorderStyle.None;
            t2.Location = new Point(243, 68);
            t2.Name = "t2";
            t2.Size = new Size(225, 519);
            t2.TabIndex = 6;
            t2.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(243, 50);
            label3.Name = "label3";
            label3.Size = new Size(135, 15);
            label3.TabIndex = 7;
            label3.Text = "Display Name (In Game)";
            // 
            // tb2
            // 
            tb2.BorderStyle = BorderStyle.FixedSingle;
            tb2.Location = new Point(243, 24);
            tb2.Name = "tb2";
            tb2.Size = new Size(225, 23);
            tb2.TabIndex = 8;
            tb2.KeyPress += tb2_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(243, 6);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 9;
            label4.Text = "Item ID Start";
            // 
            // ch1
            // 
            ch1.AutoSize = true;
            ch1.Location = new Point(971, 68);
            ch1.Name = "ch1";
            ch1.Size = new Size(128, 19);
            ch1.TabIndex = 10;
            ch1.Text = "Costume Headgear";
            ch1.UseVisualStyleBackColor = true;
            ch1.CheckedChanged += ch1_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(971, 87);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 13;
            label6.Text = "Defense";
            // 
            // tb3
            // 
            tb3.Location = new Point(971, 105);
            tb3.Name = "tb3";
            tb3.Size = new Size(128, 23);
            tb3.TabIndex = 14;
            tb3.KeyPress += tb3_KeyPress;
            // 
            // tb4
            // 
            tb4.Location = new Point(971, 150);
            tb4.Name = "tb4";
            tb4.Size = new Size(128, 23);
            tb4.TabIndex = 15;
            tb4.KeyPress += tb4_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(971, 132);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 16;
            label7.Text = "Weight";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(971, 176);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 17;
            label8.Text = "Armor Level";
            // 
            // cb2
            // 
            cb2.DropDownStyle = ComboBoxStyle.DropDownList;
            cb2.FormattingEnabled = true;
            cb2.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cb2.Location = new Point(971, 194);
            cb2.Name = "cb2";
            cb2.Size = new Size(128, 23);
            cb2.TabIndex = 18;
            // 
            // ch2
            // 
            ch2.AutoSize = true;
            ch2.Location = new Point(971, 223);
            ch2.Name = "ch2";
            ch2.Size = new Size(75, 19);
            ch2.TabIndex = 19;
            ch2.Text = "Refinable";
            ch2.UseVisualStyleBackColor = true;
            // 
            // t3
            // 
            t3.BorderStyle = BorderStyle.None;
            t3.Location = new Point(606, 69);
            t3.Name = "t3";
            t3.Size = new Size(359, 138);
            t3.TabIndex = 22;
            t3.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(606, 50);
            label10.Name = "label10";
            label10.Size = new Size(94, 15);
            label10.TabIndex = 23;
            label10.Text = "Item Description";
            // 
            // t4
            // 
            t4.BorderStyle = BorderStyle.None;
            t4.Location = new Point(606, 238);
            t4.Name = "t4";
            t4.Size = new Size(359, 138);
            t4.TabIndex = 24;
            t4.Text = "";
            // 
            // button3
            // 
            button3.Location = new Point(971, 576);
            button3.Name = "button3";
            button3.Size = new Size(128, 41);
            button3.TabIndex = 26;
            button3.Text = "Generate";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ch3
            // 
            ch3.AutoSize = true;
            ch3.Location = new Point(606, 213);
            ch3.Name = "ch3";
            ch3.Size = new Size(129, 19);
            ch3.TabIndex = 28;
            ch3.Text = "Item Description #2";
            ch3.UseVisualStyleBackColor = true;
            ch3.CheckedChanged += ch3_CheckedChanged;
            // 
            // ch4
            // 
            ch4.AutoSize = true;
            ch4.Location = new Point(606, 382);
            ch4.Name = "ch4";
            ch4.Size = new Size(83, 19);
            ch4.TabIndex = 30;
            ch4.Text = "Item Script";
            ch4.UseVisualStyleBackColor = true;
            ch4.CheckedChanged += ch4_CheckedChanged;
            // 
            // t5
            // 
            t5.BorderStyle = BorderStyle.None;
            t5.Location = new Point(606, 407);
            t5.Name = "t5";
            t5.Size = new Size(359, 180);
            t5.TabIndex = 29;
            t5.Text = "";
            // 
            // button5
            // 
            button5.Location = new Point(971, 546);
            button5.Name = "button5";
            button5.Size = new Size(128, 24);
            button5.TabIndex = 31;
            button5.Text = "Import Items";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 602);
            label11.Name = "label11";
            label11.Size = new Size(80, 15);
            label11.TabIndex = 32;
            label11.Text = "Status : Ready";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(971, 50);
            label12.Name = "label12";
            label12.Size = new Size(0, 15);
            label12.TabIndex = 33;
            // 
            // postb
            // 
            postb.BorderStyle = BorderStyle.None;
            postb.Location = new Point(474, 68);
            postb.Name = "postb";
            postb.Size = new Size(60, 519);
            postb.TabIndex = 34;
            postb.Text = "";
            postb.TextChanged += postb_TextChanged;
            // 
            // slottb
            // 
            slottb.BorderStyle = BorderStyle.None;
            slottb.Location = new Point(540, 68);
            slottb.Name = "slottb";
            slottb.Size = new Size(60, 519);
            slottb.TabIndex = 35;
            slottb.Text = "";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(474, 50);
            label13.Name = "label13";
            label13.Size = new Size(50, 15);
            label13.TabIndex = 36;
            label13.Text = "Position";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(540, 50);
            label14.Name = "label14";
            label14.Size = new Size(63, 15);
            label14.TabIndex = 37;
            label14.Text = "Slot Count";
            label14.Click += label14_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 629);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(slottb);
            Controls.Add(postb);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(button5);
            Controls.Add(ch4);
            Controls.Add(t5);
            Controls.Add(ch3);
            Controls.Add(button3);
            Controls.Add(t4);
            Controls.Add(label10);
            Controls.Add(t3);
            Controls.Add(ch2);
            Controls.Add(cb2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(tb4);
            Controls.Add(tb3);
            Controls.Add(label6);
            Controls.Add(ch1);
            Controls.Add(label4);
            Controls.Add(tb2);
            Controls.Add(label3);
            Controls.Add(t2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb1);
            Controls.Add(t1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "EZ Item Generator v1.2 by qtdan";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox t1;
        private TextBox tb1;
        private Label label1;
        private Label label2;
        private RichTextBox t2;
        private Label label3;
        private TextBox tb2;
        private Label label4;
        private CheckBox ch1;
        private Label label6;
        private TextBox tb3;
        private TextBox tb4;
        private Label label7;
        private Label label8;
        private ComboBox cb2;
        private CheckBox ch2;
        private RichTextBox t3;
        private Label label10;
        private RichTextBox t4;
        private Button button3;
        private CheckBox ch3;
        private CheckBox ch4;
        private RichTextBox t5;
        private Button button5;
        private Label label11;
        private Label label12;
        private RichTextBox postb;
        private RichTextBox slottb;
        private Label label13;
        private Label label14;
    }
}