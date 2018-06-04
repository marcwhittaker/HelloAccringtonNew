using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloAccrington
{
    class Job
    {
        public string pickup = "Accrington";
        public string destination = "Haslingden";
        public int distance = 10;
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Job newjob = new Job();
            Console.WriteLine("Please Enter Pickup Location");
            newjob.pickup = Console.ReadLine();
            Console.WriteLine("Please Enter Destination");
            newjob.destination = Console.ReadLine();
            Console.WriteLine("Please enter Distance");
            string inputdist = Console.ReadLine();
            int.TryParse(inputdist, out newjob.distance);
            Console.WriteLine(newjob.distance);
            int time = newjob.distance * 2;
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Taxi is required for " + newjob.pickup + " going to " + newjob.destination);
            Console.WriteLine("This should take " + time + " Minutes");
            Console.ReadKey();
        }
    }
}
