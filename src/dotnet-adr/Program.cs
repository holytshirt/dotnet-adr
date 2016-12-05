using System;
using Microsoft.Extensions.CommandLineUtils; 

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var app = new CommandLineApplication

            {
                Name = "dotnet adr",
                FullName = "Architecture Decision Record",
                Description = "Architecture Decision Record commandline tool",
            };
            
            app.HelpOption("-h|--help");
        }
    }
}
