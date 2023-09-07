class Program
{
    //Арифметические операторы и операнды

    //Бинарные операторы
    //+,-,*,/,%
    //Отсечение дробной части

    //Унарные операторы
    //++,-- инкремент,декремент(Постфиксный,префиксный)

    //Скобки
    //Ассоциативность операторов и порядок выполнения
    //Левоассоциативные операторы и правоассоциативные операторы

    //Целочисленные литералы
    //2: 0b1,0b10,0b11...
    //10: 1,2,3,4...
    //16: 0x0A,0XFF,0XA1...

    //Символьные литералы
    //ASCII-16: \x78 https://www.asciitable.com/
    //Unicode-16: \u0420 

    //Поразрядные операции
    //& логическое умножение
    //| логическое сложение
    //^ логическое исключающее ИЛИ
    //~ инверсия
    //Поразрядный сдвиг
    //число>>количество_разрядов
    //число<<количество_разрядов

    //Операции присваивания
    //Правоассоциативные операции
    //+=,-=,*=,/=,%=,&=,|=,^=,<<=,>>=

    //Преобразования базовых типов
    //(тип_данных_в_который_надо_преобразовать) значение_для_преобразования;
    //Сужающие и расширяющие преобразования
    //Checked

    static void Main(string[] args)
    {
        Console.Title = "Безопасные преобразования типов";
        Console.WriteLine("byte\t=> short,ushort,int,uint,long,ulong,float,double,decimal");
        Console.WriteLine("sbyte\t=> short,int,long,float,double,decimal");
        Console.WriteLine("short\t=> int,long,float,double,decimal");
        Console.WriteLine("ushort\t=> int,uint,long,ulong,float,double,decimal");
        Console.WriteLine("int\t=> long,float,double,decimal");
        Console.WriteLine("uint\t=> long,ulong,float,double,decimal");
        Console.WriteLine("long\t=> float,double,decimal");
        Console.WriteLine("ulong\t=> float,double,decimal");
        Console.WriteLine("float\t=> double");
        Console.WriteLine("char\t=> ushort,int,uint,long,ulong,float,double,decimal");
        Console.ReadKey();
    }
}