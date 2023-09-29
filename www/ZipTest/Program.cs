using System.Diagnostics;
using ZipLib;
Stopwatch stopwatch = new Stopwatch();

// Start the stopwatch
stopwatch.Start();

var ziplist = CsvReader.ReadCsv("C:/github/laurelvec_site/data/ziplatlong.csv");
var list = CsvReader.ReadCsv("C:/github/laurelvec_site/data/ziplatlong.csv");
stopwatch.Stop();

var loc1 = ziplist.Where(z => z.ZipCode == 72764).FirstOrDefault();
var loc2 = ziplist.Where(z => z.ZipCode == 72722).FirstOrDefault();

var dist = GeoCalculator.CalculateDistance(loc1.Lat, loc1.Long, loc2.Lat, loc2.Long);
Console.WriteLine($"a: la {loc1.Lat}/{loc1.Long}  b: {loc2.Lat}/{loc2.Long}");
Console.WriteLine($"ziplist count: {ziplist.Count} {dist}");


Console.ReadLine();