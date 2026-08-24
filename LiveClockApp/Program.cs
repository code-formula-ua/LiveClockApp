/*
╔══════════════════╗
║    LIVE CLOCK    ║
╠══════════════════╣
║     00:00:00     ║
╚══════════════════╝
*/

Console.CursorVisible = false;

Console.WriteLine("╔══════════════════╗");
Console.WriteLine("║    LIVE CLOCK    ║");
Console.WriteLine("╠══════════════════╣");
Console.WriteLine("║     00:00:00     ║");
Console.WriteLine("╚══════════════════╝");

while (true)
{
    Console.SetCursorPosition(6, 3);
    Console.Write(DateTime.Now.ToString("HH:mm:ss"));

    Thread.Sleep(1000);
}

