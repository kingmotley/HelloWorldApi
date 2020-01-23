using System;

namespace HelloWorld
{
    /// <summary>
    ///  Some unspecified different implementation of IWriter
    /// </summary>
    internal class DatabaseWriter:IWriter
    {
        public void Write(string s)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(string s)
        {
            throw new NotImplementedException();
        }
    }
}
