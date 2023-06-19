using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Commands.UpdateClientCommand
{
    public class UpdateClientCommand : IRequest<Response<int>>
    {
        public int Id { get; set; }
        private int _age { get; set; }
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

    public class UpdateClientCommandHandler : IRequestHandler<UpdateClientCommand, Response<int>>
    {

        private readonly IRepositoryAsync<Client> _repositoryAsync;
        private readonly IMapper _mapper;

        public UpdateClientCommandHandler(IRepositoryAsync<Client> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(UpdateClientCommand request, CancellationToken cancellationToken)
        {
            var client = await _repositoryAsync.GetByIdAsync(request.Id);

            if (client == null)
            {
                throw new KeyNotFoundException($"Registro no encontrado con el id {request.Id}");
            }
            else
            {
                client.Name = request.Name;
                client.LastName = request.LastName;
                client.BirthDate = request.BirthDate;
                client.PhoneNumber = request.PhoneNumber;
                client.Email = request.Email;
                client.Adress = request.Adress;

                await _repositoryAsync.UpdateAsync(client);

                return new Response<int>(client.Id);
            }
        }
    }
}
