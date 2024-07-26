using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    internal class EventsTask
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Special method - same name as the class name
        /// automatically called when we create an instance for the class and pass the values
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        public EventsTask(int eventId, string title, string description, DateTime startTime, DateTime endTime)
        {
            EventId = eventId;
            Title = title;
            Description = description;
            StartTime = startTime;
            EndTime = endTime;
        }
    }

    internal class Scheduler1
    {
        private List<EventsTask> events; // 3 details
        public Scheduler1()
        {
            events = new List<EventsTask>(); // Add,Remove,InsertAt
        }
        public bool AddEvent(EventsTask newEvent) //3 details
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
        public List<EventsTask> ListAllEvents()
        {
            return events.ToList();
        }
        public List<EventsTask> ListEvents(DateTime date) // return type is a List<Event>
        {
            return events.Where(e => e.StartTime.Date == date.Date).ToList(); // applying a condition 'Where clause' using lambda expression
        }

        public bool UpdateEvent(int eventId, string title, string description, DateTime startTime, DateTime endTime)
        {
            //events - 2 records currently
            var eventToUpdate = events.FirstOrDefault(e => e.EventId == eventId); //1
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

        private bool CheckOverlap(DateTime newStartTime, DateTime newEndTime, int excludeEventId = -1)
        {
            // events - instance of List<Event>
            return events.Any(e => e.EventId != excludeEventId &&
                                   (newStartTime < e.EndTime && newEndTime > e.StartTime));
            // Lambda expressions
        }

    }
    internal class EventSchedulerDemo
    {
        static void Main(string[] args)
        {
            Scheduler1 scheduler = new Scheduler1();

            scheduler.AddEvent(new EventsTask(1, "Meeting", "Team meeting", new DateTime(2024, 7, 24, 10, 0, 0), new DateTime(2024, 7, 24, 11, 0, 0)));
            Console.WriteLine("*************************");
            scheduler.AddEvent(new EventsTask(2, "Lunch", "Lunch with client", new DateTime(2024, 7, 24, 10, 0, 0), new DateTime(2024, 7, 24, 11, 0, 0)));
            Console.WriteLine("*************************");
            scheduler.AddEvent(new EventsTask(3, "Project Review", "Meet with client", new DateTime(2024, 7, 25, 16, 0, 0), new DateTime(2024, 7, 30, 13, 0, 0)));
            Console.WriteLine("*************************");

            var events = scheduler.ListAllEvents(); // 3 records
            foreach (var e in events) // loop thro the 3 records
            {
                Console.WriteLine($"Event ID: {e.EventId}, Title: {e.Title}, Description: {e.Description}, StartTime: {e.StartTime}, EndTime: {e.EndTime}");
            }
            Console.WriteLine("*************************");

            var events1 = scheduler.ListEvents(new DateTime(2024, 7, 24)); // 3 records (year,month,day)
            foreach (var e in events1) // loop thro the 3 records
            {
                Console.WriteLine($"Event ID: {e.EventId}, Title: {e.Title}, Description: {e.Description}, StartTime: {e.StartTime}, EndTime: {e.EndTime}");
            }

            Console.WriteLine("*************************");
            // Updating an event
            scheduler.UpdateEvent(1, "Team Meeting", "Updated team meeting", new DateTime(2024, 7, 24, 10, 30, 0), new DateTime(2024, 7, 24, 11, 30, 0));
            Console.WriteLine("*************************");
            scheduler.UpdateEvent(4, "Team Meeting", "Updated team meeting", new DateTime(2024, 7, 24, 10, 30, 0), new DateTime(2024, 7, 24, 11, 30, 0));
            Console.WriteLine("*************************");

            //Removing an event
            scheduler.RemoveEvent(1);
            Console.WriteLine("*************************");

            var events2 = scheduler.ListAllEvents(); // 2 records
            foreach (var e in events2) // loop thro the 2 records
            {
                Console.WriteLine($"Event ID: {e.EventId}, Title: {e.Title}, Description: {e.Description}, StartTime: {e.StartTime}, EndTime: {e.EndTime}");
            }
            Console.ReadLine();


        }
    }
}
