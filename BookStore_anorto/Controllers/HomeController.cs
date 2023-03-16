﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore_anorto.Models;
using BookStore_anorto.Models.ViewModels;

namespace BookStore_anorto.Controllers
{
    public class HomeController : Controller
    {
        private IBookstoreRepository repo;

        public HomeController(IBookstoreRepository br)
        {
            repo = br;
        }

        public IActionResult Index(int pageNum = 1)
        {
            int pageResults = 10;

            var x = new BooksViewModel
            {
                Books = repo.Books
               .OrderBy(b => b.Title)
               .Skip((pageNum - 1) * pageResults)
               .Take(pageResults),

                PageInfo = new PageInfo
                {
                    BookTotal = repo.Books.Count(),
                    BooksPerPage = pageResults,
                    CurrentPage = pageNum

                }
            };

            return View(x);
        }


    }
}
