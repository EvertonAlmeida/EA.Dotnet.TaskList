using System;
using EA.Dotnet.TaskList.Domain.Entities.Tarefa;
using EA.Dotnet.TaskList.Domain.Interfaces.Services;
using EA.Dotnet.TaskList.Domain.Interfaces.Repository;
using System.Collections.Generic;
using EA.Dotnet.TaskList.Domain.Interfaces.ReadOnly;

namespace EA.Dotnet.TaskList.Domain.Services
{
    public class TarefaService : ITarefaService
    {
        private readonly ITarefaRepository _tarefaRepository;
        private readonly ITarefaReadOnlyRepository _tarefaReadOnlyRepository;

        public TarefaService(
            ITarefaRepository tarefaRepository,
            ITarefaReadOnlyRepository tarefaReadOnlyRepository)
        {
            _tarefaRepository = tarefaRepository;
            _tarefaReadOnlyRepository = tarefaReadOnlyRepository;
        }

        public void Add(Tarefa tarefa)
        {
            _tarefaRepository.Add(tarefa);
        }

        public Tarefa GetById(Guid id)
        {
            return _tarefaRepository.GetById(id);
        }

        public IEnumerable<Tarefa> GetAll()
        {
            return _tarefaReadOnlyRepository.GetAll();
        }

        public void Update(Tarefa tarefa)
        {
            _tarefaRepository.Update(tarefa);
        }

        public void Remove(Tarefa tarefa)
        {
            _tarefaRepository.Remove(tarefa);
        }

        public void Dispose()
        {
            _tarefaRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
