using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistemacompras.Entities;
using Sistemacompras.Repositories;

namespace Sistemacompras
{
    public partial class Home : Form
    {
        private readonly GenericRepository<Brand> brandRepo;
        private readonly GenericRepository<Department> departmentRepo;
        private readonly GenericRepository<Employee> employeeRepo;
        private readonly GenericRepository<Item> itemRepo;
        private readonly GenericRepository<ItemRequest> itemRequestRepo;
        private readonly GenericRepository<Provider> providerRepo;
        private readonly GenericRepository<PurchaseOrder> purchaseOrderRepo;
        private readonly GenericRepository<Status> statusRepo;
        private readonly GenericRepository<Unit> unitRepo;

        public Home()
        {
            InitializeComponent();
            brandRepo = new GenericRepository<Brand>();
            departmentRepo = new GenericRepository<Department>();
            employeeRepo = new GenericRepository<Employee>();
            itemRepo = new GenericRepository<Item>();
            itemRequestRepo = new GenericRepository<ItemRequest>();
            providerRepo = new GenericRepository<Provider>();
            purchaseOrderRepo = new GenericRepository<PurchaseOrder>();
            statusRepo = new GenericRepository<Status>();
            unitRepo = new GenericRepository<Unit>();
        }

        private void setCrudName(string text)
        {
            GenericCrudName.Text = text;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            EmployeesBtn_Click(sender, e);
        }

        private void EmployeesBtn_Click(object sender, EventArgs e)
        {
            setCrudName("Empleados");
        }

        private void DepartmentsBtn_Click(object sender, EventArgs e)
        {
            setCrudName("Departamentos");
        }

        private void ItemsBtn_Click(object sender, EventArgs e)
        {
            setCrudName("Articulos");
        }

        private void BrandsBtn_Click(object sender, EventArgs e)
        {
            setCrudName("Marcas");
        }

        private void UnitBtn_Click(object sender, EventArgs e)
        {
            setCrudName("Unidades de medida");
        }

        private void ProvidersBtn_Click(object sender, EventArgs e)
        {
            setCrudName("Proveedores");
        }

        private void RequestBtn_Click(object sender, EventArgs e)
        {
            setCrudName("Registro de Solicitudes");
        }

        private void OrdersBtn_Click(object sender, EventArgs e)
        {
            setCrudName("Ordenes de Compra");
        }


        #region CrudButtons
        private void NewBtn_Click(object sender, EventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
