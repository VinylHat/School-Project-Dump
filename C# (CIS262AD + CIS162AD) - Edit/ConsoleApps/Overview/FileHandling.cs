using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApps
{
    /*
     * Brendan Ellison
     * 4/6/2021
     * Read, Write, Create, and Delete text files
     */
    class FileHandling
    {
        private string filePath;
        private StreamWriter sw;
        private FileStream fs;
        private const string studentName = "Brendan's";
        private const string className = "File Handler";
        public FileHandling()
        {
            FilePath = "";
            SW = null;
            fs = null;
        }
        public FileHandling(string file)
        {
            FilePath = file;
            SW = null;
            fs = null;
        }

        public StreamWriter SW
        {
            get { return sw; }
            set { sw = value; }
        }
        public FileStream FS
        {
            get { return fs; }
            set { fs = value; }
        }
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        public string ClassName
        {
            get { return className; }
        }
        public string StudentName
        {
            get { return studentName; }
        }

        public void DeleteFile()
        {
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }
        }
        public void CreateFile()
        {
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath);
            }
        }
        public void CloseFileStream()
        {
            if (FS != null)
            FS.Close();
        }
        public void CloseStreamWriter()
        {
            if (SW != null)
            SW.Close();
        }
        public void OpenFileWrite()
        {
            SW = File.AppendText(FilePath);
        }
        public void AddTextToFile(string input)
        {
            SW.Write(input);
        }
        public string ReadTextFromFile()
        {
            string message = "";
            using (FS = File.OpenRead(FilePath))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (FS.Read(b,0,b.Length) > 0)
                {
                    message += (temp.GetString(b));
                }
            }
            return message;
        }
        public override string ToString()
        {
            return "\n\tThank you for using FileHandeling class";
        }
    }
}
