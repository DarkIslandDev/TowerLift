class Program
{
    //  СЧЕТЧИКИ
    public static int i = 0;    //  комнат
    public static int x = 0;    //  этапы
    public static int f = 0;    //  этажи
    public static int d = 0;    //  дверь слева

    public static int d_Room;   //  получает число вводимое в консоли

    //  коллекции башни
    public static List<int> tower = new List<int>();
    public static List<int> block = new List<int>();
    public static List<int> floor = new List<int>();



    public static void Lift()
    {
        while (i < d_Room)
        {
            x += 1;


            for (int j = 0; j < x; j++)
            {
                f += 1;

                for (int k = 0; k < x; k++)
                {
                    i += 1;
                    floor.Append(i);

                    if (i == d_Room)
                    {
                        Console.WriteLine($"Расположение комнаты: {d_Room}, \nЭтаж: {f}, \nДверь слева: {d + 1}");
                    }
                }
                block.AddRange(floor);
            }
            tower.AddRange(block);
        }
    }

    public static void Main()
    {
        Console.Write("Введите номер комнаты: ");
        d_Room = int.Parse(Console.ReadLine());
        Lift();
    }
}