using ConversorMedidas;

public static class LengthConverter
{
    public static void Exec()
    {
        bool valid = true;
        do
        {
            double extent = 0;
            string input = "";	
            Console.WriteLine("Lenght Converter:");
            Console.WriteLine("Select a option:");
            Console.WriteLine("1. Centimeters\n2. Meters\n3. Kilometers\n4. Inch\n5. Foot\n6. Yard\n7. Mile");
            string ? readResult = Console.ReadLine();
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
                        extent = Utils.DoubleConvert(readResult);
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
                        extent = Utils.DoubleConvert(readResult);
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
                        extent = Utils.DoubleConvert(readResult);
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
                        extent = Utils.DoubleConvert(readResult);
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
                        extent = Utils.DoubleConvert(readResult);
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
                        extent = Utils.DoubleConvert(readResult);
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
                        extent = Utils.DoubleConvert(readResult);
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
    }
}