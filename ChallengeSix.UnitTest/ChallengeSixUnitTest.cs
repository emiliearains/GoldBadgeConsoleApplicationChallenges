using ChallengeSixClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChallengeSixUnitTest
{
    [TestClass]
    public class ChallengeSixUnitTest
    {
        private CarRepository _carRepository;
        private Car _car;

        [TestInitialize]
        public void Arrange()
        {
            _carRepository = new CarRepository();
            _car = new Car("Tesla", "CyberTruck", 303);
            _carRepository.AddCar(_car);
        }
        [TestMethod]
        public void SubMenuAddCar_ShouldGetNotNull()
        {
            Car testCar = new Car("Honda", "Civic Sport", 350);
            _carRepository.AddCar(testCar);
            Car carByModel = _carRepository.GetCarByModel("Civic Sport");

            Assert.IsNotNull(carByModel);
        }
        [TestMethod]
        public void SubMenuUpdateCar_ShouldReturnTrue()
        {
            Car updatedCar = _carRepository.GetCarByModel("Civic"); 
            updatedCar.Model = "CivicTest";
            _carRepository.UpdateCar("Civic", updatedCar);
            Car testUpdatedCar = _carRepository.GetCarByModel("CivicTest");
            Assert.IsNotNull(testUpdatedCar);
        }
        [TestMethod]
        public void SubMenuDeleteCar_ShouldReturnTrue()
        {
            bool deleteCar = _carRepository.DeleteCar(_car.Model);

            Assert.IsTrue(deleteCar);
        }
    }
}
