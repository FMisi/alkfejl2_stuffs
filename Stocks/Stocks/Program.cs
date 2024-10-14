using Stocks.Models;
using Stocks.Parsers;

class Program
{
    static void Main(string[] args)
    {
        string path = "stocks.csv";
        IEnumerable<Stock> stocks = StockParser.ParseCsv(path);

        // Lekérdezés: zárási ár átlag két dátum között
        DateTime startDate = new DateTime(2017, 09, 18);
        DateTime endDate = new DateTime(2017, 09, 29);
        decimal avgClosePrice = GetAverageClosePrice(stocks, startDate, endDate);
        Console.WriteLine($"Zárási ár átlag: {avgClosePrice}");

        // Lekérdezés: napok, amikor legalább ennyit esett/nőtt a részvény
        decimal limit = -1.0m;
        var significantDays = GetDaysWithSignificantChange(stocks, limit);
        Console.WriteLine("Napok jelentős változással:");
        foreach (var day in significantDays)
        {
            Console.WriteLine(day);
        }

        // Mozgó átlag lekérdezése
        var closes = stocks.Select(s => s.Close);
        var movingAvg = GetMovingAverage(closes, 3);
        Console.WriteLine("Mozgó átlag:");
        foreach (var avg in movingAvg)
        {
            Console.WriteLine(avg);
        }

        // Legjobb N kereskedési napok lekérdezése
        var bestDays = GetBestTradingDays(stocks, 3);
        Console.WriteLine("Legjobb kereskedési napok:");
        foreach (var day in bestDays)
        {
            Console.WriteLine($"{day.date}: Profit: {day.profit}");
        }
    }

    public static decimal GetAverageClosePrice(IEnumerable<Stock> stocks, DateTime startDate, DateTime endDate)
    {
        return stocks.Where(s => s.Date >= startDate && s.Date <= endDate).Average(s => s.Close);
    }

    public static IEnumerable<DateTime> GetDaysWithSignificantChange(IEnumerable<Stock> stocks, decimal limit)
    {
        return stocks
            .Where(s => (s.Open - s.Close) >= limit || (s.Open - s.Close) <= -limit)
            .Select(s => s.Date);
    }

    public static IEnumerable<decimal> GetMovingAverage(IEnumerable<decimal> numbers, int windowSize)
    {
        return numbers
            .Select((value, index) => new { value, index })
            .Where(x => x.index + windowSize <= numbers.Count())
            .Select(x => numbers.Skip(x.index).Take(windowSize).Average());
    }

    public static IEnumerable<(DateTime date, decimal profit)> GetBestTradingDays(IEnumerable<Stock> stocks, int topN)
    {
        return stocks
            .Select(s => new
            {
                s.Date,
                Profit = s.High - s.Low
            })
            .OrderByDescending(s => s.Profit)
            .Take(topN)
            .Select(s => (s.Date, s.Profit));
    }
}
