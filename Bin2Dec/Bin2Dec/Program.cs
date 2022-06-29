using System.Text.RegularExpressions;

namespace Bin2Dec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("How many binary numbers do you want to convert? ");
                var quantity = int.Parse(Console.ReadLine());

                List<string> list = new();

                Console.WriteLine("");

                for (int i = 1; i <= quantity; i++)
                {
                    Console.WriteLine($"#{i}");
                    Console.Write("Enter up to 8 binary digits: ");
                    var binaryDigits = Console.ReadLine();

                    if (binaryDigits.Length > 8)
                        throw new OverflowException("binary number over 8 digits.");

                    var containsOtherCharacters = Regex.IsMatch(binaryDigits.Trim(), "[^01]");

                    if (containsOtherCharacters)
                        throw new IOException("binary number with different characters.");

                    list.Add(binaryDigits.Trim());

                    Console.WriteLine("---");
                }

                Console.WriteLine("Binaries converted to Decimals:");

                foreach (var item in list)
                    Console.WriteLine(Convert.ToInt32(item, 2));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}