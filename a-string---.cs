// a
using System;
using System.Threading;

private static void a(string[] A_0)
{
	Console.WriteLine("Press any key to continue...");
	Console.ReadKey();
	char value = '*';
	bool flag = true;
	int num = 0;
	int num2 = 2;
	int num3 = 1;
	int num4 = 0;
	int num5 = 79;
	int num6 = 24;
	Console.BackgroundColor = ConsoleColor.DarkGray;
	Console.Clear();
	int millisecondsTimeout = 50;
	bool flag2 = true;
	do
	{
		ConsoleColor foregroundColor = Console.ForegroundColor;
		Console.ForegroundColor = ConsoleColor.Black;
		Console.SetCursorPosition(0, 0);
		Console.WriteLine("Arrows move up/down/right/left. 't' trail.  'c' clear  'esc' quit.");
		Console.SetCursorPosition(num, num2);
		Console.ForegroundColor = foregroundColor;
		if (Console.KeyAvailable)
		{
			switch (Console.ReadKey(intercept: true).Key)
			{
			case ConsoleKey.T:
				flag2 = true;
				break;
			case ConsoleKey.C:
				Console.BackgroundColor = ConsoleColor.DarkGray;
				flag2 = true;
				Console.Clear();
				break;
			case ConsoleKey.UpArrow:
				num3 = 0;
				num4 = -1;
				Console.ForegroundColor = ConsoleColor.Red;
				break;
			case ConsoleKey.DownArrow:
				num3 = 0;
				num4 = 1;
				Console.ForegroundColor = ConsoleColor.Cyan;
				break;
			case ConsoleKey.LeftArrow:
				num3 = -1;
				num4 = 0;
				Console.ForegroundColor = ConsoleColor.Green;
				break;
			case ConsoleKey.RightArrow:
				num3 = 1;
				num4 = 0;
				Console.ForegroundColor = ConsoleColor.Black;
				break;
			case ConsoleKey.Escape:
				flag = false;
				break;
			}
		}
		Console.SetCursorPosition(num, num2);
		if (!flag2)
		{
			Console.Write(' ');
		}
		num += num3;
		if (num > num5)
		{
			num = 0;
		}
		if (num < 0)
		{
			num = num5;
		}
		num2 += num4;
		if (num2 > num6)
		{
			num2 = 2;
		}
		if (num2 < 2)
		{
			num2 = num6;
		}
		Console.SetCursorPosition(num, num2);
		Console.Write(value);
		Thread.Sleep(millisecondsTimeout);
	}
	while (flag);
}
