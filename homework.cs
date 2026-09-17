using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задание 1
//namespace homework
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("byte    - " + byte.MaxValue + " - " + byte.MinValue);
//            Console.WriteLine("sbyte   - " + sbyte.MaxValue + " - " + sbyte.MinValue);
//            Console.WriteLine("short   - " + short.MaxValue + " - " + short.MinValue);
//            Console.WriteLine("ushort  - " + ushort.MaxValue + " - " + ushort.MinValue);
//            Console.WriteLine("int     - " + int.MaxValue + " - " + int.MinValue);
//            Console.WriteLine("uint    - " + uint.MaxValue + " - " + uint.MinValue);
//            Console.WriteLine("long    - " + long.MaxValue + " - " + long.MinValue);
//            Console.WriteLine("ulong   - " + ulong.MaxValue + " - " + ulong.MinValue);
//            Console.WriteLine("float   - " + float.MaxValue + " - " + float.MinValue);
//            Console.WriteLine("double  - " + double.MaxValue + " - " + double.MinValue);
//            Console.WriteLine("decimal - " + decimal.MaxValue + " - " + decimal.MinValue);
//            Console.ReadKey();
//        }
//    }
//}

//Задание 2
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Имя: ");
//        string imya = Console.ReadLine();
//        Console.Write("Город: ");
//        string gorod = Console.ReadLine();
//        Console.Write("Возраст: ");
//        int vozrast = int.Parse(Console.ReadLine());
//        Console.Write("PIN-код: ");
//        string pin = Console.ReadLine();
//        Console.WriteLine();
//        Console.WriteLine("Имя: " + imya);
//        Console.WriteLine("Город: " + gorod);
//        Console.WriteLine("Возраст: " + vozrast);
//        Console.WriteLine("PIN-код: " + pin);
//        Console.ReadKey();
//    }
//}

//Задание 3
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите строку: ");
//        string s = Console.ReadLine();
//        string result = "";
//        foreach (char c in s)
//        {
//            if (char.IsUpper(c))
//                result += char.ToLower(c);
//            else if (char.IsLower(c))
//                result += char.ToUpper(c);
//            else
//                result += c;
//        }
//        Console.WriteLine("Результат: " + result);
//        Console.ReadKey();
//    }
//}

//Задание 4
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите строку: ");
//        string stroka = Console.ReadLine();
//        Console.Write("Введите подстроку: ");
//        string podstroka = Console.ReadLine();
//        int count = 0;
//        int index = 0;
//        while ((index = stroka.IndexOf(podstroka, index)) != -1)
//        {
//            count++;
//            index += podstroka.Length;
//        }
//        Console.WriteLine("Количество вхождений: " + count);
//        Console.ReadKey();
//    } 
//}

//Задание 5
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Обычная цена: ");
//        int normPrice = int.Parse(Console.ReadLine());
//        Console.Write("Скидка в Duty Free (%): ");
//        int salePrice = int.Parse(Console.ReadLine());
//        Console.Write("Стоимость отпуска: ");
//        int holidayPrice = int.Parse(Console.ReadLine());
//        int ekonomia = normPrice * salePrice / 100;
//        int butylok = holidayPrice / ekonomia;
//        Console.WriteLine("Нужно бутылок: " + butylok);
//        Console.ReadKey();
//    }
//}

//Задание 6
//enum Kategoria { A, B, C, D }
//struct Napitok
//{
//    public string Nazvanie;
//    public double ProcentSpirta;
//}
//struct Student
//{
//    public string Familiya;
//    public string Imya;
//    public int Id;
//    public DateTime DataRozhdeniya;
//    public Kategoria Kat;
//    public Napitok Napitok;
//    public double Obem;
//}

//class Program
//{
//    static void Main()
//    {
//        Student[] stud = new Student[5];
//        stud[0].Familiya = "Иванов"; stud[0].Imya = "Иван"; stud[0].Id = 1;
//        stud[0].DataRozhdeniya = new DateTime(2005, 3, 12); stud[0].Kat = Kategoria.A;
//        stud[0].Napitok.Nazvanie = "Пиво"; stud[0].Napitok.ProcentSpirta = 5;
//        stud[0].Obem = 3.5;
//        stud[1].Familiya = "Петров"; stud[1].Imya = "Пётр"; stud[1].Id = 2;
//        stud[1].DataRozhdeniya = new DateTime(2004, 7, 5); stud[1].Kat = Kategoria.B;
//        stud[1].Napitok.Nazvanie = "Вино"; stud[1].Napitok.ProcentSpirta = 12;
//        stud[1].Obem = 1.2;
//        stud[2].Familiya = "Сидоров"; stud[2].Imya = "Семён"; stud[2].Id = 3;
//        stud[2].DataRozhdeniya = new DateTime(2005, 11, 20); stud[2].Kat = Kategoria.C;
//        stud[2].Napitok.Nazvanie = "Водка"; stud[2].Napitok.ProcentSpirta = 40;
//        stud[2].Obem = 0.5;
//        stud[3].Familiya = "Кузнецов"; stud[3].Imya = "Кирилл"; stud[3].Id = 4;
//        stud[3].DataRozhdeniya = new DateTime(2003, 2, 14); stud[3].Kat = Kategoria.A;
//        stud[3].Napitok.Nazvanie = "Коньяк"; stud[3].Napitok.ProcentSpirta = 42;
//        stud[3].Obem = 0.7;
//        stud[4].Familiya = "Смирнов"; stud[4].Imya = "Сергей"; stud[4].Id = 5;
//        stud[4].DataRozhdeniya = new DateTime(2006, 9, 1); stud[4].Kat = Kategoria.D;
//        stud[4].Napitok.Nazvanie = "Сок"; stud[4].Napitok.ProcentSpirta = 0;
//        stud[4].Obem = 0;
//        double obshiyObem = 0;
//        double obshiySpirt = 0;
//        for (int i = 0; i < 5; i++)
//        {
//            obshiyObem += stud[i].Obem;
//            obshiySpirt += stud[i].Obem * stud[i].Napitok.ProcentSpirta / 100;
//        }
//        Console.WriteLine("Общий объём жидкости: " + obshiyObem.ToString("F2") + " л");
//        Console.WriteLine("Общий объём алкоголя: " + obshiySpirt.ToString("F3") + " л");
//        Console.WriteLine();
//        for (int i = 0; i < 5; i++)
//        {
//            double procentZh = stud[i].Obem / obshiyObem * 100;
//            double spirtStudenta = stud[i].Obem * stud[i].Napitok.ProcentSpirta / 100;
//            double procentSp = spirtStudenta / obshiySpirt * 100;
//            Console.WriteLine(stud[i].Familiya + " " + stud[i].Imya + " (" + stud[i].Kat + ")");
//            Console.WriteLine("  Жидкость: " + procentZh.ToString("F1") + "%");
//            Console.WriteLine("  Алкоголь: " + procentSp.ToString("F1") + "%");
//        }
// Console.ReadKey();
//    }
//}
