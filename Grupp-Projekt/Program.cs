using System.Diagnostics;

while (true)
{
    Console.Clear();
    Console.WriteLine("1 : Skriv ut alla processer\n2 : Avsluta");

    if (!Int32.TryParse(Console.ReadKey().KeyChar.ToString(), out int val))
    {
        Console.WriteLine("\n\nDu kan bara använda dig utav siffror.\n\n");
        continue;
    }

    Console.WriteLine("\n");

    switch (val)
    {
        case 1:
            SystemInformation.ListProcesses();
            break;

        case 2:
            return;

        default:
            Console.WriteLine("Ogiltig siffra.");
            break;
    }

    Console.WriteLine("\n");
    Console.Write("Tryck på valfri tangent för att återvända till menyn... ");
    Console.ReadKey();
}

public static class SystemInformation
{
    public static void ListProcesses()
    {
        Process[] procList = Process.GetProcesses();
        int i = 0, longestProcessNameLength = 0, longestProcessIdLength = 0;

        // Kollar hur långa de längsta processnamnen och id:n i listan är, för formattering av utskrifterna
        foreach (var process in procList)
        {
            if (process.ProcessName.Length > longestProcessNameLength)
                longestProcessNameLength = process.ProcessName.Length;
            if (process.Id.ToString().Length > longestProcessIdLength)
                longestProcessIdLength = process.Id.ToString().Length;
        }

        // Utskrift
        foreach (var process in procList)
        {
            Console.Write($"\n{process.ProcessName}");
            Console.SetCursorPosition(longestProcessNameLength + longestProcessIdLength - process.Id.ToString().Length + 5, Console.GetCursorPosition().Top);
            Console.Write($"{process.Id}");

            if ((++i % 5) == 0 || i == procList.Length)
            {
                Console.WriteLine();
            }
        }
    }
}

