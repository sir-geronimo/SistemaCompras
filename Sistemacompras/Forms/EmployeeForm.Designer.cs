namespace Sistemacompras.Forms
{
    partial class EmployeeForm
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
            this.DepartmentCbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserCbx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StatusCbx = new System.Windows.Forms.ComboBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DepartmentCbx
            // 
            this.DepartmentCbx.FormattingEnabled = true;
            this.DepartmentCbx.Location = new System.Drawing.Point(122, 106);
            this.DepartmentCbx.Name = "DepartmentCbx";
            this.DepartmentCbx.Size = new System.Drawing.Size(121, 21);
            this.DepartmentCbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Departamento";
            // 
            // UserCbx
            // 
            this.UserCbx.FormattingEnabled = true;
            this.UserCbx.Location = new System.Drawing.Point(122, 62);
            this.UserCbx.Name = "UserCbx";
            this.UserCbx.Size = new System.Drawing.Size(121, 21);
            this.UserCbx.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado";
            // 
            // StatusCbx
            // 
            this.StatusCbx.FormattingEnabled = true;
            this.StatusCbx.Location = new System.Drawing.Point(122, 150);
            this.StatusCbx.Name = "StatusCbx";
            this.StatusCbx.Size = new System.Drawing.Size(121, 21);
            this.StatusCbx.TabIndex = 5;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(122, 203);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(121, 36);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Guardar";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Id";
            // 
            // IdTxt
            // 
            this.IdTxt.Location = new System.Drawing.Point(122, 23);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.ReadOnly = true;
            this.IdTxt.Size = new System.Drawing.Size(121, 20);
            this.IdTxt.TabIndex = 8;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 251);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.StatusCbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserCbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DepartmentCbx);
            this.Name = "EmployeeForm";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.EmployeeForm_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DepartmentCbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox UserCbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox StatusCbx;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IdTxt;
    }
}