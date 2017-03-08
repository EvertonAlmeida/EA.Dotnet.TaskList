using AutoMapper;
using EA.Dotnet.TaskList.Application.ViewModels;
using EA.Dotnet.TaskList.Domain.Entities.Tarefa;

namespace EA.Dotnet.TaskList.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Tarefa, TarefaViewModel>();       
        }
    }
}