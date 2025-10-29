using ConversorMedidas;
using System;

public static class TemperatureConverter
{
    public static void Exec()
    {
      
        bool valid = true;
        do{
            
            double temp = 0;
            string input = "";
            string selection = "";

            Console.Clear();
            Console.WriteLine("Temperature Converter");
            Console.WriteLine("Select a option:");
            Console.WriteLine("1. Celsius\n2. Fahrenheit\n3. Kelvin");

            string ? readResult = Console.ReadLine();

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
                        temp = Utils.DoubleConvert(readResult);                                                          
                    }		
                
                    Console.Clear();
                    Console.WriteLine("Select the measure to convert to:");
                    Console.WriteLine("1. Fahrenheit\n2. Kelvin");
                    readResult = Console.ReadLine();
                    if (readResult != null)
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
                        temp = Utils.DoubleConvert(readResult);
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
                    if (input == "1")
                        Console.WriteLine($"Temperature in Celsius:\n{(temp - 32) * 1.8:F2}");

                    else if (input == "2")
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
                        temp = Utils.DoubleConvert(readResult);
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

    }
}