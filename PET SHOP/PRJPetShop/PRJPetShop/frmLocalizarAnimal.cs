﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRJPetShop
{
    public partial class frmLocalizarAnimal : Form
    {
        public frmLocalizarAnimal()
        {
            InitializeComponent();
        }

        private void frmLocalizarAnimal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.View_AnimaisClientes'. Você pode movê-la ou removê-la conforme necessário.
            this.view_AnimaisClientesTableAdapter.Fill(this.petshopDataSet.View_AnimaisClientes);
            groupBox1.Enabled = true;

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            view_AnimaisClientesBindingSource.Filter = "ani_nome like '" + txtNome.Text + "%'";
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void view_AnimaisClientesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                VariaveisGlobais.CodigoTroca = int.Parse(view_AnimaisClientesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                VariaveisGlobais.CodigoTroca = 0;
            }
            this.Dispose();
        }
    }
}
