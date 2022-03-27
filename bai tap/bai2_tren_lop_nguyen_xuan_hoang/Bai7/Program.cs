using System;
using System.IO;

namespace Bai7
{
    class Program
    {
        static void CopyFileByFileClass(string sourceFile, string destinationFile)
        {
            try
            {
                File.Copy(sourceFile, destinationFile, true);
            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message);
            }
        }
        static void CopyFileByStream(string sourceFile, string destinationFile)
        {
            var inputStream = new StreamReader(sourceFile);
            var outputStream = new StreamWriter(destinationFile, append: false);
            try
            {
                string line = "";
                while ((line = inputStream.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    outputStream.WriteLine(line);
                }
                
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string sourceFile = @"C:\source\helloworld.txt";
            string destinationFile = @"D:\target\helloworld.txt";

            CopyFileByFileClass(sourceFile, destinationFile);

            CopyFileByStream(destinationFile, sourceFile);
        }

       
    }
}
