using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DocumentSystem
{
    /// <summary>
    /// Represents an office document
    /// </summary>
    public class OfficeDocument : BinaryDocument
    {
        public OfficeDocument(string name, string version = "", string content = "", int size = 0) 
            : base(name, content, size)
        {
            this.Version = version;
        }

        public string Version { get; private set; }
        
        public override void LoadProperty(string key, string value)
        {
            base.LoadProperty(key, value);

            if(key == "version")
            {
                this.Version = value;
            }
        }
        
        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);

            output.Add(new KeyValuePair<string, object>("version", this.Version));
        }

        public override string ToString()
        {
            return ToString("OfficeDocument");
        }
    }
}
