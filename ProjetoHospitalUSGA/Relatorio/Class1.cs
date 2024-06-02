using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ProjetoHospitalUSGA.Relatorio
{
    class Program
    {
        [STAThread]
        static void Mai1n()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Cria o formulário
            Form form = new Form();
            form.Text = "Report Viewer Example";
            form.ClientSize = new System.Drawing.Size(800, 450);

            // Cria o ReportViewer
            ReportViewer reportViewer1 = new ReportViewer();
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.LocalReport.ReportPath = @"C:\Users\junio\source\repos\ProjetoHospitalUSGA\ProjetoHospitalUSGA\Relatorio\Report1.rdlc";

            // Configura o tamanho da página como A4
            System.Drawing.Printing.PageSettings pageSettings = new System.Drawing.Printing.PageSettings();
            pageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1169); // 21 cm x 29.7 cm em centésimos de polegada
            pageSettings.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 30); // Margens de 1 cm (ou ajuste conforme necessário)
            reportViewer1.SetPageSettings(pageSettings);

            // Adiciona o ReportViewer ao formulário
            form.Controls.Add(reportViewer1);

            // Atualiza o relatório
            reportViewer1.RefreshReport();

            // Executa o aplicativo e exibe o formulário
            Application.Run(form);
        }
    }
}
