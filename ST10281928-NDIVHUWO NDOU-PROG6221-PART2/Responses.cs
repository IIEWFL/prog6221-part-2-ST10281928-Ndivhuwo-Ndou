﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Responses
{
    public static bool memory = false;
    public static bool random = false;
    public static bool sentimentFeedback = false;

    //Code Attribution
    //This method is for Dictionaries
    //https://www.geeksforgeeks.org/c-sharp-dictionary-with-examples/
    //Geeksforgeeks
    //https://www.geeksforgeeks.org/

    public static IDictionary<string, string> topics = new Dictionary<string, string>()
    {
        {"password","======================================= PASSWORD SAFETY =========================================\n" +
                    "Password safety is how secure your password is. The more secure your password\n" +
                    "is the more difficult it is to crack. Your password is the protector of you private\n" +
                    "information if it gets cracked then everything will be stolen by the attackers. In a work\n" +
                    "environment having a secure password is very crucial because if you do not you could be the\n" +
                    "reason why attackers gain information to comapny information and that is very valuable information.\n" +
                    "======================================= PASSWORD ATTACKS =========================================\n" +
                    "*Brute Force Attack - This is where the attacker will try every possible combination\n" +
                    "   for your password until they get it right.\n" +
                    "*Phishing - The attacker send you an email or text message pretending to be a trusted source\n" +
                    "   and then asks you to enter you login details.\n" +
                    "======================================= PASSWORD SAFETY TIPS =========================================\n" +
                    "*Create a complex password, a password that invloves special characters, numbers and different letters.\n" +
                    "  e.g. $ND1VH4w@I$7h3B3#7\n" +
                    "Change your password regurlarly.\n" +
                    "  e.g. Every month or twice a year\n" +
                    "*Do not click suspicious links \n" +
                    "  e.g. http://Amazonisgood.com \n" },
        {"phishing","======================================= PHISHING =========================================\n" +
                    "Phishing is the act of sending fauls communication to someone\n" +
                    "and making it look like it comes from a trustworthy source such as a corporation or\n" +
                    "someone you know in order to gain access to sensitive information or financial gain.\n" +
                    "Phishing is usually done through emails or text messages. For know we are going to focus\n" +
                    "on Email Phishing. Just like I explained what phishing is, email phing is the same thing\n" +
                    "but done via emails. With email phishing you will be getting fraudulent emails thinking they are\n" +
                    "coming from a trusted source.\n" +
                    "======================================= HOW THE ATTACK WORKS =========================================\n" +
                    "*You will get an email that uses a fear, curiosity, greed ,or ugency tactics\n" +
                    "   to get you to open the email.\n" +
                    "*You the email thinking it is safe and looks legitimate.\n" +
                    "*There will be a link in the email that you are urged to click\n" +
                    "*Once you click the link it will ask ou to perform an action such as login\n" +
                    "or download a file. once the action is performed the attackers have gained information.\n" +
                    "======================================= HOW TO PREVENT THE ATTACKS =========================================\n" +
                    "*Look at the link before you click it\n" +
                    "*Do not give out personal information on email\n" +
                    "*Monitor your online accounts.\n" },
        {"browsing","======================================= SAFE BROWSING =========================================\n" +
                    "Safe browsing is a service run by Google and is offerd on many browsers, this service is to\n" +
                    "find out if the website is safe or risky. The web browsers such as Chrome, FireFox, and Safari\n" +
                    "run this service so that they can alert you if the website that you are currently on is safe or dangerous\n" +
                    "======================================= TYPES OF RISKY WEBSITES =========================================\n" +
                    "*Phishing - This is when a website will mimick a real and legitimate website in hopes of getting\n" +
                    "   users to enter their personal information and it will be taken by the attackers.\n" +
                    "*Malware - These are sites that will try to get users to download malicious software\n" +
                    "   which will steal the users information or delete the information or hold the information\n" +
                    "   ransom until the user pays the ransom.\n" +
                    "======================================= PROTECTION FROM RISKY WEBSITES =========================================\n" +
                    "*Look at the URL link of the website, if the link starts with https then that is a secure\n" +
                    "   website because the 's' at teh end stands for secure and it shows that the website is legitimate.\n" +
                    "*Download a anti-virus software that offers protection against online attacks.\n" }

    };
    /*This counter will be used to navigate between the items of the List and give the
         * user new and random responses everytime
        */
    private static int counter = 0;
    public static List<string> scams = new List<string>()
    {
        {"*Most scams promise you finacial gains and it is a lie because it is relying on your desperation." },
        {"*Scams come in many ways, they can come through SMS, Whatsapp or even email. One thing they" +
            "all have in common is that they will target your emotions." },
        {"Scams rely on you not fact checking information." }
    };
    public static List<string> privacy = new List<string>()
    {
        {"In the modern day privacy is freedom since everyone is broadcasting themselves on the internet." },
        {"It is crucial to have privacy because it protects you from people having you information and it being sold." },
        {"Make sure you check the websites you log into and whether they are accessing your personal data." }
    };
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
            "cracked then all your accounts are at risk." },
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
            $"tricky to navigate and they make you \noverthink.To help you with your worry I will" +
            $"give you tips\nto help you out:" },
        {"curious",$"I am glad that you are curious {General.userName}. To help you with your curiosity " +
            $"I will give you more tips:"},
        {"frustrated",$"Feeling frustrated is normal. CyberSecurity is a bit complex and when you start" +
            "\nhearing more about it you get frustrated. Let me try giving you tips to calm your\n" +
            "frustration:" },
    };

    public static void Basic_Response()
    {
        /*This string variable is to control the while loop so that the user can remain in
        the loop and able to repeat requests until they type 'exit'
        */
        string run = "yes";

        while (run == "yes")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string userinput = Console.ReadLine();
            Console.ResetColor();
            storeFavourites(userinput);
            chooseResponse(userinput);
            sentimentResponse(userinput);

            while(memory == true || random == true || sentimentFeedback == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                userinput = Console.ReadLine();
                Console.ResetColor();
                memory = false;
                random = false;
                sentimentFeedback = false;
                storeFavourites(userinput);
                chooseResponse(userinput);
                sentimentResponse(userinput);

            }

            //Code Attribution
            //This method to use a string in a swicth-case was taken from stackoverflow
            //https://stackoverflow.com/questions/3853700/c-sharp-switch-case-string-starting-with
            //Raul Bojalil
            //https://stackoverflow.com/users/7550948/ra%c3%bal-bojalil

            //This input is change to lowercase making everything the same and easy to search through
            switch (userinput.ToLower())
                {
                    case string y when y.Contains("purpose"):
                        General.typingEffect("I am a chat bot that specialises in cyber security.\n" +
                            "I am here to assist you in understanding cyber security and give you tips on\n" +
                            "how to keep yourself safe and prevent any attacks from happening while on the internet.\n");
                        break;
                    case string z when z.Contains("how are you"):
                        General.typingEffect("I am great. How are you?");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.ReadLine();
                        Console.ResetColor();
                        General.typingEffect($"That is great to here\n");
                        break;
                    case string w when w.Contains("topics"):
                        General.typingEffect("The topics I currently have knowledge on are:" +
                        "\n--Password Safety" +
                        "\n--Phishing" +
                        "\n--Safe browsing\n" +
                        "\n--Scams\n"+
                        "\n--Privacy\n"+
                        "Type 'exit' to stop the chatbot\n");
                        break;
                    case string x when x.Contains("password"):
                    if (checkInterestTopic("password") == true)
                    {
                        General.typingEffect("I remember you were interested in the Password topic");
                    }
                        General.typingEffect(topics["password"]);

                        break;
                    case string x when x.Contains("phishing"):
                    if (checkInterestTopic("phishing") == true)
                    {
                        General.typingEffect("I remember you were interested in the Phishing topic");
                    }
                    General.typingEffect(topics["phishing"]);
                        break;
                    case string x when x.Contains("browsing"):
                    if (checkInterestTopic("browsing") == true)
                    {
                        General.typingEffect("I remember you were interested in the Safety Browsing topic");
                    }
                    General.typingEffect(topics["browsing"]);
                        break;
                    case string x when x.Contains("scam"):
                    if (checkInterestTopic("scam") == true)
                    {
                        General.typingEffect("I remember you were interested in the Scam topic");
                    }
                    General.typingEffect(scams[counter]);
                        break;
                    case string x when x.Contains("privacy"):
                    if (checkInterestTopic("privacy") == true)
                    {
                        General.typingEffect("I remember you were interested in the Privacy topic");
                    }
                    General.typingEffect(privacy[counter]);
                        break;
                case "exit":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Thank you, see you next time");
                        Console.ResetColor();
                        break;
                    case string x when x.Contains("phishing"):
                        General.typingEffect(topics["phishing"]);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        General.typingEffect("Sorry I did not get the request please enter again.\n");
                        Console.ResetColor();
                        break;
                }
            /*This if-statement will check if the user has typed 'exit' in order to determine 
            whether they stay in the loop or not
            */
            if (userinput == "exit")
            {
                run = "no";
            }


        }
    }
    public static bool checkInterestTopic(string input)
    {
        /*This method is here so that it can check through the profile List which stores the
         interested topics. This method will return an answer which will be used to determine 
        whether or not a user is interested in the topic and then give an appropriate response*/
        for (int i = 0; i<profile.Count;i++)
        {
            if (profile[i].Contains(input))
            {
                return true;
            }
        }
        return false;
    }

    //Code Attribution
    //This method is to add into a list
    //https://www.geeksforgeeks.org/c-sharp-list-class/
    //Geeksforgeeks
    ////https://www.geeksforgeeks.org/

    public static void storeFavourites(string input)
    {
        
        if (input.Contains("interested") || input.Contains("favourite") || input.Contains("interesting") || input.Contains("interesting")
            || input.Contains("cool") || input.Contains("like"))
        {
            switch (input)
            {
                case string x when x.Contains("password"):
                    profile.Add("password");
                    General.typingEffect($"I see {General.userName} like information regarding Password safety " +
                        "I will make sure to remember that.");
                    memory = true;
                break;

                case string x when x.Contains("phishing"):
                    profile.Add("phishing");
                    General.typingEffect($"I see {General.userName} like information regarding Phishing " +
                        "I will make sure to remember that.");
                    memory = true;
                    break;

                case string x when x.Contains("browsing"):
                    profile.Add("browsing");
                    General.typingEffect($"I see {General.userName} like information regarding Browsing Safety " +
                        "I will make sure to remember that.");
                    memory = true;
                    break;
                case string x when x.Contains("scam"):
                    profile.Add("scam");
                    General.typingEffect($"I see {General.userName} like information regarding Scams " +
                        "I will make sure to remember that.");
                    memory = true;
                    break;
                case string x when x.Contains("privacy"):
                    profile.Add("browsing");
                    General.typingEffect($"I see {General.userName} like information regarding Privacy " +
                        "I will make sure to remember that.");
                    memory = true;
                    break;

                default:
                break;
            }

        }
    }

    public static void chooseResponse(string input)
    {
        input = input.ToLower();
        if(input.Contains("tips") || input.Contains("more") || input.Contains("more information") || input.Contains("else") || input.Contains("advice"))
            switch (input)
        {
            case string x when x.Contains("password"):
                General.typingEffect(password[counter]);
                random = true;
                    counter++;
                 break;
            case string x when x.Contains("phishing"):
                General.typingEffect(phishing[counter]);
                random = true;
                    counter++;
                break;
            case string x when x.Contains("browsing"):
                General.typingEffect(browsing[counter]);
                random = true;
                    counter++;
                 break;
            case string x when x.Contains("scam"):
                General.typingEffect(scams[counter]);
                random = true;
                    counter++;
                 break;
            case string x when x.Contains("privacy"):
                General.typingEffect(privacy[counter]);
                random = true;
                    counter++;
                break;
        }
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
                General.typingEffect(sentiment["worried"]);
                
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
                sentimentFeedback = true;
                break;
            case string x when x.Contains("curious"):
                General.typingEffect(sentiment["curious"]);
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
                sentimentFeedback = true;
                break;
            case string x when x.Contains("frustrated"):
                General.typingEffect(sentiment["frustrated"]);
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
                sentimentFeedback = true;
                break;
            default:
                break;
        }

    }
}
