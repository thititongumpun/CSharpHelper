using CsvHelper;
using Microsoft.VisualBasic.FileIO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using Z.BulkOperations;

namespace Worker.BulkInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            //string csv_file_path = @"D:\Helper\CSharpHelper\Worker.BulkInsert\Data\Sentiment-Data.csv";
            //var csv = GetCSV(csv_file_path);
            //Console.WriteLine("Rows count:" + csv.Rows.Count);


            //InsertDataToDatabase(csv);
            //Console.WriteLine("Done");
            var q = QueryTable();

            List<SentimentInfo> sentiments = new List<SentimentInfo>();
            sentiments = ConvertDataTable<SentimentInfo>(q);

            string filePath = @"D:\Helper\CSharpHelper\Worker.BulkInsert\Data\Sentiment-Data555.csv";


            using (var memoryStream = new MemoryStream())
            using (var writer = new StreamWriter(new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite), Encoding.UTF8))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(sentiments);
            }
        }

        private static DataTable GetDataTableFromCSVFile(string path)
        {
            DataTable dt = new DataTable();
            try
            {
                using TextFieldParser csvReader = new TextFieldParser(path);
                csvReader.SetDelimiters(new string[] { "," });
                csvReader.HasFieldsEnclosedInQuotes = true;
                string[] colFields = csvReader.ReadFields();
                foreach (string column in colFields)
                {
                    DataColumn dc = new DataColumn(column);
                    dc.AllowDBNull = true;
                    dt.Columns.Add(dc);
                }
                while (!csvReader.EndOfData)
                {
                    string[] fieldData = csvReader.ReadFields();
                    for (int i = 0; i < fieldData.Length; ++i)
                    {
                        if (fieldData[i] == String.Empty)
                        {
                            fieldData[i] = null;
                        }
                    }
                    dt.Rows.Add(fieldData);
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        public static void InsertDataToDatabase(DataTable dataTable)
        {
            string connectionString = null;
            MySqlConnection conn;
            connectionString = "server=localhost;database=testbulkinsert;uid=root;pwd=UsRMYSQL#PV;";
            conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                var bulk = new BulkOperation(conn);
                bulk.DestinationTableName = "csv";
                bulk.BulkInsert(dataTable);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

        }

        private static DataTable GetCSV(string path)
        {
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                using (var dr = new CsvDataReader(csv))
                {
                    var dt = new DataTable();
                    dt.Columns.Add("Id", typeof(int));
                    dt.Columns.Add("Name", typeof(string));

                    dt.Load(dr);
                    return dt;
                }
            }
        }

        private static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }

        public static DataTable QueryTable()
        {
            string connectionString = null;
            MySqlConnection conn;
            connectionString = "server=localhost;database=testbulkinsert;uid=root;pwd=UsRMYSQL#PV;";
            conn = new MySqlConnection(connectionString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                using var da = new MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM csv", conn);
                da.Fill(dt);
                da.Dispose();
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
