using System;
using Utilities.Helper;

namespace RestaurantApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Extention.ShowMe(ConsoleColor.White, "Welcome to Heaven");
            while (true)
            {
                Extention.ShowMe(ConsoleColor.DarkCyan, "1-Create Worker\n" +
                    "2-Update Worker\n" +
                    "3-Remove Worker\n+" +
                    "4-Get Worker");
                string num = Console.ReadLine();
                int input;

                bool IsNum = int.TryParse(num, out input);
                if (IsNum && input < 100 && input > 0)
                {
                    switch (input)
                    {
                        case (int)Extention.Menu.CreateWorker:
                            workerController.CreateWorker();
                            break;
                        case 2:
                            break;
                        case (int)Extention.Menu.RemoveWorker:
                            workerController.RemoveWorker();
                            break;
                        case 4:
                            break;
                        case (int)Extention.Menu.GetAllWorker:
                            workerController.GetAllWorker();
                            break;
                    }
                }
            }
        }
    }
}
