using System.Text;

public class DecimalNumber
{
    public DecimalNumber(decimal number)
    {
        this.Number = number;
    }

    public decimal Number { get; private set; }

    public string DigitsInReversedOrder()
    {
        string numAsStr = this.Number.ToString();
        StringBuilder result = new StringBuilder();

        for (int i = numAsStr.Length - 1; i >= 0; i--)
        {
            result.Append(numAsStr[i]);
        }

        return result.ToString();
    }
}