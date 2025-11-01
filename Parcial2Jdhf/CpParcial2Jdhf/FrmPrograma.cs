using ClnParcial2Jdhf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CpParcial2Jdhf
{
    public partial class FrmPrograma : Form
    {
        private bool esNuevo = false;

        public FrmPrograma()
        {
            InitializeComponent();
        }

        private void listar()
        {
            var lista = ProgramaCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = lista;

            if (dgvLista.Columns["id"] != null) dgvLista.Columns["id"].Visible = false;
            if (dgvLista.Columns["idCanal"] != null) dgvLista.Columns["idCanal"].Visible = false;
            if (dgvLista.Columns["estado"] != null) dgvLista.Columns["estado"].Visible = false;

            if (dgvLista.Columns["titulo"] != null) dgvLista.Columns["titulo"].HeaderText = "Título";
            if (dgvLista.Columns["descripcion"] != null) dgvLista.Columns["descripcion"].HeaderText = "Descripción";
            if (dgvLista.Columns["nombreCanal"] != null) dgvLista.Columns["nombreCanal"].HeaderText = "Nombre del Canal";
            if (dgvLista.Columns["duracion"] != null) dgvLista.Columns["duracion"].HeaderText = "Duración";
            if (dgvLista.Columns["productor"] != null) dgvLista.Columns["productor"].HeaderText = "Productor";
            if (dgvLista.Columns["fechaEstreno"] != null) dgvLista.Columns["fechaEstreno"].HeaderText = "Fecha de Estreno";
            if (dgvLista.Columns["clasificacion"] != null) dgvLista.Columns["clasificacion"].HeaderText = "Clasificaciòn";

            if (lista.Count > 0 && dgvLista.Columns["titulo"] != null)
                dgvLista.CurrentCell = dgvLista.Rows[0].Cells["titulo"];

            btnEditar.Enabled = lista.Count > 0;
            btnBorrar.Enabled = lista.Count > 0;
        }

        private void FrmPrograma_Load(object sender, EventArgs e)
        {
            Size = new Size(816, 366);
            listar();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(816, 533);
            txtTitulo.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            Size = new Size(816, 533);
            txtTitulo.Focus();
        }

        private void btnCanelar_Click(object sender, EventArgs e)
        {
            Size = new Size(816, 366);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }
    }
}
