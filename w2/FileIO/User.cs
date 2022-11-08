using System;
using System.IO;
using System.Text;

namespace FileIO
{
    public class User
    {
        public string userPath = "./userInfo.txt";
        public User(){}

        public void SaveUser(string userAnswers)
        {
            File.AppendAllText(userPath, userAnswers.ToString() + Environment.NewLine);
        }

        public void GetUser()
        {
            StringBuilder userOut = new StringBuilder();
            string[] foundUsers = File.ReadAllLines(userPath);
            string[][] userIn = new string[foundUsers.Length][];

            for(int i = 0; i < foundUsers.Length; i++)
            {
                string[] temp = foundUsers[i].Split(", ");
                for(int j = 0; j < temp.Length; j++)
                {
                    //Console.WriteLine()
                    userIn[i][j] = temp[j];
                    userOut.Append(userIn[i][j]);// + " " + temp[j] + " ");
                }
            }


            Console.WriteLine(userOut.ToString());

        }
    }
}