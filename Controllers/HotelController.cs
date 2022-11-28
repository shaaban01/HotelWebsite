using Lab_10.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab10.Controllers
{
    public class HotelController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HotelController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Hotel> objHotelList=_db.Hotels;
            return View(objHotelList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Hotel obj)
        {
            _db.Hotels.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public IActionResult getHotel(int id)
        {
            var h = _db.Hotels.FirstOrDefault();
            return View(h);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _db.Hotels.Find(id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            DeletePOST(id);
            return RedirectToAction("Index");
        }

        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.Hotels.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Hotels.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index");

        }

    }

}
