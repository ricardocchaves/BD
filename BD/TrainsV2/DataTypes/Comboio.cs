using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainsV2.DataTypes
{
    class Comboio
    {
        private String _id, _tipo, _fabricante, _carruagens, _lugares;

        public Comboio(string id, string tipo, string fabricante, string carruagens, string lugares)
        {
            _id = id;
            _tipo = tipo;
            _fabricante = fabricante;
            _carruagens = carruagens;
            _lugares = lugares;
        }

        public Comboio()
        {

        }

        public string Id { get => _id; set => _id = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public string Fabricante { get => _fabricante; set => _fabricante = value; }
        public string Carruagens { get => _carruagens; set => _carruagens = value; }
        public string Lugares { get => _lugares; set => _lugares = value; }

        public override string ToString()
        {
            return Id + " " + Tipo + " " + Fabricante;
        }
    }
}
