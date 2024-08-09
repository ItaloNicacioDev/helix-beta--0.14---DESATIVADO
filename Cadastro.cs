using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using Microsoft.Data.SqlClient;


namespace helix_beta__0._14
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            fInicio fInicio = new fInicio();
            fInicio.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ITALODEV;Initial Catalog=HELIX_FINAL;Integrated Security=True;Trust Server Certificate=True"; // Substitua pela sua conexão.

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Cadastro (nome, data_nasc, nacionalidade, descendencia, ano_morte, informacoes_add, sequencia_DNA) " +
                               "VALUES (@nome, @data_nasc, @nacionalidade, @descendencia, @ano_morte, @informacoes_add, @seq_dna)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", txtNome.Text);
                    command.Parameters.AddWithValue("@data_nasc", txtData_nasc.Text);
                    command.Parameters.AddWithValue("@descendencia", txtdescendencia.Text);
                    command.Parameters.AddWithValue("@informacoes_add", txtinformacoes_add.Text);
                    command.Parameters.AddWithValue("@nacionalidade", txtnacionalidade.Text);
                    command.Parameters.AddWithValue("@ano_morte", txtano_morte.Text);
                    command.Parameters.AddWithValue("@seq_dna", txtSeq_DNA.Text);





                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registro inserido com sucesso!");
                        LimparCampos(); // Limpa os campos após a inserção.
                    }
                    else
                    {
                        MessageBox.Show("Erro ao inserir o registro.");
                    }

                }
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtData_nasc.Text = "";
            txtNome.Text = "";
            txtdescendencia.Text = "";
            txtnacionalidade.Text = "";
            txtano_morte.Text = "";
            txtinformacoes_add.Text = "";

            // Limpe os outros campos correspondentes.
        }
    }
}
