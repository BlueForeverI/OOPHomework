using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DocumentSystem
{
    /// <summary>
    /// Represents a video document
    /// </summary>
    public class VideoDocument : MultimediaDocument
    {
        public VideoDocument(string name, int frameRate = 0, int length = 0,
                                string content = "", int size = 0) 
            : base(name, length, content, size)
        {
            this.FrameRate = frameRate;
        }

        public int FrameRate { get; private set; }
        
        public override void LoadProperty(string key, string value)
        {
            base.LoadProperty(key, value);

            if(key == "framerate")
            {
                this.FrameRate = int.Parse(value);
            }
        }
        
        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);

            output.Add(new KeyValuePair<string, object>("framerate", this.FrameRate));
        }

        public override string ToString()
        {
            return ToString("VideoDocument");
        }
    }
}
