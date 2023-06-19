namespace Application.DTOs
{
    public class ClienteDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Adress { get; set; }

        public int Age { get; set; }
    }
}
