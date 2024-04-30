using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginDemo
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            string path = @"D:\PDP academy\C# darslari\LoginDemo\LoginDemo\UserList.txt";
            string[] UserList = File.ReadAllLines(path);
            string ReadUserList = File.ReadAllText(path);
            if(txFIOR.Text.Length > 0 && txUserNameR.Text.Length > 0 && txPasswordR.Text.Length > 0)
            {
                if (ReadUserList.Contains(txUserNameR.Text))
                {
                    MessageBox.Show("Foydalanuvchi nomi oldindan mavjud, Iltimos boshqa kiriting");
                }
                else
                {
                    File.AppendAllText(path, (UserList.Length + 1).ToString() + "," + txFIOR.Text + "," + txUserNameR.Text + "," + txPasswordR.Text + "," + UserType.Client + "\n");
                    MessageBox.Show("Muvaffaqqiyatli ro'yxatdan o'tdingiz!");
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Bo'sh qiymat yubordingiz, Iltimos qayta kiriting");
            }
        }
    }
    public enum UserType
    {
        SuperAdmin = 1,
        Admin,
        Client
    }
}
