using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace _1.Points
{
    /// <summary>
    /// Saves and loads Path objects from files
    /// </summary>
    public static class PathStorage
    {
        /// <summary>
        /// Serializes a Path object to file in XML format
        /// </summary>
        /// <param name="path">The Path object</param>
        /// <param name="fileName">Path to the file</param>
        public static void SavePath(Path path, string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Path));
            TextWriter textWriter = new StreamWriter(fileName, false);
            serializer.Serialize(textWriter, path);
            textWriter.Close();
        }

        /// <summary>
        /// Deserializes a Path object
        /// </summary>
        /// <param name="fileName">Path to the .xml file</param>
        /// <returns>The deserialized path object</returns>
        public static Path LoadPath(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Path));
            TextReader textReader = new StreamReader(fileName);
            Path path = (Path) serializer.Deserialize(textReader);

            textReader.Close();
            return path;
        }
    }
}
