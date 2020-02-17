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
    public partial class ProviderForm : Form
    {
        public string mode;
        public DataGridViewRow row;
        private readonly ProviderRepository providerRepo;
        private readonly PurchaseContext _Context;
        private readonly ProviderDto provider;

        public ProviderForm(string mode, DataGridViewRow row)
        {
            InitializeComponent();
            _Context = new PurchaseContext();
            providerRepo = new ProviderRepository();
            provider = new ProviderDto();

            if (mode != null)
            {
                this.mode = mode;

                if (this.mode.Equals("Create"))
                {
                    Text = "Crear Unidad de Medida";
                }

                if (this.mode.Equals("Edit"))
                {
                    Text = "Editar Unidad de Medida";
                    this.row = row;
                }
            }
        }

        private void ProviderForm_Load(object sender, EventArgs e)
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
                    provider.Id = int.Parse(row.Cells[0].Value.ToString());
                    provider.Identification = row.Cells[1].Value?.ToString();
                    provider.Name = row.Cells[2].Value?.ToString();
                    provider.PublicName = row.Cells[3].Value?.ToString();
                    provider.Status = row.Cells[4].Value?.ToString();

                    IdTxt.Text = provider.Id.ToString();
                    IdentificationTxt.Text = provider.Identification;
                    NameTxt.Text = provider.Name;
                    PublicNameTxt.Text = provider.PublicName;
                    StatusCbx.Text = provider.Status;
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

                provider.Id = int.Parse(id);
                provider.Identification = IdentificationTxt.Text;
                provider.Name = NameTxt.Text;
                provider.PublicName = PublicNameTxt.Text;
                provider.Status = StatusCbx.SelectedIndex.ToString();

                Provider item = new Provider
                {
                    Id = provider.Id,
                    Identification = provider.Identification,
                    Name = provider.Name,
                    PublicName = provider.PublicName,
                    StatusId = _Context.Statuses
                        .Where(x => x.Id == (StatusCbx.SelectedIndex + 1))
                        .Select(x => x.Id)
                        .FirstOrDefault()
                };

                if (mode.Equals("Create"))
                {
                    providerRepo.Create(item);
                }
                else
                {
                    providerRepo.Update(item);
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
