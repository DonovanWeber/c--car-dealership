using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership
{
  public class Program
  {
    public static void Main()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, 3);
      Car yugo = new Car("1980 Yugo Koral", 700, 56000, 1);
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001, 0);
      Car amc = new Car("1976 AMC Pacer", 400, 198000, 0);

      List<Car> Cars = new List<Car>() {
        volkswagen, yugo, ford, amc
      };

      yugo.Price = 300;

      Console.WriteLine("Type which car you would like to see race in the Dakar Rally!");
      string dakarCarTest = Console.ReadLine();
      if (dakarCarTest == "volkswagen")
      {
      Console.WriteLine(volkswagen.WillItWin());
      }
      else if (dakarCarTest == "yugo")
      {
      Console.WriteLine(yugo.WillItWin());
      }
      else if (dakarCarTest == "ford")
      {
      Console.WriteLine(ford.WillItWin());
      }
      else if (dakarCarTest == "amc")
      {
      Console.WriteLine(amc.WillItWin());
      }
      else 
      {
      Console.WriteLine("please enter the make of the car you would like to see!");
      }
      //string phrase = "The quick brown fox jumps over the lazy dog.";
      // string[] words = phrase.Split(' ');
      // int integerYear = int.Parse(words[0]);
      // for (int index = integerYear; index <= 2022; index++)
      // {
          
      // }

      // PRICE IN SPECIFIC YEAR CHECK:

      // Ask the user for a year
      // Write to the user how much each car cost in that year
      
      Console.WriteLine("Which year do you want to see the price of each car for?");
      string userYearPrice = Console.ReadLine();
      int intUserYearPrice = int.Parse(userYearPrice);

      foreach(Car automobile in Cars)
      {
      Console.WriteLine("The " + automobile.MakeModel + "cost " + automobile.PriceAccordingToYear(intUserYearPrice) + " dollars in " + userYearPrice);
      }

      // foreach(Car automobile in Cars)
      // {
      //   string makeAndModel = automobile.MakeModel;
      //   string[] wordsArray = makeAndModel.Split(' ');
      //   int integerYear = int.Parse(wordsArray[0]);
      //   // Console.WriteLine("year: " + integerYear);
      //   Console.WriteLine("Which year's price do you want for the " + automobile.MakeModel);
      //   string userYearPrice = Console.ReadLine();
      //   int intUserYearPrice = int.Parse(userYearPrice);

      //   int yearCounter = 0;

      //   for (int index = integerYear; index <= intUserYearPrice; index++)
      //   {
      //     yearCounter ++;
      //   }
      //   Console.WriteLine(automobile.PriceAccordingToYear(yearCounter));

      // }

      Console.WriteLine("Please provide a decimal discount rate");
      string userSuppliedDiscountRate = Console.ReadLine();
      Console.WriteLine(userSuppliedDiscountRate);
      int newDiscountRate = int.Parse(userSuppliedDiscountRate);
      Console.WriteLine(yugo.Price);
      Console.WriteLine(newDiscountRate);
      yugo.SetSalePrice(newDiscountRate);
      Console.WriteLine("The Yugo's new price is: " + yugo.Price);

      // Console.WriteLine("Please provide a decimal discount rate");
      // string userSuppliedDiscountRate = Console.ReadLine();
      // decimal newDiscountRate = Decimal.Parse(userSuppliedDiscountRate);
      // yugo.SetSalePrice(newDiscountRate);
      // Console.WriteLine("The Yugo's new price is: " + yugo.Price);

      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      List<Car> CarsMatchingSearch = new List<Car>(0);

      foreach (Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }

      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine("----------------------");
        // Console.WriteLine(automobile.GetMakeModel());
        // Console.WriteLine(automobile.GetMiles() + " miles");
        // Console.WriteLine("$" + automobile.GetPrice());
      }
    }
  }
}
