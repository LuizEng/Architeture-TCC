namespace Manager01
{
    partial class Caixa_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPagarAtendimento = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_atendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 62);
            this.panel1.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnVoltar);
            this.panel10.Controls.Add(this.btnPagarAtendimento);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1033, 62);
            this.panel10.TabIndex = 1;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(939, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(91, 23);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPagarAtendimento
            // 
            this.btnPagarAtendimento.Location = new System.Drawing.Point(8, 12);
            this.btnPagarAtendimento.Name = "btnPagarAtendimento";
            this.btnPagarAtendimento.Size = new System.Drawing.Size(171, 23);
            this.btnPagarAtendimento.TabIndex = 0;
            this.btnPagarAtendimento.Text = "Pagar atendimento selecionado";
            this.btnPagarAtendimento.UseVisualStyleBackColor = true;
            this.btnPagarAtendimento.Click += new System.EventHandler(this.btnPagarAtendimento_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 584);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1033, 49);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1033, 522);
            this.panel2.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(513, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(520, 522);
            this.panel5.TabIndex = 6;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel9.Controls.Add(this.dataGridView2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 14);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(520, 508);
            this.panel9.TabIndex = 8;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valor,
            this.tipo_pagamento,
            this.descricao});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(520, 508);
            this.dataGridView2.TabIndex = 0;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor Pago";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // tipo_pagamento
            // 
            this.tipo_pagamento.HeaderText = "Tipo do pagamento";
            this.tipo_pagamento.Name = "tipo_pagamento";
            this.tipo_pagamento.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(520, 14);
            this.panel7.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pagamentos realizados para o atendimento selecionado:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(513, 522);
            this.panel4.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel8.Controls.Add(this.dataGridView1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 14);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(513, 508);
            this.panel8.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tipo_atendimento,
            this.saldo});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(513, 508);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // tipo_atendimento
            // 
            this.tipo_atendimento.HeaderText = "Tipo Atendimento";
            this.tipo_atendimento.Name = "tipo_atendimento";
            this.tipo_atendimento.ReadOnly = true;
            // 
            // saldo
            // 
            this.saldo.HeaderText = "Saldo";
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(513, 14);
            this.panel6.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atendimentos pendentes de pagamento:";
            // 
            // Caixa_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 633);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Caixa_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa_Form";
            this.panel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnPagarAtendimento;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_atendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
    }
}