class Program
{
    //ПЕРЕМЕННЫЕ И КОНСТАНТЫ

    //ОбЪявление переменной
    //тип_переменной имя_переменной;

    //Присвоение значения переменной
    //имя_переменной = значение или литерал;

    //Объявление переменной и присвоение значения переменной
    //тип_переменной имя_переменной = значение или литерал;

    //Объявление константы и присвоение значения константы
    //const тип_константы имя_константы = значение или литерал;

    //КОНСОЛЬ
    //Консольный вывод
    //Console.WriteLine(); Console.Write(); 
    //Итерполяция ($"Имя: {name}")
    //PlaceHolders ("Имя: {0}", name)
    //Форматирование вывода
    //целочисленная_переменная.ToString("+#(###)###-##-##");

    //ЛИТЕРАЛЫ

    //Логические литералы
    //Правда(true) и неправда(flase) 

    //Вещественные литералы
    //Вещественные числа или экспоненциальная форма
    //10.2 или 1.02E1
    //0.0001 или 1E-4
    //Экспоненциальная форма: MEp мантисса, экспонента, порядок

    //Символьные литералы
    //Символы: 'A','B'...
    //Управляющие последовательности
    //'\n' - перевод строки, '\t' - табуляция, '\\' - слеш

    //Строковые литералы
    //Строки "Hello"
    //Кавычка "\""

    //null

    //ТИПЫ ДАННЫХ
    //bool,byte,sbyte,short,ushort,int,uint,long,ulong,float,double,decimal,char,string,object
    //Суффиксы F|M|U|L|UL
    //Использование системных типов
    //Неявная типизация var

    //Вспомогательные методы типов
    //typeof(), sizeof()

    //Консольный ввод
    //Console.ReadLine(); Console.Read();
    //String? Условный null

    //ЗАДАЧИ:
    //1.
    //Покупатель купил в магазине 3 упаковки шоколада по 35 рублей 25 копеек,
    //2 упаковки молока по 51 рублю 42 копейки
    //и 2 батона хлеба по 21 рублю 40 копеек. Какова сумма покупок?

    //2. 
    //Создание таблицы вывода информации всех типов данных
    const string numberFormat = "+#(###)###-##-##";
    static void Main(string[] args)
    {
        Console.Title = "Типы данных";
        long number = 79225795696;
        Console.WriteLine(number.ToString(numberFormat));

        string info = "{0}:\tМаксимальное значение: {1,30}\tМинимальное значение: {2,30} \tРазмер в памяти: {3} байт";

        Console.WriteLine("\nЛогические типы:");
        Console.WriteLine("bool\t" + info, typeof(bool), bool.TrueString, bool.FalseString, sizeof(bool));
        
        Console.WriteLine("\nЦелочисленные типы:");
        Console.WriteLine("byte\t" + info, typeof(byte), byte.MaxValue, byte.MinValue, sizeof(byte));
        Console.WriteLine("sbyte\t" + info, typeof(sbyte), sbyte.MaxValue, sbyte.MinValue, sizeof(sbyte));
        Console.WriteLine("short\t" + info, typeof(short), short.MaxValue, short.MinValue, sizeof(short));
        Console.WriteLine("ushort\t" + info, typeof(ushort), ushort.MaxValue, ushort.MinValue, sizeof(ushort));
        Console.WriteLine("int\t" + info, typeof(int), int.MaxValue, int.MinValue, sizeof(int));
        Console.WriteLine("uint\t" + info, typeof(uint), uint.MaxValue, uint.MinValue, sizeof(uint));
        Console.WriteLine("long\t" + info, typeof(long), long.MaxValue, long.MinValue, sizeof(long));
        Console.WriteLine("ulong\t" + info, typeof(ulong), ulong.MaxValue, ulong.MinValue, sizeof(ulong));

        Console.WriteLine("\nВещественные типы:");
        Console.WriteLine("float\t" + info, typeof(float), float.MaxValue, float.MinValue, sizeof(float));
        Console.WriteLine("double\t" + info, typeof(double), double.MaxValue, double.MinValue, sizeof(double));
        Console.WriteLine("decimal\t" + info, typeof(decimal), decimal.MaxValue, decimal.MinValue, sizeof(decimal));

        Console.WriteLine("\nСтроковые типы:");
        Console.WriteLine("char\t{0}\tРазмер в памяти: {1} байт", typeof(char),sizeof(char));
        Console.WriteLine("string\t{0}", typeof(string));

        Console.WriteLine("\nОсобые типы:");
        Console.WriteLine("object\t{0}", typeof(object));
        Console.WriteLine("dynamic");
        Console.ReadKey();
    }
}