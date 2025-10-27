// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

double temp = 0;
double time = 0;
double extent = 0;
string ? readResult;
bool isValid = true;

while(isValid == true)
{	
	bool valid = true;
	string selection = "";
	bool validate = false;
	
	Console.WriteLine("Select the measure converter:");
	Console.WriteLine("1. Temperature\n2. Time\n3. Lenght\n0. Exit");
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
			do{
				Console.Clear();
				Console.WriteLine("Temperature Conversor");
				string input = "";
				Console.WriteLine("Select a option:");
				Console.WriteLine("1. Celsius\n2. Fahrenheit\n3. Kelvin");
				readResult = Console.ReadLine();
				if (readResult != null)
				{
					input = readResult;
				}
				
				switch(input)
				{
					case "1":
						
						Console.Clear();
						Console.WriteLine("Insert the celsius temperature:");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							temp = DoubleConvert(readResult);                                                          
                            
						}		
					
						Console.Clear();
						Console.WriteLine("Select the measure to convert to:");
						Console.WriteLine("1. Fahrenheit\n2. Kelvin");
						readResult = Console.ReadLine();
						if(readResult != null)
						{
							input = readResult;
						}
						if (input == "1")
						{
							Console.Clear();
							Console.WriteLine($"Temperature in Fahrenheit:\n{(temp * 1.8) + 32:F2}");
						}
						else if (input == "2")
						{
							Console.Clear();
							Console.WriteLine($"Temperature in Kelvin:\n{temp + 273.15:F2}");
						}
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
						Console.Clear();
						Console.WriteLine("Insert the Fahrenheit temperature:");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							temp = DoubleConvert(readResult);
						}
						Console.Clear();
						Console.WriteLine("Select the measure to convert to:");
						Console.WriteLine("\n1. Celsius\n2. Kelvin");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							input = readResult;
						}
						Console.Clear();
						if(input == "1")
							Console.WriteLine($"Temperature in Celsius:\n{(temp - 32) * 1.8:F2}");
						else if(input == "2")
							Console.WriteLine($"Temperature in Fahrenheit:\n{((temp - 32) * 1.8) + 273.15:F2}");
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
						Console.Clear();
						Console.WriteLine("Insert the Kelvin temperature:");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							temp = DoubleConvert(readResult);
						}
						Console.Clear();
						Console.WriteLine("Select the measure to convert to:");
						Console.WriteLine("\n1. Celsius\n2. Fahrenheit");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							input = readResult;
						}
						Console.Clear();
						if (input == "1")
							Console.WriteLine($"Temperature in Celsius:\n{temp - 273.15:F2}");
						else if (input == "2")
							Console.WriteLine($"Temperature in Fahrenheit:\n{(1.8 * (temp - 273.15)) + 32:F2}");

						
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
					Console.Clear();
					Console.WriteLine("Insert the value in seconds:");
					readResult = Console.ReadLine();
					if (readResult != null)
					{
						time = DoubleConvert(readResult);
					}
					Console.Clear();
					Console.WriteLine("Select the value to convert to:");
					Console.WriteLine("\n1. Minutes\n2. Hours\n3. Days\n4. Weeks\n5. Months");
					readResult = Console.ReadLine();
						if (readResult != null)
						{
							input = readResult;
						}
					Console.Clear();
					if(input == "1")
						Console.WriteLine($"Value Converted: {time / 60:F2} Minutes");
					else if(input == "2")
						Console.WriteLine($"Value Converted: {time / 3600:F2} Hours");
					else if(input == "3")
						Console.WriteLine($"Value Converted: {time / 86400:F2} Days");
					else if(input == "4")
						Console.WriteLine($"Value Converted: {time / 604800:F2} Months");
					else if(input == "5")
						Console.WriteLine($"Value Converted: {time / (86400 * 30):F2} Years");
					break;
					//minutes
				case "2":
					Console.Clear();
					Console.WriteLine("Insert the value in minutes:");
					readResult = Console.ReadLine();
					if (readResult != null)
					{
						time = DoubleConvert(readResult);
					}
					Console.Clear();
					Console.WriteLine("Select the value to convert to:");
					Console.WriteLine("\n1. Seconds\n2. Hours\n3. Days\n4. Weeks\n5. Months");
					readResult = Console.ReadLine();
					if (readResult != null)
					{
						input = readResult;
					}
					Console.Clear();
					if(input == "1")
						Console.WriteLine($"Value Converted: {time * 60:F2} Seconds");
					else if(input == "2")
						Console.WriteLine($"Value Converted: {time / 60:F2} Hours");
					else if(input == "3")
						Console.WriteLine($"Value Converted: {time / 1440:F2} Days");
					else if(input == "4")
						Console.WriteLine($"Value Converted: {time / 10080:F2} Weeks");
					else if(input == "5")
						Console.WriteLine($"Value Converted: {time / 43800:F2} Months");

					break;

				case "3":
					Console.Clear();
					Console.WriteLine("Insert the value in hours:");
					readResult = Console.ReadLine();
					if (readResult != null)
					{
						time = DoubleConvert(readResult);
					}
					Console.Clear();
					Console.WriteLine("Select the value to convert to:");
					Console.WriteLine("\n1. Seconds\n2. minutes\n3. Days\n4. Weeks\n5. Months");
					readResult = Console.ReadLine();
					if (readResult != null)
					{
						input = readResult;
					}
					Console.Clear();
					if(input == "1")
						Console.WriteLine($"Value Converted: {time * 3600:F2} Seconds");
					else if(input == "2")
						Console.WriteLine($"Value Converted: {time *60:F2} Minutes");
					else if(input == "3")
						Console.WriteLine($"Value Converted: {time / 24:F2} Days");
					else if(input == "4")
						Console.WriteLine($"Value Converted: {time / 168:F2} Weeks");
					else if(input == "5")
						Console.WriteLine($"Value Converted: {time / 730:F2} Months");

					break;
				case "4":
					Console.Clear();
					Console.WriteLine("Insert the value in Days:");
					readResult = Console.ReadLine();
					if (readResult != null)
					{
						time = DoubleConvert(readResult);
					}
					Console.Clear();
					Console.WriteLine("Select the value to convert to:");
					Console.WriteLine("\n1. Seconds\n2. minutes\n3. Hours\n4. Weeks\n5. Months");
					readResult = Console.ReadLine();
					if (readResult != null)
					{
						input = readResult;
					}
					Console.Clear();
					if(input == "1")
						Console.WriteLine($"Value Converted: {time * 86400:F2} Seconds");
					else if(input == "2")
						Console.WriteLine($"Value Converted: {time * 1440:F2} Minutes");
					else if(input == "3")
						Console.WriteLine($"Value Converted: {time * 24:F2} Hours");
					else if(input == "4")
						Console.WriteLine($"Value Converted: {time / 7:F2} Weeks");
					else if(input == "5")
						Console.WriteLine($"Value Converted: {time / 30.417:F2} Months");
					
					break;
				case "5":
					Console.Clear();
					Console.WriteLine("Insert the value in Weeks:");
					readResult = Console.ReadLine();
					if (readResult != null)
					{
						time = DoubleConvert(readResult);
					}
					Console.Clear();
					Console.WriteLine("Select the value to convert to:");
					Console.WriteLine("\n1. Seconds\n2. minutes\n3. Hours\n4. days\n5. Months");
					readResult = Console.ReadLine();
					if(readResult != null)
					{
						input = readResult;
					}
					Console.Clear();
					if(input == "1")
						Console.WriteLine($"Value Converted: {time * 604800:F2} Seconds");
					else if(input == "2")
						Console.WriteLine($"Value Converted: {time * 10080:F2} Minutes");
					else if(input == "3")
						Console.WriteLine($"Value Converted: {time * 168:F2} Hours");
					else if(input == "4")
						Console.WriteLine($"Value Converted: {time * 7:F2} Days");
					else if(input == "5")
						Console.WriteLine($"Value Converted: {time / 4.34:F2} Months");
					break;
				case "6":
					Console.Clear();
					Console.WriteLine("Insert the value in Months:");
					readResult = Console.ReadLine();
					if (readResult != null)
					{
						time = DoubleConvert(readResult);
					}
					Console.Clear();
					Console.WriteLine("\nSelect the value to convert to:");
					Console.WriteLine("\n1. Seconds\n2. minutes\n3. Hours\n4. days\n5. Weeks");
					readResult = Console.ReadLine();
					if (readResult != null)
					{
						input = readResult;
					}
					Console.Clear();
					if(input == "1")
						Console.WriteLine($"Value Converted: {time * (86400 * 30):F2} Seconds");
					else if(input == "2")
						Console.WriteLine($"Value Converted: {time * 43800:F2} Minutes");
					else if(input == "3")
						Console.WriteLine($"Value Converted: {time * 730:F2} Hours");
					else if(input == "4")
						Console.WriteLine($"Value Converted: {time * 30.417:F2} Days");
					else if(input == "5")
						Console.WriteLine($"Value Converted: {time * 4.34:F2} Weeks");
					break;
			}
			Console.WriteLine("1. New Measure\n2. Exit");
			readResult = Console.ReadLine();
			if(readResult == "2")
				valid = false;
		}while(valid == true);
			break;

		//lenght
		case "3":
			
			do
			{
				string input = "";	
				Console.WriteLine("Lenght Converter:");
				Console.WriteLine("Select a option:");
				Console.WriteLine("1. Centimeters\n2. Meters\n3. Kilometers\n4. Inch\n5. Foot\n6. Yard\n7. Mile");
				readResult = Console.ReadLine();
				if (readResult != null)
				{
					input = readResult;
				}
				switch (input)
				{
					case "1":
						Console.Clear();
						Console.WriteLine("Insert the value in centimeters:");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							extent = DoubleConvert(readResult);
						}
						Console.Clear();
						Console.WriteLine("Select the value to convert to");
						Console.WriteLine("1. Meters\n2. Kilometers\n3. Inch\n4. Foot\n5. Yard\n6. Mile");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							input = readResult;
						}
						Console.Clear();
						if (input == "1")
						{
							Console.WriteLine($"Value Converted: {extent / 100:F2} Meters");
						}
						else if (input == "2")
						{
							Console.WriteLine($"Value Converted: {extent / 100000:F2} Kilometers");
						}
						else if (input == "3")
						{
							Console.WriteLine($"Value Converted: {extent / 2.54:F2} Inches");
						}
						else if (input == "4")
						{
							Console.WriteLine($"Value Converted: {extent / 30.48:F2} Feets");
						}
						else if (input == "5")
						{
							Console.WriteLine($"Value Converted: {extent / 91.44:F2} Yards");
						}
						else if (input == "6")
						{
							Console.WriteLine($"Value Converted: {extent / 160900:F2} Miles");
						}

						Console.WriteLine("\nNew Conversion:\n1. Yes\n2. Exit");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							input = readResult;
						}
						if (input == "2")
						{
							valid = false;
						}
						break;
					case "2":
						Console.Clear();
						Console.WriteLine("Insert the value in meters:");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							extent = DoubleConvert(readResult);
						}
						Console.Clear();
						Console.WriteLine("Select the value to convert to");
						Console.WriteLine("1. Centimeters\n2. Kilometers\n3. Inch\n4. Foot\n5. Yard\n6. Mile");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							input = readResult;
						}
						Console.Clear();
						if (input == "1")
						{
							Console.WriteLine($"Value Converted: {extent * 100:F2} Centimeters");
						}
						else if (input == "2")
						{
							Console.WriteLine($"Value Converted: {extent / 1000:F2} Kilometers");
						}
						else if (input == "3")
						{
							Console.WriteLine($"Value Converted: {extent * 39.37:F2} Inches");
						}
						else if (input == "4")
						{
							Console.WriteLine($"Value Converted: {extent * 3.281:F2} Feets");
						}
						else if (input == "5")
						{
							Console.WriteLine($"Value Converted: {extent / 1.094:F2} Yards");
						}
						else if (input == "6")
						{
							Console.WriteLine($"Value Converted: {extent / 1609:F2} Miles");
						}

						Console.WriteLine("\nNew Conversion:\n1. Yes\n2. Exit");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							input = readResult;
						}
						if (input == "2")
						{
							valid = false;
						}
						break;
					case "3":
						Console.Clear();
						Console.WriteLine("Insert the value in kilometers:");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							extent = DoubleConvert(readResult);
						}
						Console.Clear();
						Console.WriteLine("Select the value to convert to");
						Console.WriteLine("1. Centimeters\n2. Meters\n3. Inch\n4. Foot\n5. Yard\n6. Mile");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							input = readResult;
						}
						Console.Clear();
						if (input == "1")
						{
							Console.WriteLine($"Value Converted: {extent * 100000:F2} Centimeters");
						}
						else if (input == "2")
						{
							Console.WriteLine($"Value Converted: {extent * 1000:F2} Meters");
						}
						else if (input == "3")
						{
							Console.WriteLine($"Value Converted: {extent * 39370:F2} Inches");
						}
						else if (input == "4")
						{
							Console.WriteLine($"Value Converted: {extent * 3281:F2} Feets");
						}
						else if (input == "5")
						{
							Console.WriteLine($"Value Converted: {extent * 1094:F2} Yards");
						}
						else if (input == "6")
						{
							Console.WriteLine($"Value Converted: {extent / 1.609:F2} Miles");
						}

						Console.WriteLine("\nNew Conversion:\n1. Yes\n2. Exit");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							input = readResult;
						}
						if (input == "2")
						{
							valid = false;
						}
						break;
					case "4":
						Console.Clear();
						Console.WriteLine("Insert the value in inches:");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							extent = DoubleConvert(readResult);
						}
						Console.Clear();
						Console.WriteLine("Select the value to convert to");
						Console.WriteLine("1. Centimeters\n2. Meters\n3. Kilometers\n4. Foot\n5. Yard\n6. Mile");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							input = readResult;
						}
						Console.Clear();
						if (input == "1")
						{
							Console.WriteLine($"Value Converted: {extent * 2.54:F2} Centimeters");
						}
						else if (input == "2")
						{
							Console.WriteLine($"Value Converted: {extent / 39.37:F2} Meters");
						}
						else if (input == "3")
						{
							Console.WriteLine($"Value Converted: {extent / 39370:F2} Kilometers");
						}
						else if (input == "4")
						{
							Console.WriteLine($"Value Converted: {extent / 12:F2} Feets");
						}
						else if (input == "5")
						{
							Console.WriteLine($"Value Converted: {extent / 36:F2} Yards");
						}
						else if (input == "6")
						{
							Console.WriteLine($"Value Converted: {extent / 63360:F2} Miles");
						}

						Console.WriteLine("\nNew Conversion:\n1. Yes\n2. Exit");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							input = readResult;
						}
						if (input == "2")
						{
							valid = false;
						}
						break;
					case "5":
						Console.Clear();
						Console.WriteLine("Insert the value in Feets:");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							extent = DoubleConvert(readResult);
						}
						Console.Clear();
						Console.WriteLine("Select the value to convert to");
						Console.WriteLine("1. Centimeters\n2. Meters\n3. Kilometers\n4. Inch\n5. Yard\n6. Mile");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							input = readResult;
						}
						Console.Clear();
						if (input == "1")
						{
							Console.WriteLine($"Value Converted: {extent * 30.48:F2} Centimeters");
						}
						else if (input == "2")
						{
							Console.WriteLine($"Value Converted: {extent / 3.281:F2} Meters");
						}
						else if (input == "3")
						{
							Console.WriteLine($"Value Converted: {extent / 3281:F2} Kilometers");
						}
						else if (input == "4")
						{
							Console.WriteLine($"Value Converted: {extent * 12:F2} Inches");
						}
						else if (input == "5")
						{
							Console.WriteLine($"Value Converted: {extent / 3:F2} Yards");
						}
						else if (input == "6")
						{
							Console.WriteLine($"Value Converted: {extent / 5280:F2} Miles");
						}

						Console.WriteLine("\nNew Conversion:\n1. Yes\n2. Exit");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							input = readResult;
						}
						if (input == "2")
						{
							valid = false;
						}
						break;
					case "6":
						Console.Clear();
						Console.WriteLine("Insert the value in yards:");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							extent = DoubleConvert(readResult);
						}
						Console.Clear();
						Console.WriteLine("Select the value to convert to");
						Console.WriteLine("1. Centimeters\n2. Meters\n3. Kilometers\n4. Inch\n5. Foot\n6. Mile");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							input = readResult;
						}
						Console.Clear();
						if (input == "1")
						{
							Console.WriteLine($"Value Converted: {extent * 91.84:F2} Centimeters");
						}
						else if (input == "2")
						{
							Console.WriteLine($"Value Converted: {extent / 1.094:F2} Meters");
						}
						else if (input == "3")
						{
							Console.WriteLine($"Value Converted: {extent / 1094:F2} Kilometers");
						}
						else if (input == "4")
						{
							Console.WriteLine($"Value Converted: {extent * 36:F2} Inches");
						}
						else if (input == "5")
						{
							Console.WriteLine($"Value Converted: {extent * 3:F2} Feets");
						}
						else if (input == "6")
						{
							Console.WriteLine($"Value Converted: {extent / 1760:F2} Miles");
						}

						Console.WriteLine("\nNew Conversion:\n1. Yes\n2. Exit");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							input = readResult;
						}
						if (input == "2")
						{
							valid = false;
						}
						break;
					case "7":
						Console.Clear();
						Console.WriteLine("Insert the value in miles:");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							extent = DoubleConvert(readResult);
						}
						Console.Clear();
						Console.WriteLine("Select the value to convert to");
						Console.WriteLine("1. Centimeters\n2. Meters\n3. Kilometers\n4. Inch\n5. Foot\n6. Yard");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							input = readResult;
						}
						Console.Clear();
						if (input == "1")
						{
							Console.WriteLine($"Value Converted: {extent * 160900:F2} Centimeters");
						}
						else if (input == "2")
						{
							Console.WriteLine($"Value Converted: {extent * 1609:F2} Meters");
						}
						else if (input == "3")
						{
							Console.WriteLine($"Value Converted: {extent * 1.609:F2} Kilometers");
						}
						else if (input == "4")
						{
							Console.WriteLine($"Value Converted: {extent * 63360:F2} Inches");
						}
						else if (input == "5")
						{
							Console.WriteLine($"Value Converted: {extent * 5280:F2} Feets");
						}
						else if (input == "6")
						{
							Console.WriteLine($"Value Converted: {extent * 1760:F2} Yards");
						}

						Console.WriteLine("\nNew Conversion:\n1. Yes\n2. Exit");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							input = readResult;
						}
						if (input == "2")
						{
							valid = false;
						}
						break;
				}
			} while (valid == true);
			break;

	}
}

// Metodo de conversão
double DoubleConvert(string word)
{
	double resultado;
	try
	{
		resultado = double.Parse(word);

        return Math.Round(resultado, 2);
	}

	catch (FormatException ex)
	{
		throw new ArgumentException($"Valor '{word}' não é um número double válido.", nameof(word), ex);
	}
	catch (OverflowException ex)
	{
		throw new ArgumentException($"Valor '{word}' é muito grande ou pequeno para um double.", nameof(word), ex);
	}
}