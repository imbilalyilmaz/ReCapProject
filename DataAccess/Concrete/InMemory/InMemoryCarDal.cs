using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { Id = 1, BrandId = 1 , DailyPrice = 500, Description = "Ford Focus", ModelYear = 2016},
                new Car { Id = 2, BrandId = 1 , DailyPrice = 550, Description = "Ford Fiesta", ModelYear = 2017},
                new Car { Id = 3, BrandId = 2 , DailyPrice = 800, Description = "Bmw 3.20", ModelYear = 2013},
                new Car { Id = 4, BrandId = 2 , DailyPrice = 900, Description = "Bmw 5.20", ModelYear = 2014}
            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carTodelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carTodelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void GetById(int id)
        {
            Car carId = _cars.SingleOrDefault(c => c.Id == id);
            Console.WriteLine(carId.Description);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
