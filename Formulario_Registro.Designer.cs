namespace SistemaDeEmpadronamiento
{
    partial class Formulario_Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario_Registro));
            this.cmbmunicipios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtprimernombre = new System.Windows.Forms.TextBox();
            this.cmbdepartamentos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtsegundonombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtprimerapellido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtsegundoapellido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.datenacimiento = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtcui = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbmunicipios
            // 
            this.cmbmunicipios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbmunicipios.FormattingEnabled = true;
            this.cmbmunicipios.Location = new System.Drawing.Point(0, 41);
            this.cmbmunicipios.Name = "cmbmunicipios";
            this.cmbmunicipios.Size = new System.Drawing.Size(545, 24);
            this.cmbmunicipios.TabIndex = 1;
            this.cmbmunicipios.SelectedIndexChanged += new System.EventHandler(this.cmbmunicipios_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 62);
            this.label2.TabIndex = 3;
            this.label2.Text = "Primer Nombre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 100);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Location = new System.Drawing.Point(0, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ingresa los datos de los ciudadanos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bienvenida, @Betza";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txtprimernombre);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(736, 62);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtprimernombre
            // 
            this.txtprimernombre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtprimernombre.Location = new System.Drawing.Point(191, 40);
            this.txtprimernombre.Name = "txtprimernombre";
            this.txtprimernombre.Size = new System.Drawing.Size(545, 22);
            this.txtprimernombre.TabIndex = 4;
            this.txtprimernombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbdepartamentos
            // 
            this.cmbdepartamentos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbdepartamentos.FormattingEnabled = true;
            this.cmbdepartamentos.Location = new System.Drawing.Point(0, 41);
            this.cmbdepartamentos.Name = "cmbdepartamentos";
            this.cmbdepartamentos.Size = new System.Drawing.Size(545, 24);
            this.cmbdepartamentos.TabIndex = 0;
            this.cmbdepartamentos.SelectedIndexChanged += new System.EventHandler(this.cmbdepartamentos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Departamento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.txtsegundonombre);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(736, 41);
            this.panel3.TabIndex = 6;
            // 
            // txtsegundonombre
            // 
            this.txtsegundonombre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtsegundonombre.Location = new System.Drawing.Point(191, 19);
            this.txtsegundonombre.Name = "txtsegundonombre";
            this.txtsegundonombre.Size = new System.Drawing.Size(545, 22);
            this.txtsegundonombre.TabIndex = 4;
            this.txtsegundonombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 41);
            this.label5.TabIndex = 3;
            this.label5.Text = "Segundo Nombre";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.txtprimerapellido);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 203);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(736, 62);
            this.panel4.TabIndex = 7;
            // 
            // txtprimerapellido
            // 
            this.txtprimerapellido.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtprimerapellido.Location = new System.Drawing.Point(191, 40);
            this.txtprimerapellido.Name = "txtprimerapellido";
            this.txtprimerapellido.Size = new System.Drawing.Size(545, 22);
            this.txtprimerapellido.TabIndex = 4;
            this.txtprimerapellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 62);
            this.label6.TabIndex = 3;
            this.label6.Text = "Primer Apellido";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.txtsegundoapellido);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 265);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(736, 41);
            this.panel5.TabIndex = 8;
            // 
            // txtsegundoapellido
            // 
            this.txtsegundoapellido.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtsegundoapellido.Location = new System.Drawing.Point(191, 19);
            this.txtsegundoapellido.Name = "txtsegundoapellido";
            this.txtsegundoapellido.Size = new System.Drawing.Size(545, 22);
            this.txtsegundoapellido.TabIndex = 4;
            this.txtsegundoapellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 41);
            this.label7.TabIndex = 3;
            this.label7.Text = "Segundo Apelllido";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.datenacimiento);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 306);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(736, 62);
            this.panel6.TabIndex = 9;
            // 
            // datenacimiento
            // 
            this.datenacimiento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datenacimiento.Location = new System.Drawing.Point(191, 40);
            this.datenacimiento.Name = "datenacimiento";
            this.datenacimiento.Size = new System.Drawing.Size(545, 22);
            this.datenacimiento.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 62);
            this.label8.TabIndex = 3;
            this.label8.Text = "Fecha de Nacimiento";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.txtcui);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 368);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(736, 44);
            this.panel7.TabIndex = 10;
            // 
            // txtcui
            // 
            this.txtcui.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtcui.Location = new System.Drawing.Point(191, 22);
            this.txtcui.Name = "txtcui";
            this.txtcui.Size = new System.Drawing.Size(545, 22);
            this.txtcui.TabIndex = 4;
            this.txtcui.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 44);
            this.label9.TabIndex = 3;
            this.label9.Text = "CUI";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 412);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(736, 65);
            this.panel8.TabIndex = 11;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.cmbdepartamentos);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(191, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(545, 65);
            this.panel9.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.label10);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 477);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(736, 65);
            this.panel10.TabIndex = 12;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.Controls.Add(this.cmbmunicipios);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(191, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(545, 65);
            this.panel11.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 65);
            this.label10.TabIndex = 2;
            this.label10.Text = "Municipios";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.IndianRed;
            this.btnRegistrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRegistrar.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRegistrar.Location = new System.Drawing.Point(595, 0);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(141, 75);
            this.btnRegistrar.TabIndex = 13;
            this.btnRegistrar.Text = "Registrar Ciudadano";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Transparent;
            this.panel12.Controls.Add(this.btnRegistrar);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(0, 625);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(736, 75);
            this.panel12.TabIndex = 14;
            // 
            // Formulario_Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(736, 700);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formulario_Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario_Registro";
            this.Load += new System.EventHandler(this.Formulario_Registro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbmunicipios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtprimernombre;
        private System.Windows.Forms.ComboBox cmbdepartamentos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtsegundonombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtprimerapellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtsegundoapellido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker datenacimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtcui;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Panel panel12;
    }
}