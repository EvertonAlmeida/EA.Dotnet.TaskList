using AutoMapper;
using EA.Dotnet.TaskList.Application.ViewModels;
using EA.Dotnet.TaskList.Domain.Entities.Tarefa;

namespace EA.Dotnet.TaskList.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<TarefaViewModel, Tarefa>();
        }
    }
}