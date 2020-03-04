using Sistemacompras.Dto;
using Sistemacompras.Entities;
using Sistemacompras.Enum;
using Sistemacompras.Repositories;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Sistemacompras.Forms
{
    public partial class UserForm : Form
    {
        public string mode;
        public DataGridViewRow row;
        private readonly UserRepository userRepo;
        private readonly PurchaseContext _Context;
        private readonly UserDto user;

        public UserForm(string mode, DataGridViewRow row = null)
        {
            InitializeComponent();
            _Context = new PurchaseContext();
            userRepo = new UserRepository();
            user = new UserDto();

            if (mode != null)
            {
                this.mode = mode;

                if (this.mode.Equals("Create"))
                {
                    Text = "Crear Usuario";
                }

                if (this.mode.Equals("Edit"))
                {
                    Text = "Editar Usuario";
                    this.row = row;
                }
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            var statuses = _Context.Statuses
                .Where(x => x.Id == (int)StatusEnum.Active
                    || x.Id == (int)StatusEnum.Inactive
                )
                .Select(x => new
                {
                    x.Name
                })
                .ToArray();

            foreach (var status in statuses)
            {
                StatusCbx.Items.Add(status.Name);
            }

            if (mode.Equals("Create") == false)
            {
                try
                {
                    user.Id = int.Parse(row.Cells[0].Value.ToString());
                    user.Name = row.Cells[1].Value?.ToString();
                    user.Username = row.Cells[2].Value?.ToString();
                    user.Identification = row.Cells[3].Value?.ToString();
                    user.Status = row.Cells[4].Value?.ToString();

                    IdTxt.Text = user.Id.ToString();
                    NameTxt.Text = user.Name;
                    UsernameTxt.Text = user.Username;
                    IdentificationTxt.Text = user.Identification;
                    StatusCbx.Text = user.Status;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(
                        text: "Error cargando los datos",
                        caption: "Error",
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Error);
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                if (!IdTxt.Text.Equals(""))
                    id = IdTxt.Text.ToString();

                user.Id = int.Parse(id);
                user.Name = NameTxt.Text;
                user.Username = UsernameTxt.Text;
                user.Identification = IdentificationTxt.Text;
                user.Status = StatusCbx.SelectedIndex.ToString();

                User item = new User
                {
                    Id = user.Id,
                    Name = user.Name,
                    Username = user.Username,
                    Identification = user.Identification,
                    StatusId = _Context.Statuses
                        .Where(x => x.Id == (StatusCbx.SelectedIndex + 1))
                        .Select(x => x.Id)
                        .FirstOrDefault()
                };

                if (mode.Equals("Create"))
                {
                    userRepo.Create(item);
                }
                else
                {
                    userRepo.Update(item);
                }

                Close();

                MessageBox.Show(
                    text: "Registro guardado con exito",
                    caption: "Informacion",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(
                    text: "Error al guardar los datos",
                    caption: "Error",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error);
            }
        }
    }
}
