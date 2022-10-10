using Batch1_DET_2022.Models;
using Batch1_DET_2022.Models.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class CodeFirst

    {

        public static void Main(string[] args)
        {
            //AddNewBook();
            //UpdateNewBook();
            //DeleteBook();
            //GetAllBooks();
            //Console.ReadLine();
            //AddnewcustomerAndOrder();
            //AddOrderForCust();
            // GetAllCustomersWithOrder_EagerLoading();
            //GetAllCustomersWithOrder_ExplicitLoading();
            Disconnectedarchitecture();
          
        }
        //private static void AddOrderForCust()
        //{
        //    var ctx = new BookContext();

        //    var customer = ctx.Customers.Where(c => c.ID == 1).SingleOrDefault();
        //    Order ord = new Order();
        //    ord.Order_ID = 100000;
        //    ord.Amount = 9850;
        //    ord.OrderDate = DateTime.Now;
        //    ord.cust = customer;
        //    try
        //    {
        //        ctx.Orders.Add(ord);
        //        ctx.SaveChanges();
        //        Console.WriteLine("New Order Added");



        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }



        //private static void GetAllCustomersWithOrder_EagerLoading()
        //{
        //    //Eager loading means that the related data is loaded 
        //    //from the database as part of the initial query.
        //    var ctx = new BookContext();
        //    try
        //    {
        //        var customers = ctx.Customers.Include("Orders");

        //        //var customers = ctx.Customers.Include(o => o.Orders);                   

        //        foreach (var customer in customers)
        //        {
        //            Console.WriteLine(customer.Name);
        //            Console.WriteLine("----->");


        //            foreach (var order in customer.Orders)
        //            {
        //                Console.WriteLine(order.Amount.ToString() + " " + order.Order_ID);
        //            }
        //            Console.WriteLine("-----");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}
    }



    //private static void GetAllCustomersWithOrder_ExplicitLoading()
    //{
    //    //Explicit loading means that the related data is
    //    //explicitly loaded from the database at a later time.
    //    //Needs MARS to be set to TRUE in connection string
    //    var ctx = new BookContext();
    //    //try
    //    //{
    //    //    var customers = ctx.Customers;

    //    //    foreach (var customer in customers)
    //    //    {
    //    //        Console.WriteLine(customer.Name);
    //    //        Console.WriteLine("----->");

    //    //        ctx.Entry(customer).Collection(o => o.Orders).Load();

    //    //        foreach (var order in customer.Orders)
    //    //        {
    //    //            Console.WriteLine(order.Amount.ToString() + "  " + order.OrderDate.ToString());

    //    //        }
    //    //        Console.WriteLine("-----");

    //    //    }
    //    //}
    //    //catch (Exception ex)
    //    //{
    //    //    Console.WriteLine(ex.Message);
    //    //}
    //}





    //private static void AddnewcustomerAndOrder()
    //{
    //    var ctx = new BookContext();

    //    Customer customer = new Customer();
    //    customer.ID = 3;
    //    customer.Name = "Rutuja";
    //    customer.Age = 22;

    //    Order ord = new Order();
    //    ord.Order_ID = 10000;
    //    ord.Amount = 2000;
    //    ord.OrderDate = DateTime.Now;


    //    ord.cust = customer;
    //    try
    //    {
    //        ctx.Orders.Add(ord);
    //        ctx.SaveChanges();
    //        Console.WriteLine("Customer and order is created");

    //    }
    //    catch(Exception ex)
    //    {
    //        Console.WriteLine(ex.InnerException.ToString());
    //    }



    private static void Disconnectedarchitecture()
    {
        var ctx = new OnetoManyDataContext();

        var customer = ctx.Customers.Where(c => c.ID == 1).SingleOrDefault();

        ctx.Dispose();

        UpdateCustomerName(customer);

    }

    private static void UpdateCustomerName(Customer customer)
    {
        var ctx = new OnetoManyDataContext();
        customer.Name = "Mike";
        Console.WriteLine(ctx.Entry(customer).State.ToString());
        //ctx.Update<Customer>(customer);
        //OR
        ctx.Update(customer);
        //OR
        //ctx.Customers.Update(customer);
        //OR

        //  ctx.Attach(customer).State = EntityState.Modified;
        ctx.SaveChanges();
        Console.WriteLine("customer name is updated via disconnected mode");

    }

}

        //public static void AddNewBook()
        //{
        //    var ctx = new BookContext();
        //    Book book = new Book();
        //    book.BookID = 5;
        //    book.BookName = "EF core";
        //    book.author = "Jack";
        //    book.price = 100;

//    //var ctx = new BookContext();
//    Book book2 = new Book();
//    book2.BookID = 2;
//    book2.BookName = "EF core vol2";
//    book2.author = "Jack 2";
//    book2.price = 200;

//    //var ctx = new BookContext();
//    Book book3 = new Book();
//    book3.BookID = 3;
//    book3.BookName = "EF core vol3";
//    book3.author = "Jack 3";
//    book3.price = 300;

//    //var ctx = new BookContext();
//    Book book7 = new Book();
//    book7.BookID = 7;
//    book7.BookName = "EF core vol7";
//    book7.author = "Jack 7";
//    book7.price = 400;
//    try
//    {
//        ctx.Book.Add(book);
//        ctx.Book.Add(book2);
//        ctx.Book.Add(book3);
//        ctx.Book.Add(book7);
//        ctx.SaveChanges();
//        Console.WriteLine("new books added successfully");

//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.InnerException.Message);
//    }

//            public static void UpdateNewBook()
//            {
//                var ctx = new BookContext();
//                var Books = ctx.Book.Where(b => b.BookID == 3).SingleOrDefault();
//                try
//                {

//                    Books.BookName = "rutuja";
//                    ctx.Update(Books);
//                    ctx.SaveChanges();
//                    Console.WriteLine("Book db Updated");
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine(ex.InnerException.Message);
//                }




//            }


//            public static void DeleteBook()
//            {
//                var ctx = new BookContext();
//                var Books = ctx.Book.Where(b => b.BookID == 5).SingleOrDefault();
//                try
//                {
//                    ctx.Remove(Books);
//                    ctx.SaveChanges();
//                    Console.WriteLine("Book removed from db");
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine(ex.InnerException.Message);
//                }




//            }




//        }

//    }
//}


