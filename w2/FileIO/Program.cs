using System;
using System.IO;
using System.Text;

namespace FileIO
{
    public class Program
    {
        public static void Main()
        {
            string[] prompts = File.ReadAllLines("./questions.txt");
            StringBuilder userAnswers = new StringBuilder();
            User user = new User();

            Console.WriteLine("Do you exist?");
            if (Console.ReadLine() == "yes")
            {
                if (File.ReadAllLines(user.userPath) != null)
                {
                    user.GetUser();
                }
                else
                {
                    Console.WriteLine("No you don't");
                }
            }
            else
            {
                for (int i = 0; i < prompts.Length; i++)
                {

                    Console.WriteLine(prompts[i]);
                    string answer = Console.ReadLine();
                    if (i == (prompts.Length - 1))
                    {
                        userAnswers.Append(answer);
                    }
                    else
                    {
                        userAnswers.Append(answer + ", ");
                    }
                }
                user.SaveUser(userAnswers.ToString());
            }
        }
    }
}
/*
            string[] prompts = File.ReadAllLines("./questions.txt");
            string[] userAnswers = new string[prompts.Length];
            User user = new User();

            for (int i = 0; i < prompts.Length; i++)
            {

                Console.WriteLine(prompts[i]);
                string answer = Console.ReadLine();
                if (i == (prompts.Length - 1))
                {
                    userAnswers[i] = answer;
                }
                else
                {
                    userAnswers[i] = (answer + ", ");
                }
            }
            user.SaveUser(userAnswers);
*/