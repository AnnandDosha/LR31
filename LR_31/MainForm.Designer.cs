namespace LR_31
{
    partial class MainForm
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
            this.task2Button = new System.Windows.Forms.Button();
            this.task3Button = new System.Windows.Forms.Button();
            this.task4Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // task2Button
            // 
            this.task2Button.Location = new System.Drawing.Point(12, 42);
            this.task2Button.Name = "task2Button";
            this.task2Button.Size = new System.Drawing.Size(113, 29);
            this.task2Button.TabIndex = 0;
            this.task2Button.Text = "Задание2";
            this.task2Button.UseVisualStyleBackColor = true;
            this.task2Button.Click += new System.EventHandler(this.task2Button_Click);
            // 
            // task3Button
            // 
            this.task3Button.Location = new System.Drawing.Point(12, 99);
            this.task3Button.Name = "task3Button";
            this.task3Button.Size = new System.Drawing.Size(113, 29);
            this.task3Button.TabIndex = 1;
            this.task3Button.Text = "Задание3";
            this.task3Button.UseVisualStyleBackColor = true;
            this.task3Button.Click += new System.EventHandler(this.task3Button_Click);
            // 
            // task4Button
            // 
            this.task4Button.Location = new System.Drawing.Point(12, 159);
            this.task4Button.Name = "task4Button";
            this.task4Button.Size = new System.Drawing.Size(113, 27);
            this.task4Button.TabIndex = 2;
            this.task4Button.Text = "Задание4";
            this.task4Button.UseVisualStyleBackColor = true;
            this.task4Button.Click += new System.EventHandler(this.task4Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(234, 311);
            this.Controls.Add(this.task4Button);
            this.Controls.Add(this.task3Button);
            this.Controls.Add(this.task2Button);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button task2Button;
        private System.Windows.Forms.Button task3Button;
        private System.Windows.Forms.Button task4Button;
    }
}

