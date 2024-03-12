//CoderByte Array Challenge C#

using System;
using System.Linq;

class MainClass
{

    static void Main()
    {
        Console.WriteLine(ArrayChallenge(Console.ReadLine()));
    }

    public static string ArrayChallenge(int[] arr)
    {
        int maxNumber = arr.Max();

        int sumWithoutMax = arr.Sum() - maxNumber;

        if (sumWithoutMax == maxNumber)
        {
            return "true";
        }

        for (int i = 0; i < arr.Length; i++)
        {
            int currentSum = 0;

            for (int j = 0; j < arr.Length; j++)
            {
                if (i != j)
                {
                    currentSum += arr[j];

                    if (currentSum == maxNumber)
                    {
                        return "true";
                    }
                }
            }
        }
        return "false";
    }
}