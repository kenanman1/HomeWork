using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        //1 exercise
        Process process = new Process();
        process = Do();
        process.Start();
        process.WaitForExit();
        if (process.HasExited)
        {
            Console.WriteLine("Process was ended");
        }
        //2 exercise
        Process process1 = new Process();
        process1 = Do();
        process1.Start();
        Console.WriteLine("1-wait for process end; 2 - kill process");
        string choose = Console.ReadLine();
        process1.Start();

        if (choose == "1")
        {
            if (process1.HasExited)
            {
                Console.WriteLine("Process was ended");
            }
        }
        if (choose == "2")
        {
            process1.Kill();
        }
    }
    static Process Do()
    {
        Process process = new Process();
        process.StartInfo.FileName = @"C:\Program Files\Google\Chrome\Application\chrome";
        return process;
    }
}