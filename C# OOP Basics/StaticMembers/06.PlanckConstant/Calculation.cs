public class Calculation
{
    static double PLANK_CONST = 6.62606896e-34;
    static double PI = 3.14159;

    public static double reducedPlankConst()
    {
        return PLANK_CONST / (2 * PI);
    }
}