using System;
using EA.Dotnet.TaskList.Application.Interfaces;
using EA.Dotnet.TaskList.Application.ViewModels;
using AutoMapper;
using EA.Dotnet.TaskList.Domain.Entities.Tarefa;
using EA.Dotnet.TaskList.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace EA.Dotnet.TaskList.Application
{
    public class TarefaAppService : BaseAppService, ITarefaAppService
    {
        private readonly ITarefaService _tarefaService;

        public TarefaAppService(ITarefaService tarefaService)
        {
            _tarefaService = tarefaService;
        }

        public void Add(TarefaViewModel tarefaViewModel)
        {
            var tarefa = Mapper.Map<TarefaViewModel, Tarefa>(tarefaViewModel);

            BeginTransaction();

            _tarefaService.Add(tarefa);

            Commit();
        }

        public TarefaViewModel GetById(Guid id)
        {
            return Mapper.Map<Tarefa, TarefaViewModel>(_tarefaService.GetById(id));
        }

        public IEnumerable<TarefaViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Tarefa>, IEnumerable<TarefaViewModel>>(_tarefaService.GetAll());
        }

        public void Update(TarefaViewModel tarefaViewModel)
        {
            var tarefa = Mapper.Map<TarefaViewModel, Tarefa>(tarefaViewModel);

            BeginTransaction();
            _tarefaService.Update(tarefa);
            Commit();
        }

        public void Remove(TarefaViewModel tarefaViewModel)
        {
            var tarefa = Mapper.Map<TarefaViewModel, Tarefa>(tarefaViewModel);

            BeginTransaction();
            _tarefaService.Remove(tarefa);
            Commit();
        }

        public void Dispose()
        {
            _tarefaService.Dispose();
        }
    }
}
