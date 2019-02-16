namespace Emery_Assignment2
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
            this.lb_left = new System.Windows.Forms.Label();
            this.lb_right = new System.Windows.Forms.Label();
            this.rb_add = new System.Windows.Forms.RadioButton();
            this.rb_sub = new System.Windows.Forms.RadioButton();
            this.rb_mult = new System.Windows.Forms.RadioButton();
            this.rb_div = new System.Windows.Forms.RadioButton();
            this.rb_sqrt = new System.Windows.Forms.RadioButton();
            this.rb_rp = new System.Windows.Forms.RadioButton();
            this.lb_expressoins = new System.Windows.Forms.Label();
            this.lb_Result = new System.Windows.Forms.Label();
            this.txt_leftOperand = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.txt_expression = new System.Windows.Forms.TextBox();
            this.txt_rightOperand = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.gb_operations = new System.Windows.Forms.GroupBox();
            this.gb_operations.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_left
            // 
            this.lb_left.AutoSize = true;
            this.lb_left.Location = new System.Drawing.Point(16, 11);
            this.lb_left.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_left.Name = "lb_left";
            this.lb_left.Size = new System.Drawing.Size(92, 17);
            this.lb_left.TabIndex = 0;
            this.lb_left.Text = "Left Operand";
            // 
            // lb_right
            // 
            this.lb_right.AutoSize = true;
            this.lb_right.Location = new System.Drawing.Point(425, 11);
            this.lb_right.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_right.Name = "lb_right";
            this.lb_right.Size = new System.Drawing.Size(101, 17);
            this.lb_right.TabIndex = 2;
            this.lb_right.Text = "Right Operand";
            // 
            // rb_add
            // 
            this.rb_add.AutoSize = true;
            this.rb_add.Location = new System.Drawing.Point(17, 22);
            this.rb_add.Margin = new System.Windows.Forms.Padding(4);
            this.rb_add.Name = "rb_add";
            this.rb_add.Size = new System.Drawing.Size(92, 21);
            this.rb_add.TabIndex = 3;
            this.rb_add.TabStop = true;
            this.rb_add.Text = "+ Addition";
            this.rb_add.UseVisualStyleBackColor = true;
            this.rb_add.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_sub
            // 
            this.rb_sub.AutoSize = true;
            this.rb_sub.Location = new System.Drawing.Point(17, 46);
            this.rb_sub.Margin = new System.Windows.Forms.Padding(4);
            this.rb_sub.Name = "rb_sub";
            this.rb_sub.Size = new System.Drawing.Size(110, 21);
            this.rb_sub.TabIndex = 4;
            this.rb_sub.TabStop = true;
            this.rb_sub.Text = "- Subtraction";
            this.rb_sub.UseVisualStyleBackColor = true;
            // 
            // rb_mult
            // 
            this.rb_mult.AutoSize = true;
            this.rb_mult.Location = new System.Drawing.Point(17, 72);
            this.rb_mult.Margin = new System.Windows.Forms.Padding(4);
            this.rb_mult.Name = "rb_mult";
            this.rb_mult.Size = new System.Drawing.Size(119, 21);
            this.rb_mult.TabIndex = 5;
            this.rb_mult.TabStop = true;
            this.rb_mult.Text = "* Multiplication";
            this.rb_mult.UseVisualStyleBackColor = true;
            // 
            // rb_div
            // 
            this.rb_div.AutoSize = true;
            this.rb_div.Location = new System.Drawing.Point(17, 101);
            this.rb_div.Margin = new System.Windows.Forms.Padding(4);
            this.rb_div.Name = "rb_div";
            this.rb_div.Size = new System.Drawing.Size(86, 21);
            this.rb_div.TabIndex = 6;
            this.rb_div.TabStop = true;
            this.rb_div.Text = "/ Division";
            this.rb_div.UseVisualStyleBackColor = true;
            // 
            // rb_sqrt
            // 
            this.rb_sqrt.AutoSize = true;
            this.rb_sqrt.Location = new System.Drawing.Point(17, 139);
            this.rb_sqrt.Margin = new System.Windows.Forms.Padding(4);
            this.rb_sqrt.Name = "rb_sqrt";
            this.rb_sqrt.Size = new System.Drawing.Size(313, 21);
            this.rb_sqrt.TabIndex = 7;
            this.rb_sqrt.TabStop = true;
            this.rb_sqrt.Text = "Square root (will use the Left Operand value)";
            this.rb_sqrt.UseVisualStyleBackColor = true;
            // 
            // rb_rp
            // 
            this.rb_rp.AutoSize = true;
            this.rb_rp.Location = new System.Drawing.Point(17, 168);
            this.rb_rp.Margin = new System.Windows.Forms.Padding(4);
            this.rb_rp.Name = "rb_rp";
            this.rb_rp.Size = new System.Drawing.Size(108, 21);
            this.rb_rp.TabIndex = 8;
            this.rb_rp.TabStop = true;
            this.rb_rp.Text = "Raise Power";
            this.rb_rp.UseVisualStyleBackColor = true;
            // 
            // lb_expressoins
            // 
            this.lb_expressoins.AutoSize = true;
            this.lb_expressoins.Location = new System.Drawing.Point(59, 226);
            this.lb_expressoins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_expressoins.Name = "lb_expressoins";
            this.lb_expressoins.Size = new System.Drawing.Size(84, 17);
            this.lb_expressoins.TabIndex = 9;
            this.lb_expressoins.Text = "Expressions";
            // 
            // lb_Result
            // 
            this.lb_Result.AutoSize = true;
            this.lb_Result.Location = new System.Drawing.Point(59, 288);
            this.lb_Result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Result.Name = "lb_Result";
            this.lb_Result.Size = new System.Drawing.Size(48, 17);
            this.lb_Result.TabIndex = 10;
            this.lb_Result.Text = "Result";
            // 
            // txt_leftOperand
            // 
            this.txt_leftOperand.Location = new System.Drawing.Point(9, 42);
            this.txt_leftOperand.Margin = new System.Windows.Forms.Padding(4);
            this.txt_leftOperand.Name = "txt_leftOperand";
            this.txt_leftOperand.Size = new System.Drawing.Size(99, 22);
            this.txt_leftOperand.TabIndex = 11;
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(151, 279);
            this.txt_result.Margin = new System.Windows.Forms.Padding(4);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(267, 22);
            this.txt_result.TabIndex = 12;
            // 
            // txt_expression
            // 
            this.txt_expression.Location = new System.Drawing.Point(151, 226);
            this.txt_expression.Margin = new System.Windows.Forms.Padding(4);
            this.txt_expression.Name = "txt_expression";
            this.txt_expression.Size = new System.Drawing.Size(267, 22);
            this.txt_expression.TabIndex = 13;
            // 
            // txt_rightOperand
            // 
            this.txt_rightOperand.Location = new System.Drawing.Point(428, 42);
            this.txt_rightOperand.Margin = new System.Windows.Forms.Padding(4);
            this.txt_rightOperand.Name = "txt_rightOperand";
            this.txt_rightOperand.Size = new System.Drawing.Size(97, 22);
            this.txt_rightOperand.TabIndex = 14;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(63, 311);
            this.btn_calculate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(100, 28);
            this.btn_calculate.TabIndex = 15;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(208, 311);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(120, 28);
            this.btn_clear.TabIndex = 16;
            this.btn_clear.Text = "Clear Calculator";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(359, 311);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(100, 28);
            this.btn_exit.TabIndex = 17;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // gb_operations
            // 
            this.gb_operations.Controls.Add(this.rb_add);
            this.gb_operations.Controls.Add(this.rb_sub);
            this.gb_operations.Controls.Add(this.rb_mult);
            this.gb_operations.Controls.Add(this.rb_div);
            this.gb_operations.Controls.Add(this.rb_sqrt);
            this.gb_operations.Controls.Add(this.rb_rp);
            this.gb_operations.Location = new System.Drawing.Point(115, 12);
            this.gb_operations.Name = "gb_operations";
            this.gb_operations.Size = new System.Drawing.Size(303, 196);
            this.gb_operations.TabIndex = 19;
            this.gb_operations.TabStop = false;
            this.gb_operations.Text = "Operations";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 364);
            this.Controls.Add(this.gb_operations);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.txt_rightOperand);
            this.Controls.Add(this.txt_expression);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.txt_leftOperand);
            this.Controls.Add(this.lb_Result);
            this.Controls.Add(this.lb_expressoins);
            this.Controls.Add(this.lb_right);
            this.Controls.Add(this.lb_left);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_operations.ResumeLayout(false);
            this.gb_operations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_left;
        private System.Windows.Forms.Label lb_right;
        private System.Windows.Forms.RadioButton rb_add;
        private System.Windows.Forms.RadioButton rb_sub;
        private System.Windows.Forms.RadioButton rb_mult;
        private System.Windows.Forms.RadioButton rb_div;
        private System.Windows.Forms.RadioButton rb_sqrt;
        private System.Windows.Forms.RadioButton rb_rp;
        private System.Windows.Forms.Label lb_expressoins;
        private System.Windows.Forms.Label lb_Result;
        private System.Windows.Forms.TextBox txt_leftOperand;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.TextBox txt_expression;
        private System.Windows.Forms.TextBox txt_rightOperand;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.GroupBox gb_operations;
    }
}

