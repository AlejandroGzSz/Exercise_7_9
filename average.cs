using System;
public class Average
{
	public static void Main()
	{
		double sum = 0, counter = 0, average;
		string mark;

		Console.Write("Insert a mark: ");
		mark=Console.ReadLine();	
		while(mark != "end")
		{ 
			counter++;   
			sum += Convert.ToDouble(mark); 
			Console.Write("Insert a mark: ");
			mark = Console.ReadLine();
		}

		if (counter != 0) {
			average = sum / counter;  
			Console.WriteLine("The average is {0}.",average);
		}
	}
}
