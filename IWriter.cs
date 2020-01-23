namespace HelloWorld
{
    public interface IWriter
    {
        /// <summary>
        /// Write a string
        /// </summary>
        /// <param name="s">The string to write.</param>
        /// <exception cref="System.IO.IOException">Ignore.</exception>
        public void Write(string s);

        /// <summary>
        /// Write a line
        /// </summary>
        /// <param name="s">The string to write.</param>
        /// <exception cref="System.IO.IOException">Ignore.</exception>
        public void WriteLine(string s);

    }
}
