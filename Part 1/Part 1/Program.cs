using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using NAudio.Wave;

namespace Part_1
{
    internal class Program
    {
        // Function for voice message
        static void VoiceMessage()
        {
            try
            {
                // Initialize the sound player with the path to your greeting audio
                SoundPlayer Greetings = new SoundPlayer("C:\\Users\\Dam!LoLa\\Desktop\\Part 1\\Part 1\\Part 1\\Voice message.wav");
                Greetings.PlaySync(); // Play the audio synchronously, ensuring the greeting finishes before continuing
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing greeting: " + ex.Message);
            }
        }

        // Function to display the ASCII logo for the "Cyber Security Awareness Bot"
        static void Logodisplay()
        {
            Console.Clear();
            string logo = @"                                                                    
            (          )                                            
            )\ (    ( /(   (  (                                     
          (((_))\ ) )\()) ))\ )(                                    
          )\__(()/(((_)\ /((_(()\                                   
         ((/ __)(_)| |(_(_))  ((_)                                  
          | (_| || | '_ / -_)| '_|                                  
           \(__\_, |_.__\___||_|                                    
            )\ )__/                   )                             
           (()/(  (       (  (  (  ( /((                            
            /(_))))\ (   ))\ )( )\ )\())\ )                         
           (_)) /((_))\ /((_(()((_(_))(()/(                         
           / __(_)) ((_(_))( ((_(_| |_ )(_))                        
         ( \__ / -_/ _|| || | '_| |  _| || |           (         )  
         )\|___(__(\__| \),(|_| |(|\__|\_, (         ( )\     ( /(  
      ((((_)(  )\))(  ( /( )(   ))\ (  |__))\(  (    )((_) (  )\()) 
       )\ _ )\((_)()\ )(_)(()\ /((_))\ ) /((_)\ )\  ((_)_  )\(_))/  
       (_)_\(__(()((_((_)_ ((_(_)) _(_/((_))((_((_)  | _ )((_| |_   
        / _ \ \ V  V / _` | '_/ -_| ' \)/ -_(_-(_-<  | _ / _ |  _|  
       /_/ \_\ \_/\_/\__,_|_| \___|_||_|\___/__/__/  |___\___/\__|  
                                                                    
            ";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(logo);
            Console.ForegroundColor = ConsoleColor.Cyan;
            
            Console.ResetColor();
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();  // Wait for user input to proceed
        }

        // Function for user name and deco
        static void GreetingsAndUserinteraction()
        {
            // Ask for the user's name
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Please enter your name: ");
            Console.ResetColor();
            string clientName = Console.ReadLine();

            // name validation
            while (string.IsNullOrWhiteSpace(clientName))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.WriteLine("Please provide a valid name.");
                Console.ResetColor();
                Console.Write("Please enter your name: ");
                clientName = Console.ReadLine();
            }

            // Welcome the user with a welcoming message
            string DecorativeBorder = new string('*', 50);
            Console.WriteLine(DecorativeBorder);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nWelcome, {clientName}! I'm Here To Help You Stay Safe Online\n");
            Console.ResetColor();
            Console.WriteLine(DecorativeBorder);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            


            while (true)
            {
                Console.WriteLine($"\nbot:\n How can I assist you today?\n enter 'exit' to Close ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.Write($"\n{clientName}:");
                Console.ResetColor();
                string clientInput = Console.ReadLine().ToLower();



                // Exit condition
                if (clientInput == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n{clientName}, Stay safe, Be safe");
                    Console.ResetColor();
                    break;
                }



                // Responses to basic cybersecurity-related user questions.
                else if (clientInput.Contains("how are you"))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("bot: I'm just a bot, here to Help you stay safe online.");
                    Console.ResetColor();
                }
                else if (clientInput.Contains("what's your purpose") || clientInput.Contains("what is your purpose"))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("bot: that will be helping you stay safe online.");
                    Console.ResetColor();
                }
                else if (clientInput.Contains("what can i ask you about"))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("bot: Anything around cybersecurity questions! e.g: password safety, phishing, and safe browsing");
                    Console.ResetColor();
                }
                else if (clientInput.Contains("password safety"))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nNice one!");
                    Console.WriteLine("bot: You simply must make use of long, unique passwords for your account/s.");
                    Console.ResetColor();
                }
                else if (clientInput.Contains("phishing"))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nNice one!");
                    Console.WriteLine("bot: Phishing attacks involve unreal mails or sites that tricks you into sharing personal information.");
                    Console.WriteLine("bot: prevention will be to Always verify the sender's email address and avoid clicking on suspicious links.");
                    Console.ResetColor();
                }
                else if (clientInput.Contains("safe browsing"))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nNice one!");
                    Console.WriteLine("bot: For safe browsing, make use of a secure internet connection, avoid clicking on just any pop-ups.");
                    Console.ResetColor();
                }
                else if (string.IsNullOrWhiteSpace(clientInput))
                {
                    // validation for white space
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("bot: I didn't quite understand that. Could you rephrase?");
                    Console.ResetColor();
                }
                else
                {
                    // default response
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"bot: I'm here to help, {clientName}! I didn't quite understand that. Could you rephrase?");
                    Console.ResetColor();

                }

                // divider between questions
                Console.WriteLine("\n====================  ====================  ====================");
            
        }
            



        }





        static void Main(string[] args)
        {
            // Play greeting sound when application starts
            VoiceMessage();

            //displays the logo
            Logodisplay();

            //welcoming and interactive experience
            GreetingsAndUserinteraction();
        }
    }
}
