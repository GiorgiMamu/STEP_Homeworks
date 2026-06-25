using System;

namespace hw_13.Helpers
{
    // IDisposable = an interface from C# that lets you use a class with using() that calls Dispose() for cleanup
    public class Logger : IDisposable
    {
        private bool _disposed = false; 

        public Logger()
        {
            Console.WriteLine("[Logger] session started.\n");
        }

        public void Log(string message)
        {
            //don't log after the logger has been closed
            if (_disposed)
                throw new ObjectDisposedException("Logger", "Cannot log after disposing.");

            Console.WriteLine($"[LOG {DateTime.Now:HH:mm:ss}] {message}");
        }

        // this method is required by IDisposable
        public void Dispose()
        {
            if (!_disposed)
            {
                Console.WriteLine("\n[Logger] session closed. Logger disposed.");
                _disposed = true;
            }
        }
    }
}