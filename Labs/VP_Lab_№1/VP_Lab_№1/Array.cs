using System;

namespace UserLibrary
{
    public static class Array
    {
        public static (int[] EvenNumbers, int[] OddNumbers) SplitByParity(int[] sourceArray)
        {
            if (sourceArray == null || sourceArray.Length == 0)
            {
                return (new int[0], new int[0]);
            }

            int evenCount = 0;
            int oddCount = 0;

            foreach (int number in sourceArray)
            {
                if (number % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }

            int[] evenNumbers = new int[evenCount];
            int[] oddNumbers = new int[oddCount];

            int evenIndex = 0;
            int oddIndex = 0;

            foreach (int number in sourceArray)
            {
                if (number % 2 == 0)
                {
                    evenNumbers[evenIndex] = number;
                    evenIndex++;
                }
                else
                {
                    oddNumbers[oddIndex] = number;
                    oddIndex++;
                }
            }

            SortArray(evenNumbers);
            SortArray(oddNumbers);

            return (evenNumbers, oddNumbers);
        }

        private static void SortArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public static string ToString(int[] array)
        {
            if (array == null || array.Length == 0)
                return "[]";

            string result = "[";
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
                if (i < array.Length - 1)
                    result += ", ";
            }
            result += "]";
            return result;
        }
    }
}