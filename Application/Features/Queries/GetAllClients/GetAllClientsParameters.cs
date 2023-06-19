using Application.Parameters;

namespace Application.Features.Queries.GetAllClients
{
    public class GetAllClientsParameters : RequestParameter
    {
        public string ClientName { get; set; }

        public string ClientLastName { get; set; }
    }
}
