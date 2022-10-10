//using Batch1_DET_2022.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1_DET_2022
//{
//    internal class Program
//    {
//        private static void AddNewEmployee()
//        {
//            var ctx = new learningContext();
//            try
//            {
//                Emp employee = new Emp();
//                employee.Empno = 2979;
//                employee.Ename = "Rutuja";
//                employee.Sal = 1000;
//                employee.Deptno = 30;
//                employee.Job= "Employee";
//                ctx.Add(employee);
//                ctx.SaveChanges();
//                Console.WriteLine("New employee added");


//            }
//            catch
//            {
//                Console.WriteLine(ex.InnerException.Message);

//            }
//        }
//    }
//}
