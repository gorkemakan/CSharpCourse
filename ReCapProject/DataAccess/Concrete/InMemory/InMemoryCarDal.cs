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
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                //Siyah =1, Beyaz = 2, Mavi = 3
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2021,DailyPrice=1000,Description="BMW 730d"}, //Siyah BMW 730d
                new Car{Id=2,BrandId=1,ColorId=2,ModelYear=1992,DailyPrice=500,Description="BMW 520i"}, //Beyaz BMW 520i
                new Car{Id=3,BrandId=2,ColorId=1,ModelYear=1998,DailyPrice=300,Description="Volkswagen Golf Mk4"}, //Siyah VW Golf Mk4 
                new Car{Id=4,BrandId=2,ColorId=3,ModelYear=1998,DailyPrice=700,Description="Volkswagen Golf Mk8"}, //Mavi VW Golg Mk8
                new Car{Id=5,BrandId=3,ColorId=2,ModelYear=2016,DailyPrice=450,Description="Fiat Linea 1.3 Multijet"}, //Beyaz
                
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(car);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
