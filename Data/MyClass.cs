using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    class MyClass
    {
        public readonly int MyInt = 1;//字段
        public static int StaticInt = 2;//字段
        public readonly string Name;
        private int intVal;

        public int IntVal { get => intVal; set => intVal = value; }

        public override string ToString()
        {
            return $"Name:{Name}\n Val:{intVal}";
        }

        private MyClass():this("Defult Name")
        {

        }
        public MyClass(string newName)
        {
            Name = newName;
            intVal = 0;
        }
        public string Getstring()
        {
            return "Getstring";
        }
    }
    public class  MyBaseClass
    {
        private int master;//属性
        public MyBaseClass()
        {
            Console.WriteLine("这是MyBaseClass的构造方法");
        }

        public int Master1 { get => master; set => master = value; }
        protected int Master { get => Master1; set => Master1 = value; }
        /// <summary>
        /// virtual定义可重写的方法
        /// </summary>
        public virtual void Test()
        {
            MyClass myClass = new MyClass("");
            Console.WriteLine($"输出未赋值的私有字段Master{Master}\n" +
                $"访问静态字段{MyClass.StaticInt}\n" +
                $"输出myclass类的非静态字段{myClass.MyInt}");
        } 
    }
    public class MyDervedClass : MyBaseClass
    {
        public MyDervedClass()
        {
            Console.WriteLine("这是MyDervedClass的构造方法");
        }
        /// <summary>
        /// 重写MyBaseClass方法，并限定子类不能再次重写本方法
        /// </summary>
        public override sealed  void Test()
        {
            Master = 50;
            Console.WriteLine($"对父类mybaseclass的master赋值后输出:{Master}");
        }
 
    }
    public class TwoSub:MyDervedClass
    {
        protected virtual void newTest()
        {
            Console.WriteLine($"查看再次继承的Testsub的master值{Master}");
            
        }
        
        
    }

}
