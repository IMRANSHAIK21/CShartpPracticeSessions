using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Configuration;

namespace Logging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string logPath = Path.Combine(Environment.GetFolderPath(
 Environment.SpecialFolder.DesktopDirectory), "log.txt");
            Console.WriteLine($"Writing to: {logPath}");

            TextWriterTraceListener logFile = new(File.CreateText(logPath));
            Trace.Listeners.Add(logFile); // we are adding the listener here for the trace
                                          // we have listenere only for Trace not for Debug

#if DEBUG
                        // Text writer is buffered, so this option calls
                        // Flush() on all listeners after writing.
                        Trace.AutoFlush = true;
#endif
            string settingsFile = "appsettings.json";
            string settingsPath = Path.Combine(Directory.GetCurrentDirectory(), settingsFile);
            Console.WriteLine("Processing {0}", settingsPath);
            Console.WriteLine("--{0} contents--", settingsFile);
            Console.WriteLine(File.ReadAllText(settingsPath));
            Console.WriteLine("-----------------------------");
            ConfigurationBuilder configurationBuilder = new();
            configurationBuilder.SetBasePath(Directory.GetCurrentDirectory());
            configurationBuilder.AddJsonFile(settingsFile, optional: false, reloadOnChange: true);
            IConfigurationRoot configuration = configurationBuilder.Build();
            TraceSwitch ts = new(
             displayName: "PacktSwitch",
             description: "This switch is set via a JSON config.");
            configuration.GetSection("PacktSwitch").Bind(ts);
            Console.WriteLine($"Trace switch value: {ts.Value}");
            Console.WriteLine($"Trace switch level: {ts.Level}");
            // 
            Trace.WriteLineIf(ts.TraceError, "Trace error");
            Trace.WriteLineIf(ts.TraceWarning, "Trace warning");
            Trace.WriteLineIf(ts.TraceInfo, "Trace information");
            Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");


            Debug.WriteLine("Debug says, I am watching!");
            Trace.WriteLine("Trace says, I am watching!");
            // Close the text file (also flushes) and release resources.

            int unitInStock = 12;
            LogSourceDetails(unitInStock > 10, "hello", "nice");
            Debug.Close();
            Trace.Close();






        }
        static void LogSourceDetails(
            bool condition,
            [CallerMemberName] string member = "",
            [CallerFilePath] string filepath = "",
            [CallerLineNumber] int line = 0,
            [CallerArgumentExpression(nameof(condition))] string expression =""

            )
        {
            Trace.WriteLine(string.Format(
"[{0}]\n {1} on line {2}. Expression: {3}",
filepath, member, line, expression));
        }
    }
}
