using Agenda.Controller;
using Agenda.Modeu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.Viuw.PesquisarPorCodigo
{
    public partial class TelaPesquisarPorCodigo : Form
    {
        public TelaPesquisarPorCodigo()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Avancar_Click(object sender, EventArgs e)
        {

            Pessoa.Nome = tbx_NomeF.Text;
            Pessoa.Fone = tbx_FoneF.Text;
            Pessoa.Email = tbx_EmailF.Text;

            ManipulaPessoa manipulaPessoa = new ManipulaPessoa();
            //manipulaPessoa.TelaPesquisarPorCodigo();
        }

        private void btn_PesquisarF_Click(object sender, EventArgs e)
        {
            Pessoa.Id = Convert.ToInt32(tbx_PesquisarF.Text);

            ManipulaPessoa manipulaPessoa = new ManipulaPessoa();
           manipulaPessoa.BuscarCodigo();

           tbx_NomeF.Text = Pessoa.Nome;
           tbx_FoneF.Text = Pessoa.Fone;
           tbx_EmailF.Text = Pessoa.Email;

        }
    }
}
