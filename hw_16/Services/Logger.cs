using System;
using System.Collections.Generic;
using System.Text;

namespace hw_16.Services
{
    //simple logging service. sses an Action<string> delegate as the "output sink",
    // so the caller decides where log messages actually go 
    public class Logger
    {
        private readonly Action<string> _writeAction;

        public Logger() : this(Console.WriteLine) { }

        // custom constructor: caller can inject any Action<string>, Action is delegate built in.
        public Logger(Action<string> writeAction)
        {
            _writeAction = writeAction ?? throw new ArgumentNullException(nameof(writeAction));
        }

        public void Info(string message) => Write("INFO", message);

        public void Warning(string message) => Write("WARNING", message);

        public void Error(string message) => Write("ERROR", message);

        private void Write(string level, string message)
        {
            string formatted = $"[{DateTime.Now:HH:mm:ss}] [{level}] {message}";
            _writeAction(formatted);
        }
    }
}
