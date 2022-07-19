using System;
using System.Collections.Generic;
using Dealership.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Dealership
{
  public class Program
  {
    // public static void Main()
    // {
    //   Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, 3);
    //   Car yugo = new Car("1980 Yugo Koral", 700, 56000, 1);
    //   Car ford = new Car("1988 Ford Country Squire", 1400, 239001, 0);
    //   Car amc = new Car("1976 AMC Pacer", 400, 198000, 0);

    //   List<Car> Cars = new List<Car>() {
    //     volkswagen, yugo, ford, amc
    //   };

    //   yugo.Price = 300;

    //   Console.WriteLine("Type which car you would like to see race in the Dakar Rally!");
    //   string dakarCarTest = Console.ReadLine();
    //   if (dakarCarTest == "volkswagen")
    //   {
    //   Console.WriteLine(volkswagen.WillItWin());
    //   }
    //   else if (dakarCarTest == "yugo")
    //   {
    //   Console.WriteLine(yugo.WillItWin());
    //   }
    //   else if (dakarCarTest == "ford")
    //   {
    //   Console.WriteLine(ford.WillItWin());
    //   }
    //   else if (dakarCarTest == "amc")
    //   {
    //   Console.WriteLine(amc.WillItWin());
    //   }
    //   else 
    //   {
    //   Console.WriteLine("please enter the make of the car you would like to see!");
    //   }
      
    //   Console.WriteLine("Which year do you want to see the price of each car for?");
    //   string userYearPrice = Console.ReadLine();
    //   int intUserYearPrice = int.Parse(userYearPrice);

    //   foreach(Car automobile in Cars)
    //   {
    //   Console.WriteLine("The " + automobile.MakeModel + "cost " + automobile.PriceAccordingToYear(intUserYearPrice) + " dollars in " + userYearPrice);
    //   }

     

    //   Console.WriteLine("Please provide a decimal discount rate");
    //   string userSuppliedDiscountRate = Console.ReadLine();
    //   Console.WriteLine(userSuppliedDiscountRate);
    //   int newDiscountRate = int.Parse(userSuppliedDiscountRate);
    //   Console.WriteLine(yugo.Price);
    //   Console.WriteLine(newDiscountRate);
    //   yugo.SetSalePrice(newDiscountRate);
    //   Console.WriteLine("The Yugo's new price is: " + yugo.Price);

    //   Console.WriteLine("Enter maximum price: ");
    //   string stringMaxPrice = Console.ReadLine();
    //   int maxPrice = int.Parse(stringMaxPrice);

    //   List<Car> CarsMatchingSearch = new List<Car>(0);

    //   foreach (Car automobile in Cars)
    //   {
    //     if (automobile.WorthBuying(maxPrice))
    //     {
    //       CarsMatchingSearch.Add(automobile);
    //     }
    //   }

    //   foreach(Car automobile in CarsMatchingSearch)
    //   {
    //     Console.WriteLine("----------------------");
    //     // Console.WriteLine(automobile.GetMakeModel());
    //     // Console.WriteLine(automobile.GetMiles() + " miles");
    //     // Console.WriteLine("$" + automobile.GetPrice());
    //   }
    // }
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }
  }
}
