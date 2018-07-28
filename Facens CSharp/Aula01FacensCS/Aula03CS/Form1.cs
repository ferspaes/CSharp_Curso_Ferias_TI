using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula03CS
{
    public partial class Form1 : Form
    {
        Conta contaGlobal1;
        public Form1()
        {
            InitializeComponent();
        }
        #region botao 1
        private void button1_Click(object sender, EventArgs e)
        {
            Conta conta1 = new ContaCorrente();
            conta1.titular = new Cliente("Maria", 18);
            conta1.Deposita(2000);
            conta1.numero = 1;
            conta1.titular.rg = "123456789";
            conta1.titular.cpf = "123456789-00";
            int valorASerSacado = 300;

            if (conta1.titular.maiorDeIdade) MessageBox.Show("Cliente maior de idade!");
            else MessageBox.Show("Cliente menor de idade!");

            if (conta1.podeSacar(valorASerSacado))
            {
                conta1.Saca(valorASerSacado);
                MessageBox.Show("Saque efetuado com sucesso!");
            }
            else if (!(conta1.titular.maiorDeIdade)) MessageBox.Show("Valor máximo permitido para clientes menores de idade é de R$200,00");
            else MessageBox.Show("Valor não permitido!");

            MessageBox.Show("Saldo da conta: R$" + conta1.saldo);

            MessageBox.Show("Nome da conta global: " + contaGlobal1.titular.nome);
        }
        #endregion

        #region botao 2
        private void button2_Click(object sender, EventArgs e)
        {
            var nome = "Maria";
            var conta2 = new ContaPoupanca("Nomeconta", 20, 10);


            Conta c1 = new ContaPoupanca("nomeconta2", 20, 15);
            c1.Deposita(2000);
            c1.Saca(200);
            MessageBox.Show("Saldo: R$" + c1.saldo);

            //MessageBox.Show("Idade da conta global: " + contaGlobal1.titular.idade);

            ContaPoupanca cp = new ContaPoupanca();
            ContaInvestimento ci = new ContaInvestimento();
            Conta cc1 = new ContaCorrente();

            cp.Deposita(1000);
            ci.Deposita(100);

            TotalizadorDeContas t = new TotalizadorDeContas();
            t.Adiciona(cp);
            t.Adiciona(ci);

            MessageBox.Show("Total de saldo: " + t.total);

            MessageBox.Show("Tributo poupanca: R$" + cp.CalculaTributo());

            Tributavel tributo = new ContaPoupanca();
            Tributavel t2 = new ContaInvestimento();

            TotalDeTributos tt1 = new TotalDeTributos();
            tt1.Adiciona(cp);
            tt1.Adiciona(ci);

            MessageBox.Show("Total tributos: R$" + tt1.totalTributos);


        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            contaGlobal1 = new ContaPoupanca("Maria", 20, 1);
            
        }

        private void deposita_Click(object sender, EventArgs e)
        {
            contaGlobal1.Deposita(Convert.ToDouble(valor.Text));
            MessageBox.Show("Saldo da conta: " + contaGlobal1.saldo);
            valor.Clear();
            saldoAtual.Text = contaGlobal1.saldo.ToString();
        }

        private void saca_Click(object sender, EventArgs e)
        {
            contaGlobal1.Saca(Convert.ToDouble(valorSaque.Text));
            MessageBox.Show("Saldo da conta: " + contaGlobal1.saldo);
            valorSaque.Clear();
            saldoAtual.Text = contaGlobal1.saldo.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}