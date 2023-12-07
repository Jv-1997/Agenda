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

namespace Agenda.Viuw.DeletarPessoa
{
    public partial class DeletarPessoa : Form
    {
        public DeletarPessoa()
        {
            InitializeComponent();
        }



        private void btn_DeletarD_Click(object sender, EventArgs e)
        {

            Pessoa.Nome = tbx_NomeD.Text;
            ManipulaPessoa manipulaPessoa = new ManipulaPessoa();
            manipulaPessoa.DeletarPessoa();

        }



        private void btn_BuscarD_Click_1(object sender, EventArgs e)
        {
            Pessoa.Id = Convert.ToInt32(tbx_BuscarD.Text);

            ManipulaPessoa manipulaPessoa = new ManipulaPessoa();
            manipulaPessoa.BuscarCodigo();

            tbx_CodigoD.Text = Pessoa.Id.ToString();
            tbx_NomeD.Text = Pessoa.Nome;
            tbx_FoneD.Text = Pessoa.Fone;
            tbx_EmailD.Text = Pessoa.Email;

        }

        private void btn_DeletarD_Click_1(object sender, EventArgs e)
        {
            Pessoa.Id = Convert.ToInt32(tbx_BuscarD.Text);
            ManipulaPessoa manipulaPessoa = new ManipulaPessoa();
            manipulaPessoa.DeletarPessoa();
        }
    }

}
