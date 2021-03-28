using System;

public class Exams3
{
	public static void Main()
	{
		Console.WriteLine("Insert quantity boxes in 1th bucket :");
		int firstBucket = int.Parse(Console.ReadLine());
		Console.WriteLine("Insert quantity boxes in 2nd bucket :");
		int secondBucket = int.Parse(Console.ReadLine());
		Console.WriteLine("Insert quantity boxes in 3rd bucket :");
		int thirdBucket = int.Parse(Console.ReadLine());
		int p1 = 0;
		int p2 = 0;

		while (true)
		{
			while (true)
			{
				Console.WriteLine("Player1 select a bucket (1-3) :");
				int p1SelectBucket = int.Parse(Console.ReadLine());
				if (p1SelectBucket > 3 || p1SelectBucket < 1)
				{
					Console.WriteLine("We have only 3 buckets, try again!");
					continue;
				}
				switch (p1SelectBucket)
				{
					case 1:
						Console.WriteLine("Player1 How many boxes do you take away?:");
						int p1BoxesTake1 = int.Parse(Console.ReadLine());
						if (p1BoxesTake1 > 2 || p1BoxesTake1 < 1)
						{
							Console.WriteLine("Input only 1-2, try again!");
							continue;
						}
						if (p1BoxesTake1 > firstBucket)
						{
							Console.WriteLine("This bucket has only 1 box, try again!");
							continue;
						}
						firstBucket -= p1BoxesTake1;
						break;
					case 2:
						Console.WriteLine("Player1 How many boxes do you take away?:");
						int p1BoxesTake2 = int.Parse(Console.ReadLine());
						if (p1BoxesTake2 > 2 || p1BoxesTake2 < 1)
						{
							Console.WriteLine("Input only 1-2, try again!");
							continue;
						}
						if (p1BoxesTake2 > secondBucket)
						{
							Console.WriteLine("This bucket has only 1 box, try again!");
							continue;
						}
						secondBucket -= p1BoxesTake2;
						break;
					case 3:
						Console.WriteLine("Player1 How many boxes do you take away?:");
						int p1BoxesTake3 = int.Parse(Console.ReadLine());
						if (p1BoxesTake3 > 2 || p1BoxesTake3 < 1)
						{
							Console.WriteLine("Input only 1-2, try again!");
							continue;
						}
						if (p1BoxesTake3 > thirdBucket)
						{
							Console.WriteLine("This bucket has only 1 box, try again!");
							continue;
						}
						thirdBucket -= p1BoxesTake3;
						break;
				}
				break;
			}

			Console.WriteLine("1st bucket left :" + firstBucket + "" + "boxes");
			Console.WriteLine("2nd bucket left :" + secondBucket + "" + "boxes");
			Console.WriteLine("3rd bucket left :" + thirdBucket + "" + "boxes");
			if (firstBucket <= 0 && secondBucket <= 0 && thirdBucket <= 0)
			{
				p1 += 1;
				break;
			}

			while (true)
			{
				Console.WriteLine("Player2 select a bucket (1-3) :");
				int p2SelectBucket = int.Parse(Console.ReadLine());
				if (p2SelectBucket > 3 || p2SelectBucket < 1)
				{
					Console.WriteLine("We have only 3 buckets, try again!");
					continue;
				}
				switch (p2SelectBucket)
				{
					case 1:
						Console.WriteLine("Player2 How many boxes do you take away?:");
						int p2BoxesTake1 = int.Parse(Console.ReadLine());
						if (p2BoxesTake1 > 2 || p2BoxesTake1 < 1)
						{
							Console.WriteLine("Input only 1-2, try again!");
							break;
						}
						if (p2BoxesTake1 > firstBucket)
						{
							Console.WriteLine("This bucket has only 1 box, try again!");
							break;
						}
						firstBucket -= p2BoxesTake1;
						break;
					case 2:
						Console.WriteLine("Player2 How many boxes do you take away?:");
						int p2BoxesTake2 = int.Parse(Console.ReadLine());
						if (p2BoxesTake2 > 2 || p2BoxesTake2 < 1)
						{
							Console.WriteLine("Input only 1-2, try again!");
							continue;
						}
						if (p2BoxesTake2 > secondBucket)
						{
							Console.WriteLine("This bucket has only 1 box, try again!");
							continue;
						}
						secondBucket -= p2BoxesTake2;
						break;
					case 3:
						Console.WriteLine("Player2 How many boxes do you take away?:");
						int p2BoxesTake3 = int.Parse(Console.ReadLine());
						if (p2BoxesTake3 > 2 || p2BoxesTake3 < 1)
						{
							Console.WriteLine("Input only 1-2, try again!");
							continue;
						}
						if (p2BoxesTake3 > thirdBucket)
						{
							Console.WriteLine("This bucket has only 1 box, try again!");
							continue;
						}
						thirdBucket -= p2BoxesTake3;
						break;
				}
				break;
			}
			Console.WriteLine("1st bucket left :" + firstBucket + "boxes");
			Console.WriteLine("2nd bucket left :" + secondBucket + "boxes");
			Console.WriteLine("3rd bucket left :" + thirdBucket + "boxes");
			if (firstBucket <= 0 && secondBucket <= 0 && thirdBucket <= 0)
			{
				p2 += 1;
				break;
			}
		}

		if (p1 < p2)
		{
			Console.WriteLine("The winner is Player1!");
		}
		else
		{
			Console.WriteLine("The winner is Player2!");
		}
	}
}