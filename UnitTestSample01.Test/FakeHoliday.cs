using System;

namespace UnitTestSample01.Test
{
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