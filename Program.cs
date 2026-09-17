//Упражнение 3.1
//using System;
//enum VidScheta { Tekushiy, Sberegatelniy }
//class Program
//{
//    static void Main()
//    {
//        VidScheta schet = VidScheta.Sberegatelniy;
//        Console.WriteLine("Вид счёта: " + schet);
//        Console.ReadKey();
//    }
//}

//Упражнение 3.2
//using System;
//enum VidScheta { Tekushiy, Sberegatelniy }
//struct Schet
//{
//    public string Nomer;
//    public VidScheta Vid;
//    public decimal Balans;
//}
//class Program
//{
//    static void Main()
//    {
//        Schet s;
//        s.Nomer = "40817810099910004312";
//        s.Vid = VidScheta.Sberegatelniy;
//        s.Balans = 15000.50m;
//        Console.WriteLine("Номер счёта: " + s.Nomer);
//        Console.WriteLine("Вид счёта: " + s.Vid);
//        Console.WriteLine("Баланс: " + s.Balans.ToString("F2") + " руб.");
//        Console.ReadKey();
//    }
//}

//Домашнее задание 3.1
//using System;
//enum VUZ { KFU, KAI, KHTI }
//struct Rabotnik
//{
//    public string Imya;
//    public VUZ Vuz;
//}
//class Program
//{
//    static void Main()
//    {
//        Rabotnik r;
//        r.Imya = "Насыбулина Эльвина";
//        r.Vuz = VUZ.KFU;
//        Console.WriteLine("Имя: " + r.Imya);
//        Console.WriteLine("ВУЗ: " + r.Vuz);
//        Console.ReadKey();
//    }
//}