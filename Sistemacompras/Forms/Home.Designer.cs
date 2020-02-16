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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.EmployeesBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DepartmentsBtn = new System.Windows.Forms.Button();
            this.ItemsBtn = new System.Windows.Forms.Button();
            this.BrandsBtn = new System.Windows.Forms.Button();
            this.UnitBtn = new System.Windows.Forms.Button();
            this.ProvidersBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.NewBtn = new System.Windows.Forms.Button();
            this.DgvGeneric = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GenericCrudName = new System.Windows.Forms.Label();
            this.RequestBtn = new System.Windows.Forms.Button();
            this.OrdersBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.QueryTxt = new System.Windows.Forms.TextBox();
            this.CbxCriteria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UsersBtn = new System.Windows.Forms.Button();
            this.Btnx = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeneric)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeesBtn
            // 
            this.EmployeesBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EmployeesBtn.Location = new System.Drawing.Point(4, 23);
            this.EmployeesBtn.Name = "EmployeesBtn";
            this.EmployeesBtn.Size = new System.Drawing.Size(92, 34);
            this.EmployeesBtn.TabIndex = 0;
            this.EmployeesBtn.Text = "Empleados";
            this.EmployeesBtn.UseVisualStyleBackColor = false;
            this.EmployeesBtn.Click += new System.EventHandler(this.EmployeesBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mantenimientos";
            // 
            // DepartmentsBtn
            // 
            this.DepartmentsBtn.Location = new System.Drawing.Point(102, 23);
            this.DepartmentsBtn.Name = "DepartmentsBtn";
            this.DepartmentsBtn.Size = new System.Drawing.Size(99, 34);
            this.DepartmentsBtn.TabIndex = 2;
            this.DepartmentsBtn.Text = "Departamentos";
            this.DepartmentsBtn.UseVisualStyleBackColor = true;
            this.DepartmentsBtn.Click += new System.EventHandler(this.DepartmentsBtn_Click);
            // 
            // ItemsBtn
            // 
            this.ItemsBtn.Location = new System.Drawing.Point(207, 23);
            this.ItemsBtn.Name = "ItemsBtn";
            this.ItemsBtn.Size = new System.Drawing.Size(96, 34);
            this.ItemsBtn.TabIndex = 3;
            this.ItemsBtn.Text = "Articulos";
            this.ItemsBtn.UseVisualStyleBackColor = true;
            this.ItemsBtn.Click += new System.EventHandler(this.ItemsBtn_Click);
            // 
            // BrandsBtn
            // 
            this.BrandsBtn.Location = new System.Drawing.Point(309, 23);
            this.BrandsBtn.Name = "BrandsBtn";
            this.BrandsBtn.Size = new System.Drawing.Size(97, 34);
            this.BrandsBtn.TabIndex = 4;
            this.BrandsBtn.Text = "Marcas";
            this.BrandsBtn.UseVisualStyleBackColor = true;
            this.BrandsBtn.Click += new System.EventHandler(this.BrandsBtn_Click);
            // 
            // UnitBtn
            // 
            this.UnitBtn.Location = new System.Drawing.Point(4, 79);
            this.UnitBtn.Name = "UnitBtn";
            this.UnitBtn.Size = new System.Drawing.Size(92, 35);
            this.UnitBtn.TabIndex = 5;
            this.UnitBtn.Text = "Unidades de Medida";
            this.UnitBtn.UseVisualStyleBackColor = true;
            this.UnitBtn.Click += new System.EventHandler(this.UnitBtn_Click);
            // 
            // ProvidersBtn
            // 
            this.ProvidersBtn.Location = new System.Drawing.Point(102, 79);
            this.ProvidersBtn.Name = "ProvidersBtn";
            this.ProvidersBtn.Size = new System.Drawing.Size(99, 35);
            this.ProvidersBtn.TabIndex = 6;
            this.ProvidersBtn.Text = "Proveedores";
            this.ProvidersBtn.UseVisualStyleBackColor = true;
            this.ProvidersBtn.Click += new System.EventHandler(this.ProvidersBtn_Click);
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
            // RefreshBtn
            // 
            this.RefreshBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshBtn.BackgroundImage")));
            this.RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RefreshBtn.Location = new System.Drawing.Point(502, 28);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(64, 61);
            this.RefreshBtn.TabIndex = 12;
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.BackgroundImage")));
            this.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DeleteBtn.Location = new System.Drawing.Point(418, 28);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(64, 61);
            this.DeleteBtn.TabIndex = 11;
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditBtn.BackgroundImage")));
            this.EditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EditBtn.Location = new System.Drawing.Point(337, 28);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(64, 61);
            this.EditBtn.TabIndex = 10;
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // NewBtn
            // 
            this.NewBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewBtn.BackgroundImage")));
            this.NewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NewBtn.Location = new System.Drawing.Point(255, 28);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(64, 61);
            this.NewBtn.TabIndex = 9;
            this.NewBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // DgvGeneric
            // 
            this.DgvGeneric.AllowUserToAddRows = false;
            this.DgvGeneric.AllowUserToDeleteRows = false;
            this.DgvGeneric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGeneric.Location = new System.Drawing.Point(14, 37);
            this.DgvGeneric.Name = "DgvGeneric";
            this.DgvGeneric.ReadOnly = true;
            this.DgvGeneric.Size = new System.Drawing.Size(771, 368);
            this.DgvGeneric.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.GenericCrudName);
            this.panel2.Controls.Add(this.DgvGeneric);
            this.panel2.Location = new System.Drawing.Point(0, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 412);
            this.panel2.TabIndex = 9;
            // 
            // GenericCrudName
            // 
            this.GenericCrudName.AutoSize = true;
            this.GenericCrudName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenericCrudName.Location = new System.Drawing.Point(11, 12);
            this.GenericCrudName.Name = "GenericCrudName";
            this.GenericCrudName.Size = new System.Drawing.Size(21, 13);
            this.GenericCrudName.TabIndex = 9;
            this.GenericCrudName.Text = "<>";
            // 
            // RequestBtn
            // 
            this.RequestBtn.Location = new System.Drawing.Point(207, 78);
            this.RequestBtn.Name = "RequestBtn";
            this.RequestBtn.Size = new System.Drawing.Size(96, 36);
            this.RequestBtn.TabIndex = 7;
            this.RequestBtn.Text = "Solicitudes";
            this.RequestBtn.UseVisualStyleBackColor = true;
            this.RequestBtn.Click += new System.EventHandler(this.RequestBtn_Click);
            // 
            // OrdersBtn
            // 
            this.OrdersBtn.Location = new System.Drawing.Point(309, 79);
            this.OrdersBtn.Name = "OrdersBtn";
            this.OrdersBtn.Size = new System.Drawing.Size(97, 35);
            this.OrdersBtn.TabIndex = 8;
            this.OrdersBtn.Text = "Ordenes";
            this.OrdersBtn.UseVisualStyleBackColor = true;
            this.OrdersBtn.Click += new System.EventHandler(this.OrdersBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Btnx);
            this.panel3.Controls.Add(this.UsersBtn);
            this.panel3.Controls.Add(this.OrdersBtn);
            this.panel3.Controls.Add(this.RequestBtn);
            this.panel3.Controls.Add(this.ProvidersBtn);
            this.panel3.Controls.Add(this.UnitBtn);
            this.panel3.Controls.Add(this.BrandsBtn);
            this.panel3.Controls.Add(this.ItemsBtn);
            this.panel3.Controls.Add(this.DepartmentsBtn);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.EmployeesBtn);
            this.panel3.Location = new System.Drawing.Point(5, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(525, 125);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.SearchBtn);
            this.panel4.Controls.Add(this.QueryTxt);
            this.panel4.Controls.Add(this.CbxCriteria);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(542, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 125);
            this.panel4.TabIndex = 15;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("SearchBtn.Image")));
            this.SearchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchBtn.Location = new System.Drawing.Point(85, 84);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(116, 35);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "Buscar";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // QueryTxt
            // 
            this.QueryTxt.Location = new System.Drawing.Point(60, 58);
            this.QueryTxt.Name = "QueryTxt";
            this.QueryTxt.Size = new System.Drawing.Size(174, 20);
            this.QueryTxt.TabIndex = 1;
            // 
            // CbxCriteria
            // 
            this.CbxCriteria.FormattingEnabled = true;
            this.CbxCriteria.Location = new System.Drawing.Point(60, 25);
            this.CbxCriteria.Name = "CbxCriteria";
            this.CbxCriteria.Size = new System.Drawing.Size(174, 21);
            this.CbxCriteria.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Texto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Criterio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Busqueda";
            // 
            // UsersBtn
            // 
            this.UsersBtn.Location = new System.Drawing.Point(413, 23);
            this.UsersBtn.Name = "UsersBtn";
            this.UsersBtn.Size = new System.Drawing.Size(97, 34);
            this.UsersBtn.TabIndex = 9;
            this.UsersBtn.Text = "Usuarios";
            this.UsersBtn.UseVisualStyleBackColor = true;
            this.UsersBtn.Click += new System.EventHandler(this.UsersBtn_Click);
            // 
            // Btnx
            // 
            this.Btnx.Location = new System.Drawing.Point(413, 80);
            this.Btnx.Name = "Btnx";
            this.Btnx.Size = new System.Drawing.Size(97, 34);
            this.Btnx.TabIndex = 10;
            this.Btnx.Text = "?";
            this.Btnx.UseVisualStyleBackColor = true;
            this.Btnx.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 663);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Sistema de Compras";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeneric)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button RequestBtn;
        private System.Windows.Forms.Button OrdersBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox QueryTxt;
        private System.Windows.Forms.ComboBox CbxCriteria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btnx;
        private System.Windows.Forms.Button UsersBtn;
    }
}

