using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DocumentSystem
{
    /// <summary>
    /// Represents an excel document
    /// </summary>
    public class ExcelDocument : OfficeDocument, IEncryptable
    {
        public ExcelDocument(string name, int numberOfRows = 0, int numberOfColumns = 0, 
                                string version = "", string content = "", 
                                int size = 0) 
            : base(name, version, content, size)
        {
            this.NumberOfRows = numberOfRows;
            this.NumberOfColumns = numberOfColumns;
        }

        public int NumberOfRows { get; private set; }
        public int NumberOfColumns { get; private set; }
        public bool IsEncrypted { get; private set; }

        public void Encrypt()
        {
            this.IsEncrypted = true;
        }

        public void Decrypt()
        {
            this.IsEncrypted = false;
        }

        public override void LoadProperty(string key, string value)
        {
            base.LoadProperty(key, value);

            switch (key)
            {
                case "rows":
                    this.NumberOfRows = int.Parse(value);
                    break;

                case "cols":
                    this.NumberOfColumns = int.Parse(value);
                    break;
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);

            output.Add(new KeyValuePair<string, object>("rows", this.NumberOfRows));
            output.Add(new KeyValuePair<string, object>("cols", this.NumberOfColumns));
        }

        public override string ToString()
        {
            return ToString("ExcelDocument");
        }
    }
}
