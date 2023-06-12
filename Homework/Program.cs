using ConsoleApp1.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;
using System.Text;
using System.Runtime.CompilerServices;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();
            Random random= new Random();
            
            WritingTools[] writingTools = new WritingTools[10];

            
            for (int i = 0; i < writingTools.Length; i++)
            {
                int randomValue = random.Next(1, 4); 

                switch (randomValue)
                {
                    case 1:
                        writingTools[i] = new Pencil();
                        break;
                    case 2:
                        writingTools[i] = new FeltPen();
                        break;
                    case 3:
                        writingTools[i] = new Pen();
                        break;
                }
            }
           

            //Передача StringBudilder в функцию Write и стирание символа
            for (int i = 0; i < 10; i++)
            {
                foreach (WritingTools writingtool in writingTools)
                {
                    char[] randomArray = GenerateRandomText(random.Next(3, 6));
                    writingtool.Write(sb, randomArray);
                    writingtool.Erase(sb);
                    
                }
            }
            Array.Sort(writingTools, (x , y) => y.Remainder.CompareTo(x.Remainder));

            foreach (WritingTools writingtool in writingTools )
            {
                Console.WriteLine($"The rest of the writing medium in {writingtool.GetType().Name} : {writingtool.Remainder}%");
            }

        }
        

        static char[] GenerateRandomText(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] randomText = new char[length];
            for (int i = 0; i < length; i++)
            {
                randomText[i] = chars[random.Next(chars.Length)];
            }
            return randomText;

        }

       

       









    }
}





























