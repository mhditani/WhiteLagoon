using Microsoft.AspNetCore.Mvc;
using WhiteLagoon.Domain.Entities;
using WhiteLagoon.Infrastructure.Data;

namespace WhiteLagoon.Web.Controllers
{
    public class VillaController : Controller
    {
        private readonly ApplicationDbContext context;

        public VillaController(ApplicationDbContext context)
        {
            this.context = context;
        }



        public IActionResult Index()
        {
            var villas = context.Villas.ToList();
            return View(villas);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Villa villa)
        {
            if (villa.Name == villa.Description)
            {
                ModelState.AddModelError("name", "The Description can't exactly match the Name");
            }
            if (ModelState.IsValid)
            {
                context.Villas.Add(villa);
                context.SaveChanges();
                TempData["success"] = "The villa has been created successfully.";
                return RedirectToAction("Index");
            }
            return View(villa);
        }


        public IActionResult Update(int villaId)
        {
            Villa? villa = context.Villas.FirstOrDefault(x => x.Id == villaId);
            if (villa is null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(villa);
        }


        [HttpPost]
        public IActionResult Update(Villa villa)
        {
         
            if (ModelState.IsValid && villa.Id > 0)
            {
                context.Villas.Update(villa);
                context.SaveChanges();
                TempData["success"] = "The villa has been updated successfully.";

                return RedirectToAction("Index");
            }
            return View(villa);
        }


        public IActionResult Delete(int villaId)
        {
            Villa? villa = context.Villas.FirstOrDefault(y => y.Id == villaId);
            if(villa is null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(villa);
        }

        [HttpPost]
        public IActionResult Delete(Villa villa)
        {
            Villa? objFromDb = context.Villas.FirstOrDefault(v => v.Id == villa.Id);
            if (objFromDb is not null)
            {
                context.Villas.Remove(objFromDb);
                context.SaveChanges();
                TempData["success"] = "The villa has been deleted successfully.";
                return RedirectToAction("Index");
            }
            TempData["error"] = "The villa couldn't be deleted";
            return View();
        }

    }
}
