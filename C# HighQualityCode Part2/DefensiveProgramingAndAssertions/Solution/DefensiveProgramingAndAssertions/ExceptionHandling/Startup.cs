using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (arr == null)
        {
            throw new ArgumentNullException(
                "Array cannot be null!");
        }

        if (startIndex < 0 || startIndex >= arr.Length)
        {
            throw new IndexOutOfRangeException(
                "Start index cannot be negative or greater than the array length!");
        }

        if (count < 0 || count > arr.Length - startIndex)
        {
            throw new ArgumentOutOfRangeException(
                "Count cannot be negative or outside the boudries of the array!");
        }

        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }
        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (str == null)
        {
            throw new ArgumentNullException(
                "Cannot extract from null!");
        }

        if (count < 0 || count > str.Length)
        {
            throw new ArgumentOutOfRangeException(
                "Count cannot be negative or greater than the string length!");
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }
        return result.ToString();
    }

    public static void CheckPrime(int number)
    {
        if (number <= 0)
        {
            Console.WriteLine("The number is not prime!");
            return;
        }

        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                Console.WriteLine("The number is not prime!");
                break;
            }
        }
    }

    static void Main()
    {
        try
        {
            var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(String.Join(" ", subarr));

            var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(String.Join(" ", allarr));

            var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(String.Join(" ", emptyarr));

            int[] arr = null;
            emptyarr = Subsequence(arr, 0, 0);
            Console.WriteLine(String.Join(" ", emptyarr));
        }
        catch (ArgumentNullException ane)
        {
            Console.WriteLine(ane.Message);
        }
        catch (IndexOutOfRangeException ior)
        {
            Console.WriteLine(ior.Message);
        }
        catch (ArgumentOutOfRangeException aor)
        {
            Console.WriteLine(aor.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            Console.WriteLine(ExtractEnding("I love C#", 2));
            Console.WriteLine(ExtractEnding("Nakov", 4));
            Console.WriteLine(ExtractEnding("beer", 4));
            Console.WriteLine(ExtractEnding("Hi", 100));
            Console.WriteLine(ExtractEnding(null, 100));
        }
        catch (ArgumentNullException ane)
        {
            Console.WriteLine(ane.Message);
        }
        catch (ArgumentOutOfRangeException aor)
        {
            Console.WriteLine(aor.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            CheckPrime(23);
            CheckPrime(33);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            List<Exam> peterExams = new List<Exam>()
                {
                new SimpleMathExam(2),
                new CSharpExam(55),
                new CSharpExam(100),
                new SimpleMathExam(1),
                new CSharpExam(0),
                };
            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
        catch (ArgumentNullException ane)
        {
            Console.WriteLine(ane.Message);
        }
        catch (ArgumentOutOfRangeException aor)
        {
            Console.WriteLine(aor.Message);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
