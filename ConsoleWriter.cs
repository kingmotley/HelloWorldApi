using System;

namespace HelloWorld
{
    internal class ConsoleWriter:IWriter
    {
        /// <summary>
        /// Write a string
        /// </summary>
        /// <param name="s">The string to write.</param>
        /// <exception cref="System.IO.IOException">Ignore.</exception>
        public void Write(string s)
        {
            Console.Write(s);
        }

        /// <summary>
        /// Write a line
        /// </summary>
        /// <param name="s">The string to write.</param>
        /// <exception cref="System.IO.IOException">Ignore.</exception>
        public void WriteLine(string s)
        {
            Console.WriteLine(s);
        }
    }
}
