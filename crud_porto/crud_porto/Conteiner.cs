using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_porto
{
    internal class Conteiner
    {
        private String conteiner;
        private String cliente;
        private String tipo;
        private String status;
        private String categoria;

        public void setCliente(String _cliente) { cliente = _cliente; }
        public void setConteiner(String _conteiner) { conteiner = _conteiner; }
        public void setTipo(String _tipo) { tipo = _tipo; }
        public void setStatus(String _status) { status = _status; }
        public void setCategoria(String _categoria) { categoria = _categoria; }

        public String getCliente() { return cliente; }
        public String getConteiner() { return conteiner; }
        public String getTipo() { return tipo; }
        public String getStatus() { return status; }
        public String getCategoria() { return categoria; }


    }
}
