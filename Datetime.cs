using System;

namespace DateTimeDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DateTime now = DateTime.Now;

            
            Console.WriteLine("Current Date: " + now.ToString("d"));  
            Console.WriteLine("Current Time: " + now.ToString("T"));

            
            Console.WriteLine("Current Date and Time: " + now);

            
            
        }
    }
}