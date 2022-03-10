using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DomainLayer.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnionArchApp.Models;
using ServiceLayer.Service.Contract;

namespace OnionArchApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUser _user;
        public HomeController(IUser user)
        {
            this._user = user;
        }

        //Get ALl users
       
        public IActionResult Index()
        {

            var response = this._user.GetAllRepo().ToList();
            return View(response);
        }
        //Get Single record
        public IActionResult Details(long id)
        {
            var response = this._user.GetSingleRepo(id);
            return View(response);
            
        }
        //Add user
        [HttpGet]
        public IActionResult Create()
        {           
            return View(new User());
        }
        [HttpPost]
        public ActionResult Create(User user)
        {
            var response = this._user.AddUserRepo(user);
            return RedirectToAction("Index");
        }
        //Remove user
        
        public IActionResult Delete(long id)
        {
            var response = this._user.GetSingleRepo(id);
            return View(response);
            
        }
        [HttpPost]
        public IActionResult Delete(long id, User user)
        {
            
            var response = this._user.RemoveUser(id);
            return RedirectToAction("Index");
        }
        //Update user
        public IActionResult Edit(long id)
        {
            var response = this._user.GetSingleRepo(id);
            return View(response);

        }
        [HttpPost]
        public IActionResult Edit(User user)
        {
            var response = this._user.UpdateUserRepo(user);
            return RedirectToAction("Index");

        }

    }
}
