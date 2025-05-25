
using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController :Controller
    {
        public IActionResult Index1()
        {
            string message=$"Hello World.{DateTime.Now.ToString()}";
            return View("Index1",message);
        }

        public ViewResult Index2()
        {
            var names = new String[]
            {
                "Ahmet",
                "Mehmet",
                "Can"
            };
            return View(names);
        }
        public IActionResult Index3()
        {
            var list =new List<Employee>()
            {
                new Employee(){Id=1,Firstname="Ahmet",Lastname="Can",Age=20},
                new Employee(){Id=2,Firstname="Can",Lastname="Dag",Age=25},
                new Employee(){Id=3,Firstname="Demir",Lastname="Gunes",Age=37}
            };
            return View("Index3",list);
        }

        private object List<T>()
        {
            throw new NotImplementedException();
        }
    }
}