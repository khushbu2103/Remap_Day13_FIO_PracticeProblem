using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day13_FIO_PracticeProblem
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long MobileNumber { get; set; }
        public int Age { get; set; }

        public static void SaveDataToTextFile(List<Student> students)
        {
            string path = @"C:\Users\LENOVO\source\repos\Remap_Day13_FIO_PracticeProblem\Remap_Day13_FIO_PracticeProblem\StudentDetails.txt";

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                foreach (Student student in students)
                {
                    writer.WriteLine("Id : " + student.Id);
                    writer.WriteLine("Name : " + student.Name);
                    writer.WriteLine("PhoneNumber : " + student.MobileNumber);
                    writer.WriteLine("Age : " + student.Age);
                }
            }
        }
        public static void ReadDataFromTextFile()
        {
            string path = @"C:\Users\LENOVO\source\repos\Remap_Day13_FIO_PracticeProblem\Remap_Day13_FIO_PracticeProblem\StudentDetails.txt";
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);

                Console.WriteLine("Data read from file:");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
        public static void SaveDataInCSVFile(List<Student> students)
        {
            string csvPath = @"C:\Users\LENOVO\source\repos\Remap_Day13_FIO_PracticeProblem\Remap_Day13_FIO_PracticeProblem\StudentData.csv";
            var writer = File.AppendText(csvPath);
            foreach (Student student in students)
            {
                writer.WriteLine("Id : " + student.Id);
                writer.WriteLine("Name : " + student.Name);
                writer.WriteLine("PhoneNumber : " + student.MobileNumber);
                writer.WriteLine("Age : " + student.Age);
            }
            writer.Close();
        }
        public static void ReadDataFromCSVFile()
        {
            string csvPath = @"C:\Users\LENOVO\source\repos\Remap_Day13_FIO_PracticeProblem\Remap_Day13_FIO_PracticeProblem\StudentData.csv";
            using (var reader = new StreamReader(csvPath))
            {
                string s = " ";
                while ((s = reader.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }

            }
        }
        public static void SaveDataToJsonFile(List<Student> students)
        {
            string path = @"C:\Users\LENOVO\source\repos\Remap_Day13_FIO_PracticeProblem\Remap_Day13_FIO_PracticeProblem\StudentData.json";

            using (StreamWriter writer = new StreamWriter(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                using (JsonWriter jsonWriter = new JsonTextWriter(writer))
                {
                    foreach (Student student in students)
                    {
                        writer.WriteLine("Id : " + student.Id);
                        writer.WriteLine("Name : " + student.Name);
                        writer.WriteLine("PhoneNumber : " + student.MobileNumber);
                        writer.WriteLine("Age : " + student.Age);
                    }
                }
            }
        }
        public static void ReadDataFromJson()
        {
            string path = @"C:\Users\LENOVO\source\repos\Remap_Day13_FIO_PracticeProblem\Remap_Day13_FIO_PracticeProblem\StudentData.json";
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);

                Console.WriteLine("Data read from file:");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
