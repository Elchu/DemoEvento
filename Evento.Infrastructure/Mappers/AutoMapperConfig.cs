using AutoMapper;
using Evento.Core.Domain;
using Evento.Infrastructure.DTO;
using System.Linq;

namespace Evento.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {
                //mapujemy pola z Event do EventDto
                cfg.CreateMap<Event, EventDto>()
                //klasa EventDto posiada pole TicketsCount, ktorego nie ma w Event dlatego musimy to recznie zmapowac i ustawic obliczenia
                .ForMember(x => x.TicketsCount, m => m.MapFrom(p => p.Tickets.Count())); 
            })
            .CreateMapper();
    }
}