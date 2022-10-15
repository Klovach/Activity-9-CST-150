using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_9_CST_150
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Convert Millimeters to Meters.
            rtxStatistics.Text += "Bonus) convert 834 milimeters to meters : " + convertMeters(834);
            // 1.) Show the sum of two integers.
            rtxStatistics.Text += Environment.NewLine + "1.) Calculate the sum of two integers: " + (calculateSum(10, 30)); 
            // 2.) Show the average of five doubles. 
            rtxStatistics.Text += Environment.NewLine + "2.) The average of five doubles(75.3, 96.5, 45.8, 69.0, 44.6) : " + (averageDoubles(75.3, 96.5, 45.8, 69.0, 44.6));
            // 3.) Show the sum of two randomly generated integers. 
            rtxStatistics.Text += Environment.NewLine + "3.) Sum of two randomly generated integers : " + randomSum();
            // 4.) Show if three integers are divisible. 
            rtxStatistics.Text += Environment.NewLine + "4.) Check if three integers(3,9,12) are divisible by three : " + (DivisibilityBy3Check(3,9,12));
           // 5.) Show the shortest string. 
            rtxStatistics.Text += Environment.NewLine + "5.) Find the shortest string : " + findShortestString("Heaven","Iron");
            // 6.) Create an array and show the largest element in that array. 
            int[] array = { 10, 324, 45, 90, 9808 };
            rtxStatistics.Text += Environment.NewLine + "6.) Find the largest element in the array : [int[] array = { 10, 324, 45, 90, 9808 };"; 
            rtxStatistics.Text += Environment.NewLine + "The largest element in the array is : " + findLargestElement(array);
            // 7.) Invoke the generateArray(); method and show the results via a foreeach loop.
            rtxStatistics.Text += Environment.NewLine + "7.) Generate an array with a total of 50 elements: "; 
            int[] newArray = generateArray();
            foreach (var item in newArray)
            {
                rtxStatistics.Text += (item + "... ");
            } 
            // 8.) Show the result of comparing two boolean values. 
            rtxStatistics.Text += Environment.NewLine + "8.) Take two booleans and return true if they have the same value of true or false : " + (checkBooleans(false, false));
            // 9.) Show the product of an int and a double. 
             rtxStatistics.Text += Environment.NewLine + "9.) Find the product of an int and a double: " + (findProduct(10, 20.5));
            // 10.) Calculate the 2D average. 
           int[,] arr2D = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
           rtxStatistics.Text += Environment.NewLine + "10.) Calculate the 2D Average of  int[,] arr2D = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };"; 
           rtxStatistics.Text += Environment.NewLine + "The 2D average is : " + (calculate2DAverage(arr2D));
             
        }

        // Bonus) Convert millimeters to meters and return the result. : alternative - public void showMeters(int numMillimeters)  
        public double convertMeters(double numMillimeters)
        {
            return numMillimeters / 1000; 
        }

        // 1.) A method that takes two integers and displays their sum.
        public static int calculateSum(int a, int b)
        {
            int c = a + b;
            return c; 
        }

        // 2.) A method that takes five doubles and returns their average.
        public static double averageDoubles(double d1, double d2, double d3, double d4, double d5)
        {
            double average = (d1 + d2 + d3 + d4 + d5) / 5;
            return average;
        }

        // 3.) A method that returns the sum of two randomly generated integers.
        public static double randomSum()
        {
            Random randomNumber = new Random();
            int random1 = randomNumber.Next(10, 50);
            int random2 = randomNumber.Next(10, 50);
            return random1 + random2;
        }

        // 4.) A method that takes three integers and returns true if their sum is divisible by 3, false otherwise.
        public static bool DivisibilityBy3Check(int n1, int n2, int n3)
        {
            int sum = n1 + n2 + n3;
            return sum % 3 == 0;
        }

        // 5.) A method that takes two strings and displays the string that has fewer characters.
        // Note: This is accomplished with a simple if and an else statement.
        public static string findShortestString(string word1, string word2)
        {
            if (word1.Length < word2.Length)
            {
                return word1; 
            }
            else
            {
                return word2; 
            }
        }

        // 6.) A method that takes an array of doubles and returns the largest value in the array.
        private static int findLargestElement(int[] array)
        {
            // Initialize maximum element
            int max = array[0];

            /* Traverse through the array elements and compare every element with current maximum element. 
             The maximum element is currently the first element in the array. Each array element is compared
            to this element. If the element that is compared to the current maximum element is larger, the
            maximum element is replaced. This process continues until the largest element in the array is
            found in this loop.*/
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        // 8.) A method that takes two bool variables and returns true if they have the same value, false otherwise.
        private static bool checkBooleans(bool b1, bool b2)
        {
            if (b1 == true && b2 == true)
            {
                return true;
            }
            else if (b1 == false && b2 == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 10.) A method that takes a two-dimensional array of integers and returns the average of the entries.
        private static double calculate2DAverage(int[,] array)
        {
            int count = 0;
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                    count++;
                }
            }

            return sum / count;
        }

        // 9.) A method that takes an int and a double and returns their product.
        private static double findProduct(int a, double b)
        {
            return a * b;
        }

        // 7.) A method that generates and returns an array of fifty integer values.
        private static int[] generateArray()
        {
            // Declare an array
            int[] array = new int[50];
            Random random = new Random();

            /* Here we are traversing through a for loop to add 
             a random number between 10 and 50 to every element in the array.*/
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10, 50);
            }

            return array;
        }
    }
}
