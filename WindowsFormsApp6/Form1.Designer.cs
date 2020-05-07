namespace WindowsFormsApp6
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
            this.While = new System.Windows.Forms.TextBox();
            this.Do_while = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Attention = new System.Windows.Forms.TextBox();
            this.For = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // While
            // 
            this.While.BackColor = System.Drawing.SystemColors.Info;
            this.While.Location = new System.Drawing.Point(398, 190);
            this.While.Multiline = true;
            this.While.Name = "While";
            this.While.ReadOnly = true;
            this.While.Size = new System.Drawing.Size(400, 104);
            this.While.TabIndex = 1;
            // 
            // Do_while
            // 
            this.Do_while.BackColor = System.Drawing.SystemColors.Info;
            this.Do_while.Location = new System.Drawing.Point(398, 343);
            this.Do_while.Multiline = true;
            this.Do_while.Name = "Do_while";
            this.Do_while.ReadOnly = true;
            this.Do_while.Size = new System.Drawing.Size(400, 104);
            this.Do_while.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "For:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "While:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Do while:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Введите число:";
            // 
            // Nn
            // 
            this.Nn.Location = new System.Drawing.Point(15, 43);
            this.Nn.Multiline = true;
            this.Nn.Name = "Nn";
            this.Nn.Size = new System.Drawing.Size(345, 44);
            this.Nn.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Вывести";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Attention
            // 
            this.Attention.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Attention.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Attention.ForeColor = System.Drawing.Color.Red;
            this.Attention.Location = new System.Drawing.Point(15, 165);
            this.Attention.Multiline = true;
            this.Attention.Name = "Attention";
            this.Attention.ReadOnly = true;
            this.Attention.Size = new System.Drawing.Size(345, 84);
            this.Attention.TabIndex = 9;
            this.Attention.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // For
            // 
            this.For.BackColor = System.Drawing.SystemColors.Info;
            this.For.Location = new System.Drawing.Point(398, 43);
            this.For.Multiline = true;
            this.For.Name = "For";
            this.For.ReadOnly = true;
            this.For.Size = new System.Drawing.Size(400, 104);
            this.For.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 489);
            this.Controls.Add(this.For);
            this.Controls.Add(this.Attention);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Nn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Do_while);
            this.Controls.Add(this.While);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox While;
        private System.Windows.Forms.TextBox Do_while;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Attention;
        private System.Windows.Forms.TextBox For;
    }
}

