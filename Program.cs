using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring data
            float manWeight = 0.0f;
            float gravity = 9.8f;
            float gravityMoon = (gravity * 17)/ 100;
            float weightInMoon = 0.0f;

            //Requesting data from the user
            Console.Write(" Write the person's weight on earth in kg: ");
            manWeight = Convert.ToSingle(Console.ReadLine());

            //Calculating weight on the moon
            weightInMoon = (manWeight * gravityMoon) / gravity;

            //Showing results
            Console.WriteLine("This person weighs on the moon: {0} kg", weightInMoon);

            Console.ReadKey();
        }
    }
}
