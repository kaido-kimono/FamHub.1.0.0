﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FamHub._1._0._0.Models;

namespace FamHub._1._0._0.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("Acceuil");
        }

        [HttpPost]
        public ViewResult CreationCompte(Utilisateur utilisateur)
        {
            return View();
        }

    }
}
