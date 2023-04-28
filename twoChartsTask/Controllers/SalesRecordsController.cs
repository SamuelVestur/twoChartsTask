using Microsoft.AspNetCore.Mvc;
using twoChartsTask.DataLayer;
using twoChartsTask.Models;


namespace twoChartsTask.Controllers
{
    public class SalesRecordsController : Controller
    {
        // _context je typu DbContextSales, ktorá je triedou z entity framework
        private readonly DbContextSales _context;


        //Konštruktor triedy 'SalesRecordsController', ktorý má ako parameter inštanciu triedy 'DbContextSales' vytvorený pre prístup k Databáze
        public SalesRecordsController(DbContextSales context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowSalesData() 
        {
            return View(); 
        }


        //HTTP post metóda - Vytváranie inštancie triedy List<object> pre ziskanie dat o znacke auta a cene 
        [HttpPost]
        public List<object> GetSalesData()
        {
            List<object> data = new List<object>();

            List<string> labels = _context.cars.Select(p => p.car_brand)
                                     .Distinct()
                                     .ToList();

            data.Add(labels);

            List<int> SalesNumber = _context.cars
                                    .GroupBy(p => p.car_brand)
                                    .Select(g => g.Count())
                                    .ToList();

            data.Add(SalesNumber);

            return data;
        }
    }
}
