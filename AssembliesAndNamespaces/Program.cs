using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Example from https://msdn.microsoft.com/en-us/library/8bh11f1k.aspx
            // Example #2: Write one string to a text file.
            string text = "A class is the most powerful data type in C#. Like a structure, " +
                           "a class defines the data and behavior of the data type. ";
            string moreText = "We want to also add this to our file.";
            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().
            File.WriteAllText(@"D:\Coding\DotNet\Projects\AssembliesAndNamespaces\WriteText.txt", text);
            File.WriteAllText(@"D:\Coding\DotNet\Projects\AssembliesAndNamespaces\WriteText.txt", moreText); //over write the previous 'text' file

            Console.WriteLine("Hello World");
            Console.ReadLine();
            */

            WebClient client = new WebClient();
            string reply = client.DownloadString("http://huskermax.com");

            Console.WriteLine(reply);
            File.WriteAllText(@"D:\Coding\DotNet\Projects\AssembliesAndNamespaces\WriteText.txt", reply);
            Console.ReadLine();
        }
    }
}
