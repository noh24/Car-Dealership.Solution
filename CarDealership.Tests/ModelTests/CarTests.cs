using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using CarDealership.Models;

namespace CarDealership.Tests
{
  [TestClass]
  public class CarTests : IDisposable
  {
    public void Dispose()
    {
      Car.ClearAll();
    }
    [TestMethod]
    public void CarConstructor_ReturnsPropertiesOfCarInstance_CarProperties()
    {
      string make = "Nissan";
      string model = "Shitbox 3000";
      int year = 2004;
      int miles = 200000;
      int price = 200;
      Car car = new Car(make, model, year, miles, price);
      Assert.AreEqual(make, car.Make);
      Assert.AreEqual(model, car.Model);
      Assert.AreEqual(year, car.Year);
      Assert.AreEqual(miles, car.Miles);
      Assert.AreEqual(price, car.Price);
    }
    [TestMethod]
    public void GetAll_ReturnsListOfCarInstances_ListCar()
    {
      Car car1 = new Car("Mercedes", "c300");
      Car car2 = new Car("Lamborghini", "Urus");
      List<Car> carList = new List<Car> { car1, car2 };
      List<Car> result = Car.GetAll();
      CollectionAssert.AreEqual(carList, result);
    }
    [TestMethod]
    public void Find_ReturnInstanceById_Car()
    {
      Car car1 = new Car("Mercedes", "c300");
      Car car2 = new Car("Lamborghini", "Urus");
      // Car result = Car.Find(2);
      Assert.AreEqual(1, Car.Find(1));
    }
  }
}