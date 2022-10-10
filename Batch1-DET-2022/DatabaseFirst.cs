//using Batch1_DET_2022.Models;
//using Microsoft.Data.SqlClient;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1_DET_2022
//{
//    internal class DatabaseFirst
//    {
//        public static void Main(String[] args)
//        {
//            GetAllEmpDetails();
//            GetEmpDetailsById();
//            AddNewEmployee();
//            UpdateNewEmployee();
//            Console.ReadLine();
//            EmpStoredProcedure();
//            RemoveEmpUsingID();
//            UpdateEmpUsingID();
//            CallStoredProcwithSQLParamater_insert();




//            private static void UpdateNewEmployee()
//            {
//                var ctx = new learningContext();
//                var employee = ctx.Emps.Where(e => e.Empno == 2979).SingleOrDefault();
//                try
//                {
//                    Emp employee1 = new Emp();
//                    // employee.Empno = 2979;
//                    employee.Ename = "Hrithik";
//                    ctx.Update(employee);
//                    ctx.SaveChanges();
//                    Console.WriteLine("Updated");
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine(ex.InnerException.Message);
//                }
//            }

//            private static void AddNewEmployee()

//            {
//                var ctx = new learningContext();
//                try
//                {
//                    Emp employee = new Emp();
//                    employee.Empno = 9999;
//                    employee.Ename = "RUTUJA";
//                    employee.Sal = 100000;
//                    employee.Deptno = 40;
//                    employee.Job = "Trainee";
//                    ctx.Add(employee);
//                    ctx.SaveChanges();
//                    Console.WriteLine("New Employee Added");
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine(ex.InnerException.Message);
//                }


//            }
//            private static void EmpStoredProcedure()
//            {
//                var ctx = new learningContext();
//                //var employees = ctx.Emps.FromSqlRaw($"GetAllEmpsDetails").ToList();
//                var employees = ctx.Emps.FromSqlRaw($"GetEMPSDETSBYEMPNO @p0", 7499).ToList();

//                foreach (var e in employees)
//                {
//                    Console.WriteLine(e.Ename);
//                }
//            }


//            //private static void RemoveEmpUsingID()
//            //{
//            //    var ctx = new learningContext();
//            //    var eno = 1234;
//            //    int rowsAffected = ctx.Database.ExecuteSqlRaw($"RemoveEmployee {eno}");
//            //    Console.WriteLine($"No Of Rows Affected {rowsAffected}");
//            //}



//            private static void GetEmpDetailsById()
//            {
//                var ctx = new learningContext();
//                var employee = ctx.Emps.Where(e => e.Empno == 7698).SingleOrDefault();
//                Console.WriteLine(employee.Ename + " " + employee.Sal + " " + employee.Job);

//                //foreach (var employee in emp)
//                //{
//                //    Console.WriteLine(employee.Ename + " " + employee.Sal);
//                //}
//            }

//            private static void UpdateEmpUsingID()
//            {
//                var ctx = new learningContext();
//                var eno = 7566;
//                var Ename = "Rutuja";
//                int rowsAffected = ctx.Database.ExecuteSqlRaw($"UPDATENAMES {eno} @p0");
//                Console.WriteLine($"No Of Rows Affected {rowsAffected}");
//            }
//            private static void CallStoredProcwithSQLParamater_insert()
//            {
//                var ctx = new learningContext();
//                var param = new SqlParameter[] {
//                        new SqlParameter() {
//                            ParameterName = "@empno",
//                            SqlDbType =  System.Data.SqlDbType.Int,
//                            Size = 100,
//                            Direction = System.Data.
//                            ParameterDirection.Input,
//                            Value = 9999
//                        },

//                         new SqlParameter() {
//                            ParameterName = "@ename",
//                            SqlDbType =  System.Data.
//                            SqlDbType.VarChar,
//                            Size = 100,
//                            Direction = System.Data.
//                            ParameterDirection.Input,
//                            Value = "Roshan"},

//                          new SqlParameter() {
//                            ParameterName = "@job",
//                            SqlDbType =  System.Data.
//                            SqlDbType.VarChar,
//                            Size = 100,
//                            Direction = System.Data.
//                            ParameterDirection.Input,
//                            Value = "Actor"},

//                          new SqlParameter() {
//                            ParameterName = "@mgr",
//                            SqlDbType =  System.Data.
//                            SqlDbType.VarChar,
//                            Size = 100,
//                            Direction = System.Data.
//                            ParameterDirection.Input,
//                            Value = "7839"},

//                          new SqlParameter() {
//                            ParameterName = "@hiredate",
//                            SqlDbType =  System.Data.
//                            SqlDbType.DateTime,
//                            Size = 100,
//                            Direction = System.Data.
//                            ParameterDirection.Input,
//                            Value = DateTime.Now},


//                          new SqlParameter() {
//                            ParameterName = "@sal",
//                            SqlDbType =  System.Data.
//                            SqlDbType.Int,
//                            Size = 100,
//                            Direction = System.Data.
//                            ParameterDirection.Input,
//                            Value = 1600},


//                          new SqlParameter() {
//                            ParameterName = "@comm",
//                            SqlDbType =  System.Data.
//                            SqlDbType.Int,
//                            Size = 100,
//                            Direction = System.Data.
//                            ParameterDirection.Input,
//                            Value = 2850},


//                           new SqlParameter() {
//                            ParameterName = "@deptno",
//                            SqlDbType =  System.Data.
//                            SqlDbType.Int,
//                            Size = 100,
//                            Direction = System.Data.
//                            ParameterDirection.Input,
//                            Value =30},

//                       };

//                try
//                {
//                    var result = ctx.Database.ExecuteSqlRaw("InsertEmployee @empno, @ename, @job, @mgr, @hiredate, @sal, @comm, @deptno", param);
//                    Console.WriteLine("added");
//                }
//                catch (Exception ex)
//                {

//                    throw;
//                }


//                Console.WriteLine("update successful");

//            }

//        }
//    }
//}

