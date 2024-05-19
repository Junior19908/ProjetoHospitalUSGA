using ProjetoHospitalUSGA.Aplicacoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHospitalUSGA
{
    public partial class frmMenu : MetroFramework.Forms.MetroForm
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void arquivosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void examesClinAssistênciaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExamClinAssist frmExamClinAssist = new frmExamClinAssist();
            frmExamClinAssist.ShowDialog();
        }

        private void movimentoDeAtestadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovAtestados frmMov = new frmMovAtestados();
            frmMov.ShowDialog();
        }
    }
}
