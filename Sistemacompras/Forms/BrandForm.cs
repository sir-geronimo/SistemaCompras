using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistemacompras.Repositories;
using Sistemacompras.Dto;
using Sistemacompras.Entities;

namespace Sistemacompras.Forms
{
    public partial class BrandForm : Form
    {
        public string mode;
        public DataGridViewRow row;
        private readonly BrandRepository brandRepo;
        private readonly PurchaseContext _Context;
        private readonly BrandDto brand;

        public BrandForm(string mode, DataGridViewRow row)
        {
            InitializeComponent();
            _Context = new PurchaseContext();
            brandRepo = new BrandRepository();
            brand = new BrandDto();

            if (mode != null)
            {
                this.mode = mode;

                if (this.mode.Equals("Create"))
                {
                    Text = "Crear Marca";
                }

                if (this.mode.Equals("Edit"))
                {
                    Text = "Editar Marca";
                    this.row = row;
                }
            }
        }

        private void BrandForm_Load(object sender, EventArgs e)
        {
            var statuses = _Context.Statuses
                .Select(x => new {
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
                    brand.Id = int.Parse(row.Cells[0].Value.ToString());
                    brand.Description = row.Cells[1].Value.ToString() ?? "";
                    brand.Status = row.Cells[2].Value.ToString();

                    IdTxt.Text = brand.Id.ToString();
                    DescriptionTxt.Text = brand.Description;
                    StatusCbx.Text = brand.Status;
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

                brand.Id = int.Parse(id);
                brand.Description = DescriptionTxt.Text;
                brand.Status = StatusCbx.SelectedIndex.ToString();

                Brand item = new Brand
                {
                    Id = brand.Id,
                    Description = brand.Description,
                    StatusId = StatusCbx.SelectedIndex + 1
                };

                if (mode.Equals("Create"))
                {
                    brandRepo.Create(item);
                }
                else
                {
                    brandRepo.Update(item);
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
