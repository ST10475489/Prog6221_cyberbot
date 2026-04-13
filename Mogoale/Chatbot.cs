using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mogoale
{
    class Chatbot
    {
        private AudioPlayer audio = new AudioPlayer();

        public void Start()
        {
            ShowLogo();

            Console.WriteLine("playing recording");
            audio.PlayMusic("Recording2.WAV");//the recording file
            Console.WriteLine("Finished playing recording");

            Console.Write("Enter name: ");
            string Name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==================================");
            Console.WriteLine("Welcome " + Name + " to Cybersecurity chat bot");
            Console.WriteLine("==================================");
            Console.ResetColor();

            Console.WriteLine("Welcome " + Name);
            Console.WriteLine("Bot: Hello " + Name + " you are talking to chatbot");


            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("=======================================");
                Console.WriteLine("Bot: (type 'exit' to quit): ");
                Console.WriteLine("=======================================");
                Console.ResetColor();

                Console.Write("Bot: ask me anything, what would you like to know? ");
                string input = Console.ReadLine().ToLower();//covert to input to lower case

                if (input == "exit")//for when the user enters exit, the application ends
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("==================================");
                    Console.WriteLine("Bot: Goodbye " + Name + " ! Stay safe online!");
                    Console.WriteLine("==================================");
                    Console.ResetColor();
                    break;
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine(Responses.GetResponse(input));

                Console.WriteLine("--------------------------------------------------");
                Console.ResetColor();
            }

            Console.ReadKey();
        }


        //for the logo to display at the head when the application runs. Ascii art logo
        private void ShowLogo()
        {
            Console.WriteLine("+--------------------------------------------------------------------+\r\n|            _                                        _ _            |\r\n|  ___ _   _| |__   ___ _ __ ___  ___  ___ _   _ _ __(_) |_ _   _    |\r\n| / __| | | | '_ \\ / _ \\ '__/ __|/ _ \\/ __| | | | '__| | __| | | |   |\r\n|| (__| |_| | |_) |  __/ |  \\__ \\  __/ (__| |_| | |  | | |_| |_| |   |\r\n| \\___|\\__, |_.__/ \\___|_|  |___/\\___|\\___|\\__,_|_|  |_|\\__|\\__, |   |\r\n|  __ _|___/   ____ _ _ __ ___ _ __   ___  ___ ___  | |__   |___/ |_ |\r\n| / _` \\ \\ /\\ / / _` | '__/ _ \\ '_ \\ / _ \\/ __/ __| | '_ \\ / _ \\| __||\r\n|| (_| |\\ V  V / (_| | | |  __/ | | |  __/\\__ \\__ \\ | |_) | (_) | |_ |\r\n| \\__,_| \\_/\\_/ \\__,_|_|  \\___|_| |_|\\___||___/___/ |_.__/ \\___/ \\__||\r\n+--------------------------------------------------------------------+");
        }
    }
}