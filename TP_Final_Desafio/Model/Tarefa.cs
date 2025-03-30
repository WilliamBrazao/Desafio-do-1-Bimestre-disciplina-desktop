using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final_Desafio
{
    public class Tarefa
    {
        private static int contador = 1;
        public int Id {get;set; }

        public string Nome { get; set; }

        public string Prioridade { get; set; }
        
        public string DataVencimento {get; set; }

        public string Status { get; set; }
         



        public Tarefa ( string nome, string prioridade, string dataVencimento, string status)
        {
            Id = contador++;
            Nome = nome;
            Prioridade = prioridade;
            DataVencimento = dataVencimento;
            Status = status;
        }

        public void AtualizaDados(string prioridade)
        {
            Prioridade = prioridade.Trim();
        }
    }
}
