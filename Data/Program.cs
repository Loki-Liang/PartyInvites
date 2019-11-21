using System;
using System.Collections.Generic;

namespace Data
{
    class Program 
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //DataProcessing dataProcessing = new DataProcessing();
            //dataProcessing.Array();
            //dataProcessing.Aggregate();

            MyClass myClass = new MyClass("CREATE OBJECT");
            Console.WriteLine("myClass created.");
            for(int i=-1;i<=0;i++)
            {
                try
                {
                    Console.WriteLine($"\nAttemping to assign {i}to myobj.val...");
                    myClass.IntVal = i;
                    Console.WriteLine($"Value {myClass.IntVal} assign to myObj.intVal.");

                }
                catch(Exception e)
                {
                    Console.WriteLine($"Exception {e.GetType().FullName}");
                    Console.WriteLine($"Message:\n{e.Message}");

                }

            }
            Console.WriteLine($"\nOutputting {myClass.ToString()}");
            Console.WriteLine($"output.");
            Console.WriteLine( MyClass.StaticInt ); 
            MyBaseClass myBaseClass = new MyBaseClass();
            myBaseClass.Test();
            MyDervedClass myDervedClass = new MyDervedClass();
            myDervedClass.Test();
            TwoSub twoSub = new TwoSub();
            twoSub.Test();
            _AbstrcatClass _AbstrcatClass = new _AbstrcatClass();
            _AbstrcatClass._abstract();
            SubClass subClass = new SubClass();
            subClass._abstract();
            subClass.Adder();
            subClass.BaseTest();
            subClass.BaseInterFaceTest();
            subClass.BaseInterFaceTest1();
            
        }
    }
}
