using System;
using Microsoft.Extensions.CommandLineUtils; 

namespace ConsoleApplication
{
    public class Program
    {
        public static int Main(string[] args)
        {
            var app = new CommandLineApplication

            {
                Name = "dotnet adr",
                FullName = "Architecture Decision Record",
                Description = "Architecture Decision Record commandline tool",
            };
            
            app.HelpOption("-h|--help");


            app.OnExecute(() =>
                        {
                            app.ShowHelp();
                            return 2;
                        });

            return app.Execute(args);
            
           
        }
    }
}
