using Athletes.Models;
using CsvHelper.Configuration;
using System.Globalization;

namespace Athletes.Mappings
{
    public sealed class AthleteMap : ClassMap<Athlete>
    {
        public AthleteMap()
        {
            AutoMap(CultureInfo.InvariantCulture);

            Map(m => m.ID);

            Map(m => m.Name);

            Map(m => m.Sex);

            Map(m => m.Age).Convert(args =>
            {
                if (int.TryParse(args.Row.GetField("Age"), out int age))
                {
                    return age;
                }
                return null;
            });

            Map(m => m.Height).Convert(args =>
            {
                if (int.TryParse(args.Row.GetField("Height"), out int height))
                {
                    return height;
                }
                return null;
            });

            Map(m => m.Weight).Convert(args =>
            {
                if (double.TryParse(args.Row.GetField("Weight"), out double weight))
                {
                    return weight;
                }
                return null;
            });

            Map(m => m.Team);
            Map(m => m.NOC);
        }
    }
}