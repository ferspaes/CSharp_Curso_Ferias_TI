using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoFacensCSAula02
{
    class Conta
    {
        public int numeroDaConta { get; set; }
        public double saldo { get; private set; }
        public Cliente cliente { get; set; }

        public void Saca(double valorASerSacado)
        {
            this.saldo -= valorASerSacado;
        }

        public void Deposita(double valorASerDepositado)
        {
            this.saldo += valorASerDepositado;
        }

        public void Transfere(double valorASerTransferido, Conta destino)
        {
            this.Saca(valorASerTransferido);
            destino.Deposita(valorASerTransferido);
        }
    }
}
