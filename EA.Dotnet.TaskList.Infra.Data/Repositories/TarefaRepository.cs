using EA.Dotnet.TaskList.Domain.Entities.Tarefa;
using EA.Dotnet.TaskList.Domain.Interfaces.Repository;

namespace EA.Dotnet.TaskList.Infra.Data.Repositories
{
    public class TarefaRepository : BaseRepository<Tarefa>, ITarefaRepository
    {
    }
}
