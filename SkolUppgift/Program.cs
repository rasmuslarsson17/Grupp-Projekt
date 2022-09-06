using System.Diagnostics;

namespace SkolUppgift
{

    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("SystemInformationEnumerator");



            Process[] procList = Process.GetProcesses();
            foreach (var item in procList)
            {
                Console.WriteLine(item.ProcessName);
            }            




        }
    }
}