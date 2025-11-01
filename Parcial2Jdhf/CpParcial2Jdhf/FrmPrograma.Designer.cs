using System.Windows.Forms;
using System.Drawing;

namespace CpParcial2Jdhf
{
    partial class FrmPrograma
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.gbxListado = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.cbxCanal = new System.Windows.Forms.ComboBox();
            this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.txtProductor = new System.Windows.Forms.TextBox();
            this.nudDuracion = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblProductor = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCanal = new System.Windows.Forms.Label();
            this.btnCanelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbxListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.pnlAcciones.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("BubbleGum", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(783, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROGRAMAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("BubbleGum", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar el programa por nombre o titulo";
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(423, 40);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(262, 24);
            this.txtParametro.TabIndex = 2;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // gbxListado
            // 
            this.gbxListado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxListado.Controls.Add(this.dgvLista);
            this.gbxListado.Font = new System.Drawing.Font("BubbleGum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxListado.Location = new System.Drawing.Point(12, 85);
            this.gbxListado.Name = "gbxListado";
            this.gbxListado.Size = new System.Drawing.Size(776, 182);
            this.gbxListado.TabIndex = 4;
            this.gbxListado.TabStop = false;
            this.gbxListado.Text = "Lista de Programas";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(6, 28);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(764, 149);
            this.dgvLista.TabIndex = 0;
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnCancelar);
            this.pnlAcciones.Controls.Add(this.btnEditar);
            this.pnlAcciones.Controls.Add(this.btnBorrar);
            this.pnlAcciones.Controls.Add(this.btnCrear);
            this.pnlAcciones.Location = new System.Drawing.Point(31, 273);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(757, 51);
            this.pnlAcciones.TabIndex = 7;
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.cbxCanal);
            this.gbxDatos.Controls.Add(this.btnCanelar);
            this.gbxDatos.Controls.Add(this.dtpFechaCreacion);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Controls.Add(this.txtProductor);
            this.gbxDatos.Controls.Add(this.nudDuracion);
            this.gbxDatos.Controls.Add(this.textBox1);
            this.gbxDatos.Controls.Add(this.txtTitulo);
            this.gbxDatos.Controls.Add(this.lblFechaCreacion);
            this.gbxDatos.Controls.Add(this.lblDescripcion);
            this.gbxDatos.Controls.Add(this.lblProductor);
            this.gbxDatos.Controls.Add(this.lblDuracion);
            this.gbxDatos.Controls.Add(this.lblTitulo);
            this.gbxDatos.Controls.Add(this.lblCanal);
            this.gbxDatos.Font = new System.Drawing.Font("BubbleGum", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatos.Location = new System.Drawing.Point(12, 330);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(776, 158);
            this.gbxDatos.TabIndex = 12;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Introducir datos";
            // 
            // cbxCanal
            // 
            this.cbxCanal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCanal.FormattingEnabled = true;
            this.cbxCanal.Location = new System.Drawing.Point(158, 21);
            this.cbxCanal.Name = "cbxCanal";
            this.cbxCanal.Size = new System.Drawing.Size(184, 23);
            this.cbxCanal.TabIndex = 22;
            // 
            // dtpFechaCreacion
            // 
            this.dtpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCreacion.Location = new System.Drawing.Point(503, 56);
            this.dtpFechaCreacion.Name = "dtpFechaCreacion";
            this.dtpFechaCreacion.Size = new System.Drawing.Size(267, 23);
            this.dtpFechaCreacion.TabIndex = 19;
            // 
            // txtProductor
            // 
            this.txtProductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProductor.Location = new System.Drawing.Point(634, 16);
            this.txtProductor.MaxLength = 20;
            this.txtProductor.Name = "txtProductor";
            this.txtProductor.Size = new System.Drawing.Size(136, 23);
            this.txtProductor.TabIndex = 18;
            // 
            // nudDuracion
            // 
            this.nudDuracion.Location = new System.Drawing.Point(426, 21);
            this.nudDuracion.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDuracion.Name = "nudDuracion";
            this.nudDuracion.Size = new System.Drawing.Size(102, 23);
            this.nudDuracion.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(158, 88);
            this.textBox1.MaxLength = 20;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 61);
            this.textBox1.TabIndex = 16;
            // 
            // txtTitulo
            // 
            this.txtTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTitulo.Location = new System.Drawing.Point(158, 53);
            this.txtTitulo.MaxLength = 20;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(184, 23);
            this.txtTitulo.TabIndex = 15;
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Font = new System.Drawing.Font("BubbleGum", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCreacion.Location = new System.Drawing.Point(361, 61);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(129, 15);
            this.lblFechaCreacion.TabIndex = 13;
            this.lblFechaCreacion.Text = "Fecha Creacion:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(16, 91);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(101, 15);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblProductor
            // 
            this.lblProductor.AutoSize = true;
            this.lblProductor.Location = new System.Drawing.Point(534, 24);
            this.lblProductor.Name = "lblProductor";
            this.lblProductor.Size = new System.Drawing.Size(94, 15);
            this.lblProductor.TabIndex = 11;
            this.lblProductor.Text = "Productor:";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(348, 24);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(83, 15);
            this.lblDuracion.TabIndex = 10;
            this.lblDuracion.Text = "Duracion:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(16, 56);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(62, 15);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblCanal
            // 
            this.lblCanal.AutoSize = true;
            this.lblCanal.Location = new System.Drawing.Point(16, 24);
            this.lblCanal.Name = "lblCanal";
            this.lblCanal.Size = new System.Drawing.Size(147, 15);
            this.lblCanal.TabIndex = 8;
            this.lblCanal.Text = "Nombre del Canal:";
            // 
            // btnCanelar
            // 
            this.btnCanelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnCanelar.Image = global::CpParcial2Jdhf.Properties.Resources.cancel;
            this.btnCanelar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCanelar.Location = new System.Drawing.Point(572, 88);
            this.btnCanelar.Name = "btnCanelar";
            this.btnCanelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCanelar.Size = new System.Drawing.Size(73, 61);
            this.btnCanelar.TabIndex = 21;
            this.btnCanelar.Text = "Cancelar";
            this.btnCanelar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCanelar.UseVisualStyleBackColor = true;
            this.btnCanelar.Click += new System.EventHandler(this.btnCanelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Image = global::CpParcial2Jdhf.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.Location = new System.Drawing.Point(470, 87);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGuardar.Size = new System.Drawing.Size(73, 62);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Image = global::CpParcial2Jdhf.Properties.Resources.close;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(486, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancelar.Size = new System.Drawing.Size(98, 45);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Khaki;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEditar.Image = global::CpParcial2Jdhf.Properties.Resources.edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(274, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEditar.Size = new System.Drawing.Size(89, 45);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBorrar.Image = global::CpParcial2Jdhf.Properties.Resources.delete;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(380, 3);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBorrar.Size = new System.Drawing.Size(100, 45);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCrear.Image = global::CpParcial2Jdhf.Properties.Resources._new;
            this.btnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrear.Location = new System.Drawing.Point(170, 3);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCrear.Size = new System.Drawing.Size(98, 45);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Nuevo";
            this.btnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::CpParcial2Jdhf.Properties.Resources.search;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(691, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 42);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(807, 609);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.gbxListado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmPrograma";
            this.Text = "::: Programa - Parcial :::";
            this.Load += new System.EventHandler(this.FrmPrograma_Load);
            this.gbxListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.pnlAcciones.ResumeLayout(false);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbxListado;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.ComboBox cbxCanal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCanelar;
        private System.Windows.Forms.DateTimePicker dtpFechaCreacion;
        private System.Windows.Forms.TextBox txtProductor;
        private System.Windows.Forms.NumericUpDown nudDuracion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblProductor;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCanal;
    }
}
