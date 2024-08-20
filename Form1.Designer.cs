namespace word2pdf_printer
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
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            textBox1 = new TextBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(358, 207);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(284, 46);
            button1.TabIndex = 0;
            button1.Text = "Выбрать Word-файл\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(162, 129);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(831, 39);
            textBox1.TabIndex = 1;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 129);
            label1.Name = "label1";
            label1.Size = new Size(163, 32);
            label1.TabIndex = 2;
            label1.Text = "Путь к файлу:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 45);
            label2.Name = "label2";
            label2.Size = new Size(510, 32);
            label2.TabIndex = 3;
            label2.Text = "Выберите число страниц на одного клиента:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 364);
            label3.Name = "label3";
            label3.Size = new Size(161, 32);
            label3.TabIndex = 4;
            label3.Text = "Путь к папке:";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(162, 361);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(831, 39);
            textBox2.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(243, 444);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(525, 46);
            button2.TabIndex = 0;
            button2.Text = "Выбрать папку для сохранения PDF-файлов\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox1.Location = new Point(519, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 40);
            comboBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1040, 576);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Конвертация Word в PDF";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private OpenFileDialog openFileDialog1;
        private TextBox textBox1;
        private FileSystemWatcher fileSystemWatcher1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private Label label3;
        private Button button2;
        private ComboBox comboBox1;
    }
}
