using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Modeu
{
    internal class ConexaoBanco
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\joao.vmlsousa\source\repos\Agenda\Agenda\BancoDeDados\AgendaTele.mdf;Integrated Security=True";
        }
    }
}
