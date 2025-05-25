using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 class General
{
    public static string userName = " ";

    public static void Greeting()
    {
        Console.WriteLine("Hi, I am a CyberSecurity Chatbot.\nPlease tell me your name...");
         userName = Console.ReadLine();
    }
}

