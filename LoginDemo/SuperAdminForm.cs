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
    public partial class SuperAdminForm : Form
    {
        public SuperAdminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pathSuperAdmin = @"D:\PDP academy\C# darslari\LoginDemo\LoginDemo\SuperAdminFolder\SuperAdminFile.txt";
            string SuperAdminList = File.ReadAllText(pathSuperAdmin);
            MessageBox.Show(SuperAdminList);
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
