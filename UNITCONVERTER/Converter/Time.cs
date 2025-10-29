using ConversorMedidas;

public static class TimeConverter
{
    public static void Exec()
    {
        bool valid = true;
        do
        {
            double time = 0;
			string input = "";	
			Console.WriteLine("Time Converter:");
			Console.WriteLine("Select a option:");
			Console.WriteLine("1. Seconds\n2. Minutes\n3. Hours\n4. Days\n5. Months\n6. Years");
			string ? readResult = Console.ReadLine();
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
						time = Utils.DoubleConvert(readResult);
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
						time = Utils.DoubleConvert(readResult);
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
						time = Utils.DoubleConvert(readResult);
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
						time = Utils.DoubleConvert(readResult);
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
						time = Utils.DoubleConvert(readResult);
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
						time = Utils.DoubleConvert(readResult);
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

    }

}