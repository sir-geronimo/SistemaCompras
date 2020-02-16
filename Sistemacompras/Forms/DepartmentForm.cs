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
using Sistemacompras.Dto;

namespace Sistemacompras.Forms
{
    public partial class DepartmentForm : Form
    {
        private readonly string mode;
        public DataGridViewRow row;
        private readonly PurchaseContext _Context;
        private readonly DepartmentRepository departmentRepo;
        private DepartmentDto department;

        public DepartmentForm(string mode, DataGridViewRow row)
        {
            InitializeComponent();
            _Context = new PurchaseContext();
            departmentRepo = new DepartmentRepository();
            department = new DepartmentDto();

            if (mode != null)
            {
                this.mode = mode;

                if (this.mode.Equals("Create"))
                {
                    Text = "Crear Empleado";
                }

                if (this.mode.Equals("Edit"))
                {
                    Text = "Editar Empleado";
                    this.row = row;
                }
            }
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
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
                department = new DepartmentDto();

                try
                {
                    department.Id = int.Parse(row.Cells[0].Value.ToString());
                    department.Name = row.Cells[1].Value.ToString();
                    department.Status = row.Cells[2].Value.ToString();

                    IdTxt.Text = department.Id.ToString();
                    NameTxt.Text = department.Name;
                    StatusCbx.Text = department.Status;
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

                department.Id = int.Parse(id);
                department.Name = NameTxt.Text.ToString();
                department.Status = StatusCbx.SelectedIndex.ToString();

                Department item = new Department
                {
                    Id = department.Id,
                    Name = department.Name,
                    StatusId = StatusCbx.SelectedIndex + 1
                };

                if (mode.Equals("Create"))
                {
                    departmentRepo.Create(item);
                }
                else
                {
                    departmentRepo.Update(item);
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
