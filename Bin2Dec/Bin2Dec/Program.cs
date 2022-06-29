using System.Text.RegularExpressions;

namespace Bin2Dec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter up to 8 binary digits: ");
                var binaryDigits = Console.ReadLine();

                if (binaryDigits.Length > 8)
                    throw new OverflowException("binary number over 8 digits.");

                var containOnlyBinary = Regex.IsMatch(binaryDigits.Trim(), "[^01]");

                if (containOnlyBinary)
                    throw new IOException("binary number with different characters.");

                Console.WriteLine(Convert.ToInt32(binaryDigits, 2));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}