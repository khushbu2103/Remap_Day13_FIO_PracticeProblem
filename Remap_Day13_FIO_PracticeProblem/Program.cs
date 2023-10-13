using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day13_FIO_PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student{Id=1, Name="Khushi", MobileNumber=8619532017, Age=27}
            };
            Student.SaveDataToTextFile(students);
            Console.WriteLine("Data Saved Succesfully in text File");
            Student.ReadDataFromTextFile();
            //Student.SaveDataInCSVFile(students);
            //Console.WriteLine("Data Saved Succesfully in csv File");
            //Student.ReadDataFromCSVFile();
            //Student.SaveDataToJsonFile(students);
            //Console.WriteLine("Data Saved To Json File Succesfully");
            //Student.ReadDataFromJson();
            Console.ReadLine();
        }
    }
}
