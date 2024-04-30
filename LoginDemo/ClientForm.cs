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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pathClient = @"D:\PDP academy\C# darslari\LoginDemo\LoginDemo\ClientFolder\ClientFile.txt";
            string ClientList = File.ReadAllText(pathClient);
            MessageBox.Show(ClientList);
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
