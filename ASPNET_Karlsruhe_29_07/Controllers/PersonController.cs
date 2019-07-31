using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNET_Karlsruhe_29_07.Data;
using ASPNET_Karlsruhe_29_07.Models.Todo;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET_Karlsruhe_29_07.Controllers
{
    public class PersonController : Controller
    {
        private readonly TodoContext _context;
        public PersonController(TodoContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewData["Title"] = "Personenverwaltung";

            return View(_context.People.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string Birthday, string Name)
        {
            Person p = new Person();
            p.Birthday = Birthday;
            p.Name = Name;
            _context.Add(p);
            _context.SaveChanges();
            return View(_context.People.Find(p.Id));
        }
        public IActionResult Delete(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var person = _context.People.Find(id);
            if(person == null)
            {
                return NotFound();
            }

            /*Person p = new Person() { Id = id };
            _context.Entry(p).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;*/
            //_context.SaveChanges();
            return View(person);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(string? id)
        {
            var person = _context.People.Find(id);
            if (person == null)
            {
                return NotFound();
            }

            try
            {
                _context.People.Remove(person);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }catch(Exception e)
            {
                return NotFound();
            }


        }
    }
}