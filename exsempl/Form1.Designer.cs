namespace exsempl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.КДобавить = new System.Windows.Forms.Button();
            this.КУдалить = new System.Windows.Forms.Button();
            this.КРедактировать = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(220, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // КДобавить
            // 
            this.КДобавить.Location = new System.Drawing.Point(220, 227);
            this.КДобавить.Name = "КДобавить";
            this.КДобавить.Size = new System.Drawing.Size(75, 23);
            this.КДобавить.TabIndex = 1;
            this.КДобавить.Text = "Добавить";
            this.КДобавить.UseVisualStyleBackColor = true;
            // 
            // КУдалить
            // 
            this.КУдалить.Location = new System.Drawing.Point(385, 227);
            this.КУдалить.Name = "КУдалить";
            this.КУдалить.Size = new System.Drawing.Size(75, 23);
            this.КУдалить.TabIndex = 2;
            this.КУдалить.Text = "Удалить";
            this.КУдалить.UseVisualStyleBackColor = true;
            // 
            // КРедактировать
            // 
            this.КРедактировать.Location = new System.Drawing.Point(295, 279);
            this.КРедактировать.Name = "КРедактировать";
            this.КРедактировать.Size = new System.Drawing.Size(93, 23);
            this.КРедактировать.TabIndex = 3;
            this.КРедактировать.Text = "Редактировать";
            this.КРедактировать.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.КРедактировать);
            this.Controls.Add(this.КУдалить);
            this.Controls.Add(this.КДобавить);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button КДобавить;
        private System.Windows.Forms.Button КУдалить;
        private System.Windows.Forms.Button КРедактировать;
    }
}

