using NUnit.Framework;
using CarManager; //remove for tests
using System;

namespace Tests
{
    public class CarTestss
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CorrectlyInitializeCar()
        {
            string make = "a";
            string model = "a";
            double fCon = 5;
            double fCap = 6;
            Car car = new Car(make, model, fCon, fCap);

            Assert.IsNotNull(car);
            Assert.AreEqual(make, car.Make);
            Assert.AreEqual(model, car.Model);
            Assert.AreEqual(fCon, car.FuelConsumption);
            Assert.AreEqual(fCap, car.FuelCapacity);
        }

        [Test]
        [TestCase("", "a", 5, 5)]
        [TestCase(null, "a", 5, 5)]
        [TestCase("a", "", 5, 5)]
        [TestCase("a", null, 5, 5)]
        [TestCase("a", "a", 0, 5)]
        [TestCase("a", "a", -5, 5)]
        [TestCase("a", "a", 5, -5)]
        [TestCase("a", "a", 5, 0)]
        public void When_CarIsInitializedWithWrongParamsShould_ThrowException(string make, string model, double fCon, double fCap)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car(make, model, fCon, fCap);
            });
        }

        [Test]
        public void CarIsNormallyRefueled()
        {
            int amount = 5;
            Car car = new Car("a", "a", 5, 10);

            car.Refuel(amount);

            Assert.AreEqual(amount, car.FuelAmount);
        }

        [Test]
        [TestCase(0)]
        [TestCase(-5)]
        public void When_CarIsRefueledWithInvalidAmountShould_ThrowException(double f)
        {
            Car car = new Car("a", "a", 5, 10);

            Assert.Throws<ArgumentException>(() =>
            {
                car.Refuel(f);
            });
        }

        [Test]
        public void When_CarIsRefueled_ShouldNotHaveMoreThanMaxCapacityOfFuel()
        {
            Car car = new Car("a", "a", 5, 10);
            car.Refuel(5);

            car.Refuel(car.FuelCapacity);

            Assert.AreEqual(car.FuelCapacity, car.FuelAmount);
        }

        [Test]
        public void DriveNormally()
        {
            double distance = 2;
            Car car = new Car("a", "a", 5, 10);
            car.Refuel(car.FuelCapacity);

            car.Drive(distance);

            Assert.AreEqual(car.FuelAmount, car.FuelCapacity - distance / 100 * car.FuelConsumption);
        }

        [Test]
        public void DriveUntilTankEmpty()
        {
            Car car = new Car("a", "a", 100, 10);
            car.Refuel(car.FuelCapacity);

            car.Drive(10);

            Assert.AreEqual(0, car.FuelAmount);
        }

        [Test]
        public void When_DistanceIsTooBigForTheAmountOfFuelLeft_ThrowException()
        {
            Car car = new Car("a", "a", 100, 10);
            car.Refuel(car.FuelCapacity);

            Assert.Throws<InvalidOperationException>(() => { car.Drive(11); });
        }
    }
}
