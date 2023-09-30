using System.Diagnostics;

Stopwatch stopwatch = new Stopwatch();

// Start the stopwatch
stopwatch.Start();

//var ziplist = CsvReader.ReadCsv("C:/github/laurelvecwww/data/ziplatlong.csv");
//var list = CsvReader.ReadCsv("C:/github/laurelvecwww/data/ziplatlong.csv");

var ziplist = CsvReader.ReadCsv("C:/github/laurelwww/data/ziplatLongPlus.csv");
//var list = CsvReader.ReadCsv("C:/github/laurelvecwww/data/ziplatlongPlus.csv");
stopwatch.Stop();

var loc1 = ziplist.Where(z => z.ZipCode == 72722).FirstOrDefault();
var loc2 = ziplist.Where(z => z.ZipCode == 72756).FirstOrDefault();


var dist = GeoCalculator.CalculateDistance(loc1.Lat, loc1.Long, loc2.Lat, loc2.Long);
Console.WriteLine($"{loc1.ZipCode} a: lat {loc1.Lat} {loc1.Long}\nb:{loc2.ZipCode} {loc2.Lat} {loc2.Long}");

Console.WriteLine($"\n\n ziplist count: {ziplist.Count} {dist}");


Console.ReadLine();