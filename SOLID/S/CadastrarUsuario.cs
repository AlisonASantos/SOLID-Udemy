using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S
{
    class CadastrarUsuario
    {
        public int id;
        public string nome;
        public string email;

        public CadastrarUsuario(int id, string nome, string email)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
        }
    }
}
