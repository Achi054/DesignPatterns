using ProxyPattern.ExternalComponent;

namespace ProxyPattern.ProxyComponent
{
    public class BookParserProxy : IBookParser
    {
        string _fileName;
        BookParser _parser;
        public BookParserProxy(string fileName)
        {
            this._fileName = fileName;
        }
        public void Display()
        {
            if(_parser == null)
            {
                _parser = new BookParser(this._fileName);
            }
            _parser.Display();
        }
    }
}