using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_porto
{
    internal class BLL
    {
        public static void conecta()
        {
            DAL.contecta();
        }

        public static void desconecta()
        {
            DAL.descontecta();
        }

        public static void validaCodigoConteiner(Conteiner conteiner, char op)
        {
            Erro.setErro(false);
            if(conteiner.getConteiner().Equals(""))
            {
                Erro.setMsg("Código obrigatório!");
                return;
            }
            if (op == 'c')
                DAL.consultaConteiner(conteiner);
            else
                DAL.excluiConteiner(conteiner);
        }

        public static void validaCodigoMovimentacao(Movimentacao movimentacao, char op)
        {
            Erro.setErro(false);
            if (movimentacao.getConteiner().Equals(""))
            {
                Erro.setMsg("Código obrigatório!");
                return;
            }
            if (op == 'c')
                DAL.consultaMovimentacao(movimentacao);
            else
                DAL.excluiMovimentacao(movimentacao);
        }

        public static void validaDadosConteiner(Conteiner conteiner, char op)
        {
            Erro.setErro(false);
            if (conteiner.getConteiner().Equals(""))
            {
                Erro.setMsg("Código obrigatório!");
                return;
            }

            bool flag = true;
            int i = 0;
            String cod = conteiner.getConteiner();
            while(flag && i < cod.Length)
            {
                if(i<4)
                {
                    flag = Char.IsLetter(cod[i]);
                }
                else
                {
                    flag = Char.IsDigit(cod[i]);
                }
                i++;
            }
            if(flag == false || cod.Length != 11)
            {
                Erro.setMsg("Código inválido!");
                return;
            }

            if (conteiner.getCliente().Equals(""))
            {
                Erro.setMsg("Cliente obrigatório!");
                return;
            }

            if (conteiner.getTipo().Equals(""))
            {
                Erro.setMsg("Tipo obrigatório!");
                return;
            }

            if (conteiner.getStatus().Equals(""))
            {
                Erro.setMsg("Status obrigatório!");
                return;
            }

            if (conteiner.getCategoria().Equals(""))
            {
                Erro.setMsg("Categoria obrigatório!");
                return;
            }

            if (op == 'i')
                DAL.inseriConteiner(conteiner);
            else
                DAL.atualizaConteiner(conteiner);
        }

        public static void validaDadosMovimentacao(Movimentacao movimentacao, char op)
        {
            Erro.setErro(false);

            if (movimentacao.getConteiner().Equals(""))
            {
                Erro.setMsg("Código obrigatório!");
                return;
            }
            if (movimentacao.getTipoMovimentacao().Equals(""))
            {
                Erro.setMsg("Movimentação obrigatório!");
                return;
            }
            if (movimentacao.getDataInicial().Equals(""))
            {
                Erro.setMsg("Data inicial obrigatório!");
                return;
            }

            bool date1 = DateTime.TryParse(movimentacao.getDataInicial(), out DateTime date2);
            if(date1==false)
            {
                Erro.setMsg("Data inicial inválida!");
                return;
            }

            if (movimentacao.getHoraInicial().Equals(""))
            {
                Erro.setMsg("Horário inicial obrigatório!");
                return;
            }

            int auxh, auxm;
            try
            {
                auxh = DateTime.Parse(movimentacao.getHoraInicial()).Hour;
                auxm = DateTime.Parse(movimentacao.getHoraInicial()).Minute;
            }
            catch(Exception)
            {
                Erro.setMsg("Horário inicial inválido!");
                return;
            }



            if (movimentacao.getDataFinal().Equals(""))
            {
                Erro.setMsg("Data final obrigatório!");
                return;
            }

            bool date3 = DateTime.TryParse(movimentacao.getDataFinal(), out DateTime date4);
            if (date3 == false)
            {
                Erro.setMsg("Data final inválida!");
                return;
            }

            if(date2 > date4)
            {
                Erro.setMsg("Data final menor que inicial!");
                return;
            }

            if (movimentacao.getHoraFinal().Equals(""))
            {
                Erro.setMsg("Horário final obrigatório!");
                return;
            }

            int auxh2, auxm2;
            try
            {
                auxh2 = DateTime.Parse(movimentacao.getHoraFinal()).Hour;
                auxm2 = DateTime.Parse(movimentacao.getHoraFinal()).Minute;
            }
            catch (Exception)
            {
                Erro.setMsg("Horário final inválido!");
                return;
            }

            if(date2 == date4 && auxh > auxh2)
            {
                Erro.setMsg("Horário final inválido para essa data!");
                return;
            }

            if (date2 == date4 && auxh == auxh2 && auxm > auxm2)
            {
                Erro.setMsg("Horário final inválido para essa data!");
                return;
            }

            if (op == 'i')
                DAL.salvaMovimentacao(movimentacao);
            else
                DAL.atualizaMovimentacao(movimentacao);

        }

    }
}
