﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new IndexViewModel();
            ViewData["Message"] = "Добрый день, это тестовый текст на главной странице";
            var result = View("Main", viewModel);
            result.StatusCode = 200;
            return result;
        }

        public IActionResult Privacy()
        {
            ViewData["Policy"] = "Текст политики конфидециальности сайта.";
            return View("Privacy");
        }

        public IActionResult TestPage(int page)
        {
            ViewBag.PageIncrement = ++page;
            return View(new TestPageViewModel{Page = page});
        }

        
    }
}