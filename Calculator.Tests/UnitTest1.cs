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
        #region Tests for toll free vehicles
        [Test]
        public void IsTollFreeVehicleTestMotorcycle()
        {
            Motorbike v = new Motorbike();
            Assert.True(CongestionTaxCalculator.IsTollFreeVehicle(v));
        }
        [Test]
        public void IsTollFreeVehicleTestCar()
        {
            Car v = new Car();
            Assert.False(CongestionTaxCalculator.IsTollFreeVehicle(v));
        }
        [Test]
        public void IsTollFreeVehicleTestBus()
        {
            Bus v = new Bus();
            Assert.True(CongestionTaxCalculator.IsTollFreeVehicle(v));
        }
        [Test]
        public void IsTollFreeVehicleTestEmergencyVehicle()
        {
            Emergency v = new Emergency();
            Assert.True(CongestionTaxCalculator.IsTollFreeVehicle(v));
        }
        [Test]
        public void IsTollFreeVehicleTestDiplomatic()
        {
            Diplomat v = new Diplomat();
            Assert.True(CongestionTaxCalculator.IsTollFreeVehicle(v));
        }
        [Test]
        public void IsTollFreeVehicleTestMilitary()
        {
            Military v = new Military();
            Assert.True(CongestionTaxCalculator.IsTollFreeVehicle(v));
        }

        public void IsTollFreeVehicleTestForeign()
        {
            Foreign v = new Foreign();
            Assert.True(CongestionTaxCalculator.IsTollFreeVehicle(v));
        }
        #endregion

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