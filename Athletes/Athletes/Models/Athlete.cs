using CsvHelper.Configuration.Attributes;

namespace Athletes.Models
{
    public class Athlete
    {
        [Index(0)]
        public int ID { get; set; }

        [Index(1)]
        public string? Name { get; set; }

        [Index(2)]
        public string? Sex { get; set; }

        [Index(3)]
        public int? Age { get; set; }

        [Index(4)]
        public int? Height { get; set; }

        [Index(5)]
        public double? Weight { get; set; }

        [Index(6)]
        public string? Team { get; set; }

        [Index(7)]
        public string? NOC { get; set; }
    }
}
