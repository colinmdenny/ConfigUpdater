using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace ConfigUpdater
{
    class Program
    {
        static string path;
        static string oldConfig;
        static string newConfig;
        
        static void Main(string[] args)
        {
            // Get the Path of the config
            path = @"D:\Work\GitHub\ConfigUpdater\trunk\ConfigUpdater\TestFiles\App.config";
            
            // Get the config contents
            oldConfig = File.ReadAllText(path);
            Console.WriteLine("Consumed config succesfully");
            
            // Replace all the details that are needed
   
            string pattern = "<compilation debug=\"true\" />";
            string replacement = "<compilation debug=\"false\" />";
            Regex rgx = new Regex(pattern);
            newConfig = rgx.Replace(oldConfig, replacement);

            // Update the original file with the updated content
            File.WriteAllText(path, newConfig);

            Console.ReadLine();

        }
    }
}
