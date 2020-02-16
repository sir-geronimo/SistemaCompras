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
    public partial class ItemForm : Form
    {
        public string mode;
        public DataGridViewRow row;
        private readonly ItemRepository itemRepo;
        private readonly PurchaseContext _Context;
        private ItemDto item;

        public ItemForm(string mode, DataGridViewRow row)
        {
            InitializeComponent();
            _Context = new PurchaseContext();
            itemRepo = new ItemRepository();
            item = new ItemDto();

            if (mode != null)
            {
                this.mode = mode;

                if (this.mode.Equals("Create"))
                {
                    Text = "Crear Articulo";
                }

                if (this.mode.Equals("Edit"))
                {
                    Text = "Editar Articulo";
                    this.row = row;
                }
            }
        }

        private void ItemForm_Load(object sender, EventArgs e)
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
                    item.Id = int.Parse(row.Cells[0].Value.ToString());
                    item.Description = row.Cells[1].Value.ToString();
                    item.Status = row.Cells[2].Value.ToString();

                    IdTxt.Text = item.Id.ToString();
                    DescriptionTxt.Text = item.Description;
                    StatusCbx.Text = item.Status;
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

                item.Id = int.Parse(id);
                item.Description = DescriptionTxt.Text;
                item.Status = row.Cells[2].Value.ToString();

                Item data = new Item
                {
                    Id = item.Id,
                    Description = item.Description,
                    StatusId = StatusCbx.SelectedIndex + 1
                };

                if (mode.Equals("Create"))
                {
                    itemRepo.Create(data);
                }
                else
                {
                    itemRepo.Update(data);
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
