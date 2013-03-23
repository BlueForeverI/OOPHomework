using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DocumentSystem
{
    /// <summary>
    /// Represents a PDF document
    /// </summary>
    public class PdfDocument : BinaryDocument, IEncryptable
    {
        public PdfDocument(string name, int numberOfPages = 0, string content = "", int size = 0)
            : base(name, content, size)
        {
            this.NumberOfPages = numberOfPages;
        }

        public int NumberOfPages { get; private set; }
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

            if(key == "pages")
            {
                this.NumberOfPages = int.Parse(value);
            }
        }
        
        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);

            output.Add(new KeyValuePair<string, object>("pages", this.NumberOfPages));
        }

        public override string ToString()
        {
            return ToString("PDFDocument");
        }
    }
}
