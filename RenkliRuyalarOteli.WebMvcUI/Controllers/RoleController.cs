﻿using Microsoft.AspNetCore.Mvc;
using RenkliRuyalarOteli.BL.Abstract;

namespace RenkliRuyalarOteli.WebMvcUI.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleManager roleManager;
        public RoleController(IRoleManager roleManager)
        {
            this.roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            var result = await roleManager.FindAllAsync();
            return View(result);
        }
    }
}
