namespace Encryption
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.encryptDecryptButton = new System.Windows.Forms.Button();
            this.outputButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.rewriteOriginalCheckBox = new System.Windows.Forms.CheckBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.output_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.comboBox1.Location = new System.Drawing.Point(9, 10);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(66, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "MODE";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBox2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.comboBox2.Location = new System.Drawing.Point(102, 10);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(103, 21);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.Text = "CYPHER TYPE";
            this.comboBox2.UseWaitCursor = true;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(11, 367);
            this.loadButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(148, 28);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Load ";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // encryptDecryptButton
            // 
            this.encryptDecryptButton.Location = new System.Drawing.Point(177, 367);
            this.encryptDecryptButton.Margin = new System.Windows.Forms.Padding(2);
            this.encryptDecryptButton.Name = "encryptDecryptButton";
            this.encryptDecryptButton.Size = new System.Drawing.Size(98, 38);
            this.encryptDecryptButton.TabIndex = 3;
            this.encryptDecryptButton.Text = "Encrypt/Decrypt";
            this.encryptDecryptButton.UseVisualStyleBackColor = true;
            this.encryptDecryptButton.Click += new System.EventHandler(this.encryptDecryptButton_Click);
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(426, 367);
            this.outputButton.Margin = new System.Windows.Forms.Padding(2);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(238, 28);
            this.outputButton.TabIndex = 3;
            this.outputButton.Text = "Output";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(2, 421);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(682, 29);
            this.progressBar1.TabIndex = 5;
            // 
            // rewriteOriginalCheckBox
            // 
            this.rewriteOriginalCheckBox.AutoSize = true;
            this.rewriteOriginalCheckBox.Location = new System.Drawing.Point(272, 11);
            this.rewriteOriginalCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.rewriteOriginalCheckBox.Name = "rewriteOriginalCheckBox";
            this.rewriteOriginalCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rewriteOriginalCheckBox.Size = new System.Drawing.Size(100, 17);
            this.rewriteOriginalCheckBox.TabIndex = 6;
            this.rewriteOriginalCheckBox.Text = "Rewrite Original";
            this.rewriteOriginalCheckBox.UseVisualStyleBackColor = true;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(9, 37);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTextBox.Size = new System.Drawing.Size(238, 325);
            this.inputTextBox.TabIndex = 7;
            this.inputTextBox.Enter += new System.EventHandler(this.inputTextBox_Enter);
            this.inputTextBox.Leave += new System.EventHandler(this.inputTextBox_Leave);
            // 
            // output_textBox
            // 
            this.output_textBox.Location = new System.Drawing.Point(426, 37);
            this.output_textBox.Multiline = true;
            this.output_textBox.Name = "output_textBox";
            this.output_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output_textBox.Size = new System.Drawing.Size(238, 325);
            this.output_textBox.TabIndex = 7;
            this.output_textBox.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 461);
            this.Controls.Add(this.output_textBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.rewriteOriginalCheckBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.encryptDecryptButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button encryptDecryptButton;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox rewriteOriginalCheckBox;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox output_textBox;
    }
}

