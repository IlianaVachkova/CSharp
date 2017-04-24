public class Connection
{
    public Node Node { get; set; }
    public int Distance { get; set; }

    public Connection(Node node, int distance)
    {
        this.Node = node;
        this.Distance = distance;
    }
}