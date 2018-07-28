using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03CS
{
    class ContaCorrente : Conta
    {
        public static int qtdContaCorrente { get; private set; }
        public override void Saca(double valorASerSacado)
        {
            if (base.podeSacar(valorASerSacado))
            {
                this.saldo -= valorASerSacado;
                this.saldo = saldo - (valorASerSacado * 0.01);
            }
        }
        public ContaCorrente()
        {
            ContaCorrente.qtdContaCorrente++;
        }

        public static int RetornaTotaldeContasCorrente(int somaMais)
        {
            return ContaCorrente.qtdContaCorrente + somaMais;
        }
    }
}