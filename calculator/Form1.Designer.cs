namespace calculator
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
            display = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            subtract = new Button();
            button15 = new Button();
            zero = new Button();
            none = new Button();
            add = new Button();
            three = new Button();
            two = new Button();
            one = new Button();
            multiply = new Button();
            six = new Button();
            five = new Button();
            four = new Button();
            divide = new Button();
            nine = new Button();
            eight = new Button();
            seven = new Button();
            result = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // display
            // 
            display.Dock = DockStyle.Top;
            display.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            display.Location = new Point(0, 0);
            display.Name = "display";
            display.Size = new Size(308, 40);
            display.TabIndex = 1;
            display.Text = "0";
            display.TextAlign = ContentAlignment.TopRight;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(subtract, 3, 3);
            tableLayoutPanel1.Controls.Add(button15, 2, 3);
            tableLayoutPanel1.Controls.Add(zero, 1, 3);
            tableLayoutPanel1.Controls.Add(none, 0, 3);
            tableLayoutPanel1.Controls.Add(add, 3, 2);
            tableLayoutPanel1.Controls.Add(three, 2, 2);
            tableLayoutPanel1.Controls.Add(two, 1, 2);
            tableLayoutPanel1.Controls.Add(one, 0, 2);
            tableLayoutPanel1.Controls.Add(multiply, 3, 1);
            tableLayoutPanel1.Controls.Add(six, 2, 1);
            tableLayoutPanel1.Controls.Add(five, 1, 1);
            tableLayoutPanel1.Controls.Add(four, 0, 1);
            tableLayoutPanel1.Controls.Add(divide, 3, 0);
            tableLayoutPanel1.Controls.Add(nine, 2, 0);
            tableLayoutPanel1.Controls.Add(eight, 1, 0);
            tableLayoutPanel1.Controls.Add(seven, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 73);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(308, 302);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // subtract
            // 
            subtract.BackColor = SystemColors.GradientInactiveCaption;
            subtract.Font = new Font("굴림", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            subtract.Location = new Point(234, 228);
            subtract.Name = "subtract";
            subtract.Size = new Size(71, 69);
            subtract.TabIndex = 15;
            subtract.Text = "-";
            subtract.UseVisualStyleBackColor = false;
            subtract.Click += cal_button;
            // 
            // button15
            // 
            button15.BackColor = SystemColors.GradientInactiveCaption;
            button15.Font = new Font("굴림", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button15.Location = new Point(157, 228);
            button15.Name = "button15";
            button15.Size = new Size(71, 69);
            button15.TabIndex = 14;
            button15.Text = ".";
            button15.UseVisualStyleBackColor = false;
            button15.Click += btnNumClick;
            // 
            // zero
            // 
            zero.BackColor = SystemColors.GradientInactiveCaption;
            zero.Font = new Font("굴림", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            zero.Location = new Point(80, 228);
            zero.Name = "zero";
            zero.Size = new Size(71, 69);
            zero.TabIndex = 13;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = false;
            zero.Click += btnNumClick;
            // 
            // none
            // 
            none.BackColor = SystemColors.GradientInactiveCaption;
            none.Font = new Font("굴림", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            none.Location = new Point(3, 228);
            none.Name = "none";
            none.Size = new Size(71, 69);
            none.TabIndex = 12;
            none.Text = "AC";
            none.UseVisualStyleBackColor = false;
            none.Click += clear_button;
            // 
            // add
            // 
            add.BackColor = SystemColors.GradientInactiveCaption;
            add.Font = new Font("굴림", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            add.Location = new Point(234, 153);
            add.Name = "add";
            add.Size = new Size(71, 69);
            add.TabIndex = 11;
            add.Text = "+";
            add.UseVisualStyleBackColor = false;
            add.Click += cal_button;
            // 
            // three
            // 
            three.BackColor = SystemColors.GradientInactiveCaption;
            three.Font = new Font("굴림", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            three.Location = new Point(157, 153);
            three.Name = "three";
            three.Size = new Size(71, 69);
            three.TabIndex = 10;
            three.Text = "3";
            three.UseVisualStyleBackColor = false;
            three.Click += btnNumClick;
            // 
            // two
            // 
            two.BackColor = SystemColors.GradientInactiveCaption;
            two.Font = new Font("굴림", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            two.Location = new Point(80, 153);
            two.Name = "two";
            two.Size = new Size(71, 69);
            two.TabIndex = 9;
            two.Text = "2";
            two.UseVisualStyleBackColor = false;
            two.Click += btnNumClick;
            // 
            // one
            // 
            one.BackColor = SystemColors.GradientInactiveCaption;
            one.Font = new Font("굴림", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            one.Location = new Point(3, 153);
            one.Name = "one";
            one.Size = new Size(71, 69);
            one.TabIndex = 8;
            one.Text = "1";
            one.UseVisualStyleBackColor = false;
            one.Click += btnNumClick;
            // 
            // multiply
            // 
            multiply.BackColor = SystemColors.GradientInactiveCaption;
            multiply.Font = new Font("굴림", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            multiply.Location = new Point(234, 78);
            multiply.Name = "multiply";
            multiply.Size = new Size(71, 69);
            multiply.TabIndex = 7;
            multiply.Text = "x";
            multiply.UseVisualStyleBackColor = false;
            multiply.Click += cal_button;
            // 
            // six
            // 
            six.BackColor = SystemColors.GradientInactiveCaption;
            six.Font = new Font("굴림", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            six.Location = new Point(157, 78);
            six.Name = "six";
            six.Size = new Size(71, 69);
            six.TabIndex = 6;
            six.Text = "6";
            six.UseVisualStyleBackColor = false;
            six.Click += btnNumClick;
            // 
            // five
            // 
            five.BackColor = SystemColors.GradientInactiveCaption;
            five.Font = new Font("굴림", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            five.Location = new Point(80, 78);
            five.Name = "five";
            five.Size = new Size(71, 69);
            five.TabIndex = 5;
            five.Text = "5";
            five.UseVisualStyleBackColor = false;
            five.Click += btnNumClick;
            // 
            // four
            // 
            four.BackColor = SystemColors.GradientInactiveCaption;
            four.Font = new Font("굴림", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            four.Location = new Point(3, 78);
            four.Name = "four";
            four.Size = new Size(71, 69);
            four.TabIndex = 4;
            four.Text = "4";
            four.UseVisualStyleBackColor = false;
            four.Click += btnNumClick;
            // 
            // divide
            // 
            divide.BackColor = SystemColors.GradientInactiveCaption;
            divide.Font = new Font("굴림", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            divide.Location = new Point(234, 3);
            divide.Name = "divide";
            divide.Size = new Size(71, 69);
            divide.TabIndex = 3;
            divide.Text = "÷";
            divide.UseVisualStyleBackColor = false;
            divide.Click += cal_button;
            // 
            // nine
            // 
            nine.BackColor = SystemColors.GradientInactiveCaption;
            nine.Font = new Font("굴림", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            nine.Location = new Point(157, 3);
            nine.Name = "nine";
            nine.Size = new Size(71, 69);
            nine.TabIndex = 2;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = false;
            nine.Click += btnNumClick;
            // 
            // eight
            // 
            eight.BackColor = SystemColors.GradientInactiveCaption;
            eight.Font = new Font("굴림", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            eight.Location = new Point(80, 3);
            eight.Name = "eight";
            eight.Size = new Size(71, 69);
            eight.TabIndex = 1;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = false;
            eight.Click += btnNumClick;
            // 
            // seven
            // 
            seven.BackColor = SystemColors.GradientInactiveCaption;
            seven.Font = new Font("굴림", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            seven.Location = new Point(3, 3);
            seven.Name = "seven";
            seven.Size = new Size(71, 69);
            seven.TabIndex = 0;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = false;
            seven.Click += btnNumClick;
            // 
            // result
            // 
            result.BackColor = SystemColors.GradientInactiveCaption;
            result.Dock = DockStyle.Bottom;
            result.Font = new Font("굴림", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            result.Location = new Point(0, 369);
            result.Name = "result";
            result.Size = new Size(308, 42);
            result.TabIndex = 3;
            result.Text = "=";
            result.UseVisualStyleBackColor = false;
            result.Click += result_button;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 411);
            Controls.Add(result);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(display);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label display;
        private TableLayoutPanel tableLayoutPanel1;
        private Button subtract;
        private Button button15;
        private Button zero;
        private Button none;
        private Button add;
        private Button three;
        private Button two;
        private Button one;
        private Button multiply;
        private Button six;
        private Button five;
        private Button four;
        private Button divide;
        private Button nine;
        private Button eight;
        private Button seven;
        private Button result;
    }
}