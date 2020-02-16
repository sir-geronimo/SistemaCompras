using Sistemacompras.Repositories;
using System;
using System.Windows.Forms;

namespace Sistemacompras
{
    public partial class Home : Form
    {
        private readonly BrandRepository brandRepo;
        private readonly DepartmentRepository departmentRepo;
        private readonly EmployeeRepository employeeRepo;
        // private readonly ItemRepository itemRepo;
        // private readonly ItemRequestRepository requestRepo;
        // private readonly ProviderRepository providerRepo;
        // private readonly PurchaseOrderRepository orderRepo;
        // private readonly StatusRepository statusRepo;
        // private readonly UnitRepository unitRepo;
        private int activeGrid;

        public Home()
        {
            InitializeComponent();
            brandRepo = new BrandRepository();
            departmentRepo = new DepartmentRepository();
            employeeRepo = new EmployeeRepository();
            // itemRepo = new GenericRepository<Item>();
            // requestRepo = new GenericRepository<ItemRequest>();
            // providerRepo = new GenericRepository<Provider>();
            // orderRepo = new GenericRepository<PurchaseOrder>();
            // statusRepo = new GenericRepository<Status>();
            // unitRepo = new GenericRepository<Unit>();
        }

        private void setCrudName(string text, int active)
        {
            GenericCrudName.Text = text;
            activeGrid = active;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            EmployeesBtn_Click(sender, e);
        }

        private void EmployeesBtn_Click(object sender, EventArgs e)
        {
            setCrudName("Empleados", 0);
            DgvGeneric.DataSource = employeeRepo.GetAll();
        }

        private void DepartmentsBtn_Click(object sender, EventArgs e)
        {
            setCrudName("Departamentos", 1);
            DgvGeneric.DataSource = departmentRepo.GetAll();
        }

        private void ItemsBtn_Click(object sender, EventArgs e)
        {
            setCrudName("Articulos", 2);
            // DgvGeneric.DataSource = itemRepo.GetAll();
        }

        private void BrandsBtn_Click(object sender, EventArgs e)
        {
            setCrudName("Marcas", 3);
            DgvGeneric.DataSource = brandRepo.GetAll();
        }

        private void UnitBtn_Click(object sender, EventArgs e)
        {
            setCrudName("Unidades de Medida", 4);
            // DgvGeneric.DataSource = unitRepo.GetAll();
        }

        private void ProvidersBtn_Click(object sender, EventArgs e)
        {
            setCrudName("Proveedores", 5);
            // DgvGeneric.DataSource = providerRepo.GetAll();
        }

        private void RequestBtn_Click(object sender, EventArgs e)
        {
            setCrudName("Registro de Solicitudes", 6);
            // DgvGeneric.DataSource = requestRepo.GetAll();
        }

        private void OrdersBtn_Click(object sender, EventArgs e)
        {
            setCrudName("Ordenes de Compra", 7);
            // DgvGeneric.DataSource = orderRepo.GetAll();
        }


        #region Crud Buttons
        private void NewBtn_Click(object sender, EventArgs e)
        {
            NewForm newForm = new NewForm("Create");
            newForm.ShowDialog();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            NewForm newForm = new NewForm("Edit");
            newForm.ShowDialog();
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
