using Sistemacompras.Dto;
using Sistemacompras.Forms;
using Sistemacompras.Repositories;
using System;
using System.Collections.Generic;
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
        private readonly ProviderRepository providerRepo;
        // private readonly PurchaseOrderRepository orderRepo;
        // private readonly StatusRepository statusRepo;
        private readonly UnitRepository unitRepo;
        private int activeGrid;
        private List<Column> columns;

        public Home()
        {
            InitializeComponent();
            brandRepo = new BrandRepository();
            departmentRepo = new DepartmentRepository();
            employeeRepo = new EmployeeRepository();
            itemRepo = new ItemRepository();
            userRepo = new UserRepository();
            // requestRepo = new GenericRepository<ItemRequest>();
            providerRepo = new ProviderRepository();
            // orderRepo = new GenericRepository<PurchaseOrder>();
            // statusRepo = new GenericRepository<Status>();
            unitRepo = new UnitRepository();
        }


        private void Home_Load(object sender, EventArgs e)
        {
            EmployeesBtn_Click(sender, e);
        }

        private void SetCrudName(string text, int active, IEnumerable<object> data, List<Column> columns)
        {
            GenericCrudName.Text = text;
            activeGrid = active;
            DgvGeneric.DataSource = data;

            foreach (Column column in columns)
            {
                DgvGeneric.Columns[column.Name].HeaderText = column.Text;
            }
            DgvGeneric.AutoResizeColumns();
        }

        #region Crud Tables

        private void EmployeesBtn_Click(object sender, EventArgs e)
        {
            columns = new List<Column>()
            {
                new Column()
                {
                    Name = "Identification",
                    Text = "Identificacion"
                },
                new Column()
                {
                    Name = "Name",
                    Text = "Nombre"
                },
                new Column()
                {
                    Name = "Department",
                    Text = "Departamento"
                },
                new Column()
                {
                    Name = "Status",
                    Text = "Estado"
                },
                new Column()
                {
                    Name = "CreatedDate",
                    Text = "Fecha de Creacion"
                },
            };

            SetCrudName(
                text: "Empleados",
                active: 0,
                data: employeeRepo.GetAll(),
                columns: columns
            );
        }

        private void DepartmentsBtn_Click(object sender, EventArgs e)
        {
            columns = new List<Column>()
            {
                new Column()
                {
                    Name = "Name",
                    Text = "Nombre"
                },
                new Column()
                {
                    Name = "Status",
                    Text = "Estado"
                },
                new Column()
                {
                    Name = "CreatedDate",
                    Text = "Fecha de Creacion"
                },
            };

            SetCrudName(
                text: "Departamentos",
                active: 1,
                data: departmentRepo.GetAll(),
                columns: columns
            );
        }

        private void ItemsBtn_Click(object sender, EventArgs e)
        {
            columns = new List<Column>()
            {
                new Column()
                {
                    Name = "Name",
                    Text = "Nombre"
                },
                new Column()
                {
                    Name = "Description",
                    Text = "Descripcion"
                },
                new Column()
                {
                    Name = "Brand",
                    Text = "Marca"
                },
                new Column()
                {
                    Name = "Unit",
                    Text = "Unidad de Medida"
                },
                new Column()
                {
                    Name = "Stock",
                    Text = "Existencia"
                },
                new Column()
                {
                    Name = "Status",
                    Text = "Estado"
                },
                new Column()
                {
                    Name = "CreatedDate",
                    Text = "Fecha de Creacion"
                },
            };

            SetCrudName(
                text: "Articulos",
                active: 2,
                data: itemRepo.GetAll(),
                columns: columns
            );
        }

        private void BrandsBtn_Click(object sender, EventArgs e)
        {
            columns = new List<Column>()
            {
                new Column()
                {
                    Name = "Name",
                    Text = "Nombre"
                },
                new Column()
                {
                    Name = "Description",
                    Text = "Descripcion"
                },
                new Column()
                {
                    Name = "Status",
                    Text = "Estado"
                },
                new Column()
                {
                    Name = "CreatedDate",
                    Text = "Fecha de Creacion"
                },
            };

            SetCrudName(
                text: "Marcas",
                active: 3,
                data: brandRepo.GetAll(),
                columns: columns
            );
        }

        private void UnitBtn_Click(object sender, EventArgs e)
        {
            columns = new List<Column>()
            {
                new Column()
                {
                    Name = "Name",
                    Text = "Nombre"
                },
                new Column()
                {
                    Name = "Description",
                    Text = "Descripcion"
                },
                new Column()
                {
                    Name = "Status",
                    Text = "Estado"
                },
                new Column()
                {
                    Name = "CreatedDate",
                    Text = "Fecha de Creacion"
                },
            };

            SetCrudName(
                text: "Unidades de Medida",
                active: 4,
                data: unitRepo.GetAll(),
                columns: columns
            );
        }

        private void ProvidersBtn_Click(object sender, EventArgs e)
        {
            columns = new List<Column>()
            {
                new Column()
                {
                    Name = "Identification",
                    Text = "Identificacion"
                },
                new Column()
                {
                    Name = "Name",
                    Text = "Nombre"
                },
                new Column()
                {
                    Name = "PublicName",
                    Text = "Nombre Cormercial"
                },
                new Column()
                {
                    Name = "Status",
                    Text = "Estado"
                },
                new Column()
                {
                    Name = "CreatedDate",
                    Text = "Fecha de Creacion"
                },
            };

            SetCrudName(
                text: "Proveedores",
                active: 5,
                data: providerRepo.GetAll(),
                columns: columns
            );
        }

        private void RequestBtn_Click(object sender, EventArgs e)
        {
            // SetCrudName("Registro de Solicitudes", 6);
            // DgvGeneric.DataSource = requestRepo.GetAll();
        }

        private void OrdersBtn_Click(object sender, EventArgs e)
        {
            // SetCrudName("Ordenes de Compra", 7);
            // DgvGeneric.DataSource = orderRepo.GetAll();
        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            columns = new List<Column>()
            {
                new Column()
                {
                    Name = "Name",
                    Text = "Nombre"
                },
                new Column()
                {
                    Name = "Username",
                    Text = "Nombre de Usuario"
                },
                new Column()
                {
                    Name = "Identification",
                    Text = "Identificacion"
                },
                new Column()
                {
                    Name = "Status",
                    Text = "Estado"
                },
                new Column()
                {
                    Name = "CreatedDate",
                    Text = "Fecha de Creacion"
                },
            };

            SetCrudName(
                text: "Usuarios",
                active: 8,
                data: userRepo.GetAll(),
                columns: columns
            );
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
            DataGridViewRow selectedRow = new DataGridViewRow();
            try
            {
                selectedRow = DgvGeneric.SelectedRows[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            int idToDelete = int.Parse(selectedRow.Cells[0].Value.ToString());

            switch (activeGrid)
            {
                case 0:
                    if (idToDelete == employeeRepo.Get(idToDelete).Id)
                    {
                        employeeRepo.Delete(idToDelete);
                        ShowDeletedMessage(sender, e);
                    }
                    break;
                case 1:
                    if (idToDelete == departmentRepo.Get(idToDelete).Id)
                    {
                        departmentRepo.Delete(idToDelete);
                        ShowDeletedMessage(sender, e);
                    }
                    break;
                case 2:
                    if (idToDelete == itemRepo.Get(idToDelete).Id)
                    {
                        itemRepo.Delete(idToDelete);
                        ShowDeletedMessage(sender, e);
                    }
                    break;
                case 3:
                    if (idToDelete == brandRepo.Get(idToDelete).Id)
                    {
                        brandRepo.Delete(idToDelete);
                        ShowDeletedMessage(sender, e);
                    }
                    break;
                case 4:
                    if (idToDelete == unitRepo.Get(idToDelete).Id)
                    {
                        unitRepo.Delete(idToDelete);
                        ShowDeletedMessage(sender, e);
                    }
                    break;
                case 5:
                    if (idToDelete == providerRepo.Get(idToDelete).Id)
                    {
                        providerRepo.Delete(idToDelete);
                        ShowDeletedMessage(sender, e);
                    }
                    break;
                case 6:
                    // if (idToDelete == requestRepo.Get(idToDelete).Id)
                    // {
                    //     requestRepo.Delete(idToDelete);
                    //     ShowDeletedMessage(sender, e);
                    // }
                    break;
                case 7:
                    // if (idToDelete == orderRepo.Get(idToDelete).Id)
                    // {
                    //     orderRepo.Delete(idToDelete);
                    //     ShowDeletedMessage(sender, e);
                    // }
                    break;
                case 8:
                    if (idToDelete == userRepo.Get(idToDelete).Id)
                    {
                        userRepo.Delete(idToDelete);
                        ShowDeletedMessage(sender, e);
                    }
                    break;
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            switch (activeGrid)
            {
                case 0:
                    EmployeesBtn_Click(sender, e);
                    break;
                case 1:
                    DepartmentsBtn_Click(sender, e);
                    break;
                case 2:
                    ItemsBtn_Click(sender, e);
                    break;
                case 3:
                    BrandsBtn_Click(sender, e);
                    break;
                case 4:
                    UnitBtn_Click(sender, e);
                    break;
                case 5:
                    ProvidersBtn_Click(sender, e);
                    break;
                case 6:
                    RequestBtn_Click(sender, e);
                    break;
                case 7:
                    OrdersBtn_Click(sender, e);
                    break;
                case 8:
                    UsersBtn_Click(sender, e);
                    break;
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // TODO: Finish this
        }

        private void ShowDeletedMessage(object sender, EventArgs e)
        {
            MessageBox.Show(
                text: "Registro eliminado",
                caption: "Information",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Information);
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
                    return;
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
                case 4:
                    newForm = new UnitForm(mode, selectedRow);
                    newForm.ShowDialog();
                    break;
                case 5:
                    newForm = new ProviderForm(mode, selectedRow);
                    newForm.ShowDialog();
                    break;
                case 8:
                    newForm = new UserForm(mode, selectedRow);
                    newForm.ShowDialog();
                    break;
            }
        }
        #endregion

        private void Home_Activated(object sender, EventArgs e)
        {
            RefreshBtn_Click(sender, e);
        }
    }
}
