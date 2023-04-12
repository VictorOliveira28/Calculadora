namespace MinhaCalculadora {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            txtResult = new TextBox();
            lblOperation = new Label();
            C_Button = new Button();
            Percent_Button = new Button();
            Mult_Button = new Button();
            Sub_Button = new Button();
            _9_Button = new Button();
            _8_Button = new Button();
            _7_Button = new Button();
            Sum_Button = new Button();
            _6_Button = new Button();
            _5_Button = new Button();
            _4_Button = new Button();
            Equal_Button = new Button();
            _0_Button = new Button();
            _3_Button = new Button();
            _2_Button = new Button();
            _1_Button = new Button();
            Dot_Button = new Button();
            Divide_Button = new Button();
            Sqrt_Button = new Button();
            CE_Button = new Button();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.Location = new Point(30, 29);
            txtResult.Margin = new Padding(3, 4, 3, 4);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(409, 27);
            txtResult.TabIndex = 0;
            txtResult.Tag = "";
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // lblOperation
            // 
            lblOperation.AutoSize = true;
            lblOperation.BackColor = Color.Transparent;
            lblOperation.Location = new Point(46, 32);
            lblOperation.Name = "lblOperation";
            lblOperation.Size = new Size(0, 20);
            lblOperation.TabIndex = 1;
            lblOperation.Click += label1_Click;
            // 
            // C_Button
            // 
            C_Button.Location = new Point(188, 68);
            C_Button.Name = "C_Button";
            C_Button.Size = new Size(72, 64);
            C_Button.TabIndex = 4;
            C_Button.Text = "C";
            C_Button.UseVisualStyleBackColor = true;
            C_Button.Click += button3_Click;
            // 
            // Percent_Button
            // 
            Percent_Button.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Percent_Button.Location = new Point(366, 206);
            Percent_Button.Name = "Percent_Button";
            Percent_Button.Size = new Size(73, 64);
            Percent_Button.TabIndex = 5;
            Percent_Button.Text = "%";
            Percent_Button.UseVisualStyleBackColor = true;
            Percent_Button.Click += button4_Click;
            // 
            // Mult_Button
            // 
            Mult_Button.Location = new Point(366, 136);
            Mult_Button.Name = "Mult_Button";
            Mult_Button.Size = new Size(73, 64);
            Mult_Button.TabIndex = 6;
            Mult_Button.Text = "X";
            Mult_Button.UseVisualStyleBackColor = true;
            Mult_Button.Click += button5_Click;
            // 
            // Sub_Button
            // 
            Sub_Button.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Sub_Button.Location = new Point(266, 205);
            Sub_Button.Name = "Sub_Button";
            Sub_Button.Size = new Size(94, 67);
            Sub_Button.TabIndex = 11;
            Sub_Button.Text = "-";
            Sub_Button.UseVisualStyleBackColor = true;
            Sub_Button.Click += button6_Click_1;
            // 
            // _9_Button
            // 
            _9_Button.BackColor = SystemColors.AppWorkspace;
            _9_Button.Location = new Point(188, 138);
            _9_Button.Name = "_9_Button";
            _9_Button.Size = new Size(72, 64);
            _9_Button.TabIndex = 9;
            _9_Button.Text = "9";
            _9_Button.UseVisualStyleBackColor = false;
            _9_Button.Click += button8_Click;
            // 
            // _8_Button
            // 
            _8_Button.BackColor = SystemColors.ControlDark;
            _8_Button.Location = new Point(113, 138);
            _8_Button.Name = "_8_Button";
            _8_Button.Size = new Size(69, 64);
            _8_Button.TabIndex = 8;
            _8_Button.Text = "8";
            _8_Button.UseVisualStyleBackColor = false;
            _8_Button.Click += button9_Click;
            // 
            // _7_Button
            // 
            _7_Button.BackColor = SystemColors.ControlDark;
            _7_Button.Location = new Point(30, 138);
            _7_Button.Name = "_7_Button";
            _7_Button.Size = new Size(77, 64);
            _7_Button.TabIndex = 7;
            _7_Button.Text = "7";
            _7_Button.UseVisualStyleBackColor = false;
            _7_Button.Click += button10_Click;
            // 
            // Sum_Button
            // 
            Sum_Button.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Sum_Button.Location = new Point(266, 138);
            Sum_Button.Name = "Sum_Button";
            Sum_Button.Size = new Size(94, 64);
            Sum_Button.TabIndex = 16;
            Sum_Button.Text = "+";
            Sum_Button.UseVisualStyleBackColor = true;
            Sum_Button.Click += button11_Click;
            // 
            // _6_Button
            // 
            _6_Button.Location = new Point(188, 208);
            _6_Button.Name = "_6_Button";
            _6_Button.Size = new Size(72, 64);
            _6_Button.TabIndex = 14;
            _6_Button.Text = "6";
            _6_Button.UseVisualStyleBackColor = true;
            _6_Button.Click += button13_Click_1;
            // 
            // _5_Button
            // 
            _5_Button.Location = new Point(113, 208);
            _5_Button.Name = "_5_Button";
            _5_Button.Size = new Size(69, 64);
            _5_Button.TabIndex = 13;
            _5_Button.Text = "5";
            _5_Button.UseVisualStyleBackColor = true;
            _5_Button.Click += button14_Click;
            // 
            // _4_Button
            // 
            _4_Button.Location = new Point(30, 208);
            _4_Button.Name = "_4_Button";
            _4_Button.Size = new Size(77, 64);
            _4_Button.TabIndex = 12;
            _4_Button.Text = "4";
            _4_Button.UseVisualStyleBackColor = true;
            _4_Button.Click += button15_Click;
            // 
            // Equal_Button
            // 
            Equal_Button.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Equal_Button.Location = new Point(266, 278);
            Equal_Button.Name = "Equal_Button";
            Equal_Button.Size = new Size(173, 141);
            Equal_Button.TabIndex = 21;
            Equal_Button.Text = "=";
            Equal_Button.UseVisualStyleBackColor = true;
            Equal_Button.Click += button16_Click;
            // 
            // _0_Button
            // 
            _0_Button.Location = new Point(30, 348);
            _0_Button.Name = "_0_Button";
            _0_Button.Size = new Size(152, 71);
            _0_Button.TabIndex = 20;
            _0_Button.Text = "0";
            _0_Button.UseVisualStyleBackColor = true;
            _0_Button.Click += button17_Click;
            // 
            // _3_Button
            // 
            _3_Button.Location = new Point(188, 278);
            _3_Button.Name = "_3_Button";
            _3_Button.Size = new Size(72, 64);
            _3_Button.TabIndex = 19;
            _3_Button.Text = "3";
            _3_Button.UseVisualStyleBackColor = true;
            _3_Button.Click += button18_Click;
            // 
            // _2_Button
            // 
            _2_Button.Location = new Point(113, 278);
            _2_Button.Name = "_2_Button";
            _2_Button.Size = new Size(69, 64);
            _2_Button.TabIndex = 18;
            _2_Button.Text = "2";
            _2_Button.UseVisualStyleBackColor = true;
            _2_Button.Click += button19_Click;
            // 
            // _1_Button
            // 
            _1_Button.Location = new Point(30, 278);
            _1_Button.Name = "_1_Button";
            _1_Button.Size = new Size(77, 64);
            _1_Button.TabIndex = 17;
            _1_Button.Text = "1";
            _1_Button.UseVisualStyleBackColor = true;
            _1_Button.Click += button20_Click;
            // 
            // Dot_Button
            // 
            Dot_Button.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Dot_Button.Location = new Point(188, 348);
            Dot_Button.Name = "Dot_Button";
            Dot_Button.Size = new Size(72, 71);
            Dot_Button.TabIndex = 22;
            Dot_Button.Text = ".";
            Dot_Button.UseVisualStyleBackColor = true;
            Dot_Button.Click += button7_Click;
            // 
            // Divide_Button
            // 
            Divide_Button.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Divide_Button.Location = new Point(266, 68);
            Divide_Button.Name = "Divide_Button";
            Divide_Button.Size = new Size(94, 64);
            Divide_Button.TabIndex = 23;
            Divide_Button.Text = "/";
            Divide_Button.UseVisualStyleBackColor = true;
            Divide_Button.Click += button12_Click;
            // 
            // Sqrt_Button
            // 
            Sqrt_Button.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Sqrt_Button.Location = new Point(366, 68);
            Sqrt_Button.Name = "Sqrt_Button";
            Sqrt_Button.Size = new Size(73, 64);
            Sqrt_Button.TabIndex = 24;
            Sqrt_Button.Text = "√ ";
            Sqrt_Button.UseVisualStyleBackColor = true;
            Sqrt_Button.Click += button21_Click;
            // 
            // CE_Button
            // 
            CE_Button.Location = new Point(32, 69);
            CE_Button.Name = "CE_Button";
            CE_Button.Size = new Size(152, 65);
            CE_Button.TabIndex = 25;
            CE_Button.Text = "CE";
            CE_Button.UseVisualStyleBackColor = true;
            CE_Button.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 434);
            Controls.Add(CE_Button);
            Controls.Add(Sqrt_Button);
            Controls.Add(Divide_Button);
            Controls.Add(Dot_Button);
            Controls.Add(Equal_Button);
            Controls.Add(_0_Button);
            Controls.Add(_3_Button);
            Controls.Add(_2_Button);
            Controls.Add(_1_Button);
            Controls.Add(Sum_Button);
            Controls.Add(_6_Button);
            Controls.Add(_5_Button);
            Controls.Add(_4_Button);
            Controls.Add(Sub_Button);
            Controls.Add(_9_Button);
            Controls.Add(_8_Button);
            Controls.Add(_7_Button);
            Controls.Add(Mult_Button);
            Controls.Add(Percent_Button);
            Controls.Add(C_Button);
            Controls.Add(lblOperation);
            Controls.Add(txtResult);
            Name = "Form1";
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResult;
        private Label lblOperation;
        private Button C_Button;
        private Button Percent_Button;
        private Button Mult_Button;
        private Button Sub_Button;
        private Button _9_Button;
        private Button _8_Button;
        private Button _7_Button;
        private Button Sum_Button;
        private Button _6_Button;
        private Button _5_Button;
        private Button _4_Button;
        private Button Equal_Button;
        private Button _0_Button;
        private Button _3_Button;
        private Button _2_Button;
        private Button _1_Button;
        private Button Dot_Button;
        private Button Divide_Button;
        private Button Sqrt_Button;
        private Button CE_Button;
    }
}