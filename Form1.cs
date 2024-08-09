using System.Data.SqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace helix_beta__0._14
{
    public partial class fInicio : Form
    {



        public fInicio()
        {
            InitializeComponent();
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            Iniciar iniciar = new Iniciar();
            iniciar.ShowDialog();
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
