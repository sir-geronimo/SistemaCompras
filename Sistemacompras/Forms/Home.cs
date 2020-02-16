using Sistemacompras.Forms;
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
        private readonly ItemRepository itemRepo;
        private readonly UserRepository userRepo;
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
            itemRepo = new ItemRepository();
            userRepo = new UserRepository();
            // requestRepo = new GenericRepository<ItemRequest>();
            // providerRepo = new GenericRepository<Provider>();
            // orderRepo = new GenericRepository<PurchaseOrder>();
            // statusRepo = new GenericRepository<Status>();
            // unitRepo = new GenericRepository<Unit>();
        }

        private void SetCrudName(string text, int active)
        {
            GenericCrudName.Text = text;
            activeGrid = active;
        }


        private void Home_Load(object sender, EventArgs e)
        {
            EmployeesBtn_Click(sender, e);
        }

        #region Crud Tables

        private void EmployeesBtn_Click(object sender, EventArgs e)
        {
            SetCrudName("Empleados", 0);
            DgvGeneric.DataSource = employeeRepo.GetAll();
        }

        private void DepartmentsBtn_Click(object sender, EventArgs e)
        {
            SetCrudName("Departamentos", 1);
            DgvGeneric.DataSource = departmentRepo.GetAll();
        }

        private void ItemsBtn_Click(object sender, EventArgs e)
        {
            SetCrudName("Articulos", 2);
            DgvGeneric.DataSource = itemRepo.GetAll();
        }

        private void BrandsBtn_Click(object sender, EventArgs e)
        {
            SetCrudName("Marcas", 3);
            DgvGeneric.DataSource = brandRepo.GetAll();
        }

        private void UnitBtn_Click(object sender, EventArgs e)
        {
            SetCrudName("Unidades de Medida", 4);
            // DgvGeneric.DataSource = unitRepo.GetAll();
        }

        private void ProvidersBtn_Click(object sender, EventArgs e)
        {
            SetCrudName("Proveedores", 5);
            // DgvGeneric.DataSource = providerRepo.GetAll();
        }

        private void RequestBtn_Click(object sender, EventArgs e)
        {
            SetCrudName("Registro de Solicitudes", 6);
            // DgvGeneric.DataSource = requestRepo.GetAll();
        }

        private void OrdersBtn_Click(object sender, EventArgs e)
        {
            SetCrudName("Ordenes de Compra", 7);
            // DgvGeneric.DataSource = orderRepo.GetAll();
        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            SetCrudName("Usuarios", 8);
            DgvGeneric.DataSource = userRepo.GetAll();
        }

        #endregion

        #region Crud Buttons
        private void NewBtn_Click(object sender, EventArgs e)
        {
            InitForm("Create");
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            InitForm("Edit");
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

        #region Form
        private void InitForm(string mode)
        {
            Form newForm;
            DataGridViewRow selectedRow = new DataGridViewRow();
            if (mode.Equals("Edit"))
            {
                try
                {
                    selectedRow = DgvGeneric.SelectedRows[0];
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(
                        text: "Debes seleccionar una fila",
                        caption: "Error",
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Error);
                }

            }

            switch (activeGrid)
            {
                case 0:
                    newForm = new EmployeeForm(mode, selectedRow);
                    newForm.ShowDialog();
                    break;
                case 1:
                    newForm = new DepartmentForm(mode, selectedRow);
                    newForm.ShowDialog();
                    break;
                case 2:
                    newForm = new ItemForm(mode, selectedRow);
                    newForm.ShowDialog();
                    break;
                case 3:
                    newForm = new BrandForm(mode, selectedRow);
                    newForm.ShowDialog();
                    break;
                case 8:
                    newForm = new UserForm(mode, selectedRow);
                    newForm.ShowDialog();
                    break;
            }
        }
        #endregion
    }
}
