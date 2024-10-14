using CsvHelper.Configuration;
using CsvHelper;
using System.Globalization;
using Stocks.Models;

namespace Stocks.Parsers
{
    

    public class StockMap : ClassMap<Stock>
    {
        public StockMap()
        {
            Map(m => m.Date).Name("DateTime");
            Map(m => m.Open);
            Map(m => m.High);
            Map(m => m.Low);
            Map(m => m.Close);
            Map(m => m.Volume);
        }
    }

    public class StockParser
    {
        public static IEnumerable<Stock> ParseCsv(string pathToFile)
        {
            using (var reader = new StreamReader(pathToFile))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                Delimiter = ","
            }))
            {
                csv.Context.RegisterClassMap<StockMap>(); // Regisztráljuk a mappinget
                return csv.GetRecords<Stock>().ToList();
            }
        }
    }
}