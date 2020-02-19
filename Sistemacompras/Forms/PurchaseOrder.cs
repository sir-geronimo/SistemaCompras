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
    public partial class PurchaseOrderForm : Form
    {
        public string mode;
        public DataGridViewRow row;
        private readonly PurchaseOrderRepository purchaseOrderRepo;
        private readonly PurchaseContext _Context;
        private readonly PurchaseOrderDto purchase;

        public PurchaseOrderForm(string mode, DataGridViewRow row)
        {
            InitializeComponent();
            _Context = new PurchaseContext();
            purchaseOrderRepo = new PurchaseOrderRepository();
            purchase = new PurchaseOrderDto();

            if (mode != null)
            {
                this.mode = mode;

                if (this.mode.Equals("Create"))
                {
                    Text = "Crear Solicitud de Articulo";
                }

                if (this.mode.Equals("Edit"))
                {
                    Text = "Editar Solicitud de Articulo";
                    this.row = row;
                }
            }
        }

        private void PurchaseOrderForm_Load(object sender, EventArgs e)
        {
            var itemRequests = _Context.ItemRequests
                .Where(x => x.StatusId == (int)StatusEnum.Active)
                .Select(x => new
                {
                    x.Id
                })
                .ToArray();
            var brands = _Context.Brands
                .Where(x => x.StatusId == (int)StatusEnum.Active)
                .Select(x => new
                {
                    x.Name
                })
                .ToArray();
            var items = _Context.Items
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

            foreach (var itemRequest in itemRequests)
            {
                RequestCbx.Items.Add(itemRequest.Id);
            }

            foreach (var brand in brands)
            {
                BrandCbx.Items.Add(brand.Name);
            }

            foreach (var item in items)
            {
                ItemCbx.Items.Add(item.Name);
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
                    purchase.Id = int.Parse(row.Cells[0].Value?.ToString());
                    purchase.ItemRequest = int.Parse(row.Cells[1].Value?.ToString());
                    purchase.Date = Convert.ToDateTime(row.Cells[2].Value.ToString());
                    purchase.Status = row.Cells[3].Value?.ToString();
                    purchase.Item = row.Cells[4].Value?.ToString();

                    int.TryParse(row.Cells[5].Value?.ToString(), out int quantity);
                    purchase.Quantity = quantity;

                    purchase.Unit = row.Cells[6].Value?.ToString();
                    purchase.Brand = row.Cells[7].Value?.ToString();
                    
                    double.TryParse(row.Cells[5].Value?.ToString(), out double price);
                    purchase.Price = price;

                    IdTxt.Text = purchase.Id.ToString();
                    RequestCbx.Text = purchase.ItemRequest.ToString();
                    DatePckr.Value = purchase.Date;
                    StatusCbx.Text = purchase.Status;
                    ItemCbx.Text = purchase.Item;
                    QuantityTxt.Text = purchase.Quantity.ToString();
                    UnitCbx.Text = purchase.Unit;
                    BrandCbx.Text = purchase.Brand;
                    PriceTxt.Text = purchase.Price.ToString();
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
                string idRequest = "0";
                if (!RequestCbx.SelectedIndex.ToString().Equals(""))
                    idRequest = RequestCbx.SelectedIndex.ToString();

                purchase.Id = int.Parse(id);
                purchase.ItemRequest = int.Parse(idRequest);
                purchase.Date = DatePckr.Value;
                purchase.Status = StatusCbx.SelectedIndex.ToString();
                purchase.Item = ItemCbx.SelectedIndex.ToString();

                int.TryParse(QuantityTxt.Text, out int quantity);
                purchase.Quantity = quantity;

                purchase.Unit = UnitCbx.SelectedIndex.ToString();
                purchase.Brand = BrandCbx.SelectedIndex.ToString();
                    
                double.TryParse(PriceTxt.Text, out double price);
                purchase.Price = price;

                PurchaseOrder data = new PurchaseOrder
                {
                    Id = purchase.Id,
                    ItemRequestId = _Context.ItemRequests
                        .Where(x => x.Id == (RequestCbx.SelectedIndex + 1))
                        .Select(x => x.Id)
                        .FirstOrDefault(),
                    Date = purchase.Date,
                    StatusId = _Context.Statuses
                        .Where(x => x.Id == (StatusCbx.SelectedIndex + 1))
                        .Select(x => x.Id)
                        .FirstOrDefault(),
                    ItemId = _Context.Items
                        .Where(x => x.Id == (ItemCbx.SelectedIndex + 1))
                        .Select(x => x.Id)
                        .FirstOrDefault(),
                    Quantity = purchase.Quantity,
                    UnitId = _Context.Units
                        .Where(x => x.Id == (UnitCbx.SelectedIndex + 1))
                        .Select(x => x.Id)
                        .FirstOrDefault(),
                    BrandId = _Context.Brands
                        .Where(x => x.Id == (BrandCbx.SelectedIndex + 1))
                        .Select(x => x.Id)
                        .FirstOrDefault(),
                    Price = purchase.Price                    
                };

                if (mode.Equals("Create"))
                {
                    purchaseOrderRepo.Create(data);
                }
                else
                {
                    purchaseOrderRepo.Update(data);
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
