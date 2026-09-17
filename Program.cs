//using System;
//namespace Class
//{
//    class Program
//    {
//        static void Main()
//        { } }
////    //Задание 0
//    byte oxygenLevel = 250;
//    byte extraOxygen = 10;
//    byte result = (byte)(oxygenLevel + extraOxygen);
//    Console.WriteLine(oxygenLevel);
//    Console.WriteLine(extraOxygen);
//    Console.WriteLine(result);
//    Console.WriteLine(oxygenLevel + extraOxygen);
//}

//Задание 1 Анкета космонавта
//using System;
//using System.Globalization;

//class Program
//{
//    class Candidate
//    {
//        public string Name = "";
//        public int Age;
//        public decimal Height;
//        public decimal Weight;
//        public string FavoriteMovie = "";
//    }
//    static void Main()
//    {
//        var candidate = new Candidate
//        {
//            Name = ReadText("Имя: "),
//            Age = ReadInt("Возраст: "),
//            Height = ReadDecimal("Рост в метрах: "),
//            Weight = ReadDecimal("Вес в килограммах: "),
//            FavoriteMovie = ReadText("Любимый фильм про космос: ")
//        };
//        Console.WriteLine($"Имя:           {candidate.Name}");
//        Console.WriteLine($"Возраст:       {candidate.Age} лет");
//        Console.WriteLine($"Рост:          {candidate.Height:0.##} м");
//        Console.WriteLine($"Вес:           {candidate.Weight:0.##} кг");
//        Console.WriteLine($"Любимый фильм: {candidate.FavoriteMovie}");
//    }
//    static string ReadText(string message)
//    {
//        while (true)
//        {
//            Console.Write(message);
//            string value = Console.ReadLine()?.Trim() ?? "";
//            if (value.Length > 0)
//                return value;
//            Console.WriteLine("Значение не должно быть пустым.");
//        }
//    }
//    static int ReadInt(string message)
//    {
//        while (true)
//        {
//            Console.Write(message);
//            if (int.TryParse(Console.ReadLine(), out int value) && value >= 0)
//                return value;
//            Console.WriteLine("Введите целое неотрицательное число.");
//        }
//    }
//    static decimal ReadDecimal(string message)
//    {
//        while (true)
//        {
//            Console.Write(message);
//            string input = (Console.ReadLine() ?? "").Replace(',', '.');
//            if (decimal.TryParse(
//                    input,
//                    NumberStyles.Float,
//                    CultureInfo.InvariantCulture,
//                    out decimal value) && value >= 0)
//            {
//                return value;
//            }

//            Console.WriteLine("Введите корректное число, например 1.75.");
//        }
//    }
//}
//Задание 2 Билет на поезд

//using System;
//using System.Globalization;
//enum CarriageType { Плацкарт = 1, Купе, СВ, Люкс }
//class Ticket
//{
//    public string Passenger { get; set; }
//    public string Train { get; set; }
//    public DateTime Departure { get; set; }
//    public CarriageType Carriage { get; set; }
//    public decimal Price { get; set; }
//    public void Print() => Console.WriteLine(
//        $"\nБилет:\nПассажир: {Passenger}\nПоезд: {Train}\n" +
//        $"Отправление: {Departure:dd.MM.yyyy HH:mm}\n" +
//        $"Вагон: {Carriage}\nЦена: {Price:F2} руб.");
//}
//class Program
//{
//    static string Read(string prompt) { Console.Write(prompt); return Console.ReadLine(); }

//    static T ReadValue<T>(string prompt, Func<string, T> parser)
//    {
//        while (true)
//        {
//            try { return parser(Read(prompt)); }
//            catch { Console.WriteLine("Ошибка! Попробуйте снова."); }
//        }
//    }
//    static void Main()
//    {
//        var ticket = new Ticket
//        {
//            Passenger = Read("ФИО: "),
//            Train = Read("Номер поезда: "),
//            Departure = ReadValue("Дата и время (дд.ММ.гггг чч:мм): ",
//                s => DateTime.ParseExact(s, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture)),
//            Carriage = ReadValue("Тип вагона (1-Плацкарт, 2-Купе, 3-СВ, 4-Люкс): ",
//                s => (CarriageType)int.Parse(s)),
//            Price = ReadValue("Цена: ",
//                s => decimal.Parse(s.Replace('.', ',')))
//        };
//        ticket.Print();
//        Console.ReadKey();
//    }
//}
//Задание 3 Аренда автомобиля
//using System;
//using System.Globalization;
//enum Klass { Ekonom = 1, Komfort, Biznes, Premium }
//class Arenda
//{
//    public string Klient;
//    public string Marka;
//    public Klass KlassAvto;
//    public DateTime Nachalo;
//    public DateTime Konec;
//    public decimal CenaZaSutki;
//    public void Pechat()
//    {
//        int dney = (Konec - Nachalo).Days;
//        decimal itogo = dney * CenaZaSutki;
//        Console.WriteLine();
//        Console.WriteLine("Договор аренды:");
//        Console.WriteLine("Клиент: " + Klient);
//        Console.WriteLine("Автомобиль: " + Marka);
//        Console.WriteLine("Класс: " + KlassAvto);
//        Console.WriteLine("Начало: " + Nachalo.ToString("dd.MM.yyyy"));
//        Console.WriteLine("Окончание: " + Konec.ToString("dd.MM.yyyy"));
//        Console.WriteLine("Дней: " + dney);
//        Console.WriteLine("Цена за сутки: " + CenaZaSutki.ToString("F2") + " руб.");
//        Console.WriteLine("Итого: " + itogo.ToString("F2") + " руб.");
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        Arenda a = new Arenda();
//        Console.Write("Введите имя клиента: ");
//        a.Klient = Console.ReadLine();
//        Console.Write("Введите марку автомобиля: ");
//        a.Marka = Console.ReadLine();
//        Console.WriteLine("Выберите класс автомобиля:");
//        Console.WriteLine("1 - Эконом");
//        Console.WriteLine("2 - Комфорт");
//        Console.WriteLine("3 - Бизнес");
//        Console.WriteLine("4 - Премиум");
//        int vibor;
//        while (true)
//        {
//            Console.Write("Ваш выбор: ");
//            if (int.TryParse(Console.ReadLine(), out vibor) && vibor >= 1 && vibor <= 4)
//                break;
//            Console.WriteLine("Ошибка, введите число от 1 до 4");
//        }
//        a.KlassAvto = (Klass)vibor;
//        while (true)
//        {
//            Console.Write("Введите дату начала (дд.мм.гггг): ");
//            string s = Console.ReadLine();
//            if (DateTime.TryParseExact(s, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out a.Nachalo))
//                break;
//            Console.WriteLine("Ошибка, введите дату в формате дд.мм.гггг");
//        }
//        while (true)
//        {
//            Console.Write("Введите дату окончания (дд.мм.гггг): ");
//            string s = Console.ReadLine();
//            if (DateTime.TryParseExact(s, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out a.Konec))
//                break;
//            Console.WriteLine("Ошибка, введите дату в формате дд.мм.гггг");
//        }
//        while (true)
//        {
//            Console.Write("Введите стоимость за сутки: ");
//            string s = Console.ReadLine().Replace('.', ',');
//            if (decimal.TryParse(s, out a.CenaZaSutki))
//                break;
//            Console.WriteLine("Ошибка, введите число");
//        }
//        a.Pechat();
//        Console.ReadKey();
//    }
//}
//Задание 4 Данные студента

//using System;
//using System.Globalization;
//enum Fakultet { IT = 1, Ekonomika, Yurisprudentsiya, Dizain }
//class Student
//{
//    public string Fio;
//    public string Zachetka;
//    public Fakultet Fak;
//    public int Kurs;
//    public double SredniyBall;
//    public DateTime DataZachisleniya;
//    public void Pokazat()
//    {
//        Console.WriteLine();
//        Console.WriteLine("Карточка студента:");
//        Console.WriteLine("ФИО: " + Fio);
//        Console.WriteLine("Зачётная книжка: " + Zachetka);
//        Console.WriteLine("Факультет: " + Fak);
//        Console.WriteLine("Курс: " + Kurs);
//        Console.WriteLine("Средний балл: " + SredniyBall.ToString("F2"));
//        Console.WriteLine("Дата зачисления: " + DataZachisleniya.ToString("dd.MM.yyyy"));
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        Student st = new Student();
//        Console.Write("Введите ФИО: ");
//        st.Fio = Console.ReadLine();
//        Console.Write("Введите номер зачётки: ");
//        st.Zachetka = Console.ReadLine();
//        Console.WriteLine("Выберите факультет:");
//        Console.WriteLine("1 - ИТ");
//        Console.WriteLine("2 - Экономика");
//        Console.WriteLine("3 - Юриспруденция");
//        Console.WriteLine("4 - Дизайн");
//        int vibor;
//        while (true)
//        {
//            Console.Write("Ваш выбор: ");
//            if (int.TryParse(Console.ReadLine(), out vibor) && vibor >= 1 && vibor <= 4)
//                break;
//            Console.WriteLine("Ошибка, введите число от 1 до 4");
//        }
//        st.Fak = (Fakultet)vibor;
//        while (true)
//        {
//            Console.Write("Введите курс: ");
//            if (int.TryParse(Console.ReadLine(), out st.Kurs))
//                break;
//            Console.WriteLine("Ошибка, введите число");
//        }
//        while (true)
//        {
//            Console.Write("Введите средний балл: ");
//            string s = Console.ReadLine().Replace('.', ',');
//            if (double.TryParse(s, out st.SredniyBall))
//                break;
//            Console.WriteLine("Ошибка, введите число");
//        }
//        while (true)
//        {
//            Console.Write("Введите дату зачисления (дд.мм.гггг): ");
//            string s = Console.ReadLine();
//            if (DateTime.TryParseExact(s, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out st.DataZachisleniya))
//                break;
//            Console.WriteLine("Ошибка, введите дату в формате дд.мм.гггг");
//        }
//        st.Pokazat();
//        Console.ReadKey();
//    }
//}