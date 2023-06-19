using Application.DTOs;
using Application.Interfaces;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Queries.GetAllClients
{
    public class GetAllClientsQuery : IRequest<List<ClienteDto>>
    {
        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public class GetAllClientsQueryHandler : IRequestHandler<GetAllClientsQuery, PagedResponse<List<ClienteDto>>>
        {
            private readonly IRepositoryAsync<Client> _repositoryAsync;
            private readonly IMapper _mapper;

            public async Task<PagedResponse<List<ClienteDto>>> Handle(GetAllClientsQuery request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }

        }
    }
}
