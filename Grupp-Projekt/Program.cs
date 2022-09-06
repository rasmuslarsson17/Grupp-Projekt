using System.Diagnostics;

while (true)
{
    Console.WriteLine("1 : Skriv ut alla processers\n2 : avsluta");
    int val = 0;
    if(!Int32.TryParse(Console.ReadLine(), out val))
    {
        Console.WriteLine("Du kan bara använda dig utav bokstäver");
        continue;
    }

    switch (val)
    {
        case 1:
            Process[] procList = Process.GetProcesses();
            foreach (var process in procList)
                Console.WriteLine($"{process.ProcessName} : {process.Id}");
            break;

        case 2:
            return;
            
        default:
            break;
    }

}