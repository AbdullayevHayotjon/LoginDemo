namespace LoginDemo
{
    partial class MainForm
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
            lbUserName = new Label();
            lbPassword = new Label();
            btEnter = new Button();
            txPassword = new TextBox();
            txUserName = new TextBox();
            LkRegister = new LinkLabel();
            SuspendLayout();
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Calibri", 13.8F);
            lbUserName.Location = new Point(99, 77);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(107, 28);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "Username";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Calibri", 13.8F);
            lbPassword.Location = new Point(99, 124);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(101, 28);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // btEnter
            // 
            btEnter.BackColor = SystemColors.Highlight;
            btEnter.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btEnter.Location = new Point(99, 182);
            btEnter.Name = "btEnter";
            btEnter.Size = new Size(399, 42);
            btEnter.TabIndex = 2;
            btEnter.Text = "Enter";
            btEnter.UseVisualStyleBackColor = false;
            btEnter.Click += btEnter_Click;
            // 
            // txPassword
            // 
            txPassword.BackColor = SystemColors.Info;
            txPassword.Font = new Font("Segoe UI", 13.8F);
            txPassword.Location = new Point(236, 118);
            txPassword.Name = "txPassword";
            txPassword.PasswordChar = '*';
            txPassword.Size = new Size(262, 38);
            txPassword.TabIndex = 4;
            // 
            // txUserName
            // 
            txUserName.BackColor = SystemColors.Info;
            txUserName.Font = new Font("Segoe UI", 13.8F);
            txUserName.Location = new Point(236, 71);
            txUserName.Name = "txUserName";
            txUserName.Size = new Size(262, 38);
            txUserName.TabIndex = 5;
            // 
            // LkRegister
            // 
            LkRegister.AutoSize = true;
            LkRegister.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LkRegister.Location = new Point(257, 227);
            LkRegister.Name = "LkRegister";
            LkRegister.Size = new Size(82, 28);
            LkRegister.TabIndex = 6;
            LkRegister.TabStop = true;
            LkRegister.Text = "Register";
            LkRegister.LinkClicked += LkRegister_LinkClicked;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 317);
            Controls.Add(LkRegister);
            Controls.Add(txUserName);
            Controls.Add(txPassword);
            Controls.Add(btEnter);
            Controls.Add(lbPassword);
            Controls.Add(lbUserName);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUserName;
        private Label lbPassword;
        private Button btEnter;
        private TextBox txPassword;
        private TextBox txUserName;
        private LinkLabel LkRegister;
    }
}
