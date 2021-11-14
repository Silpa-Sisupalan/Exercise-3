using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{

    class Program
    {
        public void tempconverter()//Simple interest = (Principle amount*interest rate*years)/100
        {
            Console.WriteLine("Name\tAge\tdeposit-Amount\tInterestRate(%)\tyears\tAmount(SI)");
            string name = "sam";
            int age = 65;
            double depositamount = 23000.00;
            double interestrate = 12.75;
            int year = 1;
            while (year <= 5)
            {

                double amount = (depositamount * interestrate * year) / 100;
                Console.WriteLine("{0}\t{1}\t{2}\t\t{3}\t\t{4}\t{5}",name,age,depositamount,interestrate,year,amount);
                age++;
                year++;

            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.tempconverter();
            Console.ReadLine();
        }
    }
}