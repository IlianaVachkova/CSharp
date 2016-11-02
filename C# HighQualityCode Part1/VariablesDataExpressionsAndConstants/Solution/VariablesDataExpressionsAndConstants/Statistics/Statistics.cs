using System.Text;

namespace Statistics
{
    public class Statistic
    {
        public string PrintStatistics(double[] elements)
        {
            StringBuilder statistics = new StringBuilder();
            statistics.AppendFormat("Min: {0}", MinElement(elements));
            statistics.AppendLine();
            statistics.AppendFormat("Max: {0}", MaxElement(elements));
            statistics.AppendLine();
            statistics.AppendFormat("Average: {0}", AverageValue(elements));

            return statistics.ToString();
        }

        private double MinElement(double[] elements)
        {
            double minElement = double.MaxValue;
            for (int index = 0; index < elements.Length; index++)
            {
                if (elements[index] < minElement)
                {
                    minElement = elements[index];
                }
            }

            return minElement;
        }

        private double MaxElement(double[] elements)
        {
            double maxElement = double.MinValue;
            for (int index = 0; index < elements.Length; index++)
            {
                if (elements[index] > maxElement)
                {
                    maxElement = elements[index];
                }
            }

            return maxElement;
        }

        private double AverageValue(double[] elements)
        {
            double sum = 0;
            int countOfElements = elements.Length;
            for (int index = 0; index < elements.Length; index++)
            {
                sum += elements[index];
            }

            double averageValue = sum / countOfElements;
            return averageValue;
        }
    }
}