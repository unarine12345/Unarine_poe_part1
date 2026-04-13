using System;
using System.Collections;

namespace Unarine_poe_part1
{
    public class chats
    {
        ArrayList answers = new ArrayList();
        ArrayList ignoring = new ArrayList();

        public void ai_chats(string name)
        {
            answers.Add("cybersecurity is the practice of protecting computers, networks, and data from attacks");
            answers.Add("a strong password should include letters, numbers, and symbols");
            answers.Add("never share your password with anyone, even friends");
            answers.Add("phishing emails often look real but are designed to steal your information");
            answers.Add("always check website links before entering personal details");
            answers.Add("public Wi-Fi can be unsafe for banking or logging into accounts");
            answers.Add("two-factor authentication adds extra security to your accounts");
            answers.Add("do not click on unknown links or pop-ups");
            answers.Add("update your software regularly to protect against viruses");
            answers.Add("malware is software designed to harm your device");
            answers.Add("a firewall helps block unauthorized access to your system");
            answers.Add("avoid downloading files from unknown sources");
            answers.Add("log out of accounts when using public computers");
            answers.Add("use antivirus software to protect your device");
            answers.Add("social engineering is when attackers trick people into giving information");
            answers.Add("backup your data regularly in case of attacks or loss");
            answers.Add("never enter personal details on suspicious websites");
            answers.Add("hackers try to exploit weak passwords to access accounts");
            answers.Add("be careful of messages asking for urgent action or money");
            answers.Add("cybersecurity helps protect your identity online");

            ignoring.Add("what");
            ignoring.Add("is");
            ignoring.Add("a");
            ignoring.Add("the");
            ignoring.Add("and");
            ignoring.Add("of");
            ignoring.Add("to");
            ignoring.Add("in");
            ignoring.Add("about");

            string asking = string.Empty;

            do
            {
                Console.Write(name + " : ");
                asking = Console.ReadLine();

                while (string.IsNullOrWhiteSpace(asking))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("ChatBot: Please enter a question.");
                    Console.ResetColor();

                    Console.Write(name + " : ");
                    asking = Console.ReadLine();
                }

            } while (end_chat(asking));
        }

        private bool end_chat(string question)
        {
            if (question.ToLower() == "exit")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ChatBot: Bye..");
                Console.ResetColor();
                return false;
            }

            string[] words = question.ToLower().Split(' ');
            bool foundAny = false;

            foreach (string answer in answers)
            {
                foreach (string word in words)
                {
                    if (!ignoring.Contains(word) && answer.ToLower().Contains(word))
                    {

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("ChatBot: ");


                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(answer);

                        Console.ResetColor();

                        foundAny = true;
                        break;
                    }
                }
            }

            if (!foundAny)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("ChatBot: ");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Sorry, I don't understand. Try asking about cybersecurity.");

                Console.ResetColor();
            }

            return true;
        }
    }
}