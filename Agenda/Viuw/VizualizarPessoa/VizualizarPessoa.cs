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

namespace Agenda.Viuw.VizualizarPessoa
{
    public partial class VizualizarPessoa : Form
    {
        public VizualizarPessoa()
        {
            InitializeComponent();
        }

        private void VizualizarPessoa_Load(object sender, EventArgs e)
        {
            Pessoa.Nome = tbx_NomeE.Text;
            Pessoa.Fone = tbx_FoneE.Text;
            Pessoa.Email = tbx_EmailE.Text;

            ManipulaPessoa manipulaPessoa = new ManipulaPessoa();
           // manipulaPessoa.VizualizarPessoa();
        }

        private void btn_Continuar_Click(object sender, EventArgs e)
        {

            Pessoa.Nome = tbx_NomeE.Text;


            ManipulaPessoa manipulaPessoa = new ManipulaPessoa();
          //  manipulaPessoa.VizualizarPessoa();

        }

        private void btn_Avancar_Click(object sender, EventArgs e)
        {

            Pessoa.Nome = tbx_NomeE.Text;
            Pessoa.Fone = tbx_FoneE.Text;
            Pessoa.Email = tbx_EmailE.Text;

            ManipulaPessoa manipulaPessoa = new ManipulaPessoa();
          //  manipulaPessoa.VizualizarPessoa();
        }

        private void tbx_NomeE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
