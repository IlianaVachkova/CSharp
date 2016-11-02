using System;

namespace Cook
{
    public class Bowl
    {
        public void Add(Vegetable vegetable)
        {
            Console.WriteLine("{0} added to the Bowl.", vegetable.GetType().Name);
        }
    }
}
