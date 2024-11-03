using CsvHelper;
using System.Globalization;
using Athletes.Models;
using Athletes.Mappings;
using static System.Formats.Asn1.AsnWriter;

public class Program
{
    private static List<Athlete> athletes = new List<Athlete>();
    private static List<AthleteEvent> athleteevents = new List<AthleteEvent>();
    private static string? outputDirectory1;
    private static string? outputDirectory2;

    private static int Main(string[] args)
    {
        // Ha a CSV fajlt nem talalja a szamitogep, akkor automatikusan a futasi konyvtarban keresse...
        string csvFilePath1 = args.Length > 0 && File.Exists(args[0]) ? args[0] : Path.Combine(AppContext.BaseDirectory, "athletes.csv");
        outputDirectory1 = Path.GetDirectoryName(csvFilePath1) ?? AppContext.BaseDirectory;

        Console.WriteLine("outputDirectory1: " + outputDirectory1);

        // ...es ha ott sem talalja, akkor dobjon errol egy errort!
        if (!File.Exists(csvFilePath1))
        {
            Console.WriteLine("Error: File not found: " + csvFilePath1);

            string baseDirectory = AppContext.BaseDirectory;
            Console.WriteLine("Program alapértelmezett könyvtára: " + baseDirectory);
            return -1;
        }

        string csvFilePath2 = args.Length > 0 && File.Exists(args[1]) ? args[1] : Path.Combine(AppContext.BaseDirectory, "athlete_events.csv");
        outputDirectory2 = Path.GetDirectoryName(csvFilePath2) ?? AppContext.BaseDirectory;

        Console.WriteLine("outputDirectory2: " + outputDirectory2);

        
        if (!File.Exists(csvFilePath2))
        {
            Console.WriteLine("Error: File not found: " + csvFilePath2);

            string baseDirectory = AppContext.BaseDirectory;
            Console.WriteLine("Program alapértelmezett könyvtára: " + baseDirectory);
            return -1;
        }

        // Beolvasas CSV-bol
        using (var reader = new StreamReader(csvFilePath1))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            // Regisztraljuk a mappolast
            csv.Context.RegisterClassMap<AthleteMap>();
            athletes = csv.GetRecords<Athlete>().ToList();
        }

        using (var reader = new StreamReader(csvFilePath2))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            // Regisztraljuk a mappolast
            csv.Context.RegisterClassMap<AthleteEventMap>();

            athleteevents = csv.GetRecords<AthleteEvent>().ToList();
        }

        Console.WriteLine("CSV files loaded successfully. Enter commands (type 'stop' to exit).");

        // Felhasznaloi parancsok fogadasa
        string? command;
        while (true)
        {
            command = Console.ReadLine();

            // Ellenorizzuk, hogy a bemenet nem null es nem ures
            if (!string.IsNullOrEmpty(command))
            {
                if (command == "stop")
                    break; // Kilepunk a ciklusbol
                ProcessCommand(command);
            }
            else
            {
                Console.WriteLine("Error: Command cannot be null or empty.");
            }
        }

        Console.WriteLine("Program terminated.");
        return 0;
    }

    private static void ProcessCommand(string command)
    {
        var parts = command.Split(' ');

        switch (parts[0])
        {
            case "team":
                if (parts.Length == 2)
                    CountTeamMembers(parts[1]);
                else
                    Console.WriteLine("Invalid command format.");
                break;

            case "count":
                if (parts.Length == 4 && int.TryParse(parts[2], out int min) && int.TryParse(parts[3], out int max))
                    CountAthletesByRange(parts[1], min, max);
                else
                    Console.WriteLine("Invalid command format.");
                break;

            case "average":
                if (parts.Length == 3)
                    CalculateTeamAverage(parts[1], parts[2]);
                else
                    Console.WriteLine("Invalid command format.");
                break;
            case "medal":
                if (parts.Length == 2)
                    Ermek(parts[1]);
                else
                    Console.WriteLine("Invalid command format.");
                break;
            case "nomedal":
                if (parts.Length == 2)
                    Evszamok(Int32.Parse(parts[1]));
                else
                    Console.WriteLine("Invalid command format.");
                break;

            default:
                Console.WriteLine("Unknown command.");
                break;
        }
    }

    private static void CountTeamMembers(string team)
    {
        if (athletes == null)
        {
            Console.WriteLine("Error: Athlete list is null.");
            return;
        }

        var result = athletes.Where(a => a.Team == team).ToList();

        var count = athletes.Count(a => a.Team == team);
        Console.WriteLine($"Team {team} has {count} members.");

        // CSV fajlba iras
        var resultRecord = new List<dynamic> {
            new { Team = team, Count = count }
        };

        string fileName = $"team-{team}.csv";
        WriteResultsToCsv(outputDirectory1, fileName, resultRecord);
    }

    private static void CountAthletesByRange(string property, int min, int max)
    {
        if (athletes == null)
        {
            Console.WriteLine("Error: Athlete list is null.");
            return;
        }

        var count = athletes.Count(a =>
        {
            switch (property.ToLower())
            {
                case "age": return a.Age.HasValue && a.Age.Value >= min && a.Age.Value <= max;
                case "height": return a.Height.HasValue && a.Height.Value >= min && a.Height.Value <= max;
                case "weight": return a.Weight.HasValue && a.Weight.Value >= min && a.Weight.Value <= max;
                default: return false;
            }
        });

        Console.WriteLine($"{count} athletes found in range {min} to {max} for {property}.");

        // CSV fajlba iras
        var resultRecord = new List<dynamic> {
            new { Count = count }
        };

        string fileName = $"count-{property}-{min}-{max}.csv";
        WriteResultsToCsv(outputDirectory1, fileName, resultRecord);
    }


    private static void CalculateTeamAverage(string team, string property)
    {
        if (athletes == null)
        {
            Console.WriteLine("Error: Athlete list is null.");
            return;
        }

        var result = athletes.Where(a => a.Team == team);
        double? average = null;

        switch (property.ToLower())
        {
            case "age":
                average = result.Average(a => a.Age);
                break;
            case "height":
                average = result.Average(a => a.Height);
                break;
            case "weight":
                average = result.Average(a => a.Weight);
                break;
        }

        if (average.HasValue)
            // :F2 == ketto tizedesjegyre kerekitse
            Console.WriteLine($"The average {property} for team {team} is {average.Value:F2}.");
        else
            Console.WriteLine($"No valid data for calculating average {property} for team {team}.");

        // CSV fajlba iras
        var averageRecord = new List<dynamic> {
            new { Property = property, Team = team, Average = average?.ToString("F2") ?? "NULL" }
        };

        string fileName = $"average-{team}-{property}.csv";
        WriteResultsToCsv(outputDirectory1, fileName, averageRecord);
    }

    // 4. feladat
    private static object Ermek(string p)
    {
        var athleteEventData = athleteevents
            .Where(x => x.Medal.Equals(p))
            .OrderByDescending(x => x.Medal.Count())
            .Select(x => new { x.Name, x.Medal.Length });

        foreach (var item in athleteEventData)
        {
            Console.WriteLine(item);
        }

        return athleteEventData.Take(5);
    }

    // 5. feladat
    private static object Evszamok(int p)
    {
        var athleteEventData = athleteevents
            .Where(x => x.Year >= p)
            .Where(x => x.Medal.Equals("NA"))
            .OrderByDescending(x => x.Year)
            .Select(x => new { x.Year});

        foreach (var item in athleteEventData)
        {
            Console.WriteLine(item);
        }

        return athleteEventData.Take(5);
    }

    // Rekord irasa CSV-be
    private static void WriteResultsToCsv<T>(string? outputDirectory, string fileName, List<T> records)
    {
        // Ellenorizzuk, hogy az outputDirectory valtozo ervenyes-e.
        // Van-e erteke es ha igen, nem-e null
        if (string.IsNullOrEmpty(outputDirectory))
        {
            Console.WriteLine("Error: Output directory is not valid.");
            return;
        }

        string outputFilePath = Path.Combine(outputDirectory, fileName);

        // Ellenorizzuk, hogy a nem null es nem ures erteku outputDirectory valtozoban tarolt konyvtar letezik-e.
        // Ha nem, letrehozzuk
        if (!Directory.Exists(outputDirectory))
        {
            try
            {
                Directory.CreateDirectory(outputDirectory);
                Console.WriteLine($"Directory created: {outputDirectory}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating directory: {ex.Message}");
                return; // Kilepunk, ha a konyvtar letrehozasa nem sikerult
            }
        }

        // Ellenorizzuk, hogy van-e mit irni a CSV fajlba
        if (records == null || records.Count == 0)
        {
            Console.WriteLine("Warning: No records to write to CSV.");
            return; // Kilepunk, ha nincs adat
        }

        // Kiiras a CSV fajlba
        try
        {
            using (var writer = new StreamWriter(outputFilePath))
            using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvWriter.WriteRecords(records);
                Console.WriteLine($"Result written: {outputFilePath}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error writing to CSV: {ex.Message}");
        }
    }

    

}
