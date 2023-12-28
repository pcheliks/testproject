namespace TextDictionaryProject
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.словарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.созданиеСловаряToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновлениеСловаряToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеСловаряToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.словарьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // словарьToolStripMenuItem
            // 
            this.словарьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.созданиеСловаряToolStripMenuItem,
            this.обновлениеСловаряToolStripMenuItem,
            this.удалениеСловаряToolStripMenuItem});
            this.словарьToolStripMenuItem.Name = "словарьToolStripMenuItem";
            this.словарьToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.словарьToolStripMenuItem.Text = "Словарь";
            // 
            // созданиеСловаряToolStripMenuItem
            // 
            this.созданиеСловаряToolStripMenuItem.Name = "созданиеСловаряToolStripMenuItem";
            this.созданиеСловаряToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.созданиеСловаряToolStripMenuItem.Text = "Создание словаря";
            this.созданиеСловаряToolStripMenuItem.Click += new System.EventHandler(this.созданиеСловаряToolStripMenuItem_Click);
            // 
            // обновлениеСловаряToolStripMenuItem
            // 
            this.обновлениеСловаряToolStripMenuItem.Name = "обновлениеСловаряToolStripMenuItem";
            this.обновлениеСловаряToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.обновлениеСловаряToolStripMenuItem.Text = "Обновление словаря";
            this.обновлениеСловаряToolStripMenuItem.Click += new System.EventHandler(this.обновлениеСловаряToolStripMenuItem_Click);
            // 
            // удалениеСловаряToolStripMenuItem
            // 
            this.удалениеСловаряToolStripMenuItem.Name = "удалениеСловаряToolStripMenuItem";
            this.удалениеСловаряToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.удалениеСловаряToolStripMenuItem.Text = "Удаление словаря";
            this.удалениеСловаряToolStripMenuItem.Click += new System.EventHandler(this.удалениеСловаряToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 74);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(75, 107);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(213, 160);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseClick);
            this.richTextBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem словарьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem созданиеСловаряToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновлениеСловаряToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалениеСловаряToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

