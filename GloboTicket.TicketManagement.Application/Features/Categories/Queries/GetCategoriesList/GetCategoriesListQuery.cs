using MediatR;
using System.Collections.Generic;

namespace GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList
{
    /// <summary>
    /// Vraća sve kategorije
    /// </summary>
    public class GetCategoriesListQuery : IRequest<List<CategoryListVm>>
    {
    }
}
