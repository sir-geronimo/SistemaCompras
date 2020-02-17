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
using Sistemacompras.Enum;

namespace Sistemacompras.Forms
{
    public partial class UnitForm : Form
    {
        public string mode;
        public DataGridViewRow row;
        private readonly UnitRepository unitRepo;
        private readonly PurchaseContext _Context;
        private readonly UnitDto unit;

        public UnitForm(string mode, DataGridViewRow row)
        {
            InitializeComponent();
            _Context = new PurchaseContext();
            unitRepo = new UnitRepository();
            unit = new UnitDto();

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

        private void UnitForm_Load(object sender, EventArgs e)
        {
            var statuses = _Context.Statuses
                .Where(x => x.Id == (int)StatusEnum.Active
                    || x.Id == (int)StatusEnum.Inactive
                )
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
                    unit.Id = int.Parse(row.Cells[0].Value.ToString());
                    unit.Name = row.Cells[1].Value?.ToString();
                    unit.Description = row.Cells[2].Value?.ToString();
                    unit.Status = row.Cells[3].Value?.ToString();

                    IdTxt.Text = unit.Id.ToString();
                    NameTxt.Text = unit.Name;
                    DescriptionTxt.Text = unit.Description;
                    StatusCbx.Text = unit.Status;
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

                unit.Id = int.Parse(id);
                unit.Name = NameTxt.Text;
                unit.Description = DescriptionTxt.Text;
                unit.Status = StatusCbx.SelectedIndex.ToString();

                Unit item = new Unit
                {
                    Id = unit.Id,
                    Name = unit.Name,
                    Description = unit.Description,
                    StatusId = _Context.Statuses
                        .Where(x => x.Id == (StatusCbx.SelectedIndex + 1))
                        .Select(x => x.Id)
                        .FirstOrDefault()
                };

                if (mode.Equals("Create"))
                {
                    unitRepo.Create(item);
                }
                else
                {
                    unitRepo.Update(item);
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
