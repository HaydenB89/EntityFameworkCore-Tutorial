using EntityFameworkCore_Tutorial.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
//Using CodeFirst allows you to work in C# while Entity Packages manages the SQL aspect
namespace EntityFameworkCore_Tutorial {
    class Program {
        static void Main(string[] args) {

            AppDbContext context = new AppDbContext();

            var items = context.Items.Include(x => x.Code).ToList();

            foreach (var item in items) {
                Console.WriteLine($"{item.Id, -10} {item.Code,-10} {item.Price,10:c}");
            }

            //    //add a new order for krogrt
            //var kroger = context.Customers.SingleOrDefault(c => c.Name.StartsWith("Krog"));
            //var order = new Order() {
            //    Id = 0, Description = "3rd Order", Total = 2500, CustomerId = kroger.Id
            //};

            //context.Orders.Add(order);
            //context.SaveChanges();


            //    //read all orders
            //var orders = context.Orders.Include(x => x.Customer).ToList();

            //foreach(var ordr in orders)
            //    Console.WriteLine($"{ordr.Id,-5}{ordr.Description,-10}" +
            //                        $"{ordr.Total,10:c} {ordr.Customer.Name,-10}");


            //delete a customer
            //var amazon = context.Customers.SingleOrDefault(c => c.Name == "Amazon");

            //if(amazon != null) {                         //this says to not look for amazon if it does not exist
            //    context.Customers.Remove(amazon);        //this is what DELETES all amazon that are not null
            //    context.SaveChanges();
            //}

               // //update a customer
            //var max = context.Customers.Find(1);

            //max.Sales += 5000;    // adjusting the sales numbers
            //context.SaveChanges();  // save to Db

            ////commenting this out to update previous customer *seen above
               // //add new customer
            //var newCustomer = new Customer() {
            //    Id = 0, Name = "Kroger", Active = true, 
            //    Sales = 30000000, Updated = new DateTime(2022, 2, 11)
            //};
            //context.Customers.Add(newCustomer);    //this does NOT put it in the DataBase, only the EF memory
            //context.SaveChanges();                 //this is what adds it to the DataBase

              //  // read customer by PRIMARY KEY
           // var customer = context.Customers.Find(2);
            //Console.WriteLine($"{customer.Name} {customer.Sales:c}");

                // // read ALL customers
           // var customers = from cust in context.Customers
            //                where cust.Sales < 100000
            //                select cust;

            ////commenting this out to try Query syntax above
            //List<Customer> customers = context.Customers
            //                                    .Where(cust => cust.Sales < 100000)
            //                                    .ToList();


           // foreach(var customer in customers) {
            //    Console.WriteLine($"{customer.Name,20} {customer.Sales,10:c}");

            //}
        }
    }
}
