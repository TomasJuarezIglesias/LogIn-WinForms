namespace LogIn
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            BtnShowPassword = new Button();
            BtnLogin = new Button();
            TxtPasswordLogin = new TextBox();
            TxtUserLogin = new TextBox();
            panel2 = new Panel();
            BtnRegister = new Button();
            TxtPasswordRegisterRepeated = new TextBox();
            TxtPasswordRegister = new TextBox();
            TxtUserRegister = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Linen;
            label1.Font = new Font("Bahnschrift Light", 14F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(103, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 27);
            label2.Name = "label2";
            label2.Size = new Size(38, 17);
            label2.TabIndex = 1;
            label2.Text = "User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 85);
            label3.Name = "label3";
            label3.Size = new Size(71, 17);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Linen;
            label4.Font = new Font("Bahnschrift Light", 14F, FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point(92, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 23);
            label4.TabIndex = 3;
            label4.Text = "Register";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 27);
            label5.Name = "label5";
            label5.Size = new Size(38, 17);
            label5.TabIndex = 4;
            label5.Text = "User";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 85);
            label6.Name = "label6";
            label6.Size = new Size(71, 17);
            label6.TabIndex = 5;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 144);
            label7.Name = "label7";
            label7.Size = new Size(120, 17);
            label7.TabIndex = 6;
            label7.Text = "Repeat Password";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(BtnShowPassword);
            panel1.Controls.Add(BtnLogin);
            panel1.Controls.Add(TxtPasswordLogin);
            panel1.Controls.Add(TxtUserLogin);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(72, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 308);
            panel1.TabIndex = 7;
            // 
            // BtnShowPassword
            // 
            BtnShowPassword.BackColor = Color.Linen;
            BtnShowPassword.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnShowPassword.Location = new Point(115, 105);
            BtnShowPassword.Name = "BtnShowPassword";
            BtnShowPassword.Size = new Size(48, 23);
            BtnShowPassword.TabIndex = 9;
            BtnShowPassword.Text = "Show";
            BtnShowPassword.UseVisualStyleBackColor = false;
            BtnShowPassword.Click += BtnShowPassword_Click;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.Linen;
            BtnLogin.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnLogin.Location = new Point(90, 209);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(75, 23);
            BtnLogin.TabIndex = 9;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // TxtPasswordLogin
            // 
            TxtPasswordLogin.Location = new Point(3, 105);
            TxtPasswordLogin.Name = "TxtPasswordLogin";
            TxtPasswordLogin.Size = new Size(106, 23);
            TxtPasswordLogin.TabIndex = 10;
            TxtPasswordLogin.UseSystemPasswordChar = true;
            // 
            // TxtUserLogin
            // 
            TxtUserLogin.Location = new Point(3, 47);
            TxtUserLogin.Name = "TxtUserLogin";
            TxtUserLogin.Size = new Size(106, 23);
            TxtUserLogin.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.NavajoWhite;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(BtnRegister);
            panel2.Controls.Add(TxtPasswordRegisterRepeated);
            panel2.Controls.Add(TxtPasswordRegister);
            panel2.Controls.Add(TxtUserRegister);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(427, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 308);
            panel2.TabIndex = 8;
            // 
            // BtnRegister
            // 
            BtnRegister.BackColor = Color.Linen;
            BtnRegister.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnRegister.Location = new Point(92, 209);
            BtnRegister.Name = "BtnRegister";
            BtnRegister.Size = new Size(75, 23);
            BtnRegister.TabIndex = 10;
            BtnRegister.Text = "Register";
            BtnRegister.UseVisualStyleBackColor = false;
            BtnRegister.Click += BtnRegister_Click;
            // 
            // TxtPasswordRegisterRepeated
            // 
            TxtPasswordRegisterRepeated.Location = new Point(3, 164);
            TxtPasswordRegisterRepeated.Name = "TxtPasswordRegisterRepeated";
            TxtPasswordRegisterRepeated.Size = new Size(106, 23);
            TxtPasswordRegisterRepeated.TabIndex = 10;
            // 
            // TxtPasswordRegister
            // 
            TxtPasswordRegister.Location = new Point(3, 105);
            TxtPasswordRegister.Name = "TxtPasswordRegister";
            TxtPasswordRegister.Size = new Size(106, 23);
            TxtPasswordRegister.TabIndex = 10;
            // 
            // TxtUserRegister
            // 
            TxtUserRegister.Location = new Point(3, 47);
            TxtUserRegister.Name = "TxtUserRegister";
            TxtUserRegister.Size = new Size(106, 23);
            TxtUserRegister.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(774, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Panel panel2;
        private TextBox TxtPasswordLogin;
        private TextBox TxtUserLogin;
        private TextBox TxtPasswordRegisterRepeated;
        private TextBox TxtPasswordRegister;
        private TextBox TxtUserRegister;
        private Button BtnLogin;
        private Button BtnRegister;
        private Button BtnShowPassword;
    }
}