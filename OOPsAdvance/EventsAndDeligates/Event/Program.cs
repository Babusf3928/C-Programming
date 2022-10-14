using System;
namespace Event;
class Program
{
    public static void Main(string[] args)
    {
        Events event1 = new Events("Quiz");
        Events event2 = new Events("Debugging");
        Events event3 = new Events("Presentation");
        Events event4 = new Events("Games");


        Events.eventLink += new EventManager(event1.ShowEvent);
        Events.eventLink += new EventManager(event2.ShowEvent);
        Events.eventLink += new EventManager(event3.ShowEvent);
        Events.eventLink += new EventManager(event4.ShowEvent);


        //Events.HandleEvent();

        Events.eventLink -= new EventManager(event3.ShowEvent);

        Events.HandleEvent();
    }
}