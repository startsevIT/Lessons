internal class Program
{
    //УСЛОВНЫЕ ВЫРАЖЕНИЯ
    //Операции сравнения
    //==,!=,<,>,<=,>=

    //Логические операции
    // |,&,||,&&,!,^
    //Разница между двойными операторами и одинарными;

    //УСЛОВНЫЕ КОНСТРУКЦИИ
    //if(Условие){},
    //if(Условие){}else{},
    //if(Условие){}esle if(Условие){}else

    //Тернарная операция
    //условие ? значение_если_правда : значение_если_ложь;
    private static void Main(string[] args)
    {
        bool a = true;
        bool b = true;
        string msg = "{0}\t|\t{1}\t|\t{2}\t|\t{3}";
        Console.Title = "Алгебра логики";

        Console.WriteLine("\nОператор OR '||'\n");
        Console.WriteLine("FIRST\t|\tOP\t|\tSECOND\t|\tRESULT");
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine(msg, a = true,"||", b = true, a || b);
        Console.WriteLine(msg, a = true, "||", b = false, a || b);
        Console.WriteLine(msg, a = false, "||", b = true, a || b);
        Console.WriteLine(msg, a = false, "||", b = false, a || b);

        Console.WriteLine("\nОператор AND '&&'\n");
        Console.WriteLine("FIRST\t|\tOP\t|\tSECOND\t|\tRESULT");
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine(msg, a = true, "&&", b = true, a && b);
        Console.WriteLine(msg, a = true, "&&", b = false, a && b);
        Console.WriteLine(msg, a = false, "&&", b = true, a && b);
        Console.WriteLine(msg, a = false, "&&", b = false, a && b);

        Console.WriteLine("\nОператор XOR '^'\n");
        Console.WriteLine("FIRST\t|\tOP\t|\tSECOND\t|\tRESULT");
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine(msg, a = true, "^", b = true, a ^ b);
        Console.WriteLine(msg, a = true, "^", b = false, a ^ b);
        Console.WriteLine(msg, a = false, "^", b = true, a ^ b);
        Console.WriteLine(msg, a = false, "^", b = false, a ^ b);
        Console.ReadKey();
    }
}