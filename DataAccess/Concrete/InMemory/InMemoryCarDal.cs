using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2017,DailyPrice=150.000,Descriptions="Toyota Corolla"},
                new Car{Id=2,BrandId=2,ColorId=2,ModelYear=2018,DailyPrice=180.000,Descriptions="Volkswagen Passat"},
                new Car{Id=3,BrandId=2,ColorId=3,ModelYear=2016,DailyPrice=110.000,Descriptions="Volkswagen Passat"},
                new Car{Id=4,BrandId=1,ColorId=4,ModelYear=2012,DailyPrice=130.000,Descriptions="Toyota Corolla"},
                new Car{Id=5,BrandId=3,ColorId=2,ModelYear=2010,DailyPrice=100.000,Descriptions="Honda Civic"},
                new Car{Id=6,BrandId=2,ColorId=1,ModelYear=2004,DailyPrice=70.000,Descriptions="Volkswagen Passat"},

            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car _carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int getId)
        {
            return _cars.Where(c=>c.BrandId == getId).ToList();
        }

        public void Update(Car car)
        {
            Car _carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            _carToUpdate.Id = car.Id;
            _carToUpdate.BrandId = car.BrandId;
            _carToUpdate.ColorId = car.ColorId;
            _carToUpdate.DailyPrice = car.DailyPrice;
            _carToUpdate.Descriptions = car.Descriptions;
            _carToUpdate.ModelYear = car.ModelYear;
            
        }
    }
}
