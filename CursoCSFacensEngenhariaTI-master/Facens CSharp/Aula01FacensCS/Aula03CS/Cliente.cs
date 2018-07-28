using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03CS
{
    class Cliente
    {
        public string nome { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public int idade { get; set; }

        public bool maiorDeIdade
        {
            get
            {
                return idade >= 18;
            }
        }

        public Cliente(string nomePassado, int idadePassada)
        {
            this.nome = nomePassado;
            this.idade = idadePassada;
        }

        public Cliente(){}
    }
}
