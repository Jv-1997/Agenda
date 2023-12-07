using Agenda.Modeu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Controller
{
    internal class ManipulaPessoa
    {
        
        public void AdicionarPessoa()
            {
                SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
                SqlCommand cmd = new SqlCommand("P_AdicionarPessoa", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                try
                {
                    cmd.Parameters.AddWithValue("@nome", Pessoa.Nome);
                    cmd.Parameters.AddWithValue("@fone", Pessoa.Fone);
                    cmd.Parameters.AddWithValue("@email", Pessoa.Email);


                    cn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cadastrado com sucesso.");
                }
                catch (Exception)
                {
                    throw;
                }


            }

        public void DeletarPessoa()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_ApagarPessoa", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try

            {
                cmd.Parameters.AddWithValue("@id", Pessoa.Id);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Excluido com Sucesso");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AlterarPessoa()
        {
            {
                SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
                SqlCommand cmd = new SqlCommand("P_AtualizarPessoa", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                try
                {
                    cmd.Parameters.AddWithValue("@id", Pessoa.Id);
                    cmd.Parameters.AddWithValue("@nome", Pessoa.Nome);
                    cmd.Parameters.AddWithValue("@fone", Pessoa.Fone);
                    cmd.Parameters.AddWithValue("@email", Pessoa.Email);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario Alterado com sucesso");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Cliente foi alterado com sucesso");
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        public void BuscarCodigo()
        {

            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());

            SqlCommand cmd = new SqlCommand("P_VisualizarCodigoPessoa", cn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;


            try

            {

                cmd.Parameters.AddWithValue("@id", Pessoa.Id);

                cn.Open();

                var dr = cmd.ExecuteReader();


                if (dr.Read())

                {

                    Pessoa.Id = Convert.ToInt32(dr["Id"]);

                    Pessoa.Nome = Convert.ToString(dr["Nome"]);

                    Pessoa.Fone = dr["Fone"].ToString();

                    Pessoa.Email = dr["Email"].ToString();

                }

                else

                {

                    Pessoa.Id = 0;

                    Pessoa.Nome = "";

                    Pessoa.Fone = "";

                    Pessoa.Email = "";

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }

        }

        public static BindingSource BuscarNome()

        {

            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());

            SqlCommand cmd = new SqlCommand("P_VisualizarPessoa", cn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nome", Pessoa.Nome);

            cn.Open();

            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();

            dados.DataSource = table;

            return dados;

        }

    }
    }


