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
    public partial class ItemRequestForm : Form
    {
        public string mode;
        public DataGridViewRow row;
        private readonly ItemRequestRepository itemRequestRepo;
        private readonly PurchaseContext _Context;
        private readonly ItemRequestDto item;

        public ItemRequestForm(string mode, DataGridViewRow row)
        {
            InitializeComponent();
            _Context = new PurchaseContext();
            itemRequestRepo = new ItemRequestRepository();
            item = new ItemRequestDto();

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

        private void ItemRequestForm_Load(object sender, EventArgs e)
        {
            var employees = _Context.Employees
                .Where(x => x.StatusId == (int)StatusEnum.Active)
                .Select(x => new
                {
                    x.User.Name
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

            foreach (var employee in employees)
            {
                EmployeeCbx.Items.Add(employee.Name);
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
                    item.Id = int.Parse(row.Cells[0].Value?.ToString());
                    item.Employee = row.Cells[1].Value?.ToString();
                    item.Date = Convert.ToDateTime(row.Cells[2].Value.ToString());
                    item.Item = row.Cells[3].Value?.ToString();

                    int.TryParse(row.Cells[4].Value?.ToString(), out int quantity);
                    item.Quantity = quantity;

                    item.Unit = row.Cells[5].Value?.ToString();
                    item.Status = row.Cells[6].Value?.ToString();

                    IdTxt.Text = item.Id.ToString();
                    EmployeeCbx.Text = item.Employee;
                    DatePckr.Value = item.Date;
                    ItemCbx.Text = item.Item;
                    QuantityTxt.Text = item.Quantity.ToString();
                    UnitCbx.Text = item.Unit;
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
                item.Employee = EmployeeCbx.SelectedIndex.ToString();
                item.Date = DatePckr.Value;
                item.Item = ItemCbx.SelectedIndex.ToString();

                int.TryParse(QuantityTxt.Text, out int quantity);
                item.Quantity = quantity;

                item.Unit = UnitCbx.SelectedIndex.ToString();
                item.Status = StatusCbx.SelectedIndex.ToString();

                ItemRequest data = new ItemRequest
                {
                    Id = item.Id,
                    EmployeeId = _Context.Employees
                        .Where(x => x.Id == (EmployeeCbx.SelectedIndex + 1))
                        .Select(x => x.Id)
                        .FirstOrDefault(),
                    Date = item.Date,
                    ItemId = _Context.Items
                        .Where(x => x.Id == (ItemCbx.SelectedIndex + 1))
                        .Select(x => x.Id)
                        .FirstOrDefault(),
                    UnitId = _Context.Units
                        .Where(x => x.Id == (UnitCbx.SelectedIndex + 1))
                        .Select(x => x.Id)
                        .FirstOrDefault(),
                    Quantity = item.Quantity,
                    StatusId = _Context.Statuses
                        .Where(x => x.Id == (StatusCbx.SelectedIndex + 1))
                        .Select(x => x.Id)
                        .FirstOrDefault()
                };

                if (mode.Equals("Create"))
                {
                    itemRequestRepo.Create(data);
                }
                else
                {
                    itemRequestRepo.Update(data);
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
