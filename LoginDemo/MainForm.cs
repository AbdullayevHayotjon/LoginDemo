using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace LoginDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            List<Users> users = new List<Users>();
            string path = @"D:\PDP academy\C# darslari\LoginDemo\LoginDemo\UserList.txt";
            string[] UserList = File.ReadAllLines(path);
            for(int i=0; i<UserList.Length; i++)
            {
                string[] UserListLine = UserList[i].Split(",");
                users.Add(new Users() { FIO = UserListLine[1], UserName = UserListLine[2], Password = UserListLine[3], UserType = UserListLine[4] });
            }
            int sanoq = 0;
            foreach(Users item in users)
            {
                if(item.UserName == txUserName.Text && item.Password == txPassword.Text)
                {
                    sanoq++;
                    if(item.UserType == UserType.SuperAdmin.ToString())
                    {
                        string pathSuperAdminFolder = @"D:\PDP academy\C# darslari\LoginDemo\LoginDemo\SuperAdminFolder";
                        string pathSuperAdminFile = Path.Combine(pathSuperAdminFolder, "SuperAdminFile.txt");
                        Directory.CreateDirectory(pathSuperAdminFolder);
                        StreamWriter streamWriter = File.CreateText(pathSuperAdminFile);
                        int i = 1;
                        foreach(Users item1 in users)
                        {
                            if(item1.UserType == UserType.SuperAdmin.ToString())
                            {
                                continue;
                            }
                            streamWriter.WriteLine(i++.ToString() + "," + item1.FIO + "," + item1.UserName + "," + item1.Password + "," + item1.UserType);
                        }
                        streamWriter.Close();
                        this.Hide();
                        SuperAdminForm superAdminForm = new SuperAdminForm();
                        superAdminForm.Show();
                    }
                    else if(item.UserType == UserType.Admin.ToString())
                    {
                        string pathAdminFolder = @"D:\PDP academy\C# darslari\LoginDemo\LoginDemo\AdminFolder";
                        string pathAdminFile = Path.Combine(pathAdminFolder, "AdminFile.txt");
                        Directory.CreateDirectory(pathAdminFolder);
                        StreamWriter streamWriter = File.CreateText(pathAdminFile);
                        int i = 1;
                        foreach (Users item1 in users)
                        {
                            if (item1.UserType == UserType.Client.ToString())
                            {
                                streamWriter.WriteLine(i++.ToString() + "," + item1.FIO + "," + item1.UserName + "," + item1.Password + "," + item1.UserType);
                            }
                        }
                        streamWriter.Close();
                        this.Hide();
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                    }
                    else
                    {
                        Users users1 = new Users();
                        foreach(Users item1 in users)
                        {
                            if(txUserName.Text == item1.UserName)
                            {
                                users1.FIO = item1.FIO;
                                users1.UserName = item1.UserName;
                                users1.Password = item1.Password;
                                users1.UserType = item1.UserType;
                            }
                        }
                        string jsonString = JsonSerializer.Serialize(users1);
                        string pathClientFolder = @"D:\PDP academy\C# darslari\LoginDemo\LoginDemo\ClientFolder";
                        string pathCLientFile = Path.Combine(pathClientFolder, "ClientFile.txt");
                        Directory.CreateDirectory(pathClientFolder);
                        StreamWriter streamWriter = File.CreateText(pathCLientFile);
                        streamWriter.WriteLine(jsonString);
                        streamWriter.Close();
                        this.Hide();
                        ClientForm clientForm = new ClientForm();
                        clientForm.Show();
                    }
                }
            }
            if(sanoq == 0)
            {
                MessageBox.Show("Login yoki parol xato!");
            }
        }

        private void LkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
