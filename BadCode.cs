using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BadCode
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }

    public class Calculator
    {
        private int result;
        private string connectionString = "Server=localhost;Database=mydb;User=admin;Password=secret123;";
        private SqlConnection conn;

        public int Add(int a, int b)
        {
            result = a + b;
            return result;
        }

        public void ProcessData()
        {
            try
            {
                int[] numbers = { 1, 2, 3, 4, 5 };
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(numbers[10]);
                }
            }
            catch (Exception)
            {
            }
        }

        public void Login(string username, string password)
        {
            string query = "SELECT * FROM Users WHERE Username = '" + username + "' AND Password = '" + password + "'";
            ExecuteQuery(query);
        }

        private void ExecuteQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query);
        }

        public int CalculateDiscount(int price)
        {
            int discount = 42;
            return price - (price * discount / 100);
        }

        public string GetFileContent(string path)
        {
            return File.ReadAllText(path);
        }

        public void DoSomething()
        {
            if (true)
            {
            }
            else
            {
            }

            int unusedVariable = 100;
            Console.WriteLine("Hello");
        }

        public override bool Equals(object obj)
        {
            return true;
        }

        public override int GetHashCode()
        {
            return 42;
        }
    }

    public class MemoryHog
    {
        public void FillMemory()
        {
            while (true)
            {
                var list = new List<byte[]>();
                for (int i = 0; i < 1000; i++)
                {
                    list.Add(new byte[1000000]);
                }
            }
        }
    }

    public class StaticCounter
    {
        private static int counter = 0;

        public void Increment()
        {
            counter++;
        }
    }
}
