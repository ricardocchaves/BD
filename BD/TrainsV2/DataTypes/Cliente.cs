using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainsV2.DataTypes
{
    class Cliente
    {
        private static Cliente _escolhido;

        private String _CC, _NIF, _userID, _nome_proprio, _apelido, _email, _tel;
        private double _saldo;

        public Cliente()
        {

        }

        public Cliente(String CC, String NIF, String userID, String nome_proprio, String apelido, String email, String tel, String saldo)
        {
            _CC = CC;
            _NIF = NIF;
            _userID = userID;
            _nome_proprio = nome_proprio;
            _apelido = apelido;
            _email = email;
            _tel = tel;
            Double.TryParse(saldo,out _saldo);
        }

        public string CC { get => _CC; set => _CC = value; }
        public string NIF { get => _NIF; set => _NIF = value; }
        public string UserID { get => _userID; set => _userID = value; }
        public string Nome_proprio { get => _nome_proprio; set => _nome_proprio = value; }
        public string Apelido { get => _apelido; set => _apelido = value; }
        public string Email { get => _email; set => _email = value; }
        public string Tel { get => _tel; set => _tel = value; }

        public double Saldo { get => _saldo; set => _saldo = value; }

        public static Cliente Escolhido { get => _escolhido; set => _escolhido = value; }

        public override string ToString()
        {
            return CC + " " + Nome_proprio + " " + Apelido;
        }
    }
}
