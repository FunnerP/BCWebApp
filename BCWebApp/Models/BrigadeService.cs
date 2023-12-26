using System.Text.Json.Serialization;

namespace BCWebApp.Models
{
    public class BrigadeService
    {
        public int IdBrigade { get; set; }

        public string? BrigadeName { get; set; }

        public string? BrigadeSpec { get; set; }
    }
}
