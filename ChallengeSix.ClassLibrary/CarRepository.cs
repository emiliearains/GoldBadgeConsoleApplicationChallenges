using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeSixClassLibrary
{
    public class CarRepository
    {
        private List<Car> _listOfCars = new List<Car>();
        // Create
        public void AddCar(Car car)
        {
            _listOfCars.Add(car);
        }
        // Read
        public List<Car> GetCars()
        {
            return _listOfCars;
        }
        public Car GetCarByModel(string model)
        {
            foreach (Car car in _listOfCars)
            {
                if (car.Model == model)
                {
                    return car;
                }
            }
            return new Car();
        }
        
        // Update
        public bool UpdateCar(string model, Car updatedCar)
        {
            Car existingCar = GetCarByModel(model);
            if (existingCar != null)
            {
                existingCar.Make = updatedCar.Make;
                existingCar.Model = updatedCar.Model;
                existingCar.MaxMileRange = updatedCar.MaxMileRange;
                return true;
            }
            else
            {
                return false;
            }
        }
        // Delete
        public bool DeleteCar(string model)
        {
            foreach (Car car in _listOfCars) 
            {
                if (car.Model == model)
                {
                    _listOfCars.Remove(car);
                    return true;
                }
            }
            return false;
        }
    }
}
