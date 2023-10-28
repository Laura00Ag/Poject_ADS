using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;

class Program
{
    static void Main()
    {
        var path = "path/to/your/file.csv";

        using (var reader = new StreamReader(path))
        using (var csv = new CsvReader(reader))
        {
            csv.Configuration.Delimiter = ",";
            var records = csv.GetRecords<dynamic>().ToList();

            var xValues = records.Select(x => x.PropertyNameX).ToList();
            var yValues = records.Select(y => y.PropertyNameY).ToList();

            // Aquí puedes utilizar los valores de las columnas x y y para realizar tus cálculos estadísticos
        }
    }
}