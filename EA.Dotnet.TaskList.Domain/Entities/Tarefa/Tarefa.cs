using System;

namespace EA.Dotnet.TaskList.Domain.Entities.Tarefa
{
    public class Tarefa
    {

        public Tarefa()
        {
            TarefaId = Guid.NewGuid();
        }

        public Guid TarefaId { get; set; }
        public string Titulo { get; set; }
        public bool Status { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataEdicao { get; set; }
        public DateTime DataRemocao { get; set; }
        public DateTime DataConclusao { get; set; }
    }
}
