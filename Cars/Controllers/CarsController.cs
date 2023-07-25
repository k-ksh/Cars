using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Cars.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {

        private readonly ILogger<CarsController> _logger;

        public CarsController(ILogger<CarsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Car")]
        // GET api/cars
        public IEnumerable<Car> Get()
        {
            // Create a list of cars and return it
            var cars = new List<Car>
            {
                new Car { Id = 1, Make = "Toyota", Model = "Camry", Year = 2022 },
                new Car { Id = 2, Make = "Honda", Model = "Civic", Year = 2021 },
                new Car { Id = 3, Make = "Ford", Model = "Mustang", Year = 2023 },
                new Car { Id = 4, Make = "Chevrolet", Model = "Corvette", Year = 2022 }
            };

            return cars;
        }
    }
}


//{
//    public class CarsController : Controller
//    {
//        // GET: CarsController
//        public ActionResult Index()
//        {
//            return View();
//        }

//        // GET: CarsController/Details/5
//        public ActionResult Details(int id)
//        {
//            return View();
//        }

//        // GET: CarsController/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: CarsController/Create
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create(IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: CarsController/Edit/5
//        public ActionResult Edit(int id)
//        {
//            return View();
//        }

//        // POST: CarsController/Edit/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit(int id, IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: CarsController/Delete/5
//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        // POST: CarsController/Delete/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Delete(int id, IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }
//    }
//}
