using System.Text.Json.Serialization;

namespace BCWebApp.Models
{
    public class ClientService
    {
        public int IdClient { get; set; }

        public string? Firstname { get; set; }

        public string? Surname { get; set; }

        public string? Lastname { get; set; }

        public string? Adress { get; set; }

        public string? Number { get; set; }

        public int? Balance { get; set; }

    }
}
