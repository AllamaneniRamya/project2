using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RainbowSchoolsStudentData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = "studentdata.txt";
            try
            {
                string[] studentData = File.ReadAllLines("C:\\Users\\Administrator\\OneDrive\\Desktop\\Project2\\studentdata.txt");
                foreach (var student in studentData)
                {
                    Console.WriteLine(student);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File not found: {filepath}");
            }
        }
    }
}
