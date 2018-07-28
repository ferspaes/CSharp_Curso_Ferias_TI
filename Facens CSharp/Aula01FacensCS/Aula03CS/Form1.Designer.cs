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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.valor = new System.Windows.Forms.TextBox();
            this.valorSaque = new System.Windows.Forms.TextBox();
            this.deposita = new System.Windows.Forms.Button();
            this.saca = new System.Windows.Forms.Button();
            this.saldoAtual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // valor
            // 
            this.valor.Location = new System.Drawing.Point(12, 38);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(100, 20);
            this.valor.TabIndex = 2;
            // 
            // valorSaque
            // 
            this.valorSaque.Location = new System.Drawing.Point(172, 38);
            this.valorSaque.Name = "valorSaque";
            this.valorSaque.Size = new System.Drawing.Size(100, 20);
            this.valorSaque.TabIndex = 3;
            // 
            // deposita
            // 
            this.deposita.Location = new System.Drawing.Point(12, 81);
            this.deposita.Name = "deposita";
            this.deposita.Size = new System.Drawing.Size(100, 34);
            this.deposita.TabIndex = 4;
            this.deposita.Text = "Deposita";
            this.deposita.UseVisualStyleBackColor = true;
            this.deposita.Click += new System.EventHandler(this.deposita_Click);
            // 
            // saca
            // 
            this.saca.Location = new System.Drawing.Point(172, 81);
            this.saca.Name = "saca";
            this.saca.Size = new System.Drawing.Size(100, 34);
            this.saca.TabIndex = 5;
            this.saca.Text = "Saca";
            this.saca.UseVisualStyleBackColor = true;
            this.saca.Click += new System.EventHandler(this.saca_Click);
            // 
            // saldoAtual
            // 
            this.saldoAtual.Location = new System.Drawing.Point(93, 163);
            this.saldoAtual.Name = "saldoAtual";
            this.saldoAtual.Size = new System.Drawing.Size(100, 20);
            this.saldoAtual.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Valor Atual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "R$";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saldoAtual);
            this.Controls.Add(this.saca);
            this.Controls.Add(this.deposita);
            this.Controls.Add(this.valorSaque);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.TextBox valorSaque;
        private System.Windows.Forms.Button deposita;
        private System.Windows.Forms.Button saca;
        private System.Windows.Forms.TextBox saldoAtual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

