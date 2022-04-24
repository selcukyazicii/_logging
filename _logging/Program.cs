using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _logging
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Lütfen sayı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi>=10 && sayi<=50)
                {
                    throw new Exception("Sayı 10 ile 50 arasında olmamalıdır");
                }
                else
                {
                    throw new Exception("Sayı şartlara uygundur,giriş yapılabilir.");
                }
            }
            catch (Exception error)
            {
                File.AppendAllText("log.txt", Environment.MachineName);
                File.AppendAllText("log.txt", Environment.NewLine);
                File.AppendAllText("log.txt", Environment.UserName);
                File.AppendAllText("log.txt", DateTime.Now.ToString("dd.MM.yyyy HH:mm"));
                File.AppendAllText("log.txt", "\r\n");
                File.AppendAllText("log.txt", error.Message);
                File.AppendAllText("log.txt", error.StackTrace);
                File.AppendAllText("log.txt", Environment.NewLine+"************"+Environment.NewLine);
            }
        }
    }
}
