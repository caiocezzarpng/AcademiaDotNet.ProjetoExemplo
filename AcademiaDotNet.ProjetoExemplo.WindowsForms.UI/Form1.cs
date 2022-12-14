using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaDotNet.ProjetoExemplo.WindowsForms.UI
{
    public partial class FFormularioInicial : Form
    {
        public FFormularioInicial()
        {
            InitializeComponent();
        }

        private void lblEndereco_Click(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            var fornecedor = new Fornecedor();


            List<Fornecedor> listaFornecedores = new List<Fornecedor>();
            listaFornecedores.Add(RetornarFornecedor(fornecedor));

            dgvFornecedores.DataSource= listaFornecedores;

        }

        private Fornecedor RetornarFornecedor(Fornecedor fornecedor)
        {

            if (txtNomeFornecedor.Text != string.Empty)
            {
                fornecedor.NomeDoFornecedor = txtNomeFornecedor.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o nome do Fornecedor!");
            }
            if (txtEndereco.Text != string.Empty)
            {
                fornecedor.Endereco = txtEndereco.Text;

            }
            else
            {
                MessageBox.Show("Você não digitou o Endereço!");
            }
            if (txtNomeDoContato.Text != string.Empty)
            {
                fornecedor.NomeDoContato = txtNomeDoContato.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o nome do contato!");
            }
            if (txtTelefone.Text != string.Empty)
            {
                fornecedor.Telefone = txtTelefone.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o telefone!");
            }

            return fornecedor;
        }

        private void textEndereco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
