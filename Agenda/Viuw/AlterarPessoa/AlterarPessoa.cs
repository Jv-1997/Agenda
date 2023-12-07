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

namespace Agenda.Viuw.AlterarPessoa
{
    public partial class AlterarPessoa : Form
    {
        public AlterarPessoa()
        {
            InitializeComponent();
        }



        private void btn_Continuar_Click(object sender, EventArgs e)
        {
            Pessoa.Id = Convert.ToInt32(tbx_ProcurarA.Text);

            ManipulaPessoa manipulaPessoa = new ManipulaPessoa();
            manipulaPessoa.BuscarCodigo();

            tbx_CodigoA.Text = Pessoa.Id.ToString();
            tbx_NomeA.Text = Pessoa.Nome;
            tbx_FoneA.Text = Pessoa.Fone;
            tbx_EmailA.Text = Pessoa.Email;
        }

        private void btn_Avancar_Click(object sender, EventArgs e)
        {  
                Pessoa.Id = Convert.ToInt32(tbx_CodigoA.Text);
                Pessoa.Nome = tbx_NomeA.Text;
                Pessoa.Fone = tbx_FoneA.Text;
                Pessoa.Email = tbx_EmailA.Text;

                ManipulaPessoa manipulaPessoa = new ManipulaPessoa();
                manipulaPessoa.AlterarPessoa();

            
        }
    }
}
