// See https://aka.ms/new-console-template for more information

using System;
					
double temp = 0;
double time = 0;
string ? readResult;
bool isValid = true;

while(isValid == true)
{	
	bool valid = true;
	string selection = "";
	
	Console.WriteLine("Select the measure converter:");
	Console.WriteLine("1. Temperature\n2. Time\n0. EXIT");
	readResult = Console.ReadLine();
	if(readResult != null)
	{
		selection = readResult;	
	}
	
	switch(selection)
	{
		//temperatura
		case "1":	
			do{
				Console.WriteLine("Temperature Conversor");
				string input = "";
				Console.WriteLine("Select a option:");
				Console.WriteLine("1. Celsius\n2. Fahrenheit\n3. Kelvin");
				readResult = Console.ReadLine();
				if(readResult != null)
				{
					input = readResult;
				}
				switch(input)
				{
					case "1":
						Console.WriteLine("\nInsert the celsius temperature:");
						readResult = Console.ReadLine();
						if(readResult != null)
						{
							temp = DoubleConvert(readResult);
						}
						Console.WriteLine("\nSelect the measure to convert to:");
						Console.WriteLine("\n1. Fahrenheit\n2. Kelvin");
						readResult = Console.ReadLine();
						if(readResult != null)
						{
							input = readResult;
						}
						if(input == "1")
							Console.WriteLine($"\nTemperature in Fahrenheit:\n{CelsiusToFahr(temp)}");
						else if(input == "2")
							Console.WriteLine($"\nTemperature in Kelvin:\n{CelsiusToKelvin(temp)}");
						Console.WriteLine("\nNew Convert?\n1. Yes\n2. No");
						readResult = Console.ReadLine();	
						if(readResult != null)
						{
							selection = readResult;
							if (selection == "2")
								valid = false;
						}				
						break;
					case "2":
						Console.WriteLine("\nInsert the Fahrenheit temperature:");
						readResult = Console.ReadLine();
						if(readResult != null)
						{
							temp = DoubleConvert(readResult);
						}
						Console.WriteLine("\nSelect the measure to convert to:");
						Console.WriteLine("\n1. Celsius\n2. Kelvin");
						readResult = Console.ReadLine();
						if(readResult != null)
						{
							input = readResult;
						}
						if(input == "1")
							Console.WriteLine($"\nTemperature in Celsius:\n{FahrToCelsius(temp)}");
						else if(input == "2")
							Console.WriteLine($"\nTemperature in Fahrenheit:\n{FahrToKelvin(temp)}");
						Console.WriteLine("\nNew Convert?\n1. Yes\n2. No");
						readResult = Console.ReadLine();	
						if(readResult != null)
						{
							selection = readResult;
							if (selection == "2")
								valid = false;
						}			
						break;
					case "3":
						Console.WriteLine("\nInsert the Kelvin temperature:");
						readResult = Console.ReadLine();
						if(readResult != null)
						{
							temp = DoubleConvert(readResult);
						}
						Console.WriteLine("\nSelect the measure to convert to:");
						Console.WriteLine("\n1. Celsius\n2. Fahrenheit");
						readResult = Console.ReadLine();
						if(readResult != null)
						{
							input = readResult;
						}
						if(input == "1")
							Console.WriteLine($"\nTemperature in Celsius:\n{KelvinToCelsius(temp)}");
						else if(input == "2")
							Console.WriteLine($"\nTemperature in Fahrenheit:\n{KelvinToFahr(temp)}");
						Console.WriteLine("\nNew Convert ?\n1. Yes\n2. No");
						readResult = Console.ReadLine();	
						if(readResult != null)
						{
							selection = readResult;
							if (selection == "2")
								valid = false;
						}
						break;
			}

		}while (valid == true);
		break;
			
		//time
		case "2":
			do
			{
			string input = "";	
			Console.WriteLine("Time Converter:");
			Console.WriteLine("Select a option:");
			Console.WriteLine("1. Seconds\n2. Minutes\n3. Hours\n4. Days\n5. Months\n6. Years");
			readResult = Console.ReadLine();
			if(readResult != null)
			{
				input = readResult;
			}
				
			switch(input)
			{
				//seconds
				case "1":
					Console.WriteLine("\nInsert the value in seconds:");
					readResult = Console.ReadLine();
					if(readResult != null)
					{
						time = DoubleConvert(readResult);
					}
					Console.WriteLine("\nSelect the value to convert to:");
					Console.WriteLine("\n1. Minutes\n2. Hours\n3. Days\n4. Weeks\n5. Months");
					readResult = Console.ReadLine();
					if(readResult != null)
					{
						input = readResult;
					}
					if(input == "1")
						Console.WriteLine($"\n{SecondsToMinutes(time)} Minutes");
					else if(input == "2")
						Console.WriteLine($"\n{SecondsToHours(time)} Hours");
					else if(input == "3")
						Console.WriteLine($"\n{SecondsToDays(time)} Days");
					else if(input == "4")
						Console.WriteLine($"\n{SecondsToWeeks(time)} Months");
					else if(input == "5")
						Console.WriteLine($"\n{SecondsToMonths(time)} Years");
					break;
					
				case "2":
					Console.WriteLine("\nInsert the value in minutes:");
					readResult = Console.ReadLine();
					if(readResult != null)
					{
						time = DoubleConvert(readResult);
					}
					Console.WriteLine("\nSelect the value to convert to:");
					Console.WriteLine("\n1. Seconds\n2. Hours\n3. Days\n4. Weeks\n5. Months");
					readResult = Console.ReadLine();
					if(readResult != null)
					{
						input = readResult;
					}
					if(input == "1")
						Console.WriteLine($"{time * 60} Seconds");
					else if(input == "2")
						Console.WriteLine($"{time / 60} Hours");
					else if(input == "3")
						Console.WriteLine($"{time / 1440} Days");
					else if(input == "4")
						Console.WriteLine($"{time / 10080} Weeks");
					else if(input == "5")
						Console.WriteLine($"{time / 43800} Months");
					
					break;
				
			}
			Console.WriteLine("1. New Measure\n2. Exit");
			readResult = Console.ReadLine();
			if(readResult == "2")
				valid = false;
		}while(valid == true);
		break;
	}
}

//Metodos Temperatura
double DoubleConvert(string word)
{
	double val = 0;
	bool isValid = double.TryParse(word, out val);
	return val;
}


double CelsiusToFahr(double val)
{
	return (val * 1.8) + 32;
}

double CelsiusToKelvin(double val)
{
	return val + 273.15;
}

double FahrToCelsius(double val)
{
	return (val - 32) * 1.8;
}

double FahrToKelvin(double val)
{
	return FahrToCelsius(val) + 273.15;
}

double KelvinToCelsius(double val)
{
	return val - 273.15;
}

double KelvinToFahr(double val)
{
	return (1.8 * KelvinToCelsius(val)) + 32;
}
 
//Metodos Tempo Seconds
double SecondsToMinutes(double time)
{
	return time / 60;
}
double SecondsToHours(double time)
{
	return time / 3600;
}
double SecondsToDays(double time)
{
	return time / 86400;
}
double SecondsToWeeks(double time)
{
	return time / 604800;
}
double SecondsToMonths(double time)
{
	return time / (86400 * 30);
}
