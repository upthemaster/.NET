//using System;
//namespace Replace_Methods_with_lambda_expressions

//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // Using built-in Action delegate
//            Action<string, double> processOrder = null;

//            // Lambda 1 - Generate Bill
//            processOrder += (customerName, amount) =>
//            {
//                Console.WriteLine("Generating bill for " + customerName);
//                Console.WriteLine("Amount: ₹" + amount);
//            };

//            // Lambda 2 - Send Email
//            processOrder += (customerName, amount) =>
//            {
//                Console.WriteLine("Sending Email to " + customerName);
//            };

//            // Lambda 3 - Send SMS
//            processOrder += (customerName, amount) =>
//            {
//                Console.WriteLine("Sending SMS notification...");
//            };

//            // Calling multicast delegate
//            processOrder("Aditya", 2500);

//            Console.ReadLine();
//        }
//    }
//}