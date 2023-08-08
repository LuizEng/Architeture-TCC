namespace ManagerService.View
{
    partial class Pagamento_Form
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
            this.cmbTipoPagamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTotalPago = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grdServicos = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalServicos = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdServicos)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.cmbTipoPagamento);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btnPagar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 132);
            this.panel1.TabIndex = 0;
            // 
            // cmbTipoPagamento
            // 
            this.cmbTipoPagamento.FormattingEnabled = true;
            this.cmbTipoPagamento.Location = new System.Drawing.Point(122, 45);
            this.cmbTipoPagamento.Name = "cmbTipoPagamento";
            this.cmbTipoPagamento.Size = new System.Drawing.Size(199, 21);
            this.cmbTipoPagamento.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tipo do Pagamento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Valor do pagamento:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(121, 12);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(200, 20);
            this.txtValor.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblTotalServicos);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.lblTotalPago);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.lblSaldo);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 102);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(708, 30);
            this.panel5.TabIndex = 1;
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.AutoSize = true;
            this.lblTotalPago.Location = new System.Drawing.Point(173, 9);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(51, 13);
            this.lblTotalPago.TabIndex = 5;
            this.lblTotalPago.Text = "R$ 50.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Pago:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(318, 9);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(51, 13);
            this.lblSaldo.TabIndex = 3;
            this.lblSaldo.Text = "R$ 50.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total pendente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saldos da agenda";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(202, 73);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(119, 23);
            this.btnPagar.TabIndex = 0;
            this.btnPagar.Text = "Realizar Pagamento";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 300);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grdServicos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(708, 284);
            this.panel4.TabIndex = 1;
            // 
            // grdServicos
            // 
            this.grdServicos.AllowUserToAddRows = false;
            this.grdServicos.AllowUserToDeleteRows = false;
            this.grdServicos.AllowUserToOrderColumns = true;
            this.grdServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdServicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdServicos.Location = new System.Drawing.Point(0, 0);
            this.grdServicos.Name = "grdServicos";
            this.grdServicos.ReadOnly = true;
            this.grdServicos.Size = new System.Drawing.Size(708, 284);
            this.grdServicos.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(708, 16);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serviços Realizados:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(375, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total dos serviços:";
            // 
            // lblTotalServicos
            // 
            this.lblTotalServicos.AutoSize = true;
            this.lblTotalServicos.Location = new System.Drawing.Point(472, 9);
            this.lblTotalServicos.Name = "lblTotalServicos";
            this.lblTotalServicos.Size = new System.Drawing.Size(51, 13);
            this.lblTotalServicos.TabIndex = 7;
            this.lblTotalServicos.Text = "R$ 50.00";
            // 
            // Pagamento_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 432);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Pagamento_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdServicos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView grdServicos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.ComboBox cmbTipoPagamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblTotalServicos;
        private System.Windows.Forms.Label label7;
    }
}