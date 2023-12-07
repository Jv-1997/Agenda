using Agenda.Viuw.AdicionarPessoa;
using Agenda.Viuw.AlterarPessoa;
using Agenda.Viuw.DeletarPessoa;
using Agenda.Viuw.PesquisarPorCodigo;
using Agenda.Viuw.VizualizarPessoa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            AdicionarPessoa adicionarPessoa = new AdicionarPessoa();
            adicionarPessoa.Show();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_altera_Click(object sender, EventArgs e)
        {
            AlterarPessoa alterarPessoa = new AlterarPessoa();
            alterarPessoa.Show();
        }

        private void btn_Vizualizar_Click(object sender, EventArgs e)
        {
            VizualizarPessoa vizualizarPessoa = new VizualizarPessoa();
            vizualizarPessoa.Show();
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            DeletarPessoa deletarPessoa = new DeletarPessoa();
            deletarPessoa.Show();
        }

        private void btn_Codigo_Click(object sender, EventArgs e)
        {
            TelaPesquisarPorCodigo pesquisarPorCodigo = new TelaPesquisarPorCodigo();
            pesquisarPorCodigo.Show();
        }
    }
}
