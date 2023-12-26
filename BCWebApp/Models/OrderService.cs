using BCWebApp.Components.Pages;
using System.Text.Json.Serialization;

namespace BCWebApp.Models
{
    public class OrderService
    {
        public int IdOrder { get; set; }

        public int? IdClient { get; set; }

        public int? IdBrigade { get; set; }

        public DateTime? Date { get; set; }

        public int? Cost { get; set; }
    }
}
