using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADOActivity_3DAL;

namespace ADOActivity_3UI
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDetails obj = new StudentDetails();

            var result = obj.StudentInfoDetails();

            Console.WriteLine("***********Student Details***********");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
