using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainsV2.DataTypes
{
    class Fatura
    {
        private String _descricao, _valor, _data;

        public Fatura(string descricao, string valor, string data)
        {
            _descricao = descricao;
            _valor = valor;
            _data = data;
        }

        public Fatura()
        {

        }

        public string Descricao { get => _descricao; set => _descricao = value; }
        public string Valor { get => _valor; set => _valor = value; }
        public string Data { get => _data; set => _data = value; }

        public override string ToString()
        {
            return Data+"    "+Valor+" , "+Descricao;
        }

    }
}
