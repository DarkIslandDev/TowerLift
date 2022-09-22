class Program
{
    public static List<int> floors;
    public static List<int> rooms;

    public static void Lift(int room)
    {
        int floor = 0;
        floors = new List<int> {1};
        rooms = new List<int> {1};

        for (int i = 0; i < floors.Count; i++)
        {
            for (int j = 0; j < rooms.Count; j++)
            {
                rooms[i] = room;
                floors[i] = rooms[j] + rooms[j];
                floor = floors[i];

            }
        }
        Console.WriteLine($"{floor} {room}");
    }

    public static void Main()
    {
        Console.Write("Введите номер отеля: ");

        int n = int.Parse(Console.ReadLine());

        //Lift(result);
        //Console.ReadKey();

        int result = 0;
        int b = 1;
        int tmp;

        for (int i = 0; i < n; i++)
        {
            tmp = result;
            result = b;
            b += tmp;
        }

        Console.WriteLine(result);
    }
}