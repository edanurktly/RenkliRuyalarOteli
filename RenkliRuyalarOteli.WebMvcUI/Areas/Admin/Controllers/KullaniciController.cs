﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RenkliRuyalarOteli.BL.Abstract;

namespace RenkliRuyalarOteli.WebMvcUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class KullaniciController : Controller
    {
        private readonly IKullaniciManager kullaniciManager;

        public KullaniciController(IKullaniciManager kullaniciManager)
        {
            this.kullaniciManager = kullaniciManager;
        }
        public async Task<IActionResult> Index()
        {
            var result = await kullaniciManager.FindAllIncludeAsync(null, p => p.Roller);
            return View(result.ToList());
        }
        public async Task<IActionResult> Kayit()
        {
            return View();
        }
    }
}