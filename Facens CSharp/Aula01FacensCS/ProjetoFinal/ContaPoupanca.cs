using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03CS
{
    class ContaPoupanca : Conta, Tributavel
    {
        public override void Saca(double valorASerSacado)
        {
            if (base.podeSacar(valorASerSacado))
            {
                this.saldo -= valorASerSacado;
                this.saldo = saldo - (valorASerSacado * 0.01);
            }
        }
        public double CalculaTributo()
        {
            return this.saldo * 0.007;
        }

        public ContaPoupanca (string nome, int idade, int numeroConta)
                             : base (nome, idade, numeroConta) {}

        public ContaPoupanca () : base(){}

    }
}
