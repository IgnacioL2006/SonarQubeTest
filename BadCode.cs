using System;
using System.IO;

namespace BadCode
{
    public class User
    {
        public string Username;
        public string Password; // Bad: storing password as plain text
        public string Email;
    }

    public class Calculator
    {
        public int result; // Bad: using instance field for local calculation

        public int Add(int a, int b)
        {
            result = a + b;
            return result;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b; // Bad: no check for division by zero
        }
    }

    public class FileHelper
    {
        public string ReadFile(string path)
        {
            return File.ReadAllText(path); // Bad: no path validation, can read any file
        }

        public void WriteFile(string path, string content)
        {
            File.WriteAllText(path, content); // Bad: no path validation
        }
    }

    public class StringHelper
    {
        public bool CheckPassword(string input)
        {
            if (input == "password123") // Bad: hardcoded password
            {
                return true;
            }
            else
            {
                return false; // Bad: redundant if-else
            }
        }

        public string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName; // Bad: no null checks
        }
    }

    public class DataProcessor
    {
        public void Process()
        {
            try
            {
                int[] numbers = new int[5];
                numbers[0] = 1;
                numbers[1] = 2;
                numbers[2] = 3;
                numbers[3] = 4;
                numbers[4] = 5;
                Console.WriteLine(numbers[10]); // Bad: index out of bounds
            }
            catch (Exception)
            {
            } // Bad: empty catch block
        }
    }
}
