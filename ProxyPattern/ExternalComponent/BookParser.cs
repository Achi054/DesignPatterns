using System;
using ProxyPattern.ExternalComponent;

namespace ProxyPattern.ExternalComponent
{
    public class BookParser : IBookParser
    {
        string _fileName;
        public BookParser(string fileName)
        {
            this._fileName = fileName;
            LoadFile(_fileName);
        }

        private void LoadFile(string fileName)
        {
            System.Console.WriteLine($"Loading file {fileName}");
        }

        public void Display()
        {
            System.Console.WriteLine($"Displaying content of file {this._fileName}");
        }
    }
}