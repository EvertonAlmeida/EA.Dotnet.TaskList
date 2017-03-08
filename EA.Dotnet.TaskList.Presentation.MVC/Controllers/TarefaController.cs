using EA.Dotnet.TaskList.Application.Interfaces;
using EA.Dotnet.TaskList.Application.ViewModels;
using System;
using System.Web.Mvc;

namespace EA.Dotnet.TaskList.Presentation.MVC.Controllers
{
    public class TarefaController : Controller
    {
        private readonly ITarefaAppService _tarefaAppService;

        public TarefaController(ITarefaAppService tarefaAppService)
        {
            _tarefaAppService = tarefaAppService;
        }

        // GET: Tarefa
        public ActionResult Index()
        {
            return View(_tarefaAppService.GetAll());
        }

        // GET: Tarefa/Details/5
        public ActionResult Details(Guid id)
        {
            var tarefaViewModel = _tarefaAppService.GetById(id);
            return View(tarefaViewModel);
        }

        // GET: Tarefa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tarefa/Create
        [HttpPost]
        public ActionResult Create(TarefaViewModel tarefaViewModel)
        {
            if (ModelState.IsValid)
            {
                _tarefaAppService.Add(tarefaViewModel);
                return RedirectToAction("Index");
            }
        
            return View(tarefaViewModel);
        }

        // GET: Tarefa/Edit/5
        public ActionResult Edit(Guid id)
        {
            var tarefaViewModel = _tarefaAppService.GetById(id);
            return View(tarefaViewModel);
        }

        // POST: Tarefa/Edit/5
        [HttpPost]
        public ActionResult Edit(TarefaViewModel tarefaViewModel)
        {
            if (ModelState.IsValid)
            {
                _tarefaAppService.Update(tarefaViewModel);
                return RedirectToAction("Index");
            }

            return View(tarefaViewModel);
        }

        // GET: Tarefa/Delete/5
        public ActionResult Delete(Guid id)
        {
            var tarefaViewModel = _tarefaAppService.GetById(id);
            return View(tarefaViewModel);
        }

        // POST: Tarefa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _tarefaAppService.Remove(_tarefaAppService.GetById(id));

            return RedirectToAction("Index");
        }
    }
}
