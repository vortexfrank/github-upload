using System;
using System.IO;

namespace ListFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string vPath = @"C:\Users\Francisco Chacon\Documents\CONTPAQi\TALENTO HUMANO\Capacitacion\JAVA\JavaCourse";
            string vDestinationPath = @"C:\Users\Francisco Chacon\Documents\CONTPAQi\TALENTO HUMANO\destionation.txt";
            string[] vFiles;

            vFiles = Directory.GetFiles(vPath);

            foreach(string s in vFiles)
            {
                Console.WriteLine(s);
                File.AppendAllText(vDestinationPath,s + "\n");
            }
        }
    }
}
