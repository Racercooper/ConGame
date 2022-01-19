using System;
using System.Diagnostics;
using System.Media;

namespace trying_to_make_a_funtional_something //why you reading my source code
{
	class Program
	{
		static void Main(string[] args)
		{
			/*CHARACTERS*/
			char x1; string m1;
			char x2; string m2;
			char x3; string m3;
			char x4; string m4;
			char x5; string m5;
			char x6; string m6;
			char x7; string m7;
			char x8; string m8;
			char x9; string m9;
			/*INPUTS*/
			bool down;
			bool up;
			bool left;
			bool right;
			/*ROWS*/
			string row1;
			string row2;
			string row3;
			/*ETC.*/
			int NumberOfKeys;
			double GamePercentBeaten;
			char what;
			int room;
			bool GameOver = false;
			SoundPlayer morse = new SoundPlayer("morse.wav");
			bool Refresh = false;
			/*OUTPUTS*/
			int PlayerPosX;
			int PlayerPosY;
			int PlayerPos;
			/*KEYS*/
			bool HasKey3 = false;
			bool HasKey4 = false;
			/*CODE*/
			Console.WriteLine("Welcome to UDOLK!");
			string ok;
			Console.WriteLine("y/n do you want to see my Youtube Channel?");
			ok = Console.ReadLine();
			if(ok == "y")
			{
				System.Diagnostics.Process.Start(new ProcessStartInfo
				{
					FileName = "https://www.youtube.com/channel/UC70x1zUL-JYBCbzfoVHFg7g",
					UseShellExecute = true
				});
			}
			System.Threading.Thread.Sleep(1000);
			room = 1;
			PlayerPosX = 2;
			PlayerPosY = 2;
			PlayerPos = 5;
			x1 = '_'; row1 = "_L_";
			x2 = '_'; row2 = "_UD";
			x3 = '_'; row3 = "___";
			x4 = '_';
			x5 = '_';
			x6 = '_';
			x7 = '_';
			x8 = '_';
			x9 = '_';
			Refresh = true;
			while (!GameOver)
				{
				if (!Refresh) { what = Console.ReadKey().KeyChar; Console.Beep(500, 100); }
				else what = '_';
				Refresh = false;
					if (what == 'w' | what == 'W') { up = true; }
					else { up = false; }
					if (what == 'd' | what == 'D') { right = true; }
					else { right = false; }
					if (what == 'a' | what == 'A') { left = true; }
					else { left = false; }
					if (what == 's' | what == 'S') { down = true; }
					else { down = false; }
					if (up == true) { PlayerPosY--; }
					if (left == true) { PlayerPosX--; }
					if (right == true) { PlayerPosX++; }
					if (down == true) { PlayerPosY++; }
					PlayerPos = PlayerPosX;
					if (PlayerPosX > 4) { PlayerPosX--; }
					PlayerPos = PlayerPos + (3 * (PlayerPosY - 1));
					if (PlayerPos > 9)
					{
						PlayerPosX = 3;
						PlayerPosY = 3;
						PlayerPos = 9;
					}
					else if (PlayerPos < 1) { PlayerPos = 1; }
					NumberOfKeys = 0;
					if (HasKey3 == true) { NumberOfKeys++; }
					if (HasKey4 == true) { NumberOfKeys++; }
					x1 = '_'; if (PlayerPos == 1) { x1 = 'U'; }
					x2 = '_'; if (PlayerPos == 2) { x2 = 'U'; }
					x3 = '_'; if (PlayerPos == 3) { x3 = 'U'; }
					x4 = '_'; if (PlayerPos == 4) { x4 = 'U'; }
					x5 = '_'; if (PlayerPos == 5) { x5 = 'U'; }
					x6 = '_'; if (PlayerPos == 6) { x6 = 'U'; }
					x7 = '_'; if (PlayerPos == 7) { x7 = 'U'; }
					x8 = '_'; if (PlayerPos == 8) { x8 = 'U'; }
					x9 = '_'; if (PlayerPos == 9) { x9 = 'U'; }
					if (room == 1)
					{
					x2 = 'L'; if(PlayerPos == 2 & HasKey3)
					{
						PlayerPos = 5;
						PlayerPosX = 2;
						PlayerPosY = 2;
						room = 3;
						Refresh = true;
					}
						x6 = 'D';
						if (PlayerPos == 6)
						{
							PlayerPosX = 2;
							PlayerPosY = 2;
							PlayerPos = 5;
							room = 2;
						Refresh = true;
						}
					}
				if (room == 2)
				{
					x4 = 'D';
					x8 = 'O';
					x3 = 'K';
					if (HasKey3) { x3 = '/'; }
					if (PlayerPos == 4)
					{
						room = 1;
						PlayerPosX = 2;
						PlayerPosY = 2;
						PlayerPos = 5;
						Refresh = true;
					} if (PlayerPos == 3) { 
						HasKey3 = true;
						Console.WriteLine("You Collected a key.");
					}
					if(PlayerPos == 8) {GameOver = true;}
				}
				if(room == 3)
				{
					x3 = 'L';
					x2 = 'O';
					x4 = 'O';
					if (HasKey4 == false) { x1 = 'K'; }
					else { x1 = '/'; }
					x8 = 'D';
					if(PlayerPos == 2 | PlayerPos == 4)
					{
						GameOver = true;
					}
					if (PlayerPos == 8) { 
						room = 1;
						PlayerPosX = 2;
						PlayerPosY = 2;
						PlayerPos = 5;
						Refresh = true;
					}
					if(PlayerPos == 1) { HasKey4 = true;}
					if(PlayerPos == 3 & HasKey4 == true)
					{
						room = 4;
						PlayerPosX = 2;
						PlayerPosY = 2;
						PlayerPos = 5;
						Refresh = true;
					}
				}
				if(room == 4)
				{
					x1 = 'D';
					if(PlayerPos == 1)
					{
						room = 3;
						PlayerPosX = 3;
						PlayerPosY = 2;
						PlayerPos = 6;
						Refresh = true;
					}
				}
					m1 = x1.ToString();
					m2 = x2.ToString();
					m3 = x3.ToString();
					m4 = x4.ToString();
					m5 = x5.ToString();
					m6 = x6.ToString();
					m7 = x7.ToString();
					m8 = x8.ToString();
					m9 = x9.ToString();
					row1 = m1 + m2 + m3;
					row2 = m4 + m5 + m6;
					row3 = m7 + m8 + m9;
					Console.Clear();
					Console.WriteLine("xxxxx Pos: X:" + PlayerPosX + " Y:" + PlayerPosY + " G:" + PlayerPos);
					Console.WriteLine('x' + row1 + 'x' + " Room:" + room);
					Console.WriteLine('x' + row2 + 'x' + " w");
					Console.WriteLine('x' + row3 + 'x' + " Has " + NumberOfKeys + " Key(s)");
					Console.WriteLine("xxxxx");
			}
			System.Threading.Thread.Sleep(1000);
			Console.BackgroundColor = ConsoleColor.DarkRed;
			System.Threading.Thread.Sleep(150);
			Console.ForegroundColor = ConsoleColor.Black;
			Console.Beep(1000, 100);
			Console.Clear();
			morse.PlaySync();
			Console.Clear();
			Console.WriteLine("Game Over!");
			System.Threading.Thread.Sleep(1000);
			Console.WriteLine("The game closes in five seconds.");
			System.Threading.Thread.Sleep(5000);
			Console.Clear();
		}
	}
}