using System;

namespace Cook
{
    public class Chef
    {
        public void Cook()
        {
            Bowl bowl = GetBowl();

            Potato potato = GetPotato();
            Peel(potato);
            Cut(potato);
            bowl.Add(potato);

            Carrot carrot = GetCarrot();
            Peel(carrot);
            Cut(carrot);
            bowl.Add(carrot);
        }

        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private void Peel(Vegetable vegetable)
        {
            Console.WriteLine("{0} is peeled.", vegetable.GetType().Name);
        }

        private void Cut(Vegetable vegetable)
        {
            Console.WriteLine("{0} is cut.", vegetable.GetType().Name);
        }
    }
}
