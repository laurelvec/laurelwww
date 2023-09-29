using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;
using ZipLib; // For TextFieldParser

public class CsvReader
{
    public static List<ZipModel> ReadCsv(string path)
    {
        var records = new List<ZipModel>();

        using (TextFieldParser parser = new TextFieldParser(path))
        {
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");

            // Skip header if needed
            if (!parser.EndOfData)
                parser.ReadLine();

            while (!parser.EndOfData)
            {
                string[] fields = parser.ReadFields();
                if (fields != null && fields.Length >= 3)
                {
                    if (int.TryParse(fields[0], out int zip) &&
                        double.TryParse(fields[1], out double lat) &&
                        double.TryParse(fields[2], out double lon))
                    {
                        records.Add(new ZipModel { ZipCode = zip, Lat = lat, Long = lon });
                    }
                    else
                    {
                        Console.WriteLine($"Skipping invalid record: {string.Join(",", fields)}");
                    }
                }
            }
        }

        return records;
    }
}

class Program
{
    static void Main(string[] args)
    {
        string csvFilePath = "path_to_your_csv_file.csv";

        List<ZipModel> records = CsvReader.ReadCsv(csvFilePath);

        foreach (var record in records)
        {
            Console.WriteLine($"Zip: {record.ZipCode}, Lat: {record.Lat}, Long: {record.Long}");
        }
    }
}
