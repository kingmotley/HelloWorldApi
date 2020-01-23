using System.IO;

namespace HelloWorld
{
    public class Api : IApi
    {
        private readonly IWriter _writer;
        public Api(IWriter writer)
        {
            _writer = writer;
        }

        /// <summary>
        /// Writes Hello World to the IWriter
        /// </summary>
        /// <returns>Success</returns>
        public bool Write()
        {
            try
            {
                _writer.WriteLine("Hello World");
                return true;
            }
            catch(IOException)
            {
                return false;
            }
        }
    }
}
