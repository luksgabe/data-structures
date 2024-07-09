using System.CodeDom.Compiler;

public class FizzBuss
{

    /*
     * Complete the 'fizzBuzz' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void fizzBuzz(int n)
    {
        for (int i = 1; i < n + 1; i++)
        {
            if (isMultiple(i, 3) && isMultiple(i, 5))
            {
                Console.Write("FizzBuzz");
            }
            else if (isMultiple(i, 3) && !isMultiple(i, 5))
            {
                Console.Write("Fizz");
            }
            else if (!isMultiple(i, 3) && isMultiple(i, 5))
            {
                Console.Write("Buzz");
            }
            else
            {
                Console.Write(i);
            }
        }



    }

    private static bool isMultiple(int value, int referenceValue)
    {
        return (value % referenceValue) == 0;
    }

}

