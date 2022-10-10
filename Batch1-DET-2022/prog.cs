//using Batch1_DET_2022.Models.Data;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1_DET_2022.Data
//{
//    internal class prog
//    {
//        static void Main(string[] args)
//        {
//            AddNewBook();
//            Console.ReadLine();
//        }
//        private static void AddNewBook()
//        {
//            var ctx = new BookContext();
//            Book book = new Book();
//            book.BookID = 1;
//            book.BookName = "EF core";
//            book.author = "Jack";
//            book.price = 100;

//            try
//            {
//                ctx.Books.Add(book);
//                ctx.SaveChanges();
//                Console.WriteLine("new book added successfully");

//            }
//            catch(Exception ex)
//            {
//                Console.WriteLine(ex.InnerException.Message):

//            }



//        }
//    }
//}
