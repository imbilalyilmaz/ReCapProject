using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        CarManager carManager = new CarManager(new EfCarDal());


        /*Car car1 = new Car { Id = 1, BrandId = 1, ColorId = 1, CarName = "Fiesta", ModelYear = 2013, DailyPrice = 500, Description = "Tertemiz" };
        Car car2 = new Car { Id = 2, BrandId = 1, ColorId = 2, CarName = "Focus", ModelYear = 2015, DailyPrice = 600, Description = "Tertemiz"};
        Car car3 = new Car { Id = 3, BrandId = 2, ColorId = 2, CarName = "3.20i", ModelYear = 2017, DailyPrice = 900, Description = "Tertemiz"};
        Car car4 = new Car { Id = 4, BrandId = 2, ColorId = 3, CarName = "5.20d", ModelYear = 2012, DailyPrice = 650, Description = "Tertemiz"};
        Car car5 = new Car { Id = 5, BrandId = 3, ColorId = 4, CarName = "Amg", ModelYear = 2014, DailyPrice = 700, Description = "Tertemiz"};

        carManager.Add(car2);
        carManager.Add(car3);
        carManager.Add(car4);
        carManager.Add(car5);*/

        BrandManager brandManager = new BrandManager(new EfBrandDal());

        /*Brand brand1 = new Brand { BrandId = 1, BrandName = "Ford"};
        Brand brand2 = new Brand { BrandId = 2, BrandName = "BMW"};
        Brand brand3 = new Brand { BrandId = 3, BrandName = "Mercedes"};

        brandManager.Add(brand1);
        brandManager.Add(brand2);
        brandManager.Add(brand3);*/

        ColorManager colorManager = new ColorManager(new EfColorDal());

        /*Color color1 = new Color { ColorId = 1, ColorName = "Siyah"};
        Color color2 = new Color { ColorId = 2, ColorName = "Kırmızı"};
        Color color3 = new Color { ColorId = 3, ColorName = "Beyaz"};
        Color color4 = new Color { ColorId = 4, ColorName = "Gri"};

        colorManager.Add(color1);
        colorManager.Add(color2);
        colorManager.Add(color3);
        colorManager.Add(color4);*/

        //CarTest(carManager);
        //BrandTest(brandManager);
        //ColorTest(colorManager);

    }

    private static void ColorTest(ColorManager colorManager)
    {
        foreach (var color in colorManager.GetAll())
        {
            Console.WriteLine(color.ColorName);
        }
    }

    private static void BrandTest(BrandManager brandManager)
    {
        foreach (var brand in brandManager.GetAll())
        {
            Console.WriteLine(brand.BrandName);
        }
    }

    private static void CarTest(CarManager carManager)
    {
        foreach (var car in carManager.GetCarDetails())
        {
            Console.WriteLine("{0} / {1} / {2} / {3}",car.BrandName,car.CarName,car.ColorName,car.DailyPrice);
        }
    }
}