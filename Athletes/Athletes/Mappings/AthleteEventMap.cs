using Athletes.Models;
using CsvHelper.Configuration;
using System.Globalization;

namespace Athletes.Mappings
{
    public sealed class AthleteEventMap : ClassMap<AthleteEvent>
    {
        public AthleteEventMap()
        {
            AutoMap(CultureInfo.InvariantCulture);

            Map(m => m.ID);

            Map(m => m.Name);

            Map(m => m.Year).Convert(args =>
            {
                if (int.TryParse(args.Row.GetField("Year"), out int year))
                {
                    return year;
                }
                return null;
            });

            Map(m => m.Season);

            Map(m => m.City);

            Map(m => m.Sport);

            Map(m => m.Event);

            Map(m => m.Medal);
        }
    }
}
