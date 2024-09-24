using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WhiteLagoon.Domain.Entities;
using WhiteLagoon.Infrastructure.Data;
using WhiteLagoon.Web.ViewModels;

namespace WhiteLagoon.Web.Controllers
{
    public class VillaNumberController : Controller
    {
        private readonly ApplicationDbContext context;

        public VillaNumberController(ApplicationDbContext context)
        {
            this.context = context;
        }






        public IActionResult Index()
        {
            var Villanumber = context.VillaNumbers.Include(u => u.Villa).ToList();
            return View(Villanumber);
        }


        public IActionResult Create()
        {
            VillaNumberVM villaNumberVM = new() 
            { 
                VillaList = context.Villas.ToList().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                })
            };
      
            //ViewData["VillaList"] = list;
            //ViewBag.VillaList = list;

            return View(villaNumberVM);
        }

        [HttpPost]
        public IActionResult Create(VillaNumberVM villaNumber)
        {
            bool roomNumberExists = context.VillaNumbers.Any(u => u.Villa_Number == villaNumber.VillaNumber.Villa_Number);
            if (ModelState.IsValid && !roomNumberExists)
            {
                context.VillaNumbers.Add(villaNumber.VillaNumber);
                context.SaveChanges();
                TempData["success"] = "The Villa Number has been created successfully";
                return RedirectToAction("Index", "VillaNumber");
            }
            if (roomNumberExists)
            {
                TempData["error"] = "The Villa Number already exists";
            }
            villaNumber.VillaList = context.Villas.ToList().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.Id.ToString()
            });
            return View(villaNumber);
        }

    }
}
