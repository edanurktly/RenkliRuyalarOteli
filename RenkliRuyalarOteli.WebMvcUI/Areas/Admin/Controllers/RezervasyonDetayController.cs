using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RenkliRuyalarOteli.BL.Abstract;

namespace RenkliRuyalarOteli.WebMvcUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin, ")]
    public class RezervasyonDetayController : Controller
    {
        private readonly IRezervasyonManager rezervasyonManager;
        public RezervasyonDetayController(IRezervasyonManager rezervasyonManager)
        {
            this.rezervasyonManager = rezervasyonManager;
        }

        public async Task<IActionResult> Index()
        {
            var result = await rezervasyonManager.FindAllAsync();
            return View(result);
        }
    }
}
