﻿namespace _7._2._15_46_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.check = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(172, 157);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(211, 51);
            this.check.TabIndex = 0;
            this.check.Text = "Проверить условие";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(188, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите массив";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(45, 85);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(451, 20);
            this.input.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(219, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Результат";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(109, 320);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(330, 20);
            this.output.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 389);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check);
            this.Name = "Form1";
            this.Text = "7.2.15(46)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox output;
    }
}

