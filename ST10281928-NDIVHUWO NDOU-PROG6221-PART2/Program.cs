using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
        static void Main(string[] args)
        {
           General.Greeting();
            Console.WriteLine($"Your name is: {General.userName}");
            Responses.profile.Add(General.userName);
            Responses.storeFavourites("I am interested in password safety");
            Responses.sentimentResponse("I am worried about my password safety");
            Responses.sentimentResponse("I am worried about my password safety");
    }
}
