// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

string ? readResult;
bool isValid = true;

while(isValid == true)
{	
	
	string selection = "";
	
	Console.Clear();
	Console.WriteLine("Select the measure converter:");
	Console.WriteLine("1. Temperature\n2. Time\n3. Lenght\n4. Weight\n0. Exit");
	readResult = Console.ReadLine();
	if(readResult != null)
	{
		selection = readResult;	
	}
	
	switch(selection)
	{
		case "0":
			Console.Clear();
			Console.WriteLine("Thank You, Bye!!");
			isValid = false;
			break;
		//temperatura
		case "1":
			TemperatureConverter.Exec();
			break;
			
		//time
		case "2":
			TimeConverter.Exec();
			break;

		//lenght
		case "3":
			LengthConverter.Exec();
			break;
		//weight
		case "4":
			WeightConverter.Exec();
			break;

	}
}


