using System;
using System.IO;

namespace ReadTextFile
{
    class Program
    {
        public static string inputfile = "D:/DotNetTrainingTasks/example_textfile.txt";
        public static string outputfile = "example_textfile1.txt";
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string filedata = File.ReadAllText(inputfile);
            filedata = filedata.ToUpper();
            File.WriteAllText(inputfile, filedata);
            if(File.Exists(inputfile))
            {
                File.Delete("D:/DotNetTrainingTasks/" + outputfile.ToUpper());
                FileCopy();
            }
            else
            {
                FileCopy();
            }
            
            Console.WriteLine(File.ReadAllText("D:/DotNetTrainingTasks/" + outputfile.ToUpper()));
        }
        public static void FileCopy()
        {
            File.Copy("D:/DotNetTrainingTasks/example_textfile.txt", "D:/DotNetTrainingTasks/" + outputfile.ToUpper());
        }
    }
}
