namespace _6._1._15
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
            this.InputS = new System.Windows.Forms.TextBox();
            this.InputK = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputS
            // 
            this.InputS.Location = new System.Drawing.Point(43, 52);
            this.InputS.Name = "InputS";
            this.InputS.Size = new System.Drawing.Size(384, 20);
            this.InputS.TabIndex = 0;
            // 
            // InputK
            // 
            this.InputK.Location = new System.Drawing.Point(43, 132);
            this.InputK.Name = "InputK";
            this.InputK.Size = new System.Drawing.Size(384, 20);
            this.InputK.TabIndex = 1;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(43, 278);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(384, 20);
            this.result.TabIndex = 2;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(140, 189);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(186, 26);
            this.start.TabIndex = 3;
            this.start.Text = "Поиск элемента с номером K";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(89, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите элементы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(89, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите K:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(91, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Элемент, который вы искали:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 330);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.result);
            this.Controls.Add(this.InputK);
            this.Controls.Add(this.InputS);
            this.Name = "Form1";
            this.Text = "6.1.15";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputS;
        private System.Windows.Forms.TextBox InputK;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

