// Program
using System;
using System.Threading;

private static void Main(string[] args)
{
	Console.WriteLine("Press any key to continue...");
	Console.ReadKey();
	char ch = '*';
	bool gameLive = true;
	int x = 0;
	int y = 2;
	int dx = 1;
	int dy = 0;
	int consoleWidthLimit = 79;
	int consoleHeightLimit = 24;
	Console.BackgroundColor = ConsoleColor.DarkGray;
	Console.Clear();
	int delayInMillisecs = 50;
	bool trail = true;
	do
	{
		ConsoleColor cc = Console.ForegroundColor;
		Console.ForegroundColor = ConsoleColor.Black;
		Console.SetCursorPosition(0, 0);
		Console.WriteLine("Arrows move up/down/right/left. 't' trail.  'c' clear  'esc' quit.");
		Console.SetCursorPosition(x, y);
		Console.ForegroundColor = cc;
		if (Console.KeyAvailable)
		{
			switch (Console.ReadKey(intercept: true).Key)
			{
			case ConsoleKey.T:
				trail = true;
				break;
			case ConsoleKey.C:
				Console.BackgroundColor = ConsoleColor.DarkGray;
				trail = true;
				Console.Clear();
				break;
			case ConsoleKey.UpArrow:
				dx = 0;
				dy = -1;
				Console.ForegroundColor = ConsoleColor.Red;
				break;
			case ConsoleKey.DownArrow:
				dx = 0;
				dy = 1;
				Console.ForegroundColor = ConsoleColor.Cyan;
				break;
			case ConsoleKey.LeftArrow:
				dx = -1;
				dy = 0;
				Console.ForegroundColor = ConsoleColor.Green;
				break;
			case ConsoleKey.RightArrow:
				dx = 1;
				dy = 0;
				Console.ForegroundColor = ConsoleColor.Black;
				break;
			case ConsoleKey.Escape:
				gameLive = false;
				break;
			}
		}
		Console.SetCursorPosition(x, y);
		if (!trail)
		{
			Console.Write(' ');
		}
		x += dx;
		if (x > consoleWidthLimit)
		{
			x = 0;
		}
		if (x < 0)
		{
			x = consoleWidthLimit;
		}
		y += dy;
		if (y > consoleHeightLimit)
		{
			y = 2;
		}
		if (y < 2)
		{
			y = consoleHeightLimit;
		}
		Console.SetCursorPosition(x, y);
		Console.Write(ch);
		Thread.Sleep(delayInMillisecs);
	}
	while (gameLive);
}
