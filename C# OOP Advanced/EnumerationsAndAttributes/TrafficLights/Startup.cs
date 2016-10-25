using System;
using System.Linq;

namespace TrafficLights
{
    public class Startup
    {
        public static void Main()
        {
            string[] inputStrArr = Console.ReadLine().Split(' ').ToArray();
            Enum[] inputEnum = new Enum[inputStrArr.Length];

            for (int i = 0; i < inputStrArr.Length; i++)
            {
                inputEnum[i] = (TrafficLightsType)Enum.Parse(typeof(TrafficLightsType), inputStrArr[i]);
            }

            int repetition = int.Parse(Console.ReadLine());

            for (int i = 0; i < repetition; i++)
            {
                for (int j = 0; j < inputEnum.Length; j++)
                {
                    switch ((TrafficLightsType)inputEnum[j])
                    {
                        case TrafficLightsType.Red: inputEnum[j] = TrafficLightsType.Green; break;
                        case TrafficLightsType.Green: inputEnum[j] = TrafficLightsType.Yellow; break;
                        case TrafficLightsType.Yellow: inputEnum[j] = TrafficLightsType.Red; break;
                    }
                }

                Console.WriteLine(string.Join<Enum>(" ", inputEnum));
            }
        }
    }
}
