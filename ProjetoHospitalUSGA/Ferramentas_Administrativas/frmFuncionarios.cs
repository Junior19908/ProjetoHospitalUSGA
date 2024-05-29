using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHospitalUSGA.Ferramentas_Administrativas
{
    public partial class frmFuncionarios : MetroFramework.Forms.MetroForm
    {
        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void tb_funcionariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_funcionariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBSHPtb_func);

        }

        private void tb_funcionariosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_funcionariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBSHPtb_func);

        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBSHPtb_func.tb_funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_funcionariosTableAdapter.Fill(this.dBSHPtb_func.tb_funcionarios);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\hosp\\DBSHP.accdb";
            string query = "SELECT * FROM tb_funcionarios WHERE CPF = @CPF";

            DataTable dataTable = new DataTable();
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    OleDbCommand command = new OleDbCommand(query,connection);
                    command.Parameters.AddWithValue("@CPF", txtCpf.Text);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    adapter.Fill(dataTable);

                    tb_funcionariosDataGridView.DataSource = dataTable;
                }catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao conectar ao banco de dados: " + ex.Message);
                }
            }
        }
    }
}
