using System;
using System.Collections.Generic;
using System.Globalization;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            //#region Arrays
            //// Create an integer Array of size 50
            //var intArray = new int[50];

            ////Create a method to populate the number array with 50 random numbers that are between 0 and 50
            //var rand = new Random();
            //for (var i = 0; i < intArray.Length; i++)
            //{
            //    intArray[i] = rand.Next(0, 50);
            //}

            ////Print the first number of the array
            //Console.WriteLine(intArray[0]);
            ////Print the last number of the array            
            //Console.WriteLine(intArray[intArray.Length - 1]);
            //Console.WriteLine("All Numbers Original");
            ////Use this method to print out your numbers from arrays or lists
            //NumberPrinter(intArray);
            //Console.WriteLine("\n-------------------\n");

            ////Reverse the contents of the array and then print the array out to the console.
            ////Try for 2 different ways
            ///*     Hint: Array._____(); Create a custom method     */

            //Console.WriteLine("All Numbers Reversed:");
            //Array.Reverse(intArray);
            //NumberPrinter(intArray);
            //Console.ReadLine();

            //Console.WriteLine("\n---------REVERSE CUSTOM------------");
            //ReverseArray(intArray, out intArray);
            //NumberPrinter(intArray);
            //Console.WriteLine("-------------------");
            //Console.ReadLine();
            //Console.Clear();

            ////Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            //Console.WriteLine("Multiple of three = 0: ");
            //ThreeKiller(intArray);
            //NumberPrinter(intArray);
            //Console.ReadLine();

            //Console.WriteLine("-------------------");

            ////Sort the array in order now
            ///*      Hint: Array.____()      */
            //Console.WriteLine("\nSorted numbers:");
            //Array.Sort(intArray);
            //NumberPrinter(intArray);
            //Console.ReadLine();

            //Console.WriteLine("\n************End Arrays*************** \n");
            //#endregion

            
            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            var numList = new List<int>();

            //Print the capacity of the list to the console
            Console.WriteLine($"List starting capacity: {numList.Capacity}");
            Console.ReadLine();


            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numList);
            

            //Print the new capacity
            Console.WriteLine($"New starting capacity for the list: {numList.Capacity}");
            Console.ReadLine();
            

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            NumberChecker(numList);
            Console.ReadLine();

            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            //NumberPrinter();
            Console.WriteLine("-------------------");
            NumberPrinter(numList);
            Console.ReadLine();

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Odds Only!!");
            OddKiller(numList);
            Console.ReadLine();
            Console.WriteLine("------------------");
            NumberPrinter(numList);
            Console.ReadLine();
            //Sort the list then print results
            Console.WriteLine("Sorted Odds!!");
            numList.Sort();
            NumberPrinter(numList);
            Console.ReadLine();

            
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            var listToArray = numList.ToArray();


            //Clear the list
            numList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                } 
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (var i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
            }

        }

        private static void NumberChecker(List<int> numberList)
        {
            var repeat = true;
            int parseNumber;
            Console.WriteLine("What number will you search for in the number list?");

            do
            {
                Console.Write("> ");
                var userInput = Console.ReadLine();
                if (int.TryParse(userInput, out parseNumber))
                {
                    if (numberList.Contains(parseNumber))
                    {
                        Console.WriteLine("Your number was found!");
                        repeat = false;
                    }
                    else
                    {
                        Console.WriteLine("Your number wasn't found in the list.");
                        repeat = false;
                    }

                    //for (var i = 0; i < numberList.Capacity; i++)
                    //{
                    //    if (numberList[i] == parseNumber)
                    //    {
                    //        Console.WriteLine("Your number is found!");
                    //        Console.WriteLine($"Your number was found @ index: {i}");
                    //        repeat = false;
                    //    }
                    //    else
                    //    {
                    //        Console.WriteLine("Your number was not present in the list.");
                    //    }
                    //}
                    
                }
                else
                {
                    Console.WriteLine("Your input is invalid.");
                }

            } while (repeat);
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (var i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(0, 50));
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

        }        

        private static void ReverseArray(int[] array, out int[] outArray)
        {
            var newArray = new int[array.Length];
            for (var i = 0; i < array.Length; i++)
            {
                // last number of input array added to first index of return array, input array decremented, input array incrememnted
                newArray[i] = array[(array.Length - 1)- i];
            }
            outArray = newArray;
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
