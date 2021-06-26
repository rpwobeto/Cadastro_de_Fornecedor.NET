using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDotNet.WindowsForms.UI
{
    public partial class lbl : Form
    {
        public lbl()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var fornecedor = new Fornecedor();

            List<Fornecedor> listaFornecedores = new List<Fornecedor>();
            listaFornecedores.Add(RetornarFornecedor(fornecedor));

            dgvFornecedores.DataSource = listaFornecedores;

        }

        private Fornecedor RetornarFornecedor(Fornecedor fornecedor)
        {

            if (txtNomeFornecedor.Text != string.Empty)
            {
                fornecedor.NomeDoFornecedor = txtNomeFornecedor.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o nome do fornecedor!");
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
                fornecedor.NomeContato = txtNomeDoContato.Text;
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
                MessageBox.Show("Você não digitou o Telefone!");
            }
            return fornecedor;
        }
    }
}
