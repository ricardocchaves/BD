using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainsV2.DataTypes
{
    class Bilhete : Horario
    {
        private String _bilheteID, _data, _carruagem,
            _lugar;

        public Bilhete(string bilheteID, string data, string carruagem, string lugar)
        {
            _bilheteID = bilheteID;
            _data = data;
            _carruagem = carruagem;
            _lugar = lugar;
        }

        public Bilhete()
        {

        }

        public string BilheteID { get => _bilheteID; set => _bilheteID = value; }
        public string Data { get => _data; set => _data = value; }
        public string Carruagem { get => _carruagem; set => _carruagem = value; }
        public string Lugar { get => _lugar; set => _lugar = value; }

    }
}
