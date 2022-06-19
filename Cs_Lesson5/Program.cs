using ConsoleApplication;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//namespace Cs_Lesson5
//{
//    //class Worker
//    //{
//    //    public int Id{ get; set; }
//    //    public string Name { get; set; }

//    //    static Worker()
//    //    {
//    //        Console.WriteLine("Static constructor");
//    //    }

//    //    public Worker(int id, string name)
//    //    {
//    //        this.Id = id;
//    //        this.Name = name;
//    //        Console.WriteLine("Parametric constructor");
//    //    }
//    //}

//    //internal class Program
//    //{
//    //    static void Main(string[] args)
//    //    {
//    //        Console.Title = "C# Lesson 5";
//    //        Worker[] workers = new Worker[3];

//    //        for (int i = 0; i < 3; i++)
//    //        {
//    //            workers[i] = new Worker(i, "John");
//    //        }
//    //    }
//    //}


//    class Car
//    {
//        public int Id { get; set; } 
//        public Car(int id)
//        {
//            Thread.Sleep(1000);
//            Id = id;
//        }

//        public static DateTime globalStartTime;

//        static Car()
//        {
//            globalStartTime = DateTime.Now;
//            Console.WriteLine($@"Static constructor called
//            Global Start Time : {globalStartTime}");
//        }

//        public void Drive()
//        {
//            TimeSpan elapsedTime = DateTime.Now - globalStartTime;
//            Console.WriteLine($@"
//            Car ID : {Id} is starting its work
//            {elapsedTime.Seconds} seconds
//            after global start time
//            {globalStartTime.ToLongTimeString()}");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //for (int i = 0; i < 10; i++)
//            //{
//            //    Car car = new Car(1);
//            //    Thread.Sleep(350);
//            //    car.Drive();
//            //}

//            // Partial

//            //BankAccount bankAccount = new BankAccount()
//            //{
//            //    Id = 1,
//            //     Name = "John" 
//            //};
//            //BankAccount bankAccount2 = new BankAccount("Mike");
//            //bankAccount2.Start();

//            Console.WriteLine(NetworkConstants.TempFolderPath);


//        }
//    }
//}


//namespace Cs_Lesson5
//{
//    internal class FileHelper
//    {
//        static public FileInfo[] GetTempFiles()
//        {
//            DirectoryInfo objDirectoryInfo = new DirectoryInfo(NetworkConstants.TempFolderPath);
//            FileInfo[] allFiles = objDirectoryInfo.GetFiles("*.*", SearchOption.TopDirectoryOnly);
//            return allFiles;
//        }
//    }

//    class Program
//    {
//        public static object ZipArchiveMode { get; private set; }

//        static void Main(string[] args)
//        {
//            FileIfo[] allFiles = FileHelper.GetTempFiles();
n
//            string outputFile = @"D:\output.zip";
//            string fileToZip = @"D:\catalog.xls";
//            using (var archive = ZipFile.Open(outputFile, System.IO.Compression.ZipArchiveMode.Create))
//            {
//                archive.CreateEntryFromFile(fileToZip, Path.GetFileName(fileToZip));
//                foreach (var file in allFiles)
//                {
//                    if (file.ToString().EndsWith(".log") && DateTime.Now.Day - file.CreationTime.Day <= 3)
//                    {
//                        Console.WriteLine($" File: {file.Name} \n Full Path : {file.FullName} \n\n");
//                        archive.ExtractToDirectory(file.FullName);
//                    }
//                }
//            }
           
//            Console.ReadLine();
//        }
//    }
//}

