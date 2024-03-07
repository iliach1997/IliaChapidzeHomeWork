using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task_NET_09.DbContextModels;
using Task_NET_09.Models;
using Task_NET_09.Repository;

namespace Task_NET_09.Controllers
{
    public class ToDoItemsController : Controller
    {
       private readonly IToDoRepository _toDoRepository;
        public ToDoItemsController(IToDoRepository toDo)
        {
          _toDoRepository = toDo;
        }
        public IActionResult Index()
        {
          
            var viewModel=_toDoRepository.GetAll().ToArray();
     
            return View(viewModel);
        }
        [HttpGet]
        public IActionResult Create(int id)
        {
            if(id == 0)
            {
              return View();
            }
            else
            {
                var item=_toDoRepository.GetById(id);
                var itemModel = new GetToDuItemViewModel()
                {
                    Id = id,
                    Name = item.Name,
                    IsComplete = item.IsComplete,
                };
                return View(itemModel);
            }
           
        }
        [HttpPost]
        public IActionResult Create(GetToDuItemViewModel items)
        {
            if (items.Id == 0)
            {
                _toDoRepository.Insert(items);
                _toDoRepository.Save();
                return View(items);
            }
            else
            {
                _toDoRepository.Update(items);
                _toDoRepository.Save();
                return View(items);
            }
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult Delete(int id)
        {
            _toDoRepository.DeleteById(id);
            _toDoRepository.Save();
           return  RedirectToAction(nameof(Index));
        }
        //[HttpGet]
        //public IActionResult Edit(ToDoItems item)
        //{
        //    _toDoRepository.Update(item);
        //    _toDoRepository.Save();
         
        //    return View();
        //}
    }
}
