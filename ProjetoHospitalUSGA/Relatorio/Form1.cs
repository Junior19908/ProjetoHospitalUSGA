using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHospitalUSGA.Relatorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Report Viewer Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

            // Configurar o caminho do relatório
            this.reportViewer1.LocalReport.ReportPath = @"C:\Users\junio\source\repos\ProjetoHospitalUSGA\ProjetoHospitalUSGA\Relatorio\Report1.rdlc";

            // Configurar o tamanho da página como A4
            System.Drawing.Printing.PageSettings pageSettings = new System.Drawing.Printing.PageSettings();
            pageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1169); // 21 cm x 29.7 cm em centésimos de polegada
            pageSettings.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 30); // Margens de 1 cm (ou ajuste conforme necessário)

            // Aplicar as configurações de página
            this.reportViewer1.SetPageSettings(pageSettings);

            // Atualizar o relatório
            this.reportViewer1.RefreshReport();
        }

    }
}
