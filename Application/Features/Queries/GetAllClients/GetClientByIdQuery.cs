using Application.DTOs;
using Application.Wrappers;
//using Azure;
using MediatR;

namespace Application.Features.Queries.Get
{
    public class GetClientByIdQuery : IRequest<Response<ClienteDto>>
    {
        public int Id { get; set; }
        //public class GetClientByIdQueryHandler : IRequestHandler<GetClientByIdQuery>, Response<ClienteDto>>
        //{
        //    private readonly IRepositoryAsync<Client> _repositoryAsync;
        //    private readonly IMapper _mapper;

        //    public GetClientByIdQueryHandler(IRepositoryAsync<Client> repositoryAsync, IMapper mapper)
        //    {
        //        _repositoryAsync = repositoryAsync;
        //        _mapper = mapper;
        //    }

        //    public async Task<Response<ClienteDto>> Handle(GetClientByIdQuery request, CancellationToken cancellationToken)
        //    {

        //        var client = await _repositoryAsync.GetByIdAsync(request.Id);
        //        if (client == null)
        //        {
        //            throw new KeyNotFoundException($"Registro no encontrado con el id {request.Id}");
        //        }
        //        else
        //        {
        //            var dto = _mapper.Map<ClienteDto>(client);
        //            return new Response<ClienteDto>(dto);
        //        }
        //    }

        //    Task<Unit> IRequestHandler<GetClientByIdQuery, Unit>.Handle(GetClientByIdQuery request, CancellationToken cancellationToken)
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }
}
