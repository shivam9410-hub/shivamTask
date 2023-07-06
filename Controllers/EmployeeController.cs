using Microsoft.AspNetCore.Mvc;
using shivamTask.Models.Domain;
using shivamTask.Models.ViewModel;
using shivamTask.MyDictionary;
namespace shivamTask.Controllers
{
    public class EmployeeController : Controller
      { 

         
        public IActionResult Add()
        {         
             

            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(AddEmployee newemp)
        { 

              Employee employee = new Employee();
            employee.Name = newemp.Name;    
            employee.Email = newemp.Email;
            employee.AdharNo = newemp.AdharNo;
            employee.Role = newemp.Role;
            employee.Id=Guid.NewGuid();
             MyDictionary.MyDictionary.mydict.Add(employee.Id, employee);
            Console.WriteLine(MyDictionary.MyDictionary.mydict.Count);
            return RedirectToAction("Index", "Home");
        }
    }
}
