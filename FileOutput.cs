using System;
using System.IO;

namespace Mobile_Module_1B
{
    class FileOutput
    {
        private string file;
        public BufferedStream wr;
        public FileOutput(string filename) {
            this.file = filename;

            try { wr = new BufferedStream(new FileStream(filename, FileMode.Create, FileAccess.Write)); }
            catch (Exception e) { Console.WriteLine($"File Error: {filename} {e}"); }
        }

        public void FileWrite(string line) {
            foreach (char c in line) { wr.WriteByte((byte)c); }
            wr.WriteByte((byte)'\n');
        }

        public void FileClose() {
            wr.Flush();
            wr.Close();
        }
    }
}
