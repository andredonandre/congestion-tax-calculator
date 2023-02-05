using congestion.calculator;

namespace Calculator.Tests
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        //Toll free vehical tests
        [Test]
        public void IsTollFreeVehicleTestMotorcycle()
        {
            Motorbike bike = new Motorbike();           
            Assert.True(CongestionTaxCalculator.IsTollFreeVehicle(bike));
        }
        [Test]
        public void IsTollFreeVehicleTestCar()
        {
            Car car = new Car();
            Assert.False(CongestionTaxCalculator.IsTollFreeVehicle(car));
        }
        //[Test]
        //public void IsTollFreeVehicleTestBus()
        //{
        //    Motorbike bike = new Motorbike();
        //    Assert.True(CongestionTaxCalculator.IsTollFreeVehicle(bike));
        //}
        //[Test]
        //public void IsTollFreeVehicleTestEmergencyVehicle()
        //{
        //    Motorbike bike = new Motorbike();
        //    Assert.True(CongestionTaxCalculator.IsTollFreeVehicle(bike));
        //}
        //[Test]
        //public void IsTollFreeVehicleTestDiplomatic()
        //{
        //    Motorbike bike = new Motorbike();
        //    Assert.True(CongestionTaxCalculator.IsTollFreeVehicle(bike));
        //}
        //[Test]
        //public void IsTollFreeVehicleTestMilitary()
        //{
        //    Motorbike bike = new Motorbike();
        //    Assert.True(CongestionTaxCalculator.IsTollFreeVehicle(bike));
        //}

        //public void IsTollFreeVehicleTestForeign()
        //{
        //    Motorbike bike = new Motorbike();
        //    Assert.True(CongestionTaxCalculator.IsTollFreeVehicle(bike));
        //}

        [Test]
        public void IsTollFreeDateTest()
        {
            //DateTime date, Vehicle vehicle
            Assert.Pass();
        }

        [Test]
        public void GetTollFeeTest()
        {
            //DateTime date, Vehicle vehicle
            Assert.Pass();
        }
    }
}