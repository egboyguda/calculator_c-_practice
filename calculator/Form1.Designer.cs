
namespace calculator
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
            this.main_window = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.operator_label = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            this.division_btn = new System.Windows.Forms.Button();
            this.multiply_btn = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.minus_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.operato1_label = new System.Windows.Forms.Label();
            this.num_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // main_window
            // 
            this.main_window.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_window.Location = new System.Drawing.Point(12, 59);
            this.main_window.Multiline = true;
            this.main_window.Name = "main_window";
            this.main_window.ReadOnly = true;
            this.main_window.Size = new System.Drawing.Size(339, 61);
            this.main_window.TabIndex = 0;
            this.main_window.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.main_window.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(12, 334);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 55);
            this.button7.TabIndex = 7;
            this.button7.Text = "1";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(188, 395);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(170, 55);
            this.button17.TabIndex = 17;
            this.button17.Text = "=";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // operator_label
            // 
            this.operator_label.AutoSize = true;
            this.operator_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operator_label.Location = new System.Drawing.Point(324, 28);
            this.operator_label.Name = "operator_label";
            this.operator_label.Size = new System.Drawing.Size(0, 18);
            this.operator_label.TabIndex = 18;
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(12, 151);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(258, 55);
            this.button18.TabIndex = 20;
            this.button18.Text = "C";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // division_btn
            // 
            this.division_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division_btn.Location = new System.Drawing.Point(276, 151);
            this.division_btn.Name = "division_btn";
            this.division_btn.Size = new System.Drawing.Size(82, 55);
            this.division_btn.TabIndex = 21;
            this.division_btn.Text = "/";
            this.division_btn.UseVisualStyleBackColor = true;
            this.division_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // multiply_btn
            // 
            this.multiply_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply_btn.Location = new System.Drawing.Point(276, 212);
            this.multiply_btn.Name = "multiply_btn";
            this.multiply_btn.Size = new System.Drawing.Size(82, 55);
            this.multiply_btn.TabIndex = 22;
            this.multiply_btn.Text = "X";
            this.multiply_btn.UseVisualStyleBackColor = true;
            this.multiply_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(188, 212);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 55);
            this.button6.TabIndex = 23;
            this.button6.Text = "9";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(100, 212);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 55);
            this.button4.TabIndex = 24;
            this.button4.Text = "8";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 55);
            this.button3.TabIndex = 25;
            this.button3.Text = "7";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(12, 273);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 55);
            this.button5.TabIndex = 26;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(100, 273);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 55);
            this.button8.TabIndex = 27;
            this.button8.Text = "5";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(188, 273);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(82, 55);
            this.button9.TabIndex = 28;
            this.button9.Text = "6";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // minus_btn
            // 
            this.minus_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus_btn.Location = new System.Drawing.Point(276, 273);
            this.minus_btn.Name = "minus_btn";
            this.minus_btn.Size = new System.Drawing.Size(82, 55);
            this.minus_btn.TabIndex = 29;
            this.minus_btn.Text = "-";
            this.minus_btn.UseVisualStyleBackColor = true;
            this.minus_btn.Click += new System.EventHandler(this.button10_Click);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(276, 334);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(82, 55);
            this.add_btn.TabIndex = 30;
            this.add_btn.Text = "+";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(188, 334);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(82, 55);
            this.button12.TabIndex = 31;
            this.button12.Text = "3";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(100, 334);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(82, 55);
            this.button13.TabIndex = 32;
            this.button13.Text = "2";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(100, 395);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(82, 55);
            this.button14.TabIndex = 33;
            this.button14.Text = "0";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(12, 395);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(82, 55);
            this.button16.TabIndex = 34;
            this.button16.Text = ".";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 35;
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // operato1_label
            // 
            this.operato1_label.AutoSize = true;
            this.operato1_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operato1_label.Location = new System.Drawing.Point(322, 32);
            this.operato1_label.Name = "operato1_label";
            this.operato1_label.Size = new System.Drawing.Size(0, 24);
            this.operato1_label.TabIndex = 36;
            this.operato1_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // num_label
            // 
            this.num_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_label.Location = new System.Drawing.Point(12, 9);
            this.num_label.Name = "num_label";
            this.num_label.Size = new System.Drawing.Size(273, 39);
            this.num_label.TabIndex = 37;
            this.num_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.num_label.Click += new System.EventHandler(this.num_label_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 457);
            this.Controls.Add(this.num_label);
            this.Controls.Add(this.operato1_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.minus_btn);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.multiply_btn);
            this.Controls.Add(this.division_btn);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.operator_label);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.main_window);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox main_window;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Label operator_label;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button division_btn;
        private System.Windows.Forms.Button multiply_btn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button minus_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label operato1_label;
        private System.Windows.Forms.Label num_label;
    }
}

