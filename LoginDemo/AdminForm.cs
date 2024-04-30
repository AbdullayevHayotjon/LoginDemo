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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pathAdmin = @"D:\PDP academy\C# darslari\LoginDemo\LoginDemo\AdminFolder\AdminFile.txt";
            string AdminList = File.ReadAllText(pathAdmin);
            MessageBox.Show(AdminList);
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
