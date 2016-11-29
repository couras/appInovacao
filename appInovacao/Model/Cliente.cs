using System;
using System.Collections.Generic;
using System.Text;

namespace appInovacao.Model
{
    class Cliente
    {
        private int _id;
        private string _nome;
        private string _idade;

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }

        public string Idade
        {
            get
            {
                return _idade;
            }

            set
            {
                _idade = value;
            }
        }
    }
}
