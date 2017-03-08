using EA.Dotnet.TaskList.Domain.Entities.Tarefa;
using System.Data.Entity.ModelConfiguration;

namespace EA.Dotnet.TaskList.Infra.Data.EntityConfig
{
    public class TarefaConfiguration : EntityTypeConfiguration<Tarefa>
    {
        public TarefaConfiguration()
        {
            HasKey(t => t.TarefaId);

            Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
