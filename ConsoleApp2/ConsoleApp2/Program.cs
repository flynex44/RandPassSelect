
using System;
using System.Windows.Forms;// добавить в ссылки
using System.Text.RegularExpressions;
using System.Diagnostics;


class HelloWorld
{
    public static int Main()
    {

        Console.WriteLine("Enter Pass:  ");
        string Pass = Console.ReadLine();
        string[] numbers= {"","" };
        string iPass = "";
        string[] arr = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Z", "b", "c", "d", "f", "g", "h", "j", "k", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z", "A", "E", "U", "Y", "a", "e", "i", "o", "u", "y" };
        int a = Pass.Length;
        int b = 0;
        Regex rgx = new Regex(@"");
        bool c = Regex.IsMatch(Pass, "^[0-9]+$");
        if (c == true)
        {
            b = 9;
        }
        else
        {
            b = 58;
        }
        Stopwatch stopWatch = new Stopwatch(); // секундомер
        stopWatch.Start(); // запустить секундомер
        while (iPass != Pass)
        {
            Random rnd = new Random();
            for (int i = 0; i < a; i = i + 1)
            {
                iPass = iPass + arr[rnd.Next(0, b)];
            }
            Console.WriteLine("(Your pass: " + Pass + ") "+"Progress:   " +iPass);
            if (iPass!=Pass)
            {
                iPass = "";
            }
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Pass:  "+iPass);
        stopWatch.Stop(); // остановить секундомер
        TimeSpan ts = stopWatch.Elapsed; // структура для работы с временем
        Console.WriteLine($"Time:  {ts.Seconds:00} : {ts.Milliseconds:00}"); // вывод секунд и милисекунд
        DialogResult r8 = MessageBox.Show("Pass:  " + iPass + $"{Environment.NewLine}Time:  {ts.Seconds:00} : {ts.Milliseconds:00}","Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
        if(r8.ToString()== r8.ToString())
        {
            Console.Clear();
            Application.Restart();
            Environment.Exit(0);
        }
        return 0;

    }
}

