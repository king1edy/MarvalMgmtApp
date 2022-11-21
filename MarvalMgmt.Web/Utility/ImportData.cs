using CsvHelper;
using MarvalMgmt.Web.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;

namespace MarvalMgmt.Web.Utility
{
    public class ImportData
    {
        public static async Task<IEnumerable<Person>> ReadCsv()
        {
            IEnumerable<Person> records = new List<Person>();
            using (var reader = new StreamReader("~/Data/Person.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = csv.GetRecords<Person>();
            }

            return records;
        }
    }
}