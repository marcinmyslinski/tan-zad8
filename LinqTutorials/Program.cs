using LinqTutorials.Models;
using System;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task1");
            var t1 = LinqTasks.Task1();
            foreach (var task in t1)
            {
                Console.WriteLine(task + " </> " + task.Deptno + " </> " + task.Empno + " </> " +
                    task.Ename + " </> " + task.HireDate + " </> " + task.Job + " </> " + task.Mgr + " </> " + task.Salary);
            }

            Console.WriteLine("<---------------------------------------------------------------------------------->");
            Console.WriteLine("task2");
            var t2 = LinqTasks.Task2();
            foreach (var task in t2)
            {
                Console.WriteLine(task + " </> " + task.Deptno + " </> " + task.Empno + " </> " +
                    task.Ename + " </> " + task.HireDate + " </> " + task.Job + " </> " + task.Mgr + " </> " + task.Salary);
            }

            Console.WriteLine("<---------------------------------------------------------------------------------->");
            Console.WriteLine("task3");
            var t3 = LinqTasks.Task3();
            Console.WriteLine(t3);

            Console.WriteLine("<---------------------------------------------------------------------------------->");
            Console.WriteLine("task4");
            var t4 = LinqTasks.Task4();
            foreach (var task in t4)
            {
                Console.WriteLine(task + " </> " + task.Deptno + " </> " + task.Empno + " </> " +
                    task.Ename + " </> " + task.HireDate + " </> " + task.Job + " </> " + task.Mgr + " </> " + task.Salary);
            }

            Console.WriteLine("<---------------------------------------------------------------------------------->");
            Console.WriteLine("task5");
            var t5 = LinqTasks.Task5();
            foreach (var task in t5)
            {
                Console.WriteLine(task);
            }

            Console.WriteLine("<---------------------------------------------------------------------------------->");
            Console.WriteLine("task6");
            var t6= LinqTasks.Task6();
            foreach (var task in t6)
            {
                Console.WriteLine(task);
            }

            Console.WriteLine("<---------------------------------------------------------------------------------->");
            Console.WriteLine("task7");
            var t7 = LinqTasks.Task7();
            foreach (var task in t7)
            {
                Console.WriteLine(task);
            }

            Console.WriteLine("<---------------------------------------------------------------------------------->");
            Console.WriteLine("task8");
            var t8 = LinqTasks.Task8();

                Console.WriteLine(t8);

            Console.WriteLine("<---------------------------------------------------------------------------------->");
            Console.WriteLine("task9");
            var t9 = LinqTasks.Task9();


                Console.WriteLine(t9 + " </> " + t9.Deptno + " </> " + t9.Empno + " </> " +
                    t9.Ename + " </> " + t9.HireDate + " </> " + t9.Job + " </> " + t9.Mgr + " </> " + t9.Salary);

            Console.WriteLine("<---------------------------------------------------------------------------------->");
            Console.WriteLine("task10");
            var t10 = LinqTasks.Task10();
            foreach (var task in t10)
            {
                //  Console.WriteLine(task + " </> " + task.Deptno + " </> " + task.Empno + " </> " +
                //      task.Ename + " </> " + task.HireDate + " </> " + task.Job + " </> " + task.Mgr + " </> " + task.Salary);
                Console.WriteLine(task);
            }

        }
    }
}
