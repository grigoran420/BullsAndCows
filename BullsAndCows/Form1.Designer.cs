namespace BullsAndCows
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
            this.NewGame = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.UserEnter = new System.Windows.Forms.TextBox();
            this.UserNumbers = new System.Windows.Forms.ListBox();
            this.Result = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(22, 12);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(345, 23);
            this.NewGame.TabIndex = 0;
            this.NewGame.Text = "Новая игра";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ввести число";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserEnter
            // 
            this.UserEnter.Location = new System.Drawing.Point(22, 49);
            this.UserEnter.Name = "UserEnter";
            this.UserEnter.Size = new System.Drawing.Size(120, 20);
            this.UserEnter.TabIndex = 2;
            // 
            // UserNumbers
            // 
            this.UserNumbers.FormattingEnabled = true;
            this.UserNumbers.Location = new System.Drawing.Point(22, 82);
            this.UserNumbers.Name = "UserNumbers";
            this.UserNumbers.Size = new System.Drawing.Size(120, 95);
            this.UserNumbers.TabIndex = 3;
            this.UserNumbers.SelectedIndexChanged += new System.EventHandler(this.UserNumber_SelectedIndexChanged);
            // 
            // Result
            // 
            this.Result.FormattingEnabled = true;
            this.Result.Location = new System.Drawing.Point(148, 82);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(219, 95);
            this.Result.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 206);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.UserNumbers);
            this.Controls.Add(this.UserEnter);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NewGame);
            this.Name = "Form1";
            this.Text = "Bulls And Cows";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox UserEnter;
        private System.Windows.Forms.ListBox UserNumbers;
        private System.Windows.Forms.ListBox Result;
        private System.Windows.Forms.Button button1;
    }
}

