﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
                ViewBag.Woman = _context.Leagues
                .Where(l => l.Name.Contains("Women"))
                .ToList();
                ViewBag.Hockey = _context.Leagues
                .Where(l => l.Name.Contains("Hockey"))
                .ToList();
                ViewBag.NotFoot = _context.Leagues
                .Where(l => !l.Name.Contains("Football"))
                .ToList();
                ViewBag.Conf = _context.Leagues
                .Where(l => l.Name.Contains("Conference"))
                .ToList();
                ViewBag.Atlantic = _context.Leagues
                .Where(l => l.Name.Contains("Atlantic"))
                .ToList();
                ViewBag.Dallas = _context.Teams
                .Where(l => l.Location.Contains("Dallas"))
                .ToList();
                ViewBag.Raptors = _context.Teams
                .Where(l => l.TeamName.Contains("Raptors"))
                .ToList();
                ViewBag.City = _context.Teams
                .Where(l => l.Location.Contains("City"))
                .ToList();
                ViewBag.T = _context.Teams
                .Where(l => l.TeamName.StartsWith("T"))
                .ToList();
                ViewBag.OrderedAlpha = _context.Teams
                .OrderBy(l => l.Location)
                .ToList();
                ViewBag.RevAlpha = _context.Teams
                .OrderByDescending(l => l.TeamName)
                .ToList();
                                ViewBag.Cooper = _context.Players
                .Where(l => l.LastName.Contains("Cooper"))
                .ToList();
                ViewBag.Joshua = _context.Players
                .Where(l => l.FirstName.Contains("Joshua"))
                .ToList();
                ViewBag.Jooper = _context.Players
                .Where(l => !l.FirstName.Contains("Joshua"))
                .Where(l => l.LastName.Contains("Cooper"))
                .ToList(); 
                ViewBag.AlOrWy = _context.Players
                .Where(l => l.FirstName.Contains("Alexander") || l.FirstName.Contains("Wyatt"))
                .ToList();                                  
            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}