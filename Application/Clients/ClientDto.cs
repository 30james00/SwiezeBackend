using System;

namespace Application.Clients
{
    public class ClientDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid? ContactId { get; set; }
    }
}