using EA.Dotnet.TaskList.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace EA.Dotnet.TaskList.Application.Interfaces
{
    public interface ITarefaAppService : IDisposable
    {
        void Add(TarefaViewModel tarefaViewModel);
        TarefaViewModel GetById(Guid id);
        IEnumerable<TarefaViewModel> GetAll();
        void Update(TarefaViewModel tarefaViewModel);
        void Remove(TarefaViewModel tarefaViewModel);
    }
}
