using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Application.Common.Mappings;
using CleanArchitecture.Application.Common.Models;
using Domain.Entities;
using MediatR;

namespace CleanArchitecture.Application.Persons.Queries
{
    public class GetPersonsWithPaginationQueryHandler : IRequestHandler<GetPersonsWithPaginationQuery, PaginatedList<PersonDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetPersonsWithPaginationQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PaginatedList<PersonDto>> Handle(GetPersonsWithPaginationQuery request, CancellationToken cancellationToken)
        {
            return await _context.Persons
                .Where(x => request.PersonIds == null || request.PersonIds.Contains(x.PersonId))
                .OrderBy(x => x.PersonId)
                .ProjectTo<PersonDto>(_mapper.ConfigurationProvider)
                .PaginatedListAsync(request.PageNumber, request.PageSize);
        }
    }
}