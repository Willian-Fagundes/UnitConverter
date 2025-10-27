// See https://aka.ms/new-console-template for more information
					
double temp = 0;
double time = 0;
double extent = 0;
string ? readResult;
bool isValid = true;

while(isValid == true)
{	
	bool valid = true;
	string selection = "";
	
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
							Console.WriteLine($"Temperature in Fahrenheit:\n{(temp * 1.8) + 32}");
						}
						else if (input == "2")
						{
							Console.Clear();
							Console.WriteLine($"Temperature in Kelvin:\n{temp + 273.15}");
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
							Console.WriteLine($"Temperature in Celsius:\n{(temp - 32) * 1.8}");
						else if(input == "2")
							Console.WriteLine($"Temperature in Fahrenheit:\n{((temp - 32) * 1.8) + 273.15}");
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
							Console.WriteLine($"Temperature in Celsius:\n{temp - 273.15}");
						else if (input == "2")
							Console.WriteLine($"Temperature in Fahrenheit:\n{(1.8 * (temp - 273.15)) + 32}");

						
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
						Console.WriteLine($"Value Converted: {time / 60} Minutes");
					else if(input == "2")
						Console.WriteLine($"Value Converted: {time / 3600} Hours");
					else if(input == "3")
						Console.WriteLine($"Value Converted: {time / 86400} Days");
					else if(input == "4")
						Console.WriteLine($"Value Converted: {time / 604800} Months");
					else if(input == "5")
						Console.WriteLine($"Value Converted: {time / (86400 * 30)} Years");
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
						Console.WriteLine($"Value Converted: {time * 60} Seconds");
					else if(input == "2")
						Console.WriteLine($"Value Converted: {time / 60} Hours");
					else if(input == "3")
						Console.WriteLine($"Value Converted: {time / 1440} Days");
					else if(input == "4")
						Console.WriteLine($"Value Converted: {time / 10080} Weeks");
					else if(input == "5")
						Console.WriteLine($"Value Converted: {time / 43800} Months");

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
						Console.WriteLine($"Value Converted: {time * 3600} Seconds");
					else if(input == "2")
						Console.WriteLine($"Value Converted: {time *60} Minutes");
					else if(input == "3")
						Console.WriteLine($"Value Converted: {time / 24} Days");
					else if(input == "4")
						Console.WriteLine($"Value Converted: {time / 168} Weeks");
					else if(input == "5")
						Console.WriteLine($"Value Converted: {time / 730} Months");

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
						Console.WriteLine($"Value Converted: {time * 86400} Seconds");
					else if(input == "2")
						Console.WriteLine($"Value Converted: {time * 1440} Minutes");
					else if(input == "3")
						Console.WriteLine($"Value Converted: {time * 24} Hours");
					else if(input == "4")
						Console.WriteLine($"Value Converted: {time / 7} Weeks");
					else if(input == "5")
						Console.WriteLine($"Value Converted: {time / 30.417} Months");
					
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
						Console.WriteLine($"Value Converted: {time * 604800} Seconds");
					else if(input == "2")
						Console.WriteLine($"Value Converted: {time * 10080} Minutes");
					else if(input == "3")
						Console.WriteLine($"Value Converted: {time * 168} Hours");
					else if(input == "4")
						Console.WriteLine($"Value Converted: {time * 7} Days");
					else if(input == "5")
						Console.WriteLine($"Value Converted: {time / 4.34} Months");
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
						Console.WriteLine($"Value Converted: {time * (86400 * 30)} Seconds");
					else if(input == "2")
						Console.WriteLine($"Value Converted: {time * 43800} Minutes");
					else if(input == "3")
						Console.WriteLine($"Value Converted: {time * 730} Hours");
					else if(input == "4")
						Console.WriteLine($"Value Converted: {time * 30.417} Days");
					else if(input == "5")
						Console.WriteLine($"Value Converted: {time * 4.34} Weeks");
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
							Console.WriteLine($"Value Converted: {extent / 100} Meters");
						}
						else if (input == "2")
						{
							Console.WriteLine($"Value Converted: {extent / 100000} Kilometers");
						}
						else if (input == "3")
						{
							Console.WriteLine($"Value Converted: {extent / 2.54} Inches");
						}
						else if (input == "4")
						{
							Console.WriteLine($"Value Converted: {extent / 30.48} Feets");
						}
						else if (input == "5")
						{
							Console.WriteLine($"Value Converted: {extent / 91.44} Yards");
						}
						else if (input == "6")
						{
							Console.WriteLine($"Value Converted: {extent / 160900} Miles");
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
							Console.WriteLine($"Value Converted: {extent * 100} Centimeters");
						}
						else if (input == "2")
						{
							Console.WriteLine($"Value Converted: {extent / 1000} Kilometers");
						}
						else if (input == "3")
						{
							Console.WriteLine($"Value Converted: {extent * 39.37} Inches");
						}
						else if (input == "4")
						{
							Console.WriteLine($"Value Converted: {extent * 3.281} Feets");
						}
						else if (input == "5")
						{
							Console.WriteLine($"Value Converted: {extent / 1.094} Yards");
						}
						else if (input == "6")
						{
							Console.WriteLine($"Value Converted: {extent / 1609} Miles");
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
							Console.WriteLine($"Value Converted: {extent * 100000} Centimeters");
						}
						else if (input == "2")
						{
							Console.WriteLine($"Value Converted: {extent * 1000} Meters");
						}
						else if (input == "3")
						{
							Console.WriteLine($"Value Converted: {extent * 39370} Inches");
						}
						else if (input == "4")
						{
							Console.WriteLine($"Value Converted: {extent * 3281} Feets");
						}
						else if (input == "5")
						{
							Console.WriteLine($"Value Converted: {extent * 1094} Yards");
						}
						else if (input == "6")
						{
							Console.WriteLine($"Value Converted: {extent / 1.609} Miles");
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
							Console.WriteLine($"Value Converted: {extent * 2.54} Centimeters");
						}
						else if (input == "2")
						{
							Console.WriteLine($"Value Converted: {extent / 39.37} Meters");
						}
						else if (input == "3")
						{
							Console.WriteLine($"Value Converted: {extent / 39370} Kilometers");
						}
						else if (input == "4")
						{
							Console.WriteLine($"Value Converted: {extent / 12} Feets");
						}
						else if (input == "5")
						{
							Console.WriteLine($"Value Converted: {extent / 36} Yards");
						}
						else if (input == "6")
						{
							Console.WriteLine($"Value Converted: {extent / 63360} Miles");
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
							Console.WriteLine($"Value Converted: {extent * 30.48} Centimeters");
						}
						else if (input == "2")
						{
							Console.WriteLine($"Value Converted: {extent / 3.281} Meters");
						}
						else if (input == "3")
						{
							Console.WriteLine($"Value Converted: {extent / 3281} Kilometers");
						}
						else if (input == "4")
						{
							Console.WriteLine($"Value Converted: {extent * 12} Inches");
						}
						else if (input == "5")
						{
							Console.WriteLine($"Value Converted: {extent / 3} Yards");
						}
						else if (input == "6")
						{
							Console.WriteLine($"Value Converted: {extent / 5280} Miles");
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
							Console.WriteLine($"Value Converted: {extent * 91.84} Centimeters");
						}
						else if (input == "2")
						{
							Console.WriteLine($"Value Converted: {extent / 1.094} Meters");
						}
						else if (input == "3")
						{
							Console.WriteLine($"Value Converted: {extent / 1094} Kilometers");
						}
						else if (input == "4")
						{
							Console.WriteLine($"Value Converted: {extent * 36} Inches");
						}
						else if (input == "5")
						{
							Console.WriteLine($"Value Converted: {extent * 3} Feets");
						}
						else if (input == "6")
						{
							Console.WriteLine($"Value Converted: {extent / 1760} Miles");
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
							Console.WriteLine($"Value Converted: {extent * 160900} Centimeters");
						}
						else if (input == "2")
						{
							Console.WriteLine($"Value Converted: {extent * 1609} Meters");
						}
						else if (input == "3")
						{
							Console.WriteLine($"Value Converted: {extent * 1.609} Kilometers");
						}
						else if (input == "4")
						{
							Console.WriteLine($"Value Converted: {extent * 63360} Inches");
						}
						else if (input == "5")
						{
							Console.WriteLine($"Value Converted: {extent * 5280} Feets");
						}
						else if (input == "6")
						{
							Console.WriteLine($"Value Converted: {extent * 1760} Yards");
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
	double val = 0;
	bool isValid = double.TryParse(word, out val);
	return val;
}