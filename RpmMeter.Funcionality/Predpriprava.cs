using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmMeter.Domain
{
    internal class Predpriprava
    {

        public static void shitMethod()
        {
            try
            {
                int res = checkAge(15);
                Console.WriteLine(res);
                Console.ReadLine();
            }

            catch (CustomExeption ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        static int checkAge(int ageToCheck)
        {
            Console.WriteLine("Enter age");
            string? answer = Console.ReadLine();
            int age = Convert.ToInt32(answer);

            if (age < 18)
            {
                throw new Exception("Nesi plnolety");
            }
            return age;
        }

        public class CustomExeption : Exception
        {
            public CustomExeption(string msg) : base(msg)
            {
                
            }
        }



    }
}
