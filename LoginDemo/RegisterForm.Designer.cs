namespace LoginDemo
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txUserNameR = new TextBox();
            txPasswordR = new TextBox();
            lbPassword = new Label();
            lbUserName = new Label();
            txFIOR = new TextBox();
            label1 = new Label();
            btRegister = new Button();
            SuspendLayout();
            // 
            // txUserNameR
            // 
            txUserNameR.BackColor = SystemColors.Info;
            txUserNameR.Font = new Font("Segoe UI", 13.8F);
            txUserNameR.Location = new Point(210, 108);
            txUserNameR.Name = "txUserNameR";
            txUserNameR.Size = new Size(307, 38);
            txUserNameR.TabIndex = 11;
            // 
            // txPasswordR
            // 
            txPasswordR.BackColor = SystemColors.Info;
            txPasswordR.Font = new Font("Segoe UI", 13.8F);
            txPasswordR.Location = new Point(210, 155);
            txPasswordR.Name = "txPasswordR";
            txPasswordR.Size = new Size(307, 38);
            txPasswordR.TabIndex = 10;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Calibri", 13.8F);
            lbPassword.Location = new Point(73, 161);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(101, 28);
            lbPassword.TabIndex = 8;
            lbPassword.Text = "Password";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Calibri", 13.8F);
            lbUserName.Location = new Point(73, 114);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(107, 28);
            lbUserName.TabIndex = 7;
            lbUserName.Text = "Username";
            // 
            // txFIOR
            // 
            txFIOR.BackColor = SystemColors.Info;
            txFIOR.Font = new Font("Segoe UI", 13.8F);
            txFIOR.Location = new Point(210, 61);
            txFIOR.Name = "txFIOR";
            txFIOR.Size = new Size(307, 38);
            txFIOR.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 13.8F);
            label1.Location = new Point(73, 67);
            label1.Name = "label1";
            label1.Size = new Size(44, 28);
            label1.TabIndex = 12;
            label1.Text = "FIO";
            // 
            // btRegister
            // 
            btRegister.BackColor = SystemColors.Highlight;
            btRegister.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btRegister.Location = new Point(73, 212);
            btRegister.Name = "btRegister";
            btRegister.Size = new Size(444, 44);
            btRegister.TabIndex = 14;
            btRegister.Text = "Register";
            btRegister.UseVisualStyleBackColor = false;
            btRegister.Click += btRegister_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 317);
            Controls.Add(btRegister);
            Controls.Add(txFIOR);
            Controls.Add(label1);
            Controls.Add(txUserNameR);
            Controls.Add(txPasswordR);
            Controls.Add(lbPassword);
            Controls.Add(lbUserName);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txUserNameR;
        private TextBox txPasswordR;
        private Label lbPassword;
        private Label lbUserName;
        private TextBox txFIOR;
        private Label label1;
        private Button btRegister;
    }
}