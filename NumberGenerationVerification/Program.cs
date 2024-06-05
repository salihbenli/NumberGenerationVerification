using System.Text;
namespace NumberGenerationVerification;
internal class Program
{
    private const string chars = "ACDEFGHKLMNPRTXYZ234579";
    private static int codeLength = 8;
    private static int numberOfCodes = 1000;

    /// <summary>
    /// It starts the code generation process by calling the GenerateCodes method.
    /// </summary>
    public static void Main()
    {
        GenerateCodes();
    }
    /// <summary>
    /// It creates 1000 random 8-character data based on the random values ​​taken from the specified character string.
    /// The generated codes are displayed on the console screen, and then the checked code result is displayed on the console screen along with the result.
    /// </summary>
    private static void GenerateCodes()
    {
        Random random = new Random();
        for (int line = 0; line < numberOfCodes; line++)
        {
            StringBuilder code = new StringBuilder(codeLength);
            for (int indexNumber = 0; indexNumber < codeLength; indexNumber++)
            {
                code.Append(chars[random.Next(chars.Length)]);
            }
            Console.WriteLine(line + "-" + code);

            bool isValid = CheckCode(code.ToString());
            if (isValid)
            {
                Console.WriteLine("Valid Code= " + code);
            }
            else
            {
                Console.WriteLine("Invalid Code= " + code);
            }
        }
    }
    /// <summary>
    /// It is checked whether the incoming value has the desired number of characters. If it is not the desired length, false is returned.
    /// It is checked whether the incoming value is within the specified characters. If it does not contain the specified characters, false is returned.
    /// </summary>
    /// <param name="code"></param>
    /// <returns></returns>
    private static bool CheckCode(string code)
    {
        if (code.Length != codeLength)
        {
            return false;
        }
        foreach (char c in code)
        {
            if (!chars.Contains(c))
            {
                return false;
            }
        }
        return true;
    }
}