using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Charreire.Stephanie.Business;
using Charriere.Stephanie.RRCAG;
using static System.Net.Mime.MediaTypeNames;

namespace Charriere.Stephanie.RRCAG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call the test methods
            SalesQuoteConstructorTest();
            SetTradeInAmountTest();
            GetExteriorFinishCostTest();
            GetTotalTest();
        }

        static void SalesQuoteConstructorTest()
        {
            Console.WriteLine("Testing method SalesQuote(decimal, decimal, decimal)");

            // Test 1
            SalesQuote salesQuote = new SalesQuote(5000.00m, 1000.00m, 0.13m);
            Console.WriteLine("Test 1 - Tests GetVehicleSalePrice");
            Console.WriteLine("Expected: 5000.00");
            Console.WriteLine("Actual: " + salesQuote.GetVehicleSalePrice() + "\r\n");

            // Test 2
            SalesQuote salesQuote2 = new SalesQuote(5000.00m, 1000.00m, 0.13m);
            Console.WriteLine("Test 2 - Tests GetTradeInAmount");
            Console.WriteLine("Expected: 1000.00");
            Console.WriteLine("Actual: " + salesQuote2.GetTradeInAmount() + "\r\n");
        }

        static void SetTradeInAmountTest()
        {
            Console.WriteLine("Testing method SetTradeInAmount()");

            // Test 1
            SalesQuote salesQuote = new SalesQuote(5000.00m, 1000.00m, 0.13m);
            salesQuote.SetTradeInAmount(2000.00M);
            Console.WriteLine("Test 1");
            Console.WriteLine("Expected: 2000.00");
            Console.WriteLine("Actual: " + salesQuote.GetTradeInAmount() + "\r\n");
        }

        static void GetExteriorFinishCostTest()
        {
            Console.WriteLine("Testing method GetExteriorFinishCost()");

            // Test 1
            SalesQuote salesQuote = new SalesQuote(5000.00m, 1000.00m, 0.13m);
            salesQuote.SetExteriorFinishChosen(ExteriorFinish.Standard);
            Console.WriteLine("Test 1");
            Console.WriteLine("Expected: 202.02");
            Console.WriteLine("Actual: " + salesQuote.GetExteriorFinishCost() + "\r\n");
        }

        static void GetTotalTest()
        {
            Console.WriteLine("Testing method GetTotalTest()");

            // Test 1
            SalesQuote salesQuote = new SalesQuote(5000.00m, 1000.00m, 0.13m);
            salesQuote.GetTotal();
            Console.WriteLine("Test 1");
            Console.WriteLine("Expected: 5650.00");
            Console.WriteLine("Actual: " + salesQuote.GetTotal().ToString("F2"));
        }
    }
}
