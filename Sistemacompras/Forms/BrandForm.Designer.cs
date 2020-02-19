namespace Sistemacompras.Forms
{
    partial class BrandForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.StatusCbx = new System.Windows.Forms.ComboBox();
            this.DescriptionTxt = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // IdTxt
            // 
            this.IdTxt.Location = new System.Drawing.Point(125, 20);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.ReadOnly = true;
            this.IdTxt.Size = new System.Drawing.Size(121, 20);
            this.IdTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Descripcion";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(125, 222);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(121, 36);
            this.SaveBtn.TabIndex = 15;
            this.SaveBtn.Text = "Guardar";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Estado";
            // 
            // StatusCbx
            // 
            this.StatusCbx.FormattingEnabled = true;
            this.StatusCbx.Location = new System.Drawing.Point(125, 176);
            this.StatusCbx.Name = "StatusCbx";
            this.StatusCbx.Size = new System.Drawing.Size(121, 21);
            this.StatusCbx.TabIndex = 14;
            // 
            // DescriptionTxt
            // 
            this.DescriptionTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionTxt.Location = new System.Drawing.Point(125, 105);
            this.DescriptionTxt.Name = "DescriptionTxt";
            this.DescriptionTxt.Size = new System.Drawing.Size(121, 58);
            this.DescriptionTxt.TabIndex = 14;
            this.DescriptionTxt.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nombre";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(125, 63);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(121, 20);
            this.NameTxt.TabIndex = 17;
            // 
            // BrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 270);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DescriptionTxt);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.StatusCbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.label1);
            this.Name = "BrandForm";
            this.Text = "Marca";
            this.Load += new System.EventHandler(this.BrandForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox StatusCbx;
        private System.Windows.Forms.RichTextBox DescriptionTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTxt;
    }
}