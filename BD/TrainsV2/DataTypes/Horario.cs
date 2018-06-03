using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainsV2.DataTypes
{
    class Horario
    {
        private String _paragemPartida, _paragemChegada, _partida, 
            _horaPartida, _chegada, _horaChegada, _comboio, _linha, _viagemID, _preco;

        public Horario(string paragemPartida, string paragemChegada, string comboio, string linha, 
            string partida, string horaPartida, string chegada, string horaChegada, string viagem, string preco)
        {
            _paragemPartida = paragemPartida;
            _paragemChegada = paragemChegada;
            _comboio = comboio;
            _linha = linha;
            _partida = partida;
            _horaPartida = horaPartida;
            _chegada = chegada;
            _horaChegada = horaChegada;
            _viagemID = viagem;
            _preco = preco;
        }

        public Horario()
        {

        }

        public string ParagemPartida { get => _paragemPartida; set => _paragemPartida = value; }
        public string ParagemChegada { get => _paragemChegada; set => _paragemChegada = value; }
        public string Comboio { get => _comboio; set => _comboio = value; }
        public string Linha { get => _linha; set => _linha = value; }
        public string Partida { get => _partida; set => _partida = value; }
        public string HoraPartida { get => _horaPartida; set => _horaPartida = value; }
        public string Chegada { get => _chegada; set => _chegada = value; }
        public string HoraChegada { get => _horaChegada; set => _horaChegada = value; }
        public string Viagem { get => _viagemID; set => _viagemID = value; }
        public string Preco { get => _preco; set => _preco = value; }

        public override string ToString()
        {
            return HoraPartida + " " + Partida + " -> " + HoraChegada + " " + Chegada + " " + Comboio;
        }
    }
}
