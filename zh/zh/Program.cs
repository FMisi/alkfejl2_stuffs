using CsvHelper.Configuration;
using CsvHelper;
using System.Globalization;
using System.Text;
using zh;

class Program
{
    public static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Environment.Exit(1);
        }

        var playerData = LoadDataset(args[0]);

        /* foreach (var item in playerData)
         {
             Console.WriteLine(item.Name);
         }*/

        var task3 = playerData
            .GroupBy(x => x.Nationality)
            .Select(x => new
            {
                Nationality = x.Key,
                Average =x.Average(x => x.ValueEUR)
            })
            .OrderByDescending(x => x.Average);

        /* foreach (var item in task3)
         {
             Console.WriteLine(item);
         }*/

        var task4 = playerData
            .Where(x => x.BestPosition == "CF" && x.Age > 30)
            .OrderBy(x => x.Name)
            .Select(x => x.Name);

        /* foreach (var item in task4)
        {
            Console.WriteLine(item);
        }*/

        var task5 = playerData
            .Where(x => x.Overall >= 50 && x.Overall <= 55 && x.Age >= 26 && x.Age <= 29)
            .Select(x => x.Name);

        /* foreach (var item in task5)
        {
            Console.WriteLine(item);
        }*/

        var task6 = playerData
            .GroupBy(x => x.Club)
            .Select(x => new
            {
                Club = x.Key,
                Average = x.Average(x => x.Overall)
            });

        /* foreach (var item in task6)
       {
           Console.WriteLine(item);
       }*/
    }

    public static IEnumerable<Players> LoadDataset(string path)
    {
        if (!File.Exists(path))
        {
            Environment.Exit(1);
        }

        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Encoding = Encoding.UTF8,
            Delimiter = ";",
            MissingFieldFound = (context) => { },
            BadDataFound = (context) => { }
        };

        using var reader = new StreamReader(path);
        using var csvReader = new CsvReader(reader, config);

        csvReader.Read();
        csvReader.ReadHeader();

        var records = new List<Players>();

        while (csvReader.Read())
        {
           
            var player = new Players
            {
                ID = csvReader.GetField<int>("ID"),
                Name = csvReader.GetField<string>("Name"),
                FullName = csvReader.GetField<string>("FullName"),
                Age = csvReader.GetField<int>("Age"),
                Nationality = csvReader.GetField<string>("Nationality"),
                Overall = csvReader.GetField<int>("Overall"),
                BestPosition = csvReader.GetField<string>("BestPosition"),
                Club = csvReader.GetField<string>("Club"),
                ValueEUR = csvReader.GetField<int>("ValueEUR")
            };
            records.Add(player);
        }
        return records;
    }
}
