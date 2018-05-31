using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainsV2.DataTypes
{
    class Bilhete
    {
        private String _bilheteID, _preco, _data, _paragemPartida, _paragemChegada, _comboio, _carruagem,
            _lugar, _partida, _horaPartida, _chegada, _horaChegada;

        public Bilhete(string bilheteID, string preco, string data, string paragemPartida, 
            string paragemChegada, string comboio, string carruagem, string lugar, string partida, 
            string horaPartida, string chegada, string horaChegada)
        {
            _bilheteID = bilheteID;
            _preco = preco;
            _data = data;
            _paragemPartida = paragemPartida;
            _paragemChegada = paragemChegada;
            _comboio = comboio;
            _carruagem = carruagem;
            _lugar = lugar;
            _partida = partida;
            _horaPartida = horaPartida;
            _chegada = chegada;
            _horaChegada = horaChegada;
        }

        public Bilhete()
        {

        }

        public string BilheteID { get => _bilheteID; set => _bilheteID = value; }
        public string Preco { get => _preco; set => _preco = value; }
        public string Data { get => _data; set => _data = value; }
        public string ParagemPartida { get => _paragemPartida; set => _paragemPartida = value; }
        public string ParagemChegada { get => _paragemChegada; set => _paragemChegada = value; }
        public string Comboio { get => _comboio; set => _comboio = value; }
        public string Carruagem { get => _carruagem; set => _carruagem = value; }
        public string Lugar { get => _lugar; set => _lugar = value; }
        public string Partida { get => _partida; set => _partida = value; }
        public string HoraPartida { get => _horaPartida; set => _horaPartida = value; }
        public string Chegada { get => _chegada; set => _chegada = value; }
        public string HoraChegada { get => _horaChegada; set => _horaChegada = value; }

        public override string ToString()
        {
            return Data + " " + HoraPartida + " " + Partida + " -> " + HoraChegada + " " + Chegada + " " + Comboio;
        }
    }
}
