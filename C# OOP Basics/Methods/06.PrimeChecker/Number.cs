public class Number
{
    private string isPrime;

    public Number(int recievedNum)
    {
        this.RecievedNum = recievedNum;
        this.IsPrime = isPrime;
    }

    public int RecievedNum { get; private set; }

    public string IsPrime
    {
        get
        {
            return this.isPrime;
        }
        private set
        {
            value = "true";
            int num = this.RecievedNum;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    value = "false";
                    break;
                }
            }

            this.isPrime = value;
        }
    }

    public int NextPrimeNum()
    {
        int nextPrime = this.RecievedNum;
        bool isPrime = true;

        while (true)
        {
            isPrime = true;
            nextPrime++;
            int num = nextPrime;
            for (int i = 2; i < nextPrime; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime == true)
            {
                break;
            }
        }

        return nextPrime;
    }

    public override string ToString()
    {
        return NextPrimeNum() + ", " + this.IsPrime;
    }
}