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
        ContaPoupanca[] contas = new ContaPoupanca[10];
        public Form1()
        {
            InitializeComponent();
        }

        #region botao 1
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(inputValor.Text)
                && (comboCliente.SelectedIndex != -1)
                && (comboCliente.SelectedIndex != -1))
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
            TotalizadorDeContas t = new TotalizadorDeContas();
            foreach(ContaPoupanca conta in contas)
            {
                t.Adiciona(conta);
            }
            MessageBox.Show("Total de Saldos: R$" + t.total);
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
                && (comboCliente.SelectedIndex != -1)
                && (comboCliente.SelectedIndex != -1))
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
                && (comboCliente.SelectedIndex != -1)
                && (comboCliente.SelectedIndex != -1))
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
            Tributavel tributo = new ContaPoupanca();
            TotalDeTributos tt = new TotalDeTributos();
            foreach (ContaPoupanca conta in contas)
            {
                tt.Adiciona(conta);
            }
            MessageBox.Show("Total tributos: R$" + tt.totalTributos);
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
            if (!(comboCliente.SelectedIndex == -1))
            {
                nomeOrigem.Text = contas[comboCliente.SelectedIndex].titular.nome;
                idadeOrigem.Text = contas[comboCliente.SelectedIndex].titular.idade.ToString();
                saldoOrigem.Text = contas[comboCliente.SelectedIndex].saldo.ToString();
            }
            else
            {
                nomeOrigem.Text = string.Empty;
                idadeOrigem.Text = string.Empty;
                saldoOrigem.Text = string.Empty;
            }
        }
        #endregion

        #region Combo Destino
        private void comboDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(comboDestino.SelectedIndex == -1))
            {
                nomeDestino.Text = contas[comboDestino.SelectedIndex].titular.nome;
                idadeDestino.Text = contas[comboDestino.SelectedIndex].titular.idade.ToString();
                saldoDestino.Text = contas[comboDestino.SelectedIndex].saldo.ToString();
            }
            else
            {
                nomeDestino.Text = string.Empty;
                idadeDestino.Text = string.Empty;
                saldoDestino.Text = string.Empty;
            }
        }
        #endregion

        #region Botão Limpar Origem

        private void btnLimparOrigem_Click(object sender, EventArgs e)
        {
            comboCliente.SelectedIndex = -1;
        }

        #endregion

        #region Botão Limpar Destino

        private void btnLimparDestino_Click(object sender, EventArgs e)
        {
            comboDestino.SelectedIndex = -1;
        }

        #endregion
    }
}