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
    }
}
