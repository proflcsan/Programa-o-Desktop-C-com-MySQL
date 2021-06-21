using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Sistema_virtualdc
{
    public partial class FrmSistemavdc : Form
    {
        object resposta;
        string texto = "Deseja sair da aplicação?";
        string titulo = "<<<<< FINALIZANDO APLICAÇÃO >>>>>";
        MessageBoxButtons button = MessageBoxButtons.YesNo;
        MessageBoxIcon icon = MessageBoxIcon.Question;
        public FrmSistemavdc()
        {
            InitializeComponent();
        }

        public void Saida()
        {
            resposta = MessageBox.Show(texto,titulo,button,icon);
            if (resposta.Equals(DialogResult.Yes))
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stpData.Text = DateTime.Now.ToShortDateString();
            stpHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void FrmSistemavdc_Load(object sender, EventArgs e)
        {
            stpMensagem.Text = "<<<<<<<<<<<<<<< Virtualdc - 2021 >>>>>>>>>>>>>>>";
        }

        private void consultaGeralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Win_Exer_Virtualdc.FrmExibir we = new Win_Exer_Virtualdc.FrmExibir();
            we.ShowDialog();
        }

        private void consultaEspecíficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Win_Consulta_Virtualdc.FrmConsulta wc = new Win_Consulta_Virtualdc.FrmConsulta();
            wc.ShowDialog();
        }

        private void consultaRápidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Win_Navega_virtualdc.FrmNavega wn = new Win_Navega_virtualdc.FrmNavega();
            wn.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Win_Incluir_virtualdc.FrmIncluir wi = new Win_Incluir_virtualdc.FrmIncluir();
            wi.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Win_Altera_virtualdc.FrmAlterar wa = new Win_Altera_virtualdc.FrmAlterar();
            wa.ShowDialog();
        }

        private void excluirDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Win_Excluir_virtualdc.FrmExcluir we = new Win_Excluir_virtualdc.FrmExcluir();
            we.ShowDialog();
        }

        private void gerarRelatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Win_Relatorio_virtualdc_08_06_2021.FrmRalatorioFunc wr = new Win_Relatorio_virtualdc_08_06_2021.FrmRalatorioFunc();
            wr.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Saida();
        }
    }
}
