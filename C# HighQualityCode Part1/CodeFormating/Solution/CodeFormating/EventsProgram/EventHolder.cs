using System;
using Wintellect.PowerCollections;

public class EventHolder
{
    private MultiDictionary<string, Event> byTitle =
        new MultiDictionary<string, Event>(true);
    private OrderedBag<Event> byDate =
        new OrderedBag<Event>();

    public void AddEvent(
        DateTime date, string title, string location)
    {
        Event newEvent = new Event(
            date, title, location);

        byTitle.Add(title.ToLower(), newEvent);
        byDate.Add(newEvent);

        Messages.EventAdded();
    }

    public void DeleteEvents(string titleToDelete)
    {
        string title = titleToDelete.ToLower();
        int removed = 0;

        foreach (var eventToRemove in byTitle[title])
        {
            removed++;
            byDate.Remove(eventToRemove);
        }

        byTitle.Remove(title);
        Messages.EventDeleted(removed);
    }

    public void ListEvents(DateTime date, int count)
    {
        OrderedBag<Event>.View eventsToShow =
            byDate.RangeFrom(
            new Event(date, string.Empty, string.Empty), true);
        int shown = 0;

        foreach (var eventToShow in eventsToShow)
        {
            if (shown == count)
            {
                break;
            }

            Messages.PrintEvent(eventToShow);
            shown++;
        }

        if (shown == 0)
        {
            Messages.NoEventsFound();
        }
    }
}
