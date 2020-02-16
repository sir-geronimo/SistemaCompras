using System.Windows.Forms;

namespace Sistemacompras
{
    public partial class NewForm : Form
    {
        public string Mode;

        public NewForm(string mode)
        {
            InitializeComponent();
            if (mode != null)
            {
                Mode = mode;

                if (Mode.Equals("Create"))
                {
                    this.Text = "Crear";
                }

                if (Mode.Equals("Edit"))
                {
                    this.Text = "Editar";
                }
            }
        }
    }
}
