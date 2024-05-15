namespace crud_porto
{
    public partial class Form1 : Form
    {
        Conteiner conteiner= new Conteiner();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BLL.conecta();
            if(Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            conteiner.setConteiner(tbConteiner.Text);
            conteiner.setCliente(tbCliente.Text);
            conteiner.setTipo(cbTipo.Text);
            conteiner.setStatus(cbStatus.Text);
            conteiner.setCategoria(cbCategoria.Text);

            BLL.validaDadosConteiner(conteiner, 'i');
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
            }
            else
                MessageBox.Show("Dados inseridos!");
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            conteiner.setConteiner(tbConteiner.Text);

            BLL.validaCodigoConteiner(conteiner, 'c');

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
            }
            else
            {
                tbConteiner.Text = conteiner.getConteiner();
                tbCliente.Text = conteiner.getCliente();
                cbTipo.Text = conteiner.getTipo();
                cbStatus.Text = conteiner.getStatus();
                cbCategoria.Text = conteiner.getCategoria();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbConteiner.Text = "";
            tbCliente.Text = "";
            cbTipo.Text = "";
            cbStatus.Text = "";
            cbCategoria.Text = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            conteiner.setConteiner(tbConteiner.Text);

            BLL.validaCodigoConteiner(conteiner, 'e');

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
            }
            else
            {
                MessageBox.Show("Dados excluídos!");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            conteiner.setConteiner(tbConteiner.Text);

            BLL.validaCodigoConteiner(conteiner, 'c');

            if (!Erro.getErro())
            {
                conteiner.setCliente(tbCliente.Text);
                conteiner.setTipo(cbTipo.Text);
                conteiner.setStatus(cbStatus.Text);
                conteiner.setCategoria(cbCategoria.Text);

                BLL.validaDadosConteiner(conteiner, 'a');
                if (Erro.getErro())
                {
                    MessageBox.Show(Erro.getMsg());
                }
                else
                    MessageBox.Show("Dados alterados!");
            }
            else
            {
                MessageBox.Show(Erro.getMsg());
            }

        }

        private void btnMovimentacao_Click(object sender, EventArgs e)
        {
            Form2 formMov = new Form2();
            formMov.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            BLL.desconecta();
        }
    }
}