using appInovacao.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace appInovacao.DAO
{
    class ClienteDAO
    {
        public bool Salvar(object obj)
        {
            return true;
        }

        public List<Model.Cliente> Listar()
        {
            List<Cliente> retorno = new List<Cliente>();

            return retorno;
        }
    }
}
