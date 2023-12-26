using System.Text.Json.Serialization;

namespace BCWebApp.Models
{
    public class WorkerService
    {
        public int IdWorker { get; set; }
        public int? IdBrigade { get; set; }
        public string? Firstname { get; set; }
        public string? Surname { get; set; }
        public string? Lastname { get; set; }
        public string? Post { get; set; }
        public string? Adress { get; set; }
        public string? Number { get; set; }
    }
}
