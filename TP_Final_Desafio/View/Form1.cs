using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Final_Desafio.Controller;
using TP_Final_Desafio.Model;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.InteropServices;

namespace TP_Final_Desafio
{
    public partial class Form1 : Form
    {
        private TarefaController controller = new TarefaController();
        
        public Form1()
        {
            InitializeComponent();
            SelecionaCBX();
            dgvMostrar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbxPrioridade.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }

       public void SelecionaCBX()
        {
            cbxPrioridade.Items.Clear();
            cbxPrioridade.Items.Add("Alta");
            cbxPrioridade.Items.Add("Média");
            cbxPrioridade.Items.Add("Baixa");
            
        }
        public void limpaTela()
        {
            txtNome.Text = "";
            txtData.Text = "";
            cbxPrioridade.Text = "Alta";
            rbComcluido.Checked = false;
            rbPendente.Checked = false;
            txtNome.Focus();
        }
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (dgvMostrar.SelectedRows.Count > 0)
            {
                // Edição
                var linhaSelecionada = dgvMostrar.SelectedRows[0];
                int idSelecionado = Convert.ToInt32(linhaSelecionada.Cells["id"].Value);

                string nome = txtNome.Text;
                string data = txtData.Text;
                string prioridade = cbxPrioridade.Text;
                string status = rbComcluido.Checked ? "Concluído" : "Pendente";

                string msg = controller.EditarTarefa(idSelecionado, nome, prioridade, data, status);
                MessageBox.Show(msg);
            }
            else
            {
                // Criação de nova tarefa
                string nome = txtNome.Text;
                string data = txtData.Text;
                string prioridade = cbxPrioridade.Text;
                string status = rbComcluido.Checked ? "Concluído" : "Pendente";

                string msg = controller.SaveProduto(nome, prioridade, data, status);
                MessageBox.Show(msg);
            }
            limpaTela();
            this.RefreshDgv_Mostra();
            
        }

        private void RefreshDgv_Mostra()
        {
            List<Tarefa> tarefas = controller.GetAllTarefas();
            dgvMostrar.Rows.Clear();
            
            foreach(var tarefa in tarefas)
            {
                dgvMostrar.Rows.Add(
                    tarefa.Id,
                    tarefa.Nome,
                    tarefa.Prioridade,
                    tarefa.DataVencimento,
                    tarefa.Status);
            }
           
        }

        private void btn_Gerar_Click(object sender, EventArgs e)
        {
            chartValores.Series.Clear();
            chartValores.Titles.Clear();
            chartValores.Titles.Add("Gráfico de Prioridades");
            chartValores.ChartAreas[0].AxisX.Title = "Tarefas";
            chartValores.ChartAreas[0].AxisY.Title = "Prioridades";
            var tarefas = controller.GetAllTarefas();

            var prioridadeContagem = tarefas
                .GroupBy(t => t.Prioridade)
                .Select(g => new { Prioridade = g.Key, Quantidade = g.Count() })
                .ToList();

            Series serie = new Series("Prioridades")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Blue,
                BorderWidth = 3,
                //Label = "#VALX (#PERCENT{P0})"
                
            };
           
            foreach (var p in prioridadeContagem)
            {
                // Converta p.Quantidade para int explicitamente
                int quantidade = Convert.ToInt32(p.Quantidade);
                serie.Points.AddXY(p.Prioridade, quantidade);
                
            }
            chartValores.Series.Add(serie);
            chartValores.ChartAreas[0].AxisY.Minimum = 0; // Começa do zero
            chartValores.ChartAreas[0].AxisY.Interval = 1; // Intervalo de 1 (números inteiros)
            chartValores.ChartAreas[0].AxisY.Maximum = 7; 
            chartValores.ChartAreas[0].AxisY.LabelStyle.Format = "N0"; // Formata os rótulos como números inteiros

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if(dgvMostrar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma Tarefa!!");
                return;
            }

            var linhaSelecionadas = dgvMostrar.SelectedRows[0];
            int idSelecionado = Convert.ToInt32(linhaSelecionadas.Cells["id"].Value);
            var  tarefas = controller.GetAllTarefas().FirstOrDefault(t => t.Id == idSelecionado);
            if(tarefas != null)
            {
                txtNome.Text = tarefas.Nome;
                txtData.Text = tarefas.DataVencimento;
                cbxPrioridade.Text = tarefas.Prioridade;
                if (tarefas.Status == "Concluído")
                {
                    rbComcluido.Checked = true;
                }
                else
                {
                    rbPendente.Checked = true;
                }
            }

           
        }
    }
}
