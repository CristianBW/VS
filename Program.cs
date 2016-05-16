using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();          
        }
        void Run()
        {
            greetingConfirmation();
        }
        void greetingConfirmation()
        {
            Console.WriteLine("Hi ! This is GitPlayground, a project i created to test the functionaties of Git");
            Console.WriteLine("Press any key to close the app.");
            Console.Read();
        }
    }
}
