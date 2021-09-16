using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventsList
{
    public class GetEventsListQueryHandler : IRequestHandler<GetEventsListQuery, List<EventListVm>>
    {   
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IMapper _mapper;


        public GetEventsListQueryHandler(IMapper mapper, IAsyncRepository<Event> eventRepository)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
        }

        //Ova metoda će se automatski pozvati kada GetEventsListQuery bude trigger-an.
        //Metoda sadrži poslovnu logiku nakon primanja zahtjeva
        public async Task<List<EventListVm>> Handle(GetEventsListQuery request, CancellationToken cancellationToken)
        {
            var allEvents = (await _eventRepository.ListAllAsync()).OrderBy(x => x.Date);
            //mapper se koristi kako se mapiranje podataka ne bi trebalo ručno raditi već automatizmom
            //Ako želimo automatizam, potrebno je kreirati MappingProfile
            return _mapper.Map<List<EventListVm>>(allEvents);
        }
    }
}
