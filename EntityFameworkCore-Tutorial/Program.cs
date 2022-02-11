using EntityFameworkCore_Tutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
//Using CodeFirst allows you to work in C# while Entity Packages manages the SQL aspect
namespace EntityFameworkCore_Tutorial {
    class Program {
        static void Main(string[] args) {

            AppDbContext context = new AppDbContext();

            List<Customer> customers = context.Customers
                                                .Where(cust => cust.Sales < 100000)
                                                .ToList();


            foreach(var customer in customers) {
                Console.WriteLine($"{customer.Name} {customer.Sales:c}");

            }
        }
    }
}
