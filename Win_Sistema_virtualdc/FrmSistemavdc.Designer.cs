namespace Win_Sistema_virtualdc
{
    partial class FrmSistemavdc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSistemavdc));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.stpData = new System.Windows.Forms.ToolStripStatusLabel();
            this.stpMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.stpHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaGeralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaEspecíficaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaRápidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1694, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem,
            this.cadastrarToolStripMenuItem,
            this.toolStripMenuItem2,
            this.excluirDadosToolStripMenuItem,
            this.gerarRelatórioToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stpData,
            this.stpMensagem,
            this.stpHora});
            this.statusStrip.Location = new System.Drawing.Point(0, 731);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1694, 23);
            this.statusStrip.TabIndex = 1;
            // 
            // stpData
            // 
            this.stpData.Name = "stpData";
            this.stpData.Size = new System.Drawing.Size(47, 18);
            this.stpData.Text = "Data";
            // 
            // stpMensagem
            // 
            this.stpMensagem.Name = "stpMensagem";
            this.stpMensagem.Size = new System.Drawing.Size(97, 18);
            this.stpMensagem.Text = "Mensagem";
            // 
            // stpHora
            // 
            this.stpHora.Name = "stpHora";
            this.stpHora.Size = new System.Drawing.Size(47, 18);
            this.stpHora.Text = "Hora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Win_Sistema_virtualdc.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(317, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1204, 859);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaGeralToolStripMenuItem,
            this.consultaEspecíficaToolStripMenuItem,
            this.consultaRápidaToolStripMenuItem});
            this.consultasToolStripMenuItem.Image = global::Win_Sistema_virtualdc.Properties.Resources.search_find_lupa_21889;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultaGeralToolStripMenuItem
            // 
            this.consultaGeralToolStripMenuItem.Image = global::Win_Sistema_virtualdc.Properties.Resources.xmag_search_find_export_locate_5984;
            this.consultaGeralToolStripMenuItem.Name = "consultaGeralToolStripMenuItem";
            this.consultaGeralToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.consultaGeralToolStripMenuItem.Text = "Consulta Geral";
            this.consultaGeralToolStripMenuItem.Click += new System.EventHandler(this.consultaGeralToolStripMenuItem_Click);
            // 
            // consultaEspecíficaToolStripMenuItem
            // 
            this.consultaEspecíficaToolStripMenuItem.Image = global::Win_Sistema_virtualdc.Properties.Resources.search_find_user_16727;
            this.consultaEspecíficaToolStripMenuItem.Name = "consultaEspecíficaToolStripMenuItem";
            this.consultaEspecíficaToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.consultaEspecíficaToolStripMenuItem.Text = "Consulta Específica";
            this.consultaEspecíficaToolStripMenuItem.Click += new System.EventHandler(this.consultaEspecíficaToolStripMenuItem_Click);
            // 
            // consultaRápidaToolStripMenuItem
            // 
            this.consultaRápidaToolStripMenuItem.Image = global::Win_Sistema_virtualdc.Properties.Resources.binoculars_icon_icons_com_51235;
            this.consultaRápidaToolStripMenuItem.Name = "consultaRápidaToolStripMenuItem";
            this.consultaRápidaToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.consultaRápidaToolStripMenuItem.Text = "Consulta Rápida";
            this.consultaRápidaToolStripMenuItem.Click += new System.EventHandler(this.consultaRápidaToolStripMenuItem_Click);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Image = global::Win_Sistema_virtualdc.Properties.Resources.Adicionar;
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar Dados ";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::Win_Sistema_virtualdc.Properties.Resources.calcular;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.toolStripMenuItem2.Text = "Modificar Dados";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // excluirDadosToolStripMenuItem
            // 
            this.excluirDadosToolStripMenuItem.Image = global::Win_Sistema_virtualdc.Properties.Resources.Cancelar;
            this.excluirDadosToolStripMenuItem.Name = "excluirDadosToolStripMenuItem";
            this.excluirDadosToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.excluirDadosToolStripMenuItem.Text = "Excluir Dados";
            this.excluirDadosToolStripMenuItem.Click += new System.EventHandler(this.excluirDadosToolStripMenuItem_Click);
            // 
            // gerarRelatórioToolStripMenuItem
            // 
            this.gerarRelatórioToolStripMenuItem.Image = global::Win_Sistema_virtualdc.Properties.Resources.printer_10965;
            this.gerarRelatórioToolStripMenuItem.Name = "gerarRelatórioToolStripMenuItem";
            this.gerarRelatórioToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.gerarRelatórioToolStripMenuItem.Text = "Gerar Relatório";
            this.gerarRelatórioToolStripMenuItem.Click += new System.EventHandler(this.gerarRelatórioToolStripMenuItem_Click);
            // 
            // FrmSistemavdc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1694, 754);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmSistemavdc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virtualdc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSistemavdc_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaGeralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaEspecíficaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaRápidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem excluirDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel stpData;
        private System.Windows.Forms.ToolStripStatusLabel stpMensagem;
        private System.Windows.Forms.ToolStripStatusLabel stpHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

