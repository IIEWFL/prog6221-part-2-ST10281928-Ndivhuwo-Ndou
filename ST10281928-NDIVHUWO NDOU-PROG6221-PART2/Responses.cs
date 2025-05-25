using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Responses
{
    public static List<string> phishing = new List<string>();
    public static List<string> password = new List<string>();
    public static List<string> browsing = new List<string>();
    public static List<string> profile = new List<string>();

    public static void AddToList()
    {
        phishing.Add("Don't click on links that you are not sure are safe.");
        phishing.Add("Use security on all your devices.");
        phishing.Add("Enable MFA (Multi-Factor-Authentication) on all your accounts.");
        password.Add("Make sure that your password is not generic e.g. birthday, anniversary, pet name.");
        password.Add("NEVER resuse your password. It might be a lot to manage but never reuse a password because if one password is" +
            "\ncracked then all your accounts are at risk.");
        password.Add("Keep an eye on your accounts to make sure that there are no suspicious activities.");
        browsing.Add("A safe website will have https in the url link or it will have a lock icon at the top.");
        browsing.Add("Keep your browser updated. Outdated software may be a point of entry for threat attackers.");
        browsing.Add("Try blocking third party cookies.");
    }

    public static void storeFavourites(string input)
    {
        
        if (input.Contains("interested") || input.Contains("favourite") || input.Contains("interesting"))
        {
            switch (input)
            {
                case string x when x.Contains("password"):
                    profile.Add("password");
                    Console.WriteLine("Password topic stored");
                break;

                case string x when x.Contains("phishing"):
                    profile.Add("phishing");
                    Console.WriteLine("Phishing topic stored");
                    break;

                case string x when x.Contains("browsing"):
                    profile.Add("browsing");
                    Console.WriteLine("Browsing topic stored");
                    break;

                default:
                break;
            }

        }
    }
}
