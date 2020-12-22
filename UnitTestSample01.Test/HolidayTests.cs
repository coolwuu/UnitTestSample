using System;
using NUnit.Framework;

namespace UnitTestSample01.Test
{
    public class HolidayTests
    {
        [Test]
        public void IsTodayXMas()
        {
            var holiday = new Holiday();
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
