using System;
using System.IO;

using System.Collections;
namespace Mobile_Module_1B
{
    class FileInput
    {
        private string file;
        private BufferedStream reader;
        public FileInput(string filename) {
            this.file = filename;
            try {
                reader = new BufferedStream(new FileStream(filename, FileMode.Open, FileAccess.Read)); 
            }
            catch (Exception e) { 
                Console.WriteLine($"File Error: {filename} {e}");
            }
        }

        public void FileRead() {
            string? line;
            while ((line = FileReadLine()) != null) { Console.WriteLine(line); }
        }

        public string? FileReadLine() {
            string line = "";
            int chr;
            while ((chr = reader.ReadByte()) != -1 && chr != 10) { line += (char)chr; }
            return line == "" ? null : line;
        }

        public void FileClose()
        {
            try {
                reader.Flush();
                reader.Close();
            }
            catch (IOException e) {
                Console.WriteLine(e.ToString()); 
            }
        }
    }
}