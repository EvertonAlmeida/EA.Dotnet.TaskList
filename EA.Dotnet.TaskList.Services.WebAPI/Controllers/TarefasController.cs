using System.Collections.Generic;
using System.Web.Http;
using EA.Dotnet.TaskList.Application.ViewModels;
using EA.Dotnet.TaskList.Application.Interfaces;
using System.Net.Http;
using System.Net;

namespace EA.Dotnet.TaskList.Services.WebAPI.Controllers
{
    public class TarefasController : ApiController
    {

        private readonly ITarefaAppService _tarefaAppService;

        public TarefasController(ITarefaAppService tarefaAppService)
        {
            _tarefaAppService = tarefaAppService;
        }

        // GET: api/Tarefas
        public IEnumerable<TarefaViewModel> Get()
        {
            return _tarefaAppService.GetAll();
        }

        // GET: api/Default/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Tarefas
        public HttpResponseMessage Post(TarefaViewModel tarefaViewModel)
        {
            if (ModelState.IsValid)
            {
                _tarefaAppService.Add(tarefaViewModel);
                return Request.CreateResponse(HttpStatusCode.OK, tarefaViewModel);
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, tarefaViewModel);
        }

        // PUT: api/Tarefas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Tarefas/5
        public void Delete(int id)
        {
        }
    }
}
