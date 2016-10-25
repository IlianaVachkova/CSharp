using System.Collections.Generic;

namespace StrategyPattern
{
    public class NameComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int result = x.Name.Length.CompareTo(y.Name.Length);

            if (result == 0)
            {
                char xFirstLetter = x.Name.ToLower()[0];
                char yFirstLetter = y.Name.ToLower()[0];

                result = xFirstLetter.CompareTo(yFirstLetter);
            }

            return result;
        }
    }
}
