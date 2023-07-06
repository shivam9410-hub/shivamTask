using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using shivamTask.Models;
using shivamTask.Models.ViewModel;
using System.Diagnostics;
using shivamTask.Models.Domain;
using shivamTask.MyDictionary;
namespace shivamTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Console.WriteLine(MyDictionary.MyDictionary.mydict.Count);
            List<AddEmployee>mylist = new List<AddEmployee>();

            foreach (   KeyValuePair <Guid, Employee> emp in MyDictionary.MyDictionary.mydict) {
               AddEmployee xemp = new AddEmployee() ;
                xemp.Name = emp.Value.Name;
                xemp.Email = emp.Value.Email;
                xemp.AdharNo= emp.Value.AdharNo;    
                xemp.Role= emp.Value.Role;  
                mylist.Add(xemp);   

            
            } 
            return View(mylist);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}