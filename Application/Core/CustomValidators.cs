using System;

namespace Application.Core
{
    public class Validators
    {
        public static bool FutureDate(DateTime date)
        {
            return date > DateTime.Now;
        }
    }
}