using System;

namespace Delegates
{
    public delegate double Delegate_Prod(int a, int b);
    class Program
    {
      
        static double totalCast(int amount,int serviceCharges)
        {
            return amount + serviceCharges;

        }
        static void Main(string[] args)
        {
           Delegate_Prod delObj = new Delegate_Prod(totalCast);
            Console.WriteLine("Total Cost of Car is: ");
            int v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Service Charges On Car is :");
            int v2 = int.Parse(Console.ReadLine());
            double res = delObj(v1,v2);
            Console.WriteLine("Price of Car is : "+res);
            Console.ReadKey();

        }
    }
}
