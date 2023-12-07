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

namespace Agenda.Viuw.AdicionarPessoa
{
    public partial class AdicionarPessoa : Form
    {
        public AdicionarPessoa()
        {
            InitializeComponent();
        }


        private void btn_avancar_Click(object sender, EventArgs e)
        {
            Pessoa.Nome = tbx_Nome.Text;
            Pessoa.Fone = tbx_Fone.Text;
            Pessoa.Email = tbx_Email.Text;

            ManipulaPessoa manipulaPessoa = new ManipulaPessoa();
            manipulaPessoa.AdicionarPessoa();
        }
    }
}

