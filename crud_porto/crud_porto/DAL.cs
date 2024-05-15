using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace crud_porto
{
    internal class DAL
    {
        private static String strConexao = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\Luiz Felipe\\Desktop\\crud_porto\\crud_porto\\bin\\Debug\\Database19.mdb";
        private static OleDbConnection conn = new OleDbConnection(strConexao);
        private static OleDbCommand strSQL;
        private static OleDbDataReader result;

        public static void contecta()
        {
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                Erro.setMsg("Problemas na conexão com o banco de dados");
            }
        }

        public static void descontecta()
        {
            conn.Close();
        }

        public static void inseriConteiner(Conteiner conteiner)
        {
            String aux = "insert into TabConteiner(conteiner,cliente,tipo,status,categoria) values (@conteiner,@cliente,@tipo,@status,@categoria)";

            strSQL = new OleDbCommand(aux, conn);
            strSQL.Parameters.Add("@conteiner", OleDbType.VarChar).Value = conteiner.getConteiner();
            strSQL.Parameters.Add("@cliente", OleDbType.VarChar).Value = conteiner.getCliente();
            strSQL.Parameters.Add("@tipo", OleDbType.VarChar).Value = conteiner.getTipo();
            strSQL.Parameters.Add("@status", OleDbType.VarChar).Value = conteiner.getStatus();
            strSQL.Parameters.Add("@categoria", OleDbType.VarChar).Value = conteiner.getCategoria();

            Erro.setErro(false);

            try
            {
                strSQL.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Erro.setMsg("Chave duplicada!");
            }
        }

        public static void excluiConteiner(Conteiner conteiner)
        {
            String aux = "delete from TabConteiner where conteiner = @conteiner";

            strSQL = new OleDbCommand(aux, conn);
            strSQL.Parameters.Add("@conteiner", OleDbType.VarChar).Value = conteiner.getConteiner();
            strSQL.ExecuteNonQuery();

            String aux2 = "delete from TabMovimentacao where conteiner = @conteiner";

            strSQL = new OleDbCommand(aux2, conn);
            strSQL.Parameters.Add("@conteiner", OleDbType.VarChar).Value = conteiner.getConteiner();
            strSQL.ExecuteNonQuery();
        }

        public static void atualizaConteiner(Conteiner conteiner)
        {
            String aux = "update TabConteiner set cliente=@cliente,tipo=@tipo,status=@status,categoria=@categoria where conteiner=@conteiner";

            strSQL = new OleDbCommand(aux, conn);
           
            strSQL.Parameters.Add("@cliente", OleDbType.VarChar).Value = conteiner.getCliente();
            strSQL.Parameters.Add("@tipo", OleDbType.VarChar).Value = conteiner.getTipo();
            strSQL.Parameters.Add("@status", OleDbType.VarChar).Value = conteiner.getStatus();
            strSQL.Parameters.Add("@categoria", OleDbType.VarChar).Value = conteiner.getCategoria();
            strSQL.Parameters.Add("@conteiner", OleDbType.VarChar).Value = conteiner.getConteiner();
            strSQL.ExecuteNonQuery();
        }

        public static void consultaConteiner(Conteiner conteiner)
        {
            String aux = "select * from TabConteiner where conteiner = @conteiner";

            strSQL = new OleDbCommand(aux, conn);
            strSQL.Parameters.Add("@conteiner", OleDbType.VarChar).Value = conteiner.getConteiner();
            result = strSQL.ExecuteReader();
            Erro.setErro(false);

            if(result.Read())
            {
                conteiner.setCliente(result.GetString(1));
                conteiner.setTipo(result.GetString(2));
                conteiner.setStatus(result.GetString(3));
                conteiner.setCategoria(result.GetString(4));
            }
            else
            {
                Erro.setMsg("Conteiner não cadastrado!");
            }
        }

        public static void salvaMovimentacao(Movimentacao movimentacao)
        {
            String aux = "select * from TabConteiner where conteiner = @conteiner";

            strSQL = new OleDbCommand(aux, conn);
            strSQL.Parameters.Add("@conteiner", OleDbType.VarChar).Value = movimentacao.getConteiner();
            result = strSQL.ExecuteReader();
            Erro.setErro(false);
            if (result.Read())
            {
                String aux1 = "insert into TabMovimentacao(conteiner,movimentacao,datainicial,datafinal,horainicial,horafinal) values (@conteiner,@movimentacao,@datainicial,@datafinal,@horainicial,@horafinal)";

                strSQL = new OleDbCommand(aux1, conn);
                strSQL.Parameters.Add("@conteiner", OleDbType.VarChar).Value = movimentacao.getConteiner();
                strSQL.Parameters.Add("@movimentacao", OleDbType.VarChar).Value = movimentacao.getTipoMovimentacao();
                strSQL.Parameters.Add("@datainicial", OleDbType.VarChar).Value = movimentacao.getDataInicial();
                strSQL.Parameters.Add("@datafinal", OleDbType.VarChar).Value = movimentacao.getDataFinal();
                strSQL.Parameters.Add("@horainicial", OleDbType.VarChar).Value = movimentacao.getHoraInicial();
                strSQL.Parameters.Add("@horafinal", OleDbType.VarChar).Value = movimentacao.getHoraFinal();

                Erro.setErro(false);

                try
                {
                    strSQL.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    Erro.setMsg("Chave duplicada!");
                }
            }
            else
            {
                Erro.setMsg("Conteiner não cadastrado!");
            }
        }

        public static void excluiMovimentacao(Movimentacao movimentacao)
        {
            String aux = "delete from TabMovimentacao where conteiner = @conteiner";

            strSQL = new OleDbCommand(aux, conn);
            strSQL.Parameters.Add("@conteiner", OleDbType.VarChar).Value = movimentacao.getConteiner();
            strSQL.ExecuteNonQuery();
        }

        public static void consultaMovimentacao(Movimentacao movimentacao)
        {
            String aux = "select * from TabMovimentacao where conteiner = @conteiner";

            strSQL = new OleDbCommand(aux, conn);
            strSQL.Parameters.Add("@conteiner", OleDbType.VarChar).Value = movimentacao.getConteiner();
            result = strSQL.ExecuteReader();
            Erro.setErro(false);

            if (result.Read())
            {
                movimentacao.setTipoMovimentacao(result.GetString(1));
                movimentacao.setDataInicial(result.GetString(2));
                movimentacao.setHoraInicial(result.GetString(3));
                movimentacao.setDataFinal(result.GetString(4));
                movimentacao.setHoraFinal(result.GetString(5));
            }
            else
            {
                Erro.setMsg("Movimentação não cadastrada!");
            }
        }

        public static void atualizaMovimentacao(Movimentacao movimentacao)
        {
            String aux = "update TabMovimentacao set movimentacao=@movimentacao,datainicial=@datainicial,datafinal=@datafinal,horainicial=@horainicial,horafinal=@horafinal where conteiner=@conteiner";

            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.Add("@movimentacao", OleDbType.VarChar).Value = movimentacao.getTipoMovimentacao();
            strSQL.Parameters.Add("@datainicial", OleDbType.VarChar).Value = movimentacao.getDataInicial() ;
            strSQL.Parameters.Add("@datafinal", OleDbType.VarChar).Value = movimentacao.getDataFinal();
            strSQL.Parameters.Add("@horainicial", OleDbType.VarChar).Value = movimentacao.getHoraInicial();
            strSQL.Parameters.Add("@horafinal", OleDbType.VarChar).Value = movimentacao.getHoraFinal();
            strSQL.Parameters.Add("@conteiner", OleDbType.VarChar).Value = movimentacao.getConteiner();
            strSQL.ExecuteNonQuery();
        }

    }
}
