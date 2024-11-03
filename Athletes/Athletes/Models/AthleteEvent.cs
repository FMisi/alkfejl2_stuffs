using CsvHelper.Configuration.Attributes;

namespace Athletes.Models
{
    public class AthleteEvent
    {
        [Index(0)]
        public int ID { get; set; }

        [Index(1)]
        public string? Name { get; set; }

        [Index(2)]
        public int? Year { get; set; }

        [Index(3)]
        public string? Season { get; set; }

        [Index(4)]
        public string? City { get; set; }

        [Index(5)]
        public string? Sport { get; set; }

        [Index(6)]
        public string? Event { get; set; }

        [Index(7)]
        public string? Medal { get; set; }
    }
}
