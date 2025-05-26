using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        General.Display_Art();
        General.Play_Audio();
        General.Greeting();
        try
        {
            Responses.Basic_Response();
        }
        catch (Exception)
        {
            Console.WriteLine("Something went wrong with your input.");
        }
    }
        
          
}
