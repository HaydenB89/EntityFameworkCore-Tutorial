using EntityFameworkCore_Tutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
//Using CodeFirst allows you to work in C# while Entity Packages manages the SQL aspect
namespace EntityFameworkCore_Tutorial {
    class Program {
        static void Main(string[] args) {

            AppDbContext context = new AppDbContext();

            var customers = from cust in context.Customers
                            where cust.Sales < 100000
                            select cust;

            //commentign this out to try Query syntax
            //List<Customer> customers = context.Customers
            //                                    .Where(cust => cust.Sales < 100000)
            //                                    .ToList();


            foreach(var customer in customers) {
                Console.WriteLine($"{customer.Name} {customer.Sales:c}");

            }
        }
    }
}
