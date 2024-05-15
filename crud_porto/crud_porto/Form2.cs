using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_porto
{
    public partial class Form2 : Form
    {
        Movimentacao movimentacao = new Movimentacao();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            movimentacao.setConteiner(tbConteiner.Text);
            movimentacao.setTipoMovimentacao(cbMovimentacao.Text);
            movimentacao.setDataInicial(mtbDataInicial.Text);
            movimentacao.setDataFinal(mtbDataFinal.Text);
            movimentacao.setHoraInicial(mtbHoraInicial.Text);
            movimentacao.setHoraFinal(mtbHoraFinal.Text);

            BLL.validaDadosMovimentacao(movimentacao, 'i');

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
            }
            else
                MessageBox.Show("Dados inseridos!");
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
           movimentacao.setConteiner(tbConteiner.Text);

            BLL.validaCodigoMovimentacao(movimentacao, 'c');

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
            }
            else
            {
                tbConteiner.Text = movimentacao.getConteiner();
                cbMovimentacao.Text = movimentacao.getTipoMovimentacao();
                mtbDataInicial.Text = movimentacao.getDataInicial();
                mtbHoraInicial.Text = movimentacao.getHoraInicial();
                mtbDataFinal.Text = movimentacao.getDataFinal();
                mtbHoraFinal.Text = movimentacao.getHoraFinal();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbConteiner.Text = "";
            cbMovimentacao.Text = "";
            mtbDataInicial.Text = "";
            mtbHoraInicial.Text = "";
            mtbDataFinal.Text = "";
            mtbHoraFinal.Text = "";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            movimentacao.setConteiner(tbConteiner.Text);

            BLL.validaCodigoMovimentacao(movimentacao, 'c');

            if (!Erro.getErro())
            {
                movimentacao.setTipoMovimentacao(cbMovimentacao.Text);
                movimentacao.setDataInicial(mtbDataInicial.Text);
                movimentacao.setDataFinal(mtbDataFinal.Text);
                movimentacao.setHoraInicial(mtbHoraInicial.Text);
                movimentacao.setHoraFinal(mtbHoraFinal.Text);

                BLL.validaDadosMovimentacao(movimentacao, 'a');

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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            movimentacao.setConteiner(tbConteiner.Text);

            BLL.validaCodigoMovimentacao(movimentacao, 'e');

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
            }
            else
            {
                MessageBox.Show("Dados excluídos!");
            }
        }
    }
}
