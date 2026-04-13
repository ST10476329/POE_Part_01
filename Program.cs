using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace POE_Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string audioPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Welcome_Rec.wav");
            SoundPlayer player = new SoundPlayer(audioPath); // this allows the compiler to play my recording anywhere


            try
            {
                player.Play();
                Console.WriteLine("Cyber Security Awareness");
                Console.WriteLine("Playing greeting message...");
            }
            catch (Exception e) // introduced exceptions just in case the audio was not found 
            {
                Console.WriteLine($"There was a problem playing the audio: {e.Message}");
            }

            ClassArray.DrawLine(); // method to create borders 
            Console.WriteLine("               CYBER   SECURITY   BOT");
            ClassArray.DrawLine();

            string name = ClassArray.nameValidation(); // this method handles user input gracefully ensuring my program does not break 

            Console.Clear();
            ClassArray.displayLogo(); // the method used to display the ASCII art 
            ClassArray.DrawLine();

            Console.WriteLine($"\n[CHATBOT] : Hello there {name.ToUpper()}, how can I help you today?");

            string[] keywords = { "how are you", "purpose", "about", "password", "phishing", "browsing" };
            string[] response = {
                "I'm doing very well, thanks! :)",
                "I'm here to tell you more about cyber security.",
                "You can ask me anything regarding cyber security topics.",
                "Password safety is vital. Use a mix of uppercase, lowercase, symbols, and numbers.",
                "Phishing involves criminals stealing data via fake emails. Never click suspicious links!",
                "To keep data secure on new websites, check for HTTPS and consider incognito mode."
            };

            bool keepchatting = true;

            while (keepchatting)
            {
                ClassArray.printHeader("Conversation");
                Console.WriteLine("You may ask me anything regarding phishing, passwords, web browsing and also what my purpose is! (or type 'exit' to quit)");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"{name} > ");
                string question = Console.ReadLine()?.ToLower().Trim() ?? "";
                if (question == "exit") // if the user types exit to program should end if not it should continue
                {
                    keepchatting = false;
                    continue;
                }
                Console.ResetColor();

                bool found = false;
                for (int i = 0; i < keywords.Length; i++)
                {
                    if (question.Contains(keywords[i])) // this checks for full phrases first and then checks for single keywords unlike split that only checks for keywords 
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"Chatbot: {response[i]}");
                        Console.ResetColor();
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Chatbot: I didn't quite understand that. Could you rephrase.");
                }

                ClassArray.DrawLine();
            }

            Console.WriteLine("\nThank you for using the Cyber Security Bot. Stay safe online!");
            Console.ReadKey();
        }

    }
}

