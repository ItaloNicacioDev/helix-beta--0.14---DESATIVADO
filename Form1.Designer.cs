namespace helix_beta__0._14
{
    partial class fInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            btnSair = new Button();
            panel2 = new Panel();
            btnCadastrar = new Button();
            btncarregar = new Button();
            bntBD = new Button();
            btnConfig = new Button();
            btnFechar = new Button();
            btnIniciar = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnSair);
            panel1.Location = new Point(22, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 555);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(0, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCadastrar);
            panel2.Controls.Add(btncarregar);
            panel2.Controls.Add(bntBD);
            panel2.Controls.Add(btnConfig);
            panel2.Controls.Add(btnFechar);
            panel2.Controls.Add(btnIniciar);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 564);
            panel2.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Transparent;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Location = new Point(12, 294);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(225, 51);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar Entidade";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btncarregar
            // 
            btncarregar.BackColor = Color.Transparent;
            btncarregar.FlatAppearance.BorderSize = 0;
            btncarregar.FlatStyle = FlatStyle.Flat;
            btncarregar.Location = new Point(12, 60);
            btncarregar.Name = "btncarregar";
            btncarregar.Size = new Size(225, 51);
            btncarregar.TabIndex = 4;
            btncarregar.Text = "Carregar";
            btncarregar.UseVisualStyleBackColor = false;
            // 
            // bntBD
            // 
            bntBD.BackColor = Color.Transparent;
            bntBD.FlatAppearance.BorderSize = 0;
            bntBD.FlatStyle = FlatStyle.Flat;
            bntBD.Location = new Point(12, 363);
            bntBD.Name = "bntBD";
            bntBD.Size = new Size(225, 51);
            bntBD.TabIndex = 3;
            bntBD.Text = "Banco de Dados";
            bntBD.UseVisualStyleBackColor = false;
            bntBD.Click += button2_Click;
            // 
            // btnConfig
            // 
            btnConfig.BackColor = Color.Transparent;
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Location = new Point(12, 429);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(225, 51);
            btnConfig.TabIndex = 2;
            btnConfig.Text = "Configurações";
            btnConfig.UseVisualStyleBackColor = false;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Transparent;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(12, 501);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(225, 51);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "Sair do Sistema";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.Transparent;
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Location = new Point(12, 3);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(225, 51);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += Iniciar_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(661, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(225, 532);
            panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.dna;
            pictureBox1.Location = new Point(267, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(388, 549);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // fInicio
            // 
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(898, 576);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "fInicio";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSair;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Button btnIniciar;
        private Button btnFechar;
        private Button btnConfig;
        private Button bntBD;
        private Button btnCadastrar;
        private Button btncarregar;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
