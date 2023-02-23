using System;
using System.Threading.Tasks;

namespace EFCore.Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Test();

            Console.ReadLine();

            Console.ReadLine();
        }

        public static void Test()
        {
            var context = new DemoDBContext();

            var model = new Model.ActiveTest()
            {
                Id = Guid.NewGuid(),
                IsActive = false
            };

            var result =  context.ActiveTests.Add(model);

            context.SaveChanges();
        }
    }
}
