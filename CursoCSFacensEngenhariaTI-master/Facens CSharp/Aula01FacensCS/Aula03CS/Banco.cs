using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03CS
{
    class Banco
    {
        public static int numeroDaConta = 0;
        Conta[] contas = new Conta[10];

        public void AdicionaNovaConta(Conta conta)
        {
            if (numeroDaConta <= 10)
            {
                contas[numeroDaConta] = conta;
                numeroDaConta++;
            }

        }
    }
}
