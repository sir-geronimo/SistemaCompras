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
    public partial class ItemForm : Form
    {
        public string mode;
        public DataGridViewRow row;
        private readonly ItemRepository itemRepo;
        private readonly PurchaseContext _Context;
        private readonly ItemDto item;

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
            var brands = _Context.Brands
                .Where(x => x.StatusId == (int)StatusEnum.Active)
                .Select(x => new
                {
                    x.Name
                })
                .ToArray();
            var units = _Context.Units
                .Where(x => x.StatusId == (int)StatusEnum.Active)
                .Select(x => new
                {
                    x.Name
                })
                .ToArray();
            var statuses = _Context.Statuses
                .Where(x => x.Id == (int)StatusEnum.Active
                    || x.Id == (int)StatusEnum.Inactive
                )
                .Select(x => new
                {
                    x.Name
                })
                .ToArray();

            foreach (var brand in brands)
            {
                BrandCbx.Items.Add(brand.Name ?? "");
            }

            foreach (var unit in units)
            {
                UnitCbx.Items.Add(unit.Name);
            }

            foreach (var status in statuses)
            {
                StatusCbx.Items.Add(status.Name);
            }

            if (mode.Equals("Create") == false)
            {
                try
                {
                    item.Id = int.Parse(row.Cells[0].Value?.ToString());
                    item.Name = row.Cells[1].Value?.ToString();
                    item.Description = row.Cells[2].Value?.ToString();
                    item.Brand = row.Cells[3].Value?.ToString();
                    item.Unit = row.Cells[4].Value?.ToString();

                    int.TryParse(row.Cells[5].Value?.ToString(), out int stock);
                    item.Stock = stock;

                    item.Status = row.Cells[6].Value?.ToString();

                    IdTxt.Text = item.Id.ToString();
                    NameTxt.Text = item.Name;
                    DescriptionTxt.Text = item.Description;
                    BrandCbx.Text = item.Brand;
                    UnitCbx.Text = item.Unit;
                    StockTxt.Text = item.Stock.ToString();
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
                item.Name = NameTxt.Text;
                item.Description = DescriptionTxt.Text;
                item.Brand = BrandCbx.SelectedIndex.ToString();
                item.Unit = UnitCbx.SelectedIndex.ToString();

                int.TryParse(StockTxt.Text, out int stock);
                item.Stock = stock;

                item.Status = StatusCbx.SelectedIndex.ToString();

                Item data = new Item
                {
                    Id = item.Id,
                    Name = item.Name,
                    Description = item.Description,
                    BrandId = _Context.Brands
                        .Where(x => x.Id == (BrandCbx.SelectedIndex + 1))
                        .Select(x => x.Id)
                        .FirstOrDefault(),
                    UnitId = _Context.Units
                        .Where(x => x.Id == (UnitCbx.SelectedIndex + 1))
                        .Select(x => x.Id)
                        .FirstOrDefault(),
                    Stock = item.Stock,
                    StatusId = _Context.Statuses
                        .Where(x => x.Id == (StatusCbx.SelectedIndex + 1))
                        .Select(x => x.Id)
                        .FirstOrDefault()
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
