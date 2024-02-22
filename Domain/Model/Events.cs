using System;
namespace Domain.Model
{
	public class Events
	{
        public Guid Id { get; set; }

        public string EventsName { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }
    }
}

