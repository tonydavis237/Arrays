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

            // Creating an integer value in order to show the iteration the loop will be in
            int popArray = 1;

            // For loop to display all the elements in the array
            for(int count = 0; count < 25; count++)
            {
                numberArray[count] = popArray;
                Console.WriteLine("Element value = " + popArray.ToString());
                popArray++;
            }
            // Allows the user to exit the program
            Console.ReadKey(true);
        }
    }
}
