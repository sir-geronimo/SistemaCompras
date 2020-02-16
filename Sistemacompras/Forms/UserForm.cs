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
    public partial class UserForm : Form
    {
        public string mode;
        public DataGridViewRow row;
        private readonly UserRepository userRepo;
        private readonly PurchaseContext _Context;
        private readonly UserDto user;

        public UserForm(string mode, DataGridViewRow row)
        {
            InitializeComponent();
            _Context = new PurchaseContext();
            userRepo = new UserRepository();
            user = new UserDto();

            if (mode != null)
            {
                this.mode = mode;

                if (this.mode.Equals("Create"))
                {
                    Text = "Crear Marca";
                }

                if (this.mode.Equals("Edit"))
                {
                    Text = "Editar Marca";
                    this.row = row;
                }
            }
        }
    }
}
