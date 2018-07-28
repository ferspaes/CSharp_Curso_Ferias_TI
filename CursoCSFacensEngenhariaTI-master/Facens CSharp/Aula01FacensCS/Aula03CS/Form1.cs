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
        Conta[] contas = new Conta[10];
        public Form1()
        {
            InitializeComponent();
        }

        #region botao 1
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(inputValor.Text)
                && (comboCliente.SelectedIndex == -1)
                && (comboCliente.SelectedIndex == -1))
            {
                contas[comboCliente.SelectedIndex].Saca(Convert.ToInt32(inputValor.Text));
                contas[comboDestino.SelectedIndex].Deposita(Convert.ToInt32(inputValor.Text));
            }
            inputValor.Clear();
            saldoOrigem.Text = contas[comboCliente.SelectedIndex].saldo.ToString();
            saldoDestino.Text = contas[comboDestino.SelectedIndex].saldo.ToString();
        }
        #endregion

        #region botao 2
        private void button2_Click(object sender, EventArgs e)
        {
            var conta2 = new ContaPoupanca("Nomeconta", 20, 10);


            Conta c1 = new ContaPoupanca("nomeconta2", 20, 15);
            c1.Deposita(2000);
            c1.Saca(200);
            MessageBox.Show("Saldo: R$" + c1.saldo);
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

        #region Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            Banco b = new Banco();
            contas[0] = new ContaPoupanca();
            contas[1] = new ContaPoupanca();
            contas[2] = new ContaPoupanca();
            contas[3] = new ContaPoupanca();
            contas[4] = new ContaPoupanca();
            contas[5] = new ContaPoupanca();
            contas[6] = new ContaPoupanca();
            contas[7] = new ContaPoupanca();
            contas[8] = new ContaPoupanca();
            contas[9] = new ContaPoupanca();

            contas[0].titular = new Cliente();
            contas[1].titular = new Cliente();
            contas[2].titular = new Cliente();
            contas[3].titular = new Cliente();
            contas[4].titular = new Cliente();
            contas[5].titular = new Cliente();
            contas[6].titular = new Cliente();
            contas[7].titular = new Cliente();
            contas[8].titular = new Cliente();
            contas[9].titular = new Cliente();

            contas[0].titular.nome = "Alice";
            contas[1].titular.nome = "Maria";
            contas[2].titular.nome = "Joao";
            contas[3].titular.nome = "Joana";
            contas[4].titular.nome = "Joaquim";
            contas[5].titular.nome = "Mario";
            contas[6].titular.nome = "Luigi";
            contas[7].titular.nome = "Jose";
            contas[8].titular.nome = "Ana";
            contas[9].titular.nome = "Louise";

            contas[0].titular.idade = 20;
            contas[1].titular.idade = 20;
            contas[2].titular.idade = 20;
            contas[3].titular.idade = 20;
            contas[4].titular.idade = 20;
            contas[5].titular.idade = 20;
            contas[6].titular.idade = 20;
            contas[7].titular.idade = 20;
            contas[8].titular.idade = 20;
            contas[9].titular.idade = 20;

            foreach (Conta conta in contas)
            {
                comboCliente.Items.Add(conta.titular.nome);
                comboDestino.Items.Add(conta.titular.nome);
            }
        }
        #endregion

        #region Botão Deposita
        private void deposita_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(inputValor.Text)
                && (comboCliente.SelectedIndex == -1)
                && (comboCliente.SelectedIndex == -1))
            {
                contas[comboCliente.SelectedIndex].Deposita(Convert.ToDouble(inputValor.Text));
            }
            inputValor.Clear();
            saldoOrigem.Text = contas[comboCliente.SelectedIndex].saldo.ToString(); 
        }
        #endregion

        #region Botão Saca
        private void saca_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(inputValor.Text)
                && (comboCliente.SelectedIndex == -1)
                && (comboCliente.SelectedIndex == -1))
            {
                contas[comboCliente.SelectedIndex].Saca(Convert.ToDouble(inputValor.Text));
            }
            inputValor.Clear();
            saldoOrigem.Text = contas[comboCliente.SelectedIndex].saldo.ToString(); 
        }
        #endregion

        #region Label Click
        private void label2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Botão 3 Click
        private void button3_Click(object sender, EventArgs e)
        {
            ContaCorrente cc1 = new ContaCorrente();
            MessageBox.Show("Quantidade de contas: " + ContaCorrente.RetornaTotaldeContasCorrente(10));
            ContaCorrente cc2 = new ContaCorrente();
            MessageBox.Show("Quantidade de contas: " + ContaCorrente.RetornaTotaldeContasCorrente(20));
        }
        #endregion

        #region Botão 4 Click
        private void button4_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Combo Origem
        private void comboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomeOrigem.Text = contas[comboCliente.SelectedIndex].titular.nome;
            idadeOrigem.Text = contas[comboCliente.SelectedIndex].titular.idade.ToString();
            saldoOrigem.Text = contas[comboCliente.SelectedIndex].saldo.ToString();
        }
        #endregion

        #region Combo Destino
        private void comboDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomeDestino.Text = contas[comboDestino.SelectedIndex].titular.nome;
            idadeDestino.Text = contas[comboDestino.SelectedIndex].titular.idade.ToString();
            saldoDestino.Text = contas[comboDestino.SelectedIndex].saldo.ToString();
        }
        #endregion
    }
}