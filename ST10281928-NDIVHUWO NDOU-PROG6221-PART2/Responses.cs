using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Responses
{
    /*This counter will be used to navigate between the items of the List and give the
         * user new and random responses everytime
        */
    private static int counter = 0;
    public static List<string> phishing = new List<string>()
    {
        {"Don't click on links that you are not sure are safe." },
        {"Use security on all your devices." },
        {"Enable MFA (Multi-Factor-Authentication) on all your accounts." }
    };
    public static List<string> password = new List<string>()
    {
        {"Make sure that your password is not generic e.g. birthday, anniversary, pet name." },
        {"NEVER resuse your password. It might be a lot to manage but never reuse a password because if one password is\n" +
            "ncracked then all your accounts are at risk." },
        {"Keep an eye on your accounts to make sure that there are no suspicious activities." }
    };
    public static List<string> browsing = new List<string>()
    {
        {"A safe website will have https in the url link or it will have a lock icon at the top."},
        {"Keep your browser updated. Outdated software may be a point of entry for threat attackers."},
        {"Try blocking third party cookies." }
    };
    public static List<string> profile = new List<string>();

    public static IDictionary<string, string>  sentiment = new Dictionary<string, string>()
    {
        {$"worried",$"I totally understand why you feel this way {General.userName}. Things like these are very " +
            $"tricky to navigate and they make you overthink.\nTo help you with your worry I will" +
            $"give you tips\nto help you out." },
        {"curious",$"I am glad that you are curious {General.userName}. To help you with your curiosity " +
            $"I will give you more tips"},
        {"frustrated",$"Feeling frustrated is normal. CyberSecurity is a bit complex and when you start" +
            "\nhearing more about it you get frustrated. Let me try giving you tips to calm your\n" +
            "frustration" },
    };

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

    public static void chooseResponse(string input)
    {
        
        
        switch (input.ToLower())
        {
            case string x when x.Contains("password"):
                Console.WriteLine(password[counter]);
                break;
            case string x when x.Contains("phishing"):
                Console.WriteLine(phishing[counter]);
                break;
            case string x when x.Contains("browsing"):
                Console.WriteLine(browsing[counter]);
                break;
        }
        counter ++;
        if (counter >= 3)
        {
            counter = 0;
        }
    }

    public static void sentimentResponse(string input)
    {
        switch (input.ToLower())
        {
            case string x when x.Contains("worried"):
                Console.WriteLine(sentiment["worried"]);
                //Console.WriteLine($"You are worried {General.userName}");
                if (input.Contains("password"))
                {
                    chooseResponse("password");
                }else if (input.Contains("phishing"))
                {
                    chooseResponse("phishing");
                }
                else
                {
                    chooseResponse("browsing");
                }
                    break;
            case string x when x.Contains("curious"):
                Console.WriteLine(sentiment["curious"]);
                if (input.Contains("password"))
                {
                    chooseResponse("password");
                }
                else if (input.Contains("phishing"))
                {
                    chooseResponse("phishing");
                }
                else
                {
                    chooseResponse("browsing");
                }
                break;
            case string x when x.Contains("frustrated"):
                Console.WriteLine(sentiment["frustrated"]);
                if (input.Contains("password"))
                {
                    chooseResponse("password");
                }
                else if (input.Contains("phishing"))
                {
                    chooseResponse("phishing");
                }
                else
                {
                    chooseResponse("browsing");
                }
                break;
            default:
                break;
        }

    }
}
