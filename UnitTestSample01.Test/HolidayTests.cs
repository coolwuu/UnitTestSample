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

        internal class FakeHoliday : Holiday
        {
            private DateTime _today;

            internal void SetToday(DateTime today)
            {
                _today = today;
            }
            protected override DateTime GetToday()
            {
                return _today;
            }
        }
    }
}
