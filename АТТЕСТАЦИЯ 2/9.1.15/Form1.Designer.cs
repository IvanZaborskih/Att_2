namespace _9._1._15
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
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.inputDataGridView = new System.Windows.Forms.DataGridView();
            this.outputDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainMeneFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMeneFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMeneFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMeneFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.LoadFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.inputDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(374, 77);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(214, 20);
            this.nTextBox.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(425, 138);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(119, 88);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Change";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // inputDataGridView
            // 
            this.inputDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputDataGridView.Location = new System.Drawing.Point(21, 37);
            this.inputDataGridView.Name = "inputDataGridView";
            this.inputDataGridView.Size = new System.Drawing.Size(327, 216);
            this.inputDataGridView.TabIndex = 2;
            // 
            // outputDataGridView
            // 
            this.outputDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputDataGridView.Location = new System.Drawing.Point(611, 37);
            this.outputDataGridView.Name = "outputDataGridView";
            this.outputDataGridView.Size = new System.Drawing.Size(327, 216);
            this.outputDataGridView.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите N";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMeneFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(995, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainMeneFile
            // 
            this.MainMeneFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMeneFileOpen,
            this.MainMeneFileSave,
            this.MainMeneFileClose});
            this.MainMeneFile.Name = "MainMeneFile";
            this.MainMeneFile.Size = new System.Drawing.Size(37, 20);
            this.MainMeneFile.Text = "File";
            // 
            // MainMeneFileOpen
            // 
            this.MainMeneFileOpen.Name = "MainMeneFileOpen";
            this.MainMeneFileOpen.Size = new System.Drawing.Size(103, 22);
            this.MainMeneFileOpen.Text = "Open";
            this.MainMeneFileOpen.Click += new System.EventHandler(this.MainMeneFileOpen_Click);
            // 
            // MainMeneFileSave
            // 
            this.MainMeneFileSave.Name = "MainMeneFileSave";
            this.MainMeneFileSave.Size = new System.Drawing.Size(103, 22);
            this.MainMeneFileSave.Text = "Save";
            this.MainMeneFileSave.Click += new System.EventHandler(this.MainMeneFileSave_Click);
            // 
            // MainMeneFileClose
            // 
            this.MainMeneFileClose.Name = "MainMeneFileClose";
            this.MainMeneFileClose.Size = new System.Drawing.Size(103, 22);
            this.MainMeneFileClose.Text = "Close";
            this.MainMeneFileClose.Click += new System.EventHandler(this.MainMeneFileClose_Click);
            // 
            // LoadFileDialog
            // 
            this.LoadFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 289);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputDataGridView);
            this.Controls.Add(this.inputDataGridView);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.DataGridView inputDataGridView;
        private System.Windows.Forms.DataGridView outputDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MainMeneFile;
        private System.Windows.Forms.ToolStripMenuItem MainMeneFileOpen;
        private System.Windows.Forms.ToolStripMenuItem MainMeneFileSave;
        private System.Windows.Forms.ToolStripMenuItem MainMeneFileClose;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.OpenFileDialog LoadFileDialog;
    }
}

