using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using CleanArchitecture.Application.Common.Models;
using MediatR;

namespace CleanArchitecture.Application.Persons.Queries
{
    public class GetPersonsWithPaginationQuery : IRequest<PaginatedList<PersonDto>>
    {
        public IReadOnlyCollection<Guid>? PersonIds { get; init; }
        public int PageNumber { get; init; } = 1;
        public int PageSize { get; init; } = 10;
    }
}