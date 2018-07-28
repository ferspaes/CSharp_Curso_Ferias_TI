using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03CS
{
    abstract class Conta
    {
        public int numero { get; set; }
        public Cliente titular { get; set; }
        public double saldo { get; protected set; }
        public bool podeSacar(double valorASerSacado)
        {
            return (valorASerSacado <= this.saldo && this.saldo > 0 && this.titular.maiorDeIdade && valorASerSacado > 0
                    || valorASerSacado <= this.saldo && this.saldo > 0 && valorASerSacado <= 200 && !(this.titular.maiorDeIdade)
                    && valorASerSacado > 0); ;
        }

        public virtual void Saca(double valorASerSacado)
        {
            if (podeSacar(valorASerSacado)) this.saldo -= valorASerSacado;
            else if (valorASerSacado <= 200 && valorASerSacado > 0) this.saldo -= valorASerSacado;

        }

        public bool Deposita(double valorASerDepositado)
        {
            if (valorASerDepositado > 0) this.saldo += valorASerDepositado;
            return (valorASerDepositado > 0);
        }

        public void Transfere(double valorASerTransferido, Conta destino)
        {
            this.Saca(valorASerTransferido);
            destino.Deposita(valorASerTransferido);
        }

        public Conta(string nomeTitular, int idadeTitular, int numeroDaConta)
        {
            this.titular = new Cliente(nomeTitular, idadeTitular);
            this.numero = numeroDaConta;
        }

        public Conta()
        {
            this.titular = new Cliente();
        }
    }
}
