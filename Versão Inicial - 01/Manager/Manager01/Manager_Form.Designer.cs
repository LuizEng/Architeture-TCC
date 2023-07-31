namespace Manager01
{
    partial class Manager_Form
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastros = new System.Windows.Forms.Button();
            this.mnuCadastros = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tipoDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeAtendimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnAtendimentos = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.mnuCadastros.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnCadastros);
            this.panel1.Controls.Add(this.btnCaixa);
            this.panel1.Controls.Add(this.btnAtendimentos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnCadastros
            // 
            this.btnCadastros.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCadastros.Location = new System.Drawing.Point(202, 0);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Size = new System.Drawing.Size(101, 100);
            this.btnCadastros.TabIndex = 2;
            this.btnCadastros.Text = "Cadastros";
            this.btnCadastros.UseVisualStyleBackColor = true;
            this.btnCadastros.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCadastros_MouseDown);
            // 
            // mnuCadastros
            // 
            this.mnuCadastros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDeServiçoToolStripMenuItem,
            this.tipoDeAtendimentoToolStripMenuItem,
            this.tipoDePagamentoToolStripMenuItem});
            this.mnuCadastros.Name = "mnuCadastros";
            this.mnuCadastros.Size = new System.Drawing.Size(187, 70);
            // 
            // tipoDeServiçoToolStripMenuItem
            // 
            this.tipoDeServiçoToolStripMenuItem.Name = "tipoDeServiçoToolStripMenuItem";
            this.tipoDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.tipoDeServiçoToolStripMenuItem.Text = "Tipo de Serviço";
            this.tipoDeServiçoToolStripMenuItem.Click += new System.EventHandler(this.tipoDeServiçoToolStripMenuItem_Click);
            // 
            // tipoDeAtendimentoToolStripMenuItem
            // 
            this.tipoDeAtendimentoToolStripMenuItem.Name = "tipoDeAtendimentoToolStripMenuItem";
            this.tipoDeAtendimentoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.tipoDeAtendimentoToolStripMenuItem.Text = "Tipo de Atendimento";
            this.tipoDeAtendimentoToolStripMenuItem.Click += new System.EventHandler(this.tipoDeAtendimentoToolStripMenuItem_Click);
            // 
            // tipoDePagamentoToolStripMenuItem
            // 
            this.tipoDePagamentoToolStripMenuItem.Name = "tipoDePagamentoToolStripMenuItem";
            this.tipoDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.tipoDePagamentoToolStripMenuItem.Text = "Tipo de Pagamento";
            this.tipoDePagamentoToolStripMenuItem.Click += new System.EventHandler(this.tipoDePagamentoToolStripMenuItem_Click);
            // 
            // btnCaixa
            // 
            this.btnCaixa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCaixa.Location = new System.Drawing.Point(101, 0);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(101, 100);
            this.btnCaixa.TabIndex = 1;
            this.btnCaixa.Text = "Caixa";
            this.btnCaixa.UseVisualStyleBackColor = true;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // btnAtendimentos
            // 
            this.btnAtendimentos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAtendimentos.Location = new System.Drawing.Point(0, 0);
            this.btnAtendimentos.Name = "btnAtendimentos";
            this.btnAtendimentos.Size = new System.Drawing.Size(101, 100);
            this.btnAtendimentos.TabIndex = 0;
            this.btnAtendimentos.Text = "Atendimento";
            this.btnAtendimentos.UseVisualStyleBackColor = true;
            this.btnAtendimentos.Click += new System.EventHandler(this.btnAtendimentos_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(272, 243);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 350);
            this.panel2.TabIndex = 2;
            // 
            // Manager_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Manager_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager_Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Manager_Form_FormClosed);
            this.panel1.ResumeLayout(false);
            this.mnuCadastros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnAtendimentos;
        private System.Windows.Forms.Button btnCadastros;
        private System.Windows.Forms.ContextMenuStrip mnuCadastros;
        private System.Windows.Forms.ToolStripMenuItem tipoDeServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeAtendimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDePagamentoToolStripMenuItem;
    }
}