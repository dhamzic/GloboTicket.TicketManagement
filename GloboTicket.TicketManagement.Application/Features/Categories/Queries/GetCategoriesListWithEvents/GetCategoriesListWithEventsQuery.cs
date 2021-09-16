using MediatR;
using System.Collections.Generic;

namespace GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents
{
    public class GetCategoriesListWithEventsQuery: IRequest<List<CategoryEventListVm>>
    {
        /// <summary>
        /// Želimo li sve evente (nadolazeće i prošle) ili samo nadolazeće
        /// </summary>
        public bool IncludeHistory { get; set; }
    }
}
