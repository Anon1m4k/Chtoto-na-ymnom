namespace FirstWinFormsApp
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
            this.Peoples = new System.Windows.Forms.ListBox();
            this.AddPeople = new System.Windows.Forms.Button();
            this.PeopleTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Peoples
            // 
            this.Peoples.FormattingEnabled = true;
            this.Peoples.Location = new System.Drawing.Point(71, 12);
            this.Peoples.Name = "Peoples";
            this.Peoples.Size = new System.Drawing.Size(175, 186);
            this.Peoples.TabIndex = 0;
            this.Peoples.SelectedIndexChanged += new System.EventHandler(this.Peoples_SelectedIndexChanged);
            this.Peoples.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Peoples_PreviewKeyDown);
            // 
            // AddPeople
            // 
            this.AddPeople.Location = new System.Drawing.Point(171, 225);
            this.AddPeople.Name = "AddPeople";
            this.AddPeople.Size = new System.Drawing.Size(75, 23);
            this.AddPeople.TabIndex = 1;
            this.AddPeople.Text = "Добавить";
            this.AddPeople.UseVisualStyleBackColor = true;
            this.AddPeople.Click += new System.EventHandler(this.AddPeople_Click);
            // 
            // PeopleTextBox
            // 
            this.PeopleTextBox.Location = new System.Drawing.Point(65, 227);
            this.PeopleTextBox.Name = "PeopleTextBox";
            this.PeopleTextBox.Size = new System.Drawing.Size(100, 20);
            this.PeopleTextBox.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(726, 366);
            this.Controls.Add(this.PeopleTextBox);
            this.Controls.Add(this.AddPeople);
            this.Controls.Add(this.Peoples);
            this.Name = "MainForm";
            this.Text = "Заголовок главной формы";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Peoples;
        private System.Windows.Forms.Button AddPeople;
        private System.Windows.Forms.TextBox PeopleTextBox;
    }
}

