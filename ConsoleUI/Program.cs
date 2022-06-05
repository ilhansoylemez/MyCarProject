using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());


           // carManager.Add(new Car() {BrandId=1,CarName="Skoda", ColorId=2,DailyPrice=80,ModelYear=2015,Description="Automatic Car" });

           
        }
    }
}
