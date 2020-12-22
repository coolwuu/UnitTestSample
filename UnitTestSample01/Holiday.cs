using System;

namespace UnitTestSample01
{
    public class Holiday
    {
        public string SayXMas()
        {
            var today = GetToday();
            if (today.Month == 12 && today.Day == 25)
            {
                return "Merry X'Mas";
            }
            return "Very sad, Today is not X'Mas";
        }

        protected virtual DateTime GetToday()
        {
            return DateTime.Today;
        }
    }
}
