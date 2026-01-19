using System;
using System.Collections.Generic;

namespace CalendarApp.Models
{
    public class CalendarDefinition
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = "Nuevo Calendario";
        public string Color { get; set; } = "#3788d8";
        public bool IsVisible { get; set; } = true;
        public List<CalendarEvent> Events { get; set; } = new();
    }

    public enum RecurrenceType
    {
        None,
        Daily,
        Weekly
    }

    public class CalendarEvent
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string ParentCalendarId { get; set; } = "";
        public string Title { get; set; } = "Nuevo Evento";
        
        public DateTime Start { get; set; } 
        public DateTime End { get; set; }

        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        
        public RecurrenceType Recurrence { get; set; } = RecurrenceType.None;
        public List<DayOfWeek> RecurrenceDays { get; set; } = new();
        
        public Dictionary<DateTime, CalendarEvent?> Exceptions { get; set; } = new();
    }

    public class CalendarMatchResult
    {
        public bool Matches { get; set; }
        public List<CalendarEvent> MatchedEvents { get; set; } = new();
    }
}
