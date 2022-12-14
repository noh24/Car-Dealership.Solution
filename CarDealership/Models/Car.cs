using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int Miles { get; set; }
    public int Price { get; set; }
    public string ImgURL {get; set;}
    public int Id { get; }
    private static int HighestCarID = 0;
    private static List<Car> _instances = new List<Car> { }; // Car1.Id = List.Count,  Car2 
    
    public Car(string make, string model)
    {
      Make = make;
      Model = model;
      _instances.Add(this);
      HighestCarID++;
      Id = HighestCarID;
    }
    public Car(string make , string model, int year , int miles, int price)
      : this(make, model)
    {
      Year = year;
      Miles = miles;
      Price = price;
    }

    
    public Car(string make , string model, int year , int miles, int price, string imgURL)
      : this(make, model, year, miles, price)
    {
      ImgURL = imgURL;
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static int Find(int id)
    { 
      for(int i = 0; i < _instances.Count; i++)
      {
        if (_instances[i].Id == id)
        {
          return i;
        }
      }
      return -1;
    }

    public static int FindCar(int id)
    {
        for(int i = 0; i < _instances.Count; i++)
        {
          if(_instances[i].Id == id)
          {
            return i;
          }
        }
        return -1;
    }
    public static void Delete(int id)
    {
      // if(_instances.IndexOf == Id - 1)
      int foundId = Find(id);
      if (foundId != -1)
      {
        _instances.RemoveAt(foundId);
      }
    }
  }
}