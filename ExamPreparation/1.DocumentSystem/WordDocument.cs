using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DocumentSystem
{
    /// <summary>
    /// Represents a Word document
    /// </summary>
    public class WordDocument : OfficeDocument, IEncryptable, IEditable
    {
        public WordDocument(string name, int numberOfCharacters = 0, string version = "",
                                string content = "", int size = 0) 
            : base(name, version, content, size)
        {
            this.NumberOfCharacters = numberOfCharacters;
        }

        public int NumberOfCharacters { get; private set; }
        public bool IsEncrypted { get; private set; }

        public void Encrypt()
        {
            this.IsEncrypted = true;
        }

        public void Decrypt()
        {
            this.IsEncrypted = false;
        }

        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }
        
        public override void LoadProperty(string key, string value)
        {
            base.LoadProperty(key, value);

            if(key == "chars")
            {
                this.NumberOfCharacters = int.Parse(value);
            }
        }
        
        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);

            output.Add(new KeyValuePair<string, object>("chars", this.NumberOfCharacters));
        }

        public override string ToString()
        {
            return ToString("WordDocument");
        }
    }
}
