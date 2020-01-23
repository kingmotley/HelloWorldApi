using System;

namespace HelloWorld
{
    internal class WriterFactory
    {
        internal IWriter GetWriter(string type)
        {
            // Simple implementation, but you can make this even more generic by using fully qualified class names if necessary
            switch (type)
            {
                case "Console":
                    return new ConsoleWriter();
                case "Database":
                    return new DatabaseWriter();
            }
            throw new ArgumentOutOfRangeException(nameof(type));
        }
    }
}
