using System.Collections.Generic;

public class ImmutableList
{
    public List<int> collection;

    public ImmutableList(List<int> collection = null)
    {
        if (collection == null)
        {
            this.collection = new List<int>();
        }
        else
        {
            this.collection = collection;
        }
    }

    public ImmutableList GetImmutableLIst()
    {
        List<int> newCollection = new List<int>(this.collection);
        ImmutableList newImmutable = new ImmutableList(newCollection);
        return newImmutable;
    }
}