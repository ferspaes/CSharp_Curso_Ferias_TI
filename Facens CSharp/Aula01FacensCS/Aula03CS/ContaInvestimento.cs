using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03CS
{
    class ContaInvestimento : Conta, Tributavel
    {
        public override void Saca(double valorASerSacado)
        {
            this.saldo -= valorASerSacado;
            this.saldo -= 0.15;
        }

        public double CalculaTributo()
        {
            return this.saldo * 0.005;
        }
    }
}