namespace ConversorMedidas
{
    public static class Utils
    {
        public static double DoubleConvert(string input)
        {
            try
            {
                return Math.Round(double.Parse(input), 2);
            }
            catch
            {
                Console.WriteLine("Invalid number. Try again.");
                return 0;
            }
        }
    }
}