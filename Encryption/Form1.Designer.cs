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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.inputButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.encryptDecryptButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.rewriteOriginalCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(87, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "MODE";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // comboBox2
            // 
            this.comboBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBox2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.comboBox2.Location = new System.Drawing.Point(136, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(136, 24);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.Text = "CYPHER TYPE";
            this.comboBox2.UseWaitCursor = true;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(3, 3);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(260, 369);
            this.inputTextBox.TabIndex = 1;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(266, 3);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(22, 369);
            this.vScrollBar1.TabIndex = 2;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(2, 452);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(85, 35);
            this.inputButton.TabIndex = 3;
            this.inputButton.Text = "Input Path";
            this.inputButton.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(93, 452);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(90, 35);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Load ";
            this.loadButton.UseVisualStyleBackColor = true;
            // 
            // encryptDecryptButton
            // 
            this.encryptDecryptButton.Location = new System.Drawing.Point(222, 452);
            this.encryptDecryptButton.Name = "encryptDecryptButton";
            this.encryptDecryptButton.Size = new System.Drawing.Size(136, 35);
            this.encryptDecryptButton.TabIndex = 3;
            this.encryptDecryptButton.Text = "Encrypt/Decrypt";
            this.encryptDecryptButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.inputTextBox);
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Location = new System.Drawing.Point(12, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 379);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.outputTextBox);
            this.panel2.Controls.Add(this.vScrollBar2);
            this.panel2.Location = new System.Drawing.Point(541, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 379);
            this.panel2.TabIndex = 4;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(0, 0);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(260, 369);
            this.outputTextBox.TabIndex = 1;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(266, 3);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(22, 369);
            this.vScrollBar2.TabIndex = 2;
            this.vScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Output Path";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(788, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(2, 510);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(910, 36);
            this.progressBar1.TabIndex = 5;
            // 
            // rewriteOriginalCheckBox
            // 
            this.rewriteOriginalCheckBox.AutoSize = true;
            this.rewriteOriginalCheckBox.Location = new System.Drawing.Point(363, 14);
            this.rewriteOriginalCheckBox.Name = "rewriteOriginalCheckBox";
            this.rewriteOriginalCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rewriteOriginalCheckBox.Size = new System.Drawing.Size(123, 20);
            this.rewriteOriginalCheckBox.TabIndex = 6;
            this.rewriteOriginalCheckBox.Text = "Rewrite Original";
            this.rewriteOriginalCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 567);
            this.Controls.Add(this.rewriteOriginalCheckBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.encryptDecryptButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button encryptDecryptButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox rewriteOriginalCheckBox;
    }
}

