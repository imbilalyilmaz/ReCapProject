using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        CarManager carManager = new CarManager(new EfCarDal());

        foreach (var car in carManager.GetAll())
        {
            Console.WriteLine(car.Description);
        }
        
        Car car1 = new Car { Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2013, DailyPrice = 500, Description = "Ford Fiesta"};

        

    }
}