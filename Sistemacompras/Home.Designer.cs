namespace Sistemacompras
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmployeesBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DepartmentsBtn = new System.Windows.Forms.Button();
            this.ItemsBtn = new System.Windows.Forms.Button();
            this.BrandsBtn = new System.Windows.Forms.Button();
            this.UnitBtn = new System.Windows.Forms.Button();
            this.ProvidersBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.DgvGeneric = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GenericCrudName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeneric)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeesBtn
            // 
            this.EmployeesBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EmployeesBtn.Location = new System.Drawing.Point(12, 54);
            this.EmployeesBtn.Name = "EmployeesBtn";
            this.EmployeesBtn.Size = new System.Drawing.Size(127, 58);
            this.EmployeesBtn.TabIndex = 0;
            this.EmployeesBtn.Text = "Empleados";
            this.EmployeesBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mantenimientos";
            // 
            // DepartmentsBtn
            // 
            this.DepartmentsBtn.Location = new System.Drawing.Point(145, 54);
            this.DepartmentsBtn.Name = "DepartmentsBtn";
            this.DepartmentsBtn.Size = new System.Drawing.Size(124, 58);
            this.DepartmentsBtn.TabIndex = 2;
            this.DepartmentsBtn.Text = "Departamentos";
            this.DepartmentsBtn.UseVisualStyleBackColor = true;
            // 
            // ItemsBtn
            // 
            this.ItemsBtn.Location = new System.Drawing.Point(275, 54);
            this.ItemsBtn.Name = "ItemsBtn";
            this.ItemsBtn.Size = new System.Drawing.Size(125, 58);
            this.ItemsBtn.TabIndex = 3;
            this.ItemsBtn.Text = "Articulos";
            this.ItemsBtn.UseVisualStyleBackColor = true;
            // 
            // BrandsBtn
            // 
            this.BrandsBtn.Location = new System.Drawing.Point(406, 54);
            this.BrandsBtn.Name = "BrandsBtn";
            this.BrandsBtn.Size = new System.Drawing.Size(124, 58);
            this.BrandsBtn.TabIndex = 4;
            this.BrandsBtn.Text = "Marcas";
            this.BrandsBtn.UseVisualStyleBackColor = true;
            // 
            // UnitBtn
            // 
            this.UnitBtn.Location = new System.Drawing.Point(536, 54);
            this.UnitBtn.Name = "UnitBtn";
            this.UnitBtn.Size = new System.Drawing.Size(127, 58);
            this.UnitBtn.TabIndex = 5;
            this.UnitBtn.Text = "Unidades de Medida";
            this.UnitBtn.UseVisualStyleBackColor = true;
            // 
            // ProvidersBtn
            // 
            this.ProvidersBtn.Location = new System.Drawing.Point(669, 54);
            this.ProvidersBtn.Name = "ProvidersBtn";
            this.ProvidersBtn.Size = new System.Drawing.Size(119, 58);
            this.ProvidersBtn.TabIndex = 6;
            this.ProvidersBtn.Text = "Proveedores";
            this.ProvidersBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.RefreshBtn);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.EditBtn);
            this.panel1.Controls.Add(this.NewBtn);
            this.panel1.Location = new System.Drawing.Point(0, 550);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 116);
            this.panel1.TabIndex = 7;
            // 
            // NewBtn
            // 
            this.NewBtn.Location = new System.Drawing.Point(237, 28);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(64, 61);
            this.NewBtn.TabIndex = 0;
            this.NewBtn.Text = "Nuevo";
            this.NewBtn.UseVisualStyleBackColor = true;
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(319, 28);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(64, 61);
            this.EditBtn.TabIndex = 1;
            this.EditBtn.Text = "Editar";
            this.EditBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(400, 28);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(64, 61);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Eliminar";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(484, 28);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(64, 61);
            this.RefreshBtn.TabIndex = 3;
            this.RefreshBtn.Text = "Actualizar";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            // 
            // DgvGeneric
            // 
            this.DgvGeneric.AllowUserToAddRows = false;
            this.DgvGeneric.AllowUserToDeleteRows = false;
            this.DgvGeneric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGeneric.Location = new System.Drawing.Point(14, 37);
            this.DgvGeneric.Name = "DgvGeneric";
            this.DgvGeneric.ReadOnly = true;
            this.DgvGeneric.Size = new System.Drawing.Size(755, 368);
            this.DgvGeneric.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.GenericCrudName);
            this.panel2.Controls.Add(this.DgvGeneric);
            this.panel2.Location = new System.Drawing.Point(0, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 421);
            this.panel2.TabIndex = 9;
            // 
            // GenericCrudName
            // 
            this.GenericCrudName.AutoSize = true;
            this.GenericCrudName.Location = new System.Drawing.Point(11, 12);
            this.GenericCrudName.Name = "GenericCrudName";
            this.GenericCrudName.Size = new System.Drawing.Size(19, 13);
            this.GenericCrudName.TabIndex = 9;
            this.GenericCrudName.Text = "<>";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 669);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ProvidersBtn);
            this.Controls.Add(this.UnitBtn);
            this.Controls.Add(this.BrandsBtn);
            this.Controls.Add(this.ItemsBtn);
            this.Controls.Add(this.DepartmentsBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeesBtn);
            this.Name = "Home";
            this.Text = "Sistema de Compras";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeneric)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EmployeesBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DepartmentsBtn;
        private System.Windows.Forms.Button ItemsBtn;
        private System.Windows.Forms.Button BrandsBtn;
        private System.Windows.Forms.Button UnitBtn;
        private System.Windows.Forms.Button ProvidersBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.DataGridView DgvGeneric;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label GenericCrudName;
    }
}

