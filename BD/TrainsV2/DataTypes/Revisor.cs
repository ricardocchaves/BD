using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainsV2.DataTypes
{
    class Revisor
    {
        private String _cc, _nomeProprio, _apelido, _email, _salario, _telefone;

        public Revisor(string cc, string nomeProprio, string apelido, string email, string salario, string telefone)
        {
            _cc = cc;
            _nomeProprio = nomeProprio;
            _apelido = apelido;
            _email = email;
            _salario = salario;
            _telefone = telefone;
        }

        public Revisor()
        {

        }

        public string Cc { get => _cc; set => _cc = value; }
        public string NomeProprio { get => _nomeProprio; set => _nomeProprio = value; }
        public string Apelido { get => _apelido; set => _apelido = value; }
        public string Email { get => _email; set => _email = value; }
        public string Salario { get => _salario; set => _salario = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }

        public override string ToString()
        {
            return Cc + " " + NomeProprio + " " + Apelido;
        }
    }
}
