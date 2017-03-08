using EA.Dotnet.TaskList.Domain.Entities.Tarefa;
using EA.Dotnet.TaskList.Infra.Data.EntityConfig;
using EA.Dotnet.TaskList.Infra.Data.Interfaces;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System;

namespace EA.Dotnet.TaskList.Infra.Data.Context
{
    public class TaskListContext : DbContext, IDbContext
    {
        public TaskListContext()
            : base("TaskList")
        {

        }

        public DbSet<Tarefa> Tarefa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Conventions
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            // General Custom Context Properties
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            // ModelConfiguration
            modelBuilder.Configurations.Add(new TarefaConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        IDbSet<T> IDbContext.Set<T>()
        {
            return base.Set<T>();
        }
    }
}
