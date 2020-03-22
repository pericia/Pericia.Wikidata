using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;
using System.Text.Json;

namespace Pericia.Wikidata
{
    public static class DataLoader
    {
        public static IEnumerable<Entity> Load()
        {
            var url = "https://dumps.wikimedia.org/wikidatawiki/entities/latest-all.json.gz";
            var request = WebRequest.Create(url);
            var response = request.GetResponse();
            var dump = response.GetResponseStream();

            var gzipStream = new GZipStream(dump, CompressionMode.Decompress, false);

            var reader = new StreamReader(gzipStream);

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (!line.StartsWith("{")) continue;
                if (line.EndsWith(",")) line = line.Substring(0, line.Length - 1);

                Entity? entity = null;
                try
                {
                    entity = JsonSerializer.Deserialize<Entity>(line);
                }
                catch (Exception ex)
                {
                    Log.Error(ex, "Unable to parse line :" + Environment.NewLine + line);
                }

                if (entity != null)
                {
                    yield return entity;
                }
            }
        }
    }
}
