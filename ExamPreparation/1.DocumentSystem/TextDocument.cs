using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DocumentSystem
{
    /// <summary>
    /// Represents a general text document
    /// </summary>
    public class TextDocument : IDocument, IEditable
    {
        private string name;

        public TextDocument(string name, string content = "", string charset = "")
        {
            this.Name = name;
            this.Content = content;
            this.Charset = charset;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty string or null");
                }

                this.name = value;
            }
        }

        public string Content { get; private set; }
        public string Charset { get; private set; }

        public void LoadProperty(string key, string value)
        {
            switch (key)
            {
                case "name":
                    this.Name = value;
                    break;

                case "content":
                    this.Content = value;
                    break;

                case "charset":
                    this.Charset = value;
                    break;
            }
        }

        public void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("name", this.Name));
            output.Add(new KeyValuePair<string, object>("content", this.Content));
            output.Add(new KeyValuePair<string, object>("charset", this.Charset));
        }

        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }

        /// <summary>
        /// Overrides the default ToString() method
        /// </summary>
        /// <returns>String representation of the object's properties</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}[", "TextDocument");
            var properties = new List<KeyValuePair<string, object>>();
            this.SaveAllProperties(properties);
            properties.Sort((p1, p2) => p1.Key.CompareTo(p2.Key));

            foreach (var pair in properties)
            {
                if (!string.IsNullOrEmpty(pair.Value.ToString()))
                {
                    sb.AppendFormat("{0}={1};", pair.Key, pair.Value);
                }
            }

            sb.Remove(sb.ToString().Length - 1, 1);
            sb.Append("]");

            return sb.ToString();
        }
    }
}
