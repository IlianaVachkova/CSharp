public class MathUtil
{
    public static double Sum(double firstNum, double secondNum)
    {
        return firstNum + secondNum;
    }

    public static double Subtract(double firstNum, double secondNum)
    {
        return firstNum - secondNum;
    }

    public static double Multiply(double firstNum, double secondNum)
    {
        return firstNum * secondNum;
    }

    public static double Divide(double divident, double divisor)
    {
        return divident / divisor;
    }

    public static double Percentage(double totalNum, double percentOfNum)
    {
        return (percentOfNum / 100) * totalNum;
    }
}