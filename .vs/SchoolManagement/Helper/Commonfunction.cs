using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using ExcelDataReader;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;

namespace SchoolManagement.Helper
{
    public static class Commonfunction
    {
        public static DataTable GetDataTabletFromCSVFile(FileInfo file, string inputfilename)
        {

            var csvDataTable = new DataTable();
            string fileExtension = file.Extension.ToLower();

            try
            {
                if (fileExtension == ".csv")
                {
                    using (var reader = new StreamReader(inputfilename))
                    using (var csvReader = new TextFieldParser(reader))
                    {
                        csvReader.SetDelimiters(new string[] { "," });
                        csvReader.HasFieldsEnclosedInQuotes = true;

                        var colFields = csvReader.ReadFields();
                        foreach (string column in colFields)
                        {
                            csvDataTable.Columns.Add(new DataColumn(column) { AllowDBNull = true });
                        }

                        while (!csvReader.EndOfData)
                        {
                            var fieldData = csvReader.ReadFields();
                           
                            for (int i = 0; i < fieldData.Length; i++)
                            {
                                if (fieldData[i] == "")
                                {
                                    fieldData[i] = null;
                                }
                            }

                            if (fieldData.Length == csvDataTable.Columns.Count)
                            {
                                csvDataTable.Rows.Add(fieldData);
                            }
                            else
                            {
                                throw new ArgumentException("Row length does not match column count.");
                            }
                        }
                    }
                }
                else if (fileExtension == ".xls" || fileExtension == ".xlsx")
                {
                    System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                    using (var stream = File.Open(inputfilename, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            if (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    csvDataTable.Columns.Add(reader.GetString(i));
                                }
                            }

                            while (reader.Read())
                            {
                                var rowData = new object[reader.FieldCount];
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    rowData[i] = reader.IsDBNull(i) ? null : reader.GetValue(i);
                                }

                                csvDataTable.Rows.Add(rowData);
                            }
                        }
                    }
                }
                else
                {
                    throw new NotSupportedException("Unsupported file format.");
                }

                return csvDataTable;
            }
            catch (Exception ex)
            {
                // Log the exception as needed
                throw;
            }
        }
       
        public static List<CustomDropDownList> GetSuggestionForLeadExcel()
        {
            var list = new List<CustomDropDownList>();

            list.Add(new CustomDropDownList { value = "Name", label = "Name" });
            list.Add(new CustomDropDownList { value = "Email", label = "Email" });
            list.Add(new CustomDropDownList { value = "PhoneNumber", label = "PhoneNumber" });
            return list;

        }

        public class CustomDropDownList
        {
            public string label { get; set; }
            public string value { get; set; }
        }
    }
}