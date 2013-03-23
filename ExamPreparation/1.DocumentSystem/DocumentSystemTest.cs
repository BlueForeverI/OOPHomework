using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DocumentSystem
{
    /// <summary>
    /// Test the classes
    /// </summary>
    class DocumentSystemTest
    {
        private static List<IDocument> documents = new List<IDocument>();

        static void Main(string[] args)
        {
            IList<string> allCommands = ReadAllCommands();
            ExecuteCommands(allCommands);
        }

        private static IList<string> ReadAllCommands()
        {
            List<string> commands = new List<string>();
            while (true)
            {
                string commandLine = Console.ReadLine();
                if (commandLine == "")
                {
                    // End of commands
                    break;
                }
                commands.Add(commandLine);
            }
            return commands;
        }

        private static void ExecuteCommands(IList<string> commands)
        {
            foreach (var commandLine in commands)
            {
                int paramsStartIndex = commandLine.IndexOf("[");
                string cmd = commandLine.Substring(0, paramsStartIndex);
                int paramsEndIndex = commandLine.IndexOf("]");
                string parameters = commandLine.Substring(
                    paramsStartIndex + 1, paramsEndIndex - paramsStartIndex - 1);
                ExecuteCommand(cmd, parameters);
            }
        }

        private static void ExecuteCommand(string cmd, string parameters)
        {
            string[] cmdAttributes = parameters.Split(
                new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            if (cmd == "AddTextDocument")
            {
                AddTextDocument(cmdAttributes);
            }
            else if (cmd == "AddPDFDocument")
            {
                AddPdfDocument(cmdAttributes);
            }
            else if (cmd == "AddWordDocument")
            {
                AddWordDocument(cmdAttributes);
            }
            else if (cmd == "AddExcelDocument")
            {
                AddExcelDocument(cmdAttributes);
            }
            else if (cmd == "AddAudioDocument")
            {
                AddAudioDocument(cmdAttributes);
            }
            else if (cmd == "AddVideoDocument")
            {
                AddVideoDocument(cmdAttributes);
            }
            else if (cmd == "ListDocuments")
            {
                ListDocuments();
            }
            else if (cmd == "EncryptDocument")
            {
                EncryptDocument(parameters);
            }
            else if (cmd == "DecryptDocument")
            {
                DecryptDocument(parameters);
            }
            else if (cmd == "EncryptAllDocuments")
            {
                EncryptAllDocuments();
            }
            else if (cmd == "ChangeContent")
            {
                ChangeContent(cmdAttributes[0], cmdAttributes[1]);
            }
            else
            {
                throw new InvalidOperationException("Invalid command: " + cmd);
            }
        }

        // applies a list of properties and returns the name property
        private static string ApplyAttributes(string[] attributes, IDocument document)
        {
            string name = "";

            foreach (var attribute in attributes)
            {
                string[] keyValuePair = attribute.Split(new char[] { '=' });

                if (keyValuePair.Length > 0)
                {
                    string key = keyValuePair[0];
                    string value = keyValuePair[1];

                    if (key == "name" && !string.IsNullOrEmpty(value)
                        && !string.IsNullOrWhiteSpace(value))
                    {
                        name = value;
                    }

                    document.LoadProperty(key, value);
                }
            }

            return name;
        }

        private static void AddTextDocument(string[] attributes)
        {
            TextDocument document = new TextDocument("dummyName");

            if(ApplyAttributes(attributes, document) != "")
            {
                documents.Add(document);
                Console.WriteLine("Document added: {0}", document.Name);
            }
            else
            {
                Console.WriteLine("Document has no name");
            }
        }

        private static void AddPdfDocument(string[] attributes)
        {
            PdfDocument document = new PdfDocument("dummyName");

            if (ApplyAttributes(attributes, document) != "")
            {
                documents.Add(document);
                Console.WriteLine("Document added: {0}", document.Name);
            }
            else
            {
                Console.WriteLine("Document has no name");
            }
        }

        private static void AddWordDocument(string[] attributes)
        {
            WordDocument document = new WordDocument("dummyName");

            if (ApplyAttributes(attributes, document) != "")
            {
                documents.Add(document);
                Console.WriteLine("Document added: {0}", document.Name);
            }
            else
            {
                Console.WriteLine("Document has no name");
            }
        }

        private static void AddExcelDocument(string[] attributes)
        {
            ExcelDocument document = new ExcelDocument("dummyName");

            if (ApplyAttributes(attributes, document) != "")
            {
                documents.Add(document);
                Console.WriteLine("Document added: {0}", document.Name);
            }
            else
            {
                Console.WriteLine("Document has no name");
            }
        }

        private static void AddAudioDocument(string[] attributes)
        {
            AudioDocument document = new AudioDocument("dummyName");

            if (ApplyAttributes(attributes, document) != "")
            {
                documents.Add(document);
                Console.WriteLine("Document added: {0}", document.Name);
            }
            else
            {
                Console.WriteLine("Document has no name");
            }
        }

        private static void AddVideoDocument(string[] attributes)
        {
            VideoDocument document = new VideoDocument("dummyName");

            if (ApplyAttributes(attributes, document) != "")
            {
                documents.Add(document);
                Console.WriteLine("Document added: {0}", document.Name);
            }
            else
            {
                Console.WriteLine("Document has no name");
            }
        }

        private static void ListDocuments()
        {
            if (documents.Count == 0)
            {
                Console.WriteLine("No documents found");
            }
            else
            {
                foreach (var document in documents)
                {
                    Console.WriteLine(document.ToString());
                }
            }
        }

        private static void EncryptDocument(string name)
        {
            if(documents.Count(d => d.Name == name) == 0)
            {
                Console.WriteLine("Document not found: {0}", name);
            }
            else
            {
                var docs = documents.Where(d => d.Name == name)
                    .Select(d => d)
                    .ToList();

                foreach (var doc in docs)
                {
                    if(doc is IEncryptable)
                    {
                        (doc as IEncryptable).Encrypt();
                        Console.WriteLine("Document encrypted: {0}", name);
                    }
                    else
                    {
                        Console.WriteLine("Document does not support encryption: {0}",
                            name);
                    }
                }
            }
        }

        private static void DecryptDocument(string name)
        {
            if (documents.Count(d => d.Name == name) == 0)
            {
                Console.WriteLine("Document not found: {0}", name);
            }
            else
            {
                var docs = documents.Where(d => d.Name == name)
                    .Select(d => d)
                    .ToList();

                foreach (var doc in docs)
                {
                    if (doc is IEncryptable)
                    {
                        (doc as IEncryptable).Decrypt();
                        Console.WriteLine("Document decrypted: {0}", name);
                    }
                    else
                    {
                        Console.WriteLine("Document does not support decryption: {0}",
                            name);
                    }
                }
            }
        }

        private static void EncryptAllDocuments()
        {
            if(!documents.Any(d => d is IEncryptable))
            {
                Console.WriteLine("No encryptable documents found");
            }
            else
            {
                foreach (var document in documents)
                {
                    if(document is IEncryptable)
                    {
                        (document as IEncryptable).Encrypt();
                    }
                }

                Console.WriteLine("All documents encrypted");
            }
        }

        private static void ChangeContent(string name, string content)
        {
            if (documents.Count(d => d.Name == name) == 0)
            {
                Console.WriteLine("Document not found: {0}", name);
            }
            else
            {
                var docs = documents.Where(d => d.Name == name)
                    .Select(d => d)
                    .ToList();

                foreach (var doc in docs)
                {
                    if (doc is IEditable)
                    {
                        (doc as IEditable).ChangeContent(content);
                        Console.WriteLine("Document content changed: {0}", name);
                    }
                    else
                    {
                        Console.WriteLine("Document is not editable: {0}",
                            name);
                    }
                }
            }
        }
    }
}
