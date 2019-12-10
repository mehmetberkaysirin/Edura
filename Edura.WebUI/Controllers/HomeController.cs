using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edura.WebUI.Entity;
using Edura.WebUI.Repository;
using Edura.WebUI.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edura.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository repository;
        private IUnitOfWork uow;
        public HomeController(IUnitOfWork _uow,IProductRepository _repository)
        {
            repository = _repository;
            uow = _uow;
        }
        public IActionResult Index()
        {
            return View(uow.Products.GetAll().Where(i=>i.IsApproved && i.IsHome).ToList());
        }
        public IActionResult Details(int id)
        {
            return View(repository.Get(id));
        }
        public IActionResult Create()
        {
            var prd = new Product() { ProductName = "Yeni Ürün", Price = 100 };
            uow.Products.Add(prd);
            uow.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}