using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using CsvHelper;

namespace UtilsCSharp.csv
{
    public class CsvHelper<T> : ICsvHelper<T> where T : class, new()
    {
        public byte[] ExportSentimentCsv(IEnumerable<T> data)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var streamWriter = new StreamWriter(memoryStream, Encoding.UTF8))
                {
                    using (var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture))
                    {
                        csvWriter.WriteRecords(data);
                    }
                    return memoryStream.ToArray();
                }
            }
        }
    }
}