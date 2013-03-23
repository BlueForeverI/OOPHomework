using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DocumentSystem
{
    /// <summary>
    /// Represents a multimedia document
    /// </summary>
    public class MultimediaDocument : BinaryDocument
    {
        public MultimediaDocument(string name, int length = 0, 
                                    string content = "", int size = 0) 
            : base(name, content, size)
        {
            this.Length = length;
        }

        public int Length { get; private set; }

        public override void LoadProperty(string key, string value)
        {
            base.LoadProperty(key, value);

            if(key == "length")
            {
                this.Length = int.Parse(value);
            }
        }
        
        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);

            output.Add(new KeyValuePair<string, object>("length", this.Length));
        }

        public override string ToString()
        {
            return ToString("MultimediaDocument");
        }
    }
}
