using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DocumentSystem
{
    /// <summary>
    /// Represents a general binary document
    /// </summary>
    public class BinaryDocument : IDocument
    {
        private string name;

        public BinaryDocument(string name, string content = "", int size = 0)
        {
            this.Name = name;
            this.Content = content;
            this.Size = size;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Document has no name");
                }

                this.name = value;
            }
        }

        public string Content { get; protected set; }
        public int Size { get; private set; }

        public virtual void LoadProperty(string key, string value)
        {
            switch (key)
            {
                case "name":
                    this.Name = value;
                    break;

                case "content":
                    this.Content = value;
                    break;

                case "size":
                    this.Size = int.Parse(value);
                    break;
            }
        }

        public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("name", this.Name));
            output.Add(new KeyValuePair<string, object>("content", this.Content));
        }

        /// <summary>
        /// Used in derived classes in the override Object.ToString() method
        /// </summary>
        /// <param name="name">Name of the class</param>
        /// <returns>String representation of the object's properties</returns>
        protected string ToString(string name)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}[", name);
            var properties = new List<KeyValuePair<string, object>>();
            this.SaveAllProperties(properties);
            properties.Sort((p1, p2) => p1.Key.CompareTo(p2.Key));

            foreach (var pair in properties)
            {
                if (!string.IsNullOrEmpty(pair.Value.ToString()) && pair.Value.ToString() != "0")
                {
                    sb.AppendFormat("{0}={1};", pair.Key, pair.Value);
                }
            }

            sb.Remove(sb.ToString().Length - 1, 1);
            sb.Append("]");

            return sb.ToString();
        }

        public override string ToString()
        {
            return ToString("BinaryDocument");
        }
    }
}
