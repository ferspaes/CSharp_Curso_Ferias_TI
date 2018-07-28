using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoFacensCSAula02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeroDaConta = 1;
            string titular = "Joaquim";
            string titular2 = "Maria";
            string mensagem = "O nome do titular é "
                              + titular
                              + "\nO outro titular é "
                              + titular2;
            MessageBox.Show(mensagem.ToUpper()
                            + ", Numero: "
                            + numeroDaConta);

            int valor = 10;
            valor -= 1;
            MessageBox.Show(valor.ToString());
            double saldo = 2000.0;
            int lenght = 12;

            for (int i = 0; i < lenght; i++)
            {
                saldo *= 1.01;
            }

            MessageBox.Show("O saldo total é de R$" + Math.Round(saldo, 2));

            if (saldo > 0) MessageBox.Show("Saldo positivo");
            else MessageBox.Show("Saldo negativo");

            int idade = 18;
            int idadeMaior = 16;
            bool brasileira = true;
            bool estrangeira = false;

            if (idade >= idadeMaior && brasileira) MessageBox.Show("Pode votar!");
            else MessageBox.Show("Não permitido votar!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region Valor Nota Fiscal
            double valorDaNotaFiscal = 8000;
            double imposto = 0;

            if (valorDaNotaFiscal <= 1000) imposto = valorDaNotaFiscal * 0.2;
            else if (valorDaNotaFiscal > 1000 && valorDaNotaFiscal <= 3000) imposto = valorDaNotaFiscal * 0.25;
            else if (valorDaNotaFiscal > 3000 && valorDaNotaFiscal <= 7000) imposto = valorDaNotaFiscal * 0.28;
            else if (valorDaNotaFiscal > 7000) imposto = valorDaNotaFiscal * 0.3;
            MessageBox.Show("O valor da nota fiscal é de: \n"
                            + valorDaNotaFiscal
                            + "\nO valor do imposto é de: "
                            + imposto);
            #endregion
            #region Verificar divisor por 15
            int numeroVerificar = 15;
            if (numeroVerificar % 3 == 0) MessageBox.Show("15 é divisivel por 3");
            else if (numeroVerificar % 4 == 0) MessageBox.Show("15 não é divisivel por 4");

            string mensagemcontador = "";
            for (int contador = 0; contador <= 30; contador++)
            {
                if (contador % 3 == 0 && contador < 30) mensagemcontador += contador.ToString() + ", ";
                else if (contador == 30) mensagemcontador += contador + ".";
            }
            MessageBox.Show(mensagemcontador);
            #endregion
            Conta conta1 = new Conta();
            conta1.numeroDaConta = 1;
            conta1.Deposita(2000);
            conta1.cliente.titular = "Maria";
            Conta conta2 = new Conta();
            conta2.numeroDaConta = 2;
            conta2.Deposita(1000);
            conta2.cliente.titular = "Joaquim";

            MessageBox.Show("Titular da conta: "
                            + conta1.cliente.titular);
            MessageBox.Show("Saldo: "
                            + conta1.saldo);
            Conta copia = conta2;
            copia.Deposita(200);

            MessageBox.Show("Saldo: " + conta2.saldo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conta conta1 = new Conta();
            conta1.numeroDaConta = 1;
            conta1.Deposita(5000);
            Conta conta2 = new Conta();
            conta2.numeroDaConta = 2;
            conta2.Deposita(2000);

            Cliente cliente1 = new Cliente();
            cliente1.titular = "Maria";
            cliente1.rg = "12345679";
            cliente1.cpf = "1234579-00";
            conta1.cliente = cliente1;

            Cliente cliente2 = new Cliente();
            cliente2.titular = "Joaquim";
            cliente2.rg = "987654321";
            cliente2.cpf = "987654321-00";
            conta2.cliente = cliente2;

            Conta conta3 = new Conta();
            conta3.cliente = new Cliente();
            conta3.cliente.titular = "teste conta 3";

            conta2.Saca(200);
            MessageBox.Show("O valor da conta do " 
                            + conta2.cliente.titular
                            + " é de: " 
                            + conta2.saldo);

            conta1.Deposita(1000);
            MessageBox.Show("O valor da conta do "
                            + conta1.cliente.titular
                            + " é de: "
                            + conta1.saldo);

            conta2.Transfere(200, conta1);

            MessageBox.Show(conta2.cliente.titular 
                            + " transferiu R$200,00 para "
                            + conta1.cliente.titular
                            + "\nSaldo da conta do cliente "
                            + conta2.cliente.titular
                            + " é de: R$"
                            + conta2.saldo
                            + "\nSaldo da conta do cliente "
                            + conta1.cliente.titular
                            + " é de: R$"
                            + conta1.saldo);
        }
    }
}