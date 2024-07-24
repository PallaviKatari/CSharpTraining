using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public Event(int eventId, string title, string description, DateTime startTime, DateTime endTime)
        {
            EventId = eventId;
            Title = title;
            Description = description;
            StartTime = startTime;
            EndTime = endTime;
        }
    }

    public class Scheduler
    {
        private List<Event> events; // Passing the Event class - 5 properties

        public Scheduler()
        {
            events = new List<Event>();
        }

        public bool AddEvent(Event newEvent)
        {
            if (CheckOverlap(newEvent.StartTime, newEvent.EndTime))
            {
                Console.WriteLine("Event overlaps with an existing event.");
                return false;
            }

            events.Add(newEvent);
            Console.WriteLine("Event added successfully.");
            return true;
        }

        public bool RemoveEvent(int eventId)
        {
            var eventToRemove = events.FirstOrDefault(e => e.EventId == eventId);
            if (eventToRemove != null)
            {
                events.Remove(eventToRemove);
                Console.WriteLine("Event removed successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Event not found.");
                return false;
            }
        }

        public bool UpdateEvent(int eventId, string title, string description, DateTime startTime, DateTime endTime)
        {
            //events - 2 records currently
            var eventToUpdate = events.FirstOrDefault(e => e.EventId == eventId);
            if (eventToUpdate != null)
            {
                if (CheckOverlap(startTime, endTime, eventId))
                {
                    Console.WriteLine("Event overlaps with an existing event.");
                    return false;
                }

                eventToUpdate.Title = title;
                eventToUpdate.Description = description;
                eventToUpdate.StartTime = startTime;
                eventToUpdate.EndTime = endTime;
                Console.WriteLine("Event updated successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Event not found.");
                return false;
            }
        }

        public List<Event> ListEvents(DateTime date) // return type is a List<Event>
        {
            return events.Where(e => e.StartTime.Date == date.Date).ToList();
        }
        public List<Event> ListEventsId(int id)
        {
            return events.Where(e => e.EventId==id).ToList();
        }

        public List<Event> ListAllEvents()
        {
            return events.ToList();
        }

        private bool CheckOverlap(DateTime newStartTime, DateTime newEndTime, int excludeEventId = -1)
        {
            // events - instance of List<Event>
            return events.Any(e => e.EventId != excludeEventId &&
                                   (newStartTime < e.EndTime && newEndTime > e.StartTime));
            // Lambda expressions
        }
    }

    class ProgramEvent
    {
        static void Main(string[] args)
        {
            Scheduler scheduler = new Scheduler();

            // Adding events
            // Event events=new Event();
            scheduler.AddEvent(new Event(1, "Meeting", "Team meeting", new DateTime(2024, 7, 24, 10, 0, 0), new DateTime(2024, 7, 24, 11, 0, 0)));
            Console.WriteLine("*************************");
            scheduler.AddEvent(new Event(2, "Lunch", "Lunch with client", new DateTime(2024, 7, 24, 12, 0, 0), new DateTime(2024, 7, 24, 13, 0, 0)));
            Console.WriteLine("*************************");
            scheduler.AddEvent(new Event(3, "Project Review", "Meet with client", new DateTime(2024, 7, 24, 12, 0, 0), new DateTime(2024, 7, 24, 13, 0, 0)));
            Console.WriteLine("*************************");
            // Listing events for a specific day
            var events = scheduler.ListEvents(new DateTime(2024, 7, 24)); // 2 records
            foreach (var e in events) // loop thro the 2 records
            {
                Console.WriteLine($"Event ID: {e.EventId}, Title: {e.Title}, Description: {e.Description}, StartTime: {e.StartTime}, EndTime: {e.EndTime}");
            }

            Console.WriteLine("*************************");

            var events1 = scheduler.ListEventsId(1); // 1 record
            foreach (var e in events1)
            {
                Console.WriteLine($"Event ID: {e.EventId}, Title: {e.Title}, Description: {e.Description}, StartTime: {e.StartTime}, EndTime: {e.EndTime}");
            }
            Console.WriteLine("*************************");
            // Updating an event
            scheduler.UpdateEvent(1, "Team Meeting", "Updated team meeting", new DateTime(2024, 7, 24, 10, 30, 0), new DateTime(2024, 7, 24, 11, 30, 0));
            Console.WriteLine("*************************");

            // Removing an event
            scheduler.RemoveEvent(2);
            Console.WriteLine("*************************");

            // Listing events for a specific day
            var events2 = scheduler.ListAllEvents(); // 2 records
            foreach (var e in events2) // loop thro the 2 records
            {
                Console.WriteLine($"Event ID: {e.EventId}, Title: {e.Title}, Description: {e.Description}, StartTime: {e.StartTime}, EndTime: {e.EndTime}");
            }

            Console.ReadLine();
        }
    }
}
