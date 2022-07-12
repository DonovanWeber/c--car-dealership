using System;

namespace Dealership.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    public int Wins  { get; set; }

    public Car(string makeModel, int price, int miles, int wins)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Wins = wins;
    }
    
    // public string GetMakeModel()
    // {
    //   return _makeModel;
    // }

    // public int GetPrice()
    // {
    //   return _price;
    // }

    // public void SetPrice(int newPrice)
    // {
    //   _price = newPrice;
    // }

    public void SetSalePrice(int decimalDiscountRate)
    {
      Price = Price - Price / 100 *  decimalDiscountRate;
    }
    public string WillItWin()
    {
      if (Wins >= 1)
      {
        return "Your " + MakeModel + " would win the Dakar Rally!!!";
      }
      else 
      {
      return "Your " + MakeModel + " would not win the Dakar Rally :( ";
      }
    }

    public int PriceAccordingToYear(int userSuppliedYear)
    {
      string makeAndModel = MakeModel;
      string[] wordsArray = makeAndModel.Split(' ');
      int integerManufactureYear = int.Parse(wordsArray[0]);

      int yearsSinceManufactureDate = userSuppliedYear - integerManufactureYear;

      // refactor to require only a year from the user, then return the price of each car in that year

      return Price + (yearsSinceManufactureDate * 200);
      // The year the car was made AKA the first set of characters before a space in the MakeModel field
      // How many years have passed since the car was made until the argued year
      // Multiply the number of years-passed by 5%
      // Return / write that stuff

      // Repeat for each car



    }
    // public int GetMiles()
    // {
    //   return _miles;
    // }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }

    public static string MakeSound(string sound)
    {
      return "Our cars sound like" + sound;
    }
  }
}