﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Evento.Core.Domain;
using Evento.Infrastructure.DTO;

namespace Evento.Infrastructure.Services
{
    public interface IEventService
    {
        Task<EventDto> GetAsync(Guid id);
        Task<EventDto> GetAsync(string name);
        Task<IEnumerable<EventDto>> BrowseAsync(string name = null);
        Task CreateAsync(Guid id, string name, string description, DateTime startDate, DateTime endDate);
        Task AddTicketsAsync(Guid eventId, int amount, decimal price);
        Task UpdatedAsync(Guid id, string name, string description);
        Task DeleteAsync(Guid id);

    }
}