namespace RentalPoint
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
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewPasscheckBox = new System.Windows.Forms.CheckBox();
            this.CapchaTb = new System.Windows.Forms.TextBox();
            this.CaptchapictureBox = new System.Windows.Forms.PictureBox();
            this.CapchaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CaptchapictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(172, 17);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(162, 20);
            this.LoginTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(172, 56);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(162, 20);
            this.PasswordTextBox.TabIndex = 1;
            // 
            // SignInBtn
            // 
            this.SignInBtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInBtn.Location = new System.Drawing.Point(138, 181);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(89, 34);
            this.SignInBtn.TabIndex = 2;
            this.SignInBtn.Text = "Войти";
            this.SignInBtn.UseVisualStyleBackColor = true;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(38, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // ViewPasscheckBox
            // 
            this.ViewPasscheckBox.AutoSize = true;
            this.ViewPasscheckBox.Location = new System.Drawing.Point(188, 83);
            this.ViewPasscheckBox.Name = "ViewPasscheckBox";
            this.ViewPasscheckBox.Size = new System.Drawing.Size(114, 17);
            this.ViewPasscheckBox.TabIndex = 5;
            this.ViewPasscheckBox.Text = "Показать пароль";
            this.ViewPasscheckBox.UseVisualStyleBackColor = true;
            this.ViewPasscheckBox.CheckedChanged += new System.EventHandler(this.ViewPasscheckBox_CheckedChanged);
            // 
            // CapchaTb
            // 
            this.CapchaTb.Location = new System.Drawing.Point(172, 128);
            this.CapchaTb.Name = "CapchaTb";
            this.CapchaTb.Size = new System.Drawing.Size(100, 20);
            this.CapchaTb.TabIndex = 7;
            this.CapchaTb.Visible = false;
            // 
            // CaptchapictureBox
            // 
            this.CaptchapictureBox.Location = new System.Drawing.Point(41, 108);
            this.CaptchapictureBox.Name = "CaptchapictureBox";
            this.CaptchapictureBox.Size = new System.Drawing.Size(100, 50);
            this.CaptchapictureBox.TabIndex = 6;
            this.CaptchapictureBox.TabStop = false;
            // 
            // CapchaBtn
            // 
            this.CapchaBtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CapchaBtn.Location = new System.Drawing.Point(41, 164);
            this.CapchaBtn.Name = "CapchaBtn";
            this.CapchaBtn.Size = new System.Drawing.Size(44, 28);
            this.CapchaBtn.TabIndex = 8;
            this.CapchaBtn.UseVisualStyleBackColor = true;
            this.CapchaBtn.Click += new System.EventHandler(this.CapchaBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 227);
            this.Controls.Add(this.CapchaBtn);
            this.Controls.Add(this.CapchaTb);
            this.Controls.Add(this.CaptchapictureBox);
            this.Controls.Add(this.ViewPasscheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.CaptchapictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ViewPasscheckBox;
        public System.Windows.Forms.PictureBox CaptchapictureBox;
        public System.Windows.Forms.TextBox CapchaTb;
        private System.Windows.Forms.Button CapchaBtn;
    }
}

