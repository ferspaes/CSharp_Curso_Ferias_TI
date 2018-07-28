using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03CS
{
    class TotalizadorDeContas
    {
        public double total { get; private set; }
        
        public void Adiciona(Conta conta)
        {
            this.total += conta.saldo;
        }
    }
}
