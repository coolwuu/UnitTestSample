using System;
using NUnit.Framework;

namespace UnitTestSample01.Test
{
    public class HolidayTests
    {
        private FakeHoliday _holiday;

        [SetUp]
        public void Init()
        {
            _holiday = new FakeHoliday();
        }

        [Test]
        public void When_12_25_Should_Return_Merry_XMas()
        {
            _holiday.SetToday(new DateTime(2020, 12, 25));
            Assert.AreEqual("Merry X'Mas", _holiday.SayXMas());
        }

        [Test]
        public void When_12_01_Should_Return_Correctly()
        {
            _holiday.SetToday(new DateTime(2020, 12, 01));
            Assert.AreEqual("Very sad, Today is not X'Mas", _holiday.SayXMas());
        }
    }
}
