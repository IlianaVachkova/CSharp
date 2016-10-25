public class Number
{
    public Number(int recievedNumber)
    {
        this.RecievedNumber = recievedNumber;
    }

    public int RecievedNumber { get; private set; }

    public string LastDigit()
    {
        int lastDigit = this.RecievedNumber % 10;
        string lastDigitAsStr = string.Empty;
        switch (lastDigit)
        {
            case 0: lastDigitAsStr = "zero"; break;
            case 1: lastDigitAsStr = "one"; break;
            case 2: lastDigitAsStr = "two"; break;
            case 3: lastDigitAsStr = "three"; break;
            case 4: lastDigitAsStr = "four"; break;
            case 5: lastDigitAsStr = "five"; break;
            case 6: lastDigitAsStr = "six"; break;
            case 7: lastDigitAsStr = "seven"; break;
            case 8: lastDigitAsStr = "eight"; break;
            case 9: lastDigitAsStr = "nine"; break;
        }

        return lastDigitAsStr;
    }
}