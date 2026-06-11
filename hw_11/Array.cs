using System;
using System.Collections.Generic;
using System.Text;

namespace hw_11
{
    internal class Array : IOutput2, ICalc2
    {

        // private field to store the array of numbers
        private int[] numbers;

        // public property to access and modify the array with validation
        public int[] Numbers { 
            get
            {
                return numbers;
            }
            set
            {
                if (value == null || value.Length == 0) 
                {
                    Console.WriteLine("Array cannot be null or empty.");
                    return;
                }
                numbers = value;
            }}

        // constructor to initialize the array
        public Array(int[] numbers)
        {
            Numbers = numbers; // validation will runs here
        }

        // method to show even numbers from the array
        public void showEven()
        {
            Console.Write("Even numbers: ");
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();

        }

        // method to show odd numbers from the array
        public void showOdd()
        {
            Console.Write("Odd numbers: ");
            foreach (int i in numbers)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        public int CountDistinct()
        {
            int count = 0;
            foreach (int i in numbers)
            {
                int equalCount = 0;
                foreach (int j in numbers)
                {
                    if (i == j)
                        equalCount++;
                }
                if (equalCount == 1)
                    count++;
            }
            return count;
        }

        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            foreach (int i in numbers)
                if (i == valueToCompare)
                    count++;
            return count;
        }
    }
}
