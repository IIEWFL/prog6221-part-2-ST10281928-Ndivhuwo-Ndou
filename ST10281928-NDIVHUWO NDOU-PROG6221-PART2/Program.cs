using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10281928_NDIVHUWO_NDOU_PROG6221_PART2
{
    class Program
    {
        static void Main(string[] args)
        {
            General.Greeting();
            Console.WriteLine($"Your name is: {General.userName}");
            Responses.profile.Add(General.userName);
            Responses.storeFavourites("I am interested in password safety");
        }
    }
}
