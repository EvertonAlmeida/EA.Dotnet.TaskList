using System;
using System.Collections.Generic;
using EA.Dotnet.TaskList.Domain.Entities.Tarefa;
using EA.Dotnet.TaskList.Domain.Interfaces.ReadOnly;
using System.Data;
using Dapper;
using System.Linq;

namespace EA.Dotnet.TaskList.Infra.Data.Repositories.ReadOnly
{
    public class TarefaReadOnlyRepository : BaseReadOnlyRepository, ITarefaReadOnlyRepository
    {
        public IEnumerable<Tarefa> GetAll()
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();

                var sql = @"Select * From Tarefa t ";

                var tarefa = cn.Query<Tarefa>(sql);

                return tarefa;
            }
        }

        public Tarefa GetById(Guid id)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();

                var sql = @"Select * From Tarefa t " +
                          "WHERE t.TarefaId ='" + id + "'";

                var tarefa = cn.Query<Tarefa>(sql);

                return tarefa.FirstOrDefault();
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
