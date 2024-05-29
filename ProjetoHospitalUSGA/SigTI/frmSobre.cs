using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoHospitalUSGA.SigTI
{
    public partial class frmSobre : MetroFramework.Forms.MetroForm
    {
        public frmSobre()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            // Configuração do Formulário
            //this.Text = "Sobre o Programa";
            this.Size = new Size(500, 400);

            // Configuração dos Labels
            AddLabel("Informações do Programa", new Point(20, 20), FontStyle.Bold, 14);
            AddLabel("Desenvolvedor: Carlos Júnior", new Point(20, 60));
            AddLabel("Data de Criação: 13 de Maio de 2024", new Point(20, 90));
            AddLabel("Contato:\nTelefone: +55 82 99962-3274\nE-mail: carlosjunyoor@gmail.com", new Point(20, 120));
            AddLabel("Este trabalho é protegido por leis de propriedade intelectual e é de uso exclusivo da USGA - USINA SERRA GRANDE ALAGOAS.\nA comercialização deste trabalho sem o consentimento expresso do autor é estritamente proibida e constitui crime sujeito a sanções legais.", new Point(20, 180), FontStyle.Regular, 9);
        }

        private void AddLabel(string text, Point location, FontStyle style = FontStyle.Regular, float fontSize = 10)
        {
            Label label = new Label();
            label.Text = text;
            label.Font = new Font("Arial", fontSize, style);
            label.Location = location;
            label.AutoSize = true;
            this.Controls.Add(label);
        }
    }
}
