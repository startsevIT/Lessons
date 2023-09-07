class Program
{
    //КОНСОЛЬ
    //Console.BackgroundColor и ConsoleColor
    //Console.ForegroundColor и ConsoleColor
    //Console.Beep();

    //ЦИКЛЫ
    //for, do...while,while,foreach(строки)
    //continue, break
    //Вложенные циклы

    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("\t\t\tТАБЛИЦА УМНОЖЕНИЯ\n");
        for (int i = 1; i < 10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                if (i == 1 || j == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Beep();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.Write(i*j + "\t");
            }
            Console.WriteLine("\n");
        }
        Console.ReadKey();
    }
}