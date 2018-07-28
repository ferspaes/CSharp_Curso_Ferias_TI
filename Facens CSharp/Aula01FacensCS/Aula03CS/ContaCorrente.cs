using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03CS
{
    class ContaCorrente : Conta
    {
        public override void Saca(double valorASerSacado)
        {
            if (base.podeSacar(valorASerSacado))
            {
                this.saldo -= valorASerSacado;
                this.saldo = saldo - (valorASerSacado * 0.01);
            }
        }
    }
}