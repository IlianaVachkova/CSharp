using System.Text;

public static class Messages
{
    private static StringBuilder output =
        new StringBuilder();

    public static StringBuilder Ouput
    {
        get
        {
            return output;
        }
    }

    public static void EventAdded()
    {
        output.AppendLine("Event added");
    }

    public static void EventDeleted(int eventsCount)
    {
        if (eventsCount == 0)
        {
            NoEventsFound();
        }
        else
        {
            output.AppendFormat("{0} events deleted", eventsCount);
            output.AppendLine();
        }
    }

    public static void NoEventsFound()
    {
        output.AppendLine("No events found");
    }

    public static void PrintEvent(Event eventToPrint)
    {
        if (eventToPrint != null)
        {
            output.AppendLine(eventToPrint.ToString());
        }
    }
}

