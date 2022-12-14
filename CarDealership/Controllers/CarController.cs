using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class CarController : Controller
  {
    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> ourCars = Car.GetAll();
      return View(ourCars);
    }

    [HttpGet("/cars/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create(string make , string model, int year , int miles, int price, string picture)
    {
      Car car = new Car(make, model, year, miles, price, picture);
      return RedirectToAction("Index");
    }

    [HttpPost("/cars/delete")]
    public ActionResult Delete(int id)
    {
      Car.Delete(id);
      return RedirectToAction("Index");
    }
  }
}