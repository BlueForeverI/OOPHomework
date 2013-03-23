using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DocumentSystem
{
    /// <summary>
    /// Represents an audio document
    /// </summary>
    public class AudioDocument : MultimediaDocument
    {
        public AudioDocument(string name, int sampleRate = 0, int length = 0, 
                                string content = "", int size = 0) 
            : base(name, length, content, size)
        {
            this.SampleRate = sampleRate;
        }

        public int SampleRate { get; private set; }

        public override void LoadProperty(string key, string value)
        {
            base.LoadProperty(key, value);

            if(key == "samplerate")
            {
                this.SampleRate = int.Parse(value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);

            output.Add(new KeyValuePair<string, object>("samplerate", this.SampleRate));
        }

        public override string ToString()
        {
            return ToString("AudioDocument");
        }
    }
}
