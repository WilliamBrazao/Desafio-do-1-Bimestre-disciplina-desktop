using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final_Desafio.Model;

namespace TP_Final_Desafio.Controller
{
    internal class TarefaController
    {
        private TarefaModel model = new TarefaModel();
         
        public  string SaveProduto(string nome, string prioridade, string dataVencimento, string status)
        {

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(prioridade) || string.IsNullOrWhiteSpace(dataVencimento) || string.IsNullOrWhiteSpace(status))
            {
                return "Todos os campos são obrigatórios";
            }

            Tarefa produto = new Tarefa( nome, prioridade, dataVencimento, status);

            model.SalvarTarefa(produto);
            return "Tarefa Salva com sucesso!!";
        }
        public string EditarTarefa(int id, string nome, string prioridade, string dataVencimento, string status)
        {
            var tarefas = model.getTarefas();
            var tarefa = tarefas.FirstOrDefault(t => t.Id == id);

            if (tarefa != null)
            {
                tarefa.Nome = nome;
                tarefa.Prioridade = prioridade;
                tarefa.DataVencimento = dataVencimento;
                tarefa.Status = status;
                return "Tarefa editada com sucesso!";
            }

            return "Erro: Tarefa não encontrada.";
        }




        public List<Tarefa> GetAllTarefas()
        {
            return model.getTarefas();
        }
    }
}
