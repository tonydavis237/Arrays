/*
 * Author: Anthony Davis
 * Date: 02/06/2020
 * Description: Creating an automatic array
 */ 
using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an array to display the numbers 1-25
            int[] numberArray = new int[25];

            // For loop to display all the elements in the array
            for(int count = 1; count <= 25; count++)
            {
                numberArray[count - 1] = count;
                Console.WriteLine("Element value = " + numberArray[count-1].ToString());
            }
            // Allows the user to exit the program
            Console.ReadKey(true);
        }
    }
}
