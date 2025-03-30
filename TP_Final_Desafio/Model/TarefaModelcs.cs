using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final_Desafio.Model
{
    
    internal class TarefaModel
    {
        private static List<Tarefa> tarefas = new List<Tarefa>();

        public void SalvarTarefa(Tarefa tarefa)
        {
            tarefas.Add(tarefa);
        }
        public List<Tarefa> getTarefas()
        {
            return tarefas;
        }
    }
}
