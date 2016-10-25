using System.Collections.Generic;

public class Fibonacci
{
    private List<ulong> members;

    public Fibonacci()
    {
        this.members = new List<ulong>();
    }

    public List<ulong> GenerateFibNums(int endPos)
    {
        this.members.Add(0);
        ulong firstMem = 1;
        this.members.Add(firstMem);
        ulong secondMem = 1;
        this.members.Add(secondMem);
        ulong thirdMem = 0;
        for (int i = 0; i <= endPos; i++)
        {
            thirdMem = firstMem + secondMem;
            firstMem = secondMem;
            secondMem = thirdMem;

            this.members.Add(thirdMem);
        }

        return this.members;
    }

    public List<ulong> GetNumbersInRange(int startPosition, int endPosition)
    {
        List<ulong> result = new List<ulong>();
        for (int i = startPosition; i < endPosition; i++)
        {
            result.Add(this.members[i]);
        }

        return result;
    }
}