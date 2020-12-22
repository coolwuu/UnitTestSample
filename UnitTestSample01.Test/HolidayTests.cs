using System;
using NUnit.Framework;

namespace UnitTestSample01.Test
{
    public class HolidayTests
    {
        [Test]
        public void When_12_25_Should_Return_Merry_XMas()
        {
            var holiday = new FakeHoliday();
            holiday.SetToday(new DateTime(2020, 12, 25));
            Assert.AreEqual("Merry X'Mas", holiday.SayXMas());
        }

        [Test]
        public void When_12_01_Should_Return_Correctly()
        {
            var holiday = new FakeHoliday();
            holiday.SetToday(new DateTime(2020, 12, 01));
            Assert.AreEqual("Very sad, Today is not X'Mas", holiday.SayXMas());
        }
    }
}
