﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using RenkliRuyalarOteli.BL.Abstract;
using RenkliRuyalarOteli.WebMvcUI.Models;
using System.Security.Claims;

namespace RenkliRuyalarOteli.WebMvcUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly IKullaniciManager kullaniciManager;

        public LoginController(IKullaniciManager kullaniciManager)
        {
            this.kullaniciManager = kullaniciManager;
        }

        public IActionResult Giris()
        {
            LoginVM login = new LoginVM();
            return View(login);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Giris(LoginVM login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }



            var kullanici = kullaniciManager.FindAsync(p => p.Email == login.Email && p.Password == login.Password).Result;


            if (kullanici == null)
            {
                ModelState.AddModelError("", "Kullanici Adi Yada Sifre Hatalidir");
                return View(login);

            }
            //Claim 'leri olusturup cookie icerisine atalim
            //new Claim(ClaimTypes.Name, kullanici.Email.Split("@")[0])
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Email,kullanici.Email),
                new Claim(ClaimTypes.Role,"Admin"),
                new Claim(ClaimTypes.Name,kullanici.Adi + " " + kullanici.Soyadi)

            };

            var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authenticationProperty = new AuthenticationProperties
            {
                IsPersistent = login.RememberMe
            };

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme
                                            , new ClaimsPrincipal(claimIdentity)
                                            , authenticationProperty);



            return RedirectToAction("Index", "Home", new { Area = "Admin" });
        }


        public IActionResult LogOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}