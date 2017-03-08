using EA.Dotnet.TaskList.Domain.Entities.Tarefa;
using System;
using System.Collections.Generic;

namespace EA.Dotnet.TaskList.Domain.Interfaces.ReadOnly
{
    public interface ITarefaReadOnlyRepository : IDisposable
    {
        Tarefa GetById(Guid id);
        IEnumerable<Tarefa> GetAll();
    }
}
