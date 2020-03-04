using Sistemacompras.Repositories;
using System;
using System.Windows.Forms;

namespace Sistemacompras.Forms
{
    public partial class LoginForm : Form
    {
        private readonly UserRepository userRepo;

        public LoginForm()
        {
            InitializeComponent();
            userRepo = new UserRepository();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTxt.Text;
            string password = PasswordTxt.Text;

            if (userRepo.Login(username, password))
            {
                MessageBox.Show(
                    text: "Acceso correcto",
                    caption: "Exito",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Information
                );
                new Home().ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show(
                    text: "Credenciales incorrectas",
                    caption: "Error",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Warning
                );
            }
        }

        private async void RegisterBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new UserForm("Create").ShowDialog();
            // Implement register logic
        }

    }
}
