using System.ComponentModel.Design;
using System.Runtime.InteropServices.Marshalling;
using ConversorMedidas;

public static class Weight
{
    public static void Exec ()
    {
        string input = "";
        double weight = 0;
        Console.Clear();
        Console.WriteLine("Weight converter");
        Console.WriteLine("Select A type of weight:");
        Console.WriteLine("1. Miligrams\n2. Grams\n3. Kilograms\n4. Ounce\n5. Pound");
        string? readResult = Console.ReadLine();
        if (readResult != null)
        {
            input = readResult;
        }
        
        switch(input)
        {
            case "1":
                Console.Clear();
                Console.WriteLine("Insert the value in Miligrams:");
                readResult = Console.ReadLine();
                if(readResult != null)
                {
                    weight = Utils.DoubleConvert(readResult);
                }
                Console.Clear();
                Console.WriteLine("Select the value to convert to:");
                Console.WriteLine("1. Grams\n2. Kilograms\n3. Ounce\n4. Pound");
                readResult = Console.ReadLine();
                if(readResult != null)
                {
                    input = readResult;
                }
                if (input == "1")
                    Console.WriteLine($"{weight / 1000:F2} Grams");
                else if (input == "2")
                    Console.WriteLine($"{weight / 1000000:F2} Kilograms");
                else if (input == "3")
                    Console.WriteLine($"{weight / 28350:F2} Ounces");
                else if (input == "4")
                    Console.WriteLine($"{weight / 453600:F2} Pounds");

                break;
            case "2":
                Console.Clear();
                Console.WriteLine("Insert the value in Grams:");
                readResult = Console.ReadLine();
                if(readResult != null)
                {
                    weight = Utils.DoubleConvert(readResult);
                }
                Console.Clear();
                Console.WriteLine("Select the value to convert to:");
                Console.WriteLine("1. Miligrams\n2. Kilograms\n3. Ounce\n4. Pound");
                readResult = Console.ReadLine();
                if(readResult != null)
                {
                    input = readResult;
                }
                if (input == "1")
                    Console.WriteLine($"{weight * 1000:F2} Miligrams");
                 else if (input == "2")
                    Console.WriteLine($"{weight / 1000:F2} Kilograms");
                else if (input == "3")
                    Console.WriteLine($"{weight / 28.35:F2} Ounces");
                else if (input == "4")
                    Console.WriteLine($"{weight / 453.6:F2} Pounds");
                break;
            case "3":
                Console.Clear();
                Console.WriteLine("Insert the value in Kilograms:");
                readResult = Console.ReadLine();
                if(readResult != null)
                {
                    weight = Utils.DoubleConvert(readResult);
                }
                Console.Clear();
                Console.WriteLine("Select the value to convert to:");
                Console.WriteLine("1. Miligrams\n2. Grams\n3. Ounce\n4. Pound");
                readResult = Console.ReadLine();
                if(readResult != null)
                {
                    input = readResult;
                }
                if (input == "1")
                    Console.WriteLine($"{weight * 1000000:F2} Miligrams");
                 else if (input == "2")
                    Console.WriteLine($"{weight * 1000:F2} Grams");
                else if (input == "3")
                    Console.WriteLine($"{weight * 35.274:F2} Ounces");
                else if (input == "4")
                    Console.WriteLine($"{weight * 2.205:F2} Pounds");
                break;
            case "4":
                Console.Clear();
                Console.WriteLine("Insert the value in Ounces:");
                readResult = Console.ReadLine();
                if(readResult != null)
                {
                    weight = Utils.DoubleConvert(readResult);
                }
                Console.Clear();
                Console.WriteLine("Select the value to convert to:");
                Console.WriteLine("1. Miligrams\n2. Grams\n3. Kilograms\n4. Pound");
                readResult = Console.ReadLine();
                if(readResult != null)
                {
                    input = readResult;
                }
                if (input == "1")
                    Console.WriteLine($"{weight * 28350:F2} Miligrams");
                 else if (input == "2")
                    Console.WriteLine($"{weight * 28.35:F2} Grams");
                else if (input == "3")
                    Console.WriteLine($"{weight / 35.274:F2} Kilograms");
                else if (input == "4")
                    Console.WriteLine($"{weight / 16:F2} Pounds");
                break;
            case "5":
                Console.Clear();
                Console.WriteLine("Insert the value in Pounds:");
                readResult = Console.ReadLine();
                if(readResult != null)
                {
                    weight = Utils.DoubleConvert(readResult);
                }
                Console.Clear();
                Console.WriteLine("Select the value to convert to:");
                Console.WriteLine("1. Miligrams\n2. Grams\n3. Kilograms\n4. Ounces");
                readResult = Console.ReadLine();
                if(readResult != null)
                {
                    input = readResult;
                }
                if (input == "1")
                    Console.WriteLine($"{weight * 453600:F2} Miligrams");
                 else if (input == "2")
                    Console.WriteLine($"{weight * 453.6:F2} Grams");
                else if (input == "3")
                    Console.WriteLine($"{weight * 2.205:F2} Kilograms");
                else if (input == "4")
                    Console.WriteLine($"{weight * 16:F2} Ounces");
                break;
        }

    }
}