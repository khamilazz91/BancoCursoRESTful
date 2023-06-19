using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Commands.CreateClientCommand
{
    public class CreateClientCommand : IRequest<Response<int>>
    {
        private int _age;
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public int Age
        {
            get
            {
                if (this._age <= 0)
                {
                    this._age = new DateTime(DateTime.Now.Subtract(this.BirthDate).Ticks).Year - 1;
                }

                return this._age;
            }
        }
    }

    public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, Response<int>>
    {

        private readonly IRepositoryAsync<Client> _repositoryAsync;
        private readonly IMapper _mapper;

        public CreateClientCommandHandler(IRepositoryAsync<Client> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {

            var newRecord = _mapper.Map<Client>(request);
            var data = await _repositoryAsync.AddAsync(newRecord);

            return new Response<int>(data.Id);
        }
    }
}
