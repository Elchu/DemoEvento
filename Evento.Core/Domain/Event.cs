using System;
using System.Collections.Generic;

namespace Evento.Core.Domain
{
    //todo skonczone na 3.6
    public class Event : Entity
    {
        private ISet<Ticket> _tickets = new HashSet<Ticket>();

        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime StartDate { get; protected set; }
        public DateTime EndDate { get; protected set; }
        public DateTime UpdatedDate { get; protected set; }

        public IEnumerable<Ticket> Tickets => _tickets;

        protected Event() { }

        public Event(Guid id, string name, string description, DateTime startDate, DateTime endDate)
        {
            Id = id;
            Name = name;
            Description = description;
            CreatedAt = DateTime.UtcNow;
            StartDate = startDate;
            EndDate = endDate;
            UpdatedDate = DateTime.UtcNow;
        }

        public void AddTickets(int amount, decimal price)
        {
            var seating = _tickets.Count + 1;
            for (int i = 0; i < amount; i++)
            {
                _tickets.Add(new Ticket(this, seating, price));
                seating++;
            }
        }

    }
}