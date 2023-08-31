namespace NumberSortApp;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            string Input = "1,3,2,5,4,7,6";
            // Sample data with characters
            //string Input = "1,2,3,A,4,5,6";
            if (!string.IsNullOrEmpty(Input))
            {
                bool isIntegers = CheckIfInputsAreIntegers(Input);

                if (isIntegers)
                {
                    String output = String.Join(",", Input
                     .Split(',')
                     .Select(x => int.Parse(x))
                     .OrderByDescending(x => x));

                    Console.WriteLine(output);
                }
                else
                {
                    Console.WriteLine("Input should only contain numbers");
                }
            }
        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
        }

    }

    public static bool CheckIfInputsAreIntegers(string numbers)
    {
        string[] stringArray = numbers.Split(new char[] { ',' },
        StringSplitOptions.RemoveEmptyEntries);
        int length = stringArray.Length;
        int numvalue;

        for (int i = 0; i < length; i++)
        {

            bool isNumber = int.TryParse(stringArray[i], out numvalue);
            if (!isNumber)
                return false;

        }

        return true;
    }
}
