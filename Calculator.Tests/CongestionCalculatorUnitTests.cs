using congestion.calculator;
namespace Calculator.Tests
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
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
        //Toll Free date tests
        #region Tests for toll free dates
        [Test]
        public void IsTollFreeDateTestSunday()
        {
            DateTime date = new DateTime(2013, 02, 24);
            Assert.True(CongestionTaxCalculator.IsTollFreeDate(date));
        }

        public void IsTollFreeDateTestSaturday()
        {
            DateTime date = new DateTime(2013, 02, 09);
            Assert.True(CongestionTaxCalculator.IsTollFreeDate(date));
        }
        public void IsTollFreeDateJuly1()
        {
            DateTime date = new DateTime(2013, 07, 01);
            Assert.True(CongestionTaxCalculator.IsTollFreeDate(date));
        }
        public void IsTollFreeDateJuly13()
        {
            DateTime date = new DateTime(2013, 07, 13);
            Assert.True(CongestionTaxCalculator.IsTollFreeDate(date));
        }
        public void IsTollFreeDateJuly31()
        {
            DateTime date = new DateTime(2013, 07, 31);
            Assert.True(CongestionTaxCalculator.IsTollFreeDate(date));
        }
        public void IsTollFreeDateTest()
        {
            //DateTime date, Vehicle vehicle
            Assert.Pass();
        }

        [Test]
        public void PublicHolidayExcemptionTest()
        {
            //pentecostday
            var pentecost = new DateTime(2013, 05, 18);
            //daybefore
            var daybefore = pentecost.AddDays(-1);
            Assert.True(CongestionTaxCalculator.IsHolidayExcept(pentecost));
            Assert.True(CongestionTaxCalculator.IsHolidayExcept(daybefore));

        }

        #endregion      

        //toll fee test
        [Test]
        public void GetTollFeeAmount8()
        {
            Car car = new Car();
            DateTime time1 = new DateTime(2013, 08, 22, 06, 20, 00), time2 = new DateTime(2013, 08, 22, 09, 20, 00), time3 = new DateTime(2013, 08, 22, 18, 20, 00);
            int Fee1 = CongestionTaxCalculator.GetTollFee(time1, car), Fee2 = CongestionTaxCalculator.GetTollFee(time2, car), Fee3 = CongestionTaxCalculator.GetTollFee(time3, car);

            Assert.False(CongestionTaxCalculator.IsTollFreeDate(time1));
            Assert.False(CongestionTaxCalculator.IsTollFreeVehicle(car));
            Assert.Multiple(() =>
            {
                Assert.That(Fee2, Is.EqualTo(Fee1).Within(Fee3));
                Assert.That(Fee1, Is.EqualTo(8));
            });
        }

        [Test]
        public void GetTollFeeAmount13()
        {
            Car car = new Car();
            DateTime time1 = new DateTime(2013, 08, 22, 06, 50, 00), time2 = new DateTime(2013, 08, 22, 08, 20, 00), time3 = new DateTime(2013, 08, 22, 17, 40, 00);
            int Fee1 = CongestionTaxCalculator.GetTollFee(time1, car), Fee2 = CongestionTaxCalculator.GetTollFee(time2, car), Fee3 = CongestionTaxCalculator.GetTollFee(time3, car);

            Assert.False(CongestionTaxCalculator.IsTollFreeDate(time1));
            Assert.False(CongestionTaxCalculator.IsTollFreeVehicle(car));
            Assert.Multiple(() =>
            {
                Assert.That(Fee2, Is.EqualTo(Fee1).Within(Fee3));
                Assert.That(Fee1, Is.EqualTo(13));
            });
        }

        [Test]
        public void GetTollFeeAmount18()
        {
            Car car = new Car();
            DateTime time1 = new DateTime(2013, 08, 22, 07, 30, 00), time2 = new DateTime(2013, 08, 22, 15, 40, 00), time3 = new DateTime(2013, 08, 22, 16, 50, 00);
            int Fee1 = CongestionTaxCalculator.GetTollFee(time1, car), Fee2 = CongestionTaxCalculator.GetTollFee(time2, car), Fee3 = CongestionTaxCalculator.GetTollFee(time3, car);

            Assert.False(CongestionTaxCalculator.IsTollFreeDate(time1));
            Assert.False(CongestionTaxCalculator.IsTollFreeVehicle(car));
            Assert.Multiple(() =>
            {
                Assert.That(Fee2, Is.EqualTo(Fee1).Within(Fee3));
                Assert.That(Fee1, Is.EqualTo(18));
            });
        }

        [Test]
        public void GetTollFeeAmount0()
        {
            Car car = new Car();
            DateTime time1 = new DateTime(2013, 08, 22, 18, 45, 00), time2 = new DateTime(2013, 08, 22, 05, 20, 00), time3 = new DateTime(2013, 08, 22, 03, 20, 00);
            int Fee1 = CongestionTaxCalculator.GetTollFee(time1, car), Fee2 = CongestionTaxCalculator.GetTollFee(time2, car), Fee3 = CongestionTaxCalculator.GetTollFee(time3, car);

            Assert.False(CongestionTaxCalculator.IsTollFreeDate(time1));
            Assert.False(CongestionTaxCalculator.IsTollFreeVehicle(car));
            Assert.Multiple(() =>
            {
                Assert.That(Fee2, Is.EqualTo(Fee1).Within(Fee3));
                Assert.That(CongestionTaxCalculator.GetTollFee(time1, car), Is.EqualTo(0));
            });
        }
             

    }
}