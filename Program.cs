using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


namespace Classwork_7
{
    class Program
    {
        public static string ReverseString(string str)
        {
            return new string(str.Reverse().ToArray());

        }
        public static void SearchMail(ref string mail)
        {
            mail = mail.Split('#').Last();
        }
        static bool CheckInterface(Object obj)
        {
            return obj is IFormattable;
        }
        static void Main(string[] args)
        {
            Bank lupa = new Bank();
            lupa.PutItOnTheAccount(644);
            Bank pupa = new Bank();
            pupa.PutItOnTheAccount(10);
            pupa.Transfer(ref lupa, 14);
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            str = ReverseString(str);
            Console.WriteLine(str);
            Console.WriteLine("Задание 3");
            string name = Console.ReadLine();
            if (File.Exists(name))
            {
                string[] test = File.ReadAllLines(name);
                for (int i = 0; i < test.Length; i++)
                {
                    test[i] = test[i].ToUpper();
                }
                File.WriteAllLines("output.txt", test);
            }
            else
            {
                Console.WriteLine("Нет файла с таким названием");
            }
            string path = "mail 1.txt";
            if (File.Exists(path))
            {
                string[] test = File.ReadAllLines(path);
                for (int i = 0; i < test.Length; i++)
                {
                    SearchMail(ref test[i]);
                }
                File.WriteAllLines("mail 2.txt", test);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
            List<Song> songs = new List<Song>();
            Console.WriteLine("8.2");
            songs.Add(new Song("Beat it", "Fall Out Boy", null));
            songs.Add(new Song("Batarei", "Nervy", songs[0]));
            songs.Add(new Song("Schast'e", "Animal jazz", songs[1]));
            songs.Add(new Song("Lesnik", "KoroliShut", songs[2]));
            foreach (Song item in songs)
            {
                Console.WriteLine(item.Title());
            }
            int x = 0, y = 1;
            if (Equals(songs[y], songs[x]))
            {
                Console.WriteLine("Одна и та же песня");
            }
            else
            {
                Console.WriteLine("Разные песни");
            }
            Console.WriteLine("Задание ");
            Console.WriteLine(CheckInterface("")); 
            Console.WriteLine(CheckInterface(1)); 

        }
    }
}

