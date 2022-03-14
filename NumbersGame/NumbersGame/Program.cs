using System;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcom To my game! let's do some math :)  ");
                //call start sequence function 
                StartSequence();

            }
            catch (Exception e)
            {
                Console.WriteLine("Something wrong happened " + e.Message);

            }
            finally
            {
                Console.WriteLine("The program is completed");
            }
        }

        static void StartSequence()
        {
            try
            {
                //prompt the user to “Enter a number greater than zero
                Console.WriteLine("Kindly , insert a number greater than zero ");
                //Utilize the Convert.ToInt32() method to convert the user’s input to an integer.
                int input = Convert.ToInt32(Console.ReadLine());
                //Instantiate a new integer array that is the size the user just inputted.
                int[] arrayOfIntegers = new int[input];
                
                int [] arrayOfInts = new int[input];
                // call populate function which return an integer of array
                arrayOfInts = Populate(arrayOfIntegers);
                int sum1 = 0;
                // call GetSum function which return an the sum of the array elements

                sum1 = GetSum(arrayOfInts);
                //Console.WriteLine("");
                int product = 0;
                // print the size of the array
                Console.WriteLine("your array is size : " + input);
                //print the array
                Console.WriteLine("The numbers in the array are [" + string.Join(", ", arrayOfIntegers) + "] ");
                //print the sum of the array
                Console.WriteLine("The sum of the array is " + sum1);
                // call GetProduct function which return an the GetProduct 

                product = GetProduct(arrayOfInts, sum1);
                decimal quotient = 0;
                // call GetQuotient function which return an the GetQuotient 

                quotient = GetQuotient(product);


            }
            catch (IndexOutOfRangeException)
            {

                throw;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Something wrong happened " + e.Message);

            }
            catch (OverflowException e)
            {
                Console.WriteLine("Something wrong happened " + e.Message);

            }
        }
        //function creat the array from user input
        static int[] Populate(int[] arr)
        {
            int input;
        for (int i = 1; i <= arr.Length; i++)
            {
                Console.WriteLine("Please enter a number : "+ i + " of " + arr.Length);
                input = int.Parse( Console.ReadLine());
                arr[i-1] = Convert.ToInt32(input);
            }
        return arr;

        }
        //function calculate the sum of the array elements
        static int GetSum(int[] arr)
        {
            int sum = 0;

            try
            { 
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
             catch (Exception)
            {

                throw new Exception($"Value of {sum} is too low");
            }
        }
        //function calculate the product
        static int GetProduct(int[] arr , int sum)
        {

            try
            {
                int product = 0;
                int randomNumber;

                do
                {
                    Console.WriteLine("Please Select a randome number between  : " + 1 + " and " + arr.Length);
                     randomNumber = Convert.ToInt32(Console.ReadLine());
                }
                while 
                (randomNumber <= 1 || randomNumber > arr.Length);
                product = sum * arr[(randomNumber - 1)];
                Console.WriteLine(sum + "* " + arr[randomNumber - 1] + " = " + product );

                return product;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Something wrong happened " + e.Message);
                throw new ArgumentException("Index out of range");
            }
            
        }
       //function calculat the quotient
static decimal GetQuotient(int product)
        {
            try 
            { 
            Console.WriteLine("please enter a number to divide your product  " +product + " by ");
            int divideNumber = Convert.ToInt32(Console.ReadLine());
            decimal quotient = 0;
            quotient = decimal.Divide(product, divideNumber);
            Console.WriteLine(product + " / " + divideNumber +" = " + quotient);

                return quotient;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Something wrong happened " + e.Message);
                return 0;
            }


        }

    }
}
