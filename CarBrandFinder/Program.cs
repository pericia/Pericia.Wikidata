using Pericia.Wikidata;
using Serilog;
using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace CarBrandFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                                .MinimumLevel.Information()
                                .WriteTo.File("Logs.txt")
                                .CreateLogger();

            int nbBrands = 0;
            foreach (var entity in DataLoader.Load())
            {
                var instanceStatements = entity.FindStatements("P31");

                if (instanceStatements != null && instanceStatements.Any(s => s.MainSnak?.DataValue?.ValueId == "Q17412622")) // this is the "automobile marque" id
                {
                    LocalizedString brandName;
                    if (entity.Labels.TryGetValue("en", out brandName))
                    {
                        Console.WriteLine(brandName.Value);

                        if (++nbBrands >= 5) break;
                    }
                }
            }


        }
    }
}
