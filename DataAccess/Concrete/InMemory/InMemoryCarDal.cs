using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car {Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2018, DailyPrice = 215, Description = "Tourneo Courier Dizel Manuel"},
                new Car {Id = 2, BrandId = 1, ColorId = 1, ModelYear = 2018, DailyPrice = 265, Description = "Focus Dizel Otomatik"},
                new Car {Id = 2, BrandId = 2, ColorId = 2, ModelYear = 2019, DailyPrice = 500, Description = "216d Dizel Otomatik"},
                new Car {Id = 2, BrandId = 2, ColorId = 2, ModelYear = 2020, DailyPrice = 670, Description = "320d Benzin Otomatik"},
                new Car {Id = 2, BrandId = 3, ColorId = 3, ModelYear = 2020, DailyPrice = 430, Description = "A 180 d Dizel Otomatik"}
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;

            carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);

            _car.Remove(car);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int Id)
        {
            return _car.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
