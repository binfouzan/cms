﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BethanyPieShop.Models;
using BethanyPieShop.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanyPieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {

            var pies = _pieRepository.GetAllPies().OrderBy(p => p.Name);
            var homeViewModel = new HomeViewModel()
            {
                Pies = pies.ToList(),
                Title = "Welcome To Bethany's Pie Shop"

            };

            return View(homeViewModel);
        }
    }
}
