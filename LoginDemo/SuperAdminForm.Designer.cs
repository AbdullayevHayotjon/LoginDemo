namespace LoginDemo
{
    partial class SuperAdminForm
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(300, 95);
            button1.Name = "button1";
            button1.Size = new Size(190, 40);
            button1.TabIndex = 3;
            button1.Text = "Davom etish";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(182, 51);
            label1.Name = "label1";
            label1.Size = new Size(206, 31);
            label1.TabIndex = 2;
            label1.Text = "Siz SuperAdminsiz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(108, 100);
            label2.Name = "label2";
            label2.Size = new Size(146, 31);
            label2.TabIndex = 5;
            label2.Text = "Fayl yaratildi";
            // 
            // SuperAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 194);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "SuperAdminForm";
            Text = "SuperAdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
    }
}