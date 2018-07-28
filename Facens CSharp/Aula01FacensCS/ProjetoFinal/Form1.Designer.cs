namespace Aula03CS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTransferir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.saldoOrigem = new System.Windows.Forms.TextBox();
            this.inputValor = new System.Windows.Forms.TextBox();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.nomeOrigem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.idadeOrigem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboDestino = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.idadeDestino = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.nomeDestino = new System.Windows.Forms.TextBox();
            this.saldoDestino = new System.Windows.Forms.TextBox();
            this.btnLimparOrigem = new System.Windows.Forms.Button();
            this.btnLimparDestino = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(432, 235);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(100, 33);
            this.btnTransferir.TabIndex = 0;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(432, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Total de Saldos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // saldoOrigem
            // 
            this.saldoOrigem.Location = new System.Drawing.Point(224, 211);
            this.saldoOrigem.Name = "saldoOrigem";
            this.saldoOrigem.Size = new System.Drawing.Size(142, 20);
            this.saldoOrigem.TabIndex = 2;
            // 
            // inputValor
            // 
            this.inputValor.Location = new System.Drawing.Point(432, 104);
            this.inputValor.Name = "inputValor";
            this.inputValor.Size = new System.Drawing.Size(100, 20);
            this.inputValor.TabIndex = 3;
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(432, 135);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(102, 33);
            this.btnDepositar.TabIndex = 4;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.deposita_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(432, 185);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(100, 33);
            this.btnSacar.TabIndex = 5;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.saca_Click);
            // 
            // nomeOrigem
            // 
            this.nomeOrigem.Location = new System.Drawing.Point(225, 106);
            this.nomeOrigem.Name = "nomeOrigem";
            this.nomeOrigem.Size = new System.Drawing.Size(142, 20);
            this.nomeOrigem.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome Titular:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cliente Destino";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(432, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 33);
            this.button3.TabIndex = 9;
            this.button3.Text = "Total de Tributos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(432, 291);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 40);
            this.button4.TabIndex = 10;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboCliente
            // 
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(11, 105);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(169, 21);
            this.comboCliente.TabIndex = 11;
            this.comboCliente.SelectedIndexChanged += new System.EventHandler(this.comboCliente_SelectedIndexChanged);
            // 
            // idadeOrigem
            // 
            this.idadeOrigem.Location = new System.Drawing.Point(224, 157);
            this.idadeOrigem.Name = "idadeOrigem";
            this.idadeOrigem.Size = new System.Drawing.Size(142, 20);
            this.idadeOrigem.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Funcionalidades";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Digite o valor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Idade Titular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Saldo da Conta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Selecionar o Cliente Origem";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cliente Origem";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Selecionar o Cliente Destino";
            // 
            // comboDestino
            // 
            this.comboDestino.FormattingEnabled = true;
            this.comboDestino.Location = new System.Drawing.Point(11, 298);
            this.comboDestino.Name = "comboDestino";
            this.comboDestino.Size = new System.Drawing.Size(169, 21);
            this.comboDestino.TabIndex = 20;
            this.comboDestino.SelectedIndexChanged += new System.EventHandler(this.comboDestino_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(221, 384);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Saldo da Conta";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(221, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Idade Titular:";
            // 
            // idadeDestino
            // 
            this.idadeDestino.Location = new System.Drawing.Point(223, 349);
            this.idadeDestino.Name = "idadeDestino";
            this.idadeDestino.Size = new System.Drawing.Size(142, 20);
            this.idadeDestino.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(220, 281);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Nome Titular:";
            // 
            // nomeDestino
            // 
            this.nomeDestino.Location = new System.Drawing.Point(224, 298);
            this.nomeDestino.Name = "nomeDestino";
            this.nomeDestino.Size = new System.Drawing.Size(142, 20);
            this.nomeDestino.TabIndex = 22;
            // 
            // saldoDestino
            // 
            this.saldoDestino.Location = new System.Drawing.Point(223, 403);
            this.saldoDestino.Name = "saldoDestino";
            this.saldoDestino.Size = new System.Drawing.Size(142, 20);
            this.saldoDestino.TabIndex = 21;
            // 
            // btnLimparOrigem
            // 
            this.btnLimparOrigem.Location = new System.Drawing.Point(11, 141);
            this.btnLimparOrigem.Name = "btnLimparOrigem";
            this.btnLimparOrigem.Size = new System.Drawing.Size(169, 36);
            this.btnLimparOrigem.TabIndex = 27;
            this.btnLimparOrigem.Text = "Limpar Seleção";
            this.btnLimparOrigem.UseMnemonic = false;
            this.btnLimparOrigem.UseVisualStyleBackColor = true;
            this.btnLimparOrigem.Click += new System.EventHandler(this.btnLimparOrigem_Click);
            // 
            // btnLimparDestino
            // 
            this.btnLimparDestino.Location = new System.Drawing.Point(11, 333);
            this.btnLimparDestino.Name = "btnLimparDestino";
            this.btnLimparDestino.Size = new System.Drawing.Size(169, 36);
            this.btnLimparDestino.TabIndex = 28;
            this.btnLimparDestino.Text = "Limpar Seleção";
            this.btnLimparDestino.UseVisualStyleBackColor = true;
            this.btnLimparDestino.Click += new System.EventHandler(this.btnLimparDestino_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(171, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(207, 30);
            this.label13.TabIndex = 29;
            this.label13.Text = "Caixa Eletrônico";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 453);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnLimparDestino);
            this.Controls.Add(this.btnLimparOrigem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.idadeDestino);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nomeDestino);
            this.Controls.Add(this.saldoDestino);
            this.Controls.Add(this.comboDestino);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idadeOrigem);
            this.Controls.Add(this.comboCliente);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeOrigem);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.inputValor);
            this.Controls.Add(this.saldoOrigem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTransferir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox saldoOrigem;
        private System.Windows.Forms.TextBox inputValor;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.TextBox nomeOrigem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.TextBox idadeOrigem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboDestino;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox idadeDestino;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox nomeDestino;
        private System.Windows.Forms.TextBox saldoDestino;
        private System.Windows.Forms.Button btnLimparOrigem;
        private System.Windows.Forms.Button btnLimparDestino;
        private System.Windows.Forms.Label label13;
    }
}

