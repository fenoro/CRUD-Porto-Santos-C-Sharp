using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_porto
{
    internal class Movimentacao
    {
        private String conteiner;
        private String tipoMovimentacao;
        private String dataInicial;
        private String dataFinal;
        private String horaInicial;
        private String horaFinal;


        public void setTipoMovimentacao(String _tipoMovimentacao) { tipoMovimentacao = _tipoMovimentacao; }
        public void setConteiner(String _conteiner) { conteiner = _conteiner; }
        public void setDataInicial(String _dataInicial) { dataInicial = _dataInicial; }
        public void setDataFinal(String _dataFinal) { dataFinal = _dataFinal; }
        public void setHoraInicial(String _horaInicial) { horaInicial = _horaInicial; }
        public void setHoraFinal(String _horaFinal) { horaFinal = _horaFinal; }

        public String getTipoMovimentacao() { return tipoMovimentacao; }
        public String getConteiner() { return conteiner; }
        public String getDataInicial() { return dataInicial; }
        public String getDataFinal() { return dataFinal; }
        public String getHoraInicial() { return horaInicial; }
        public String getHoraFinal() { return horaFinal; }

    }
}
