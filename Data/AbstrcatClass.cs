using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    #region
    public abstract class BaseAbstrcatClass
    {
        protected string Name;
        public abstract string  Adder();
                
        public abstract void _abstract();
    }
    #endregion
    #region
    /// <summary>
    /// 继承抽象类，必须实现抽象方法
    /// </summary>
    public class _AbstrcatClass : BaseAbstrcatClass
    {
        new protected  string Name;
        public override void _abstract()
        {
            Console.WriteLine($"继承抽象类，实现抽象类方法{Name}");
            //throw new NotImplementedException();
        }
        public override string Adder()
        {
            return "";
            //throw new NotImplementedException();
        }
    }
#endregion
    /// <summary>
    /// 定义接口,接口只能是public修饰，不能添加其他修饰符
    /// </summary>
    public interface BaseInterface
    {
        void BaseInterFaceTest();
        string BaseInterFaceTest1();
    }
    #region
    /// <summary>
    /// 同时实现抽象方法和接口方法
    /// </summary>
    public class SubClass : BaseAbstrcatClass, BaseInterface
    {
        public override string Adder()
        {
            Console.WriteLine("继承了BaseAbstractClass,BaseInterface");
            return "";
            //throw new NotImplementedException();
        }
        public override void _abstract()
        {
            Console.WriteLine($"\n实现BaseAbstractClass的_abstractFunction");
            //throw new NotImplementedException();
        }
        
        /// <summary>
        /// 使用virtual和abstract实现InterfaceFunction;
        /// </summary>
        public virtual  void BaseTest()
        {
            Console.WriteLine("重写了InterfaceFunction");
        }
        /// <summary>
        /// 显式实现接口
        /// </summary>
        public void BaseInterFaceTest()
        {
            Console.WriteLine("实现接口方法");
            //throw new NotImplementedException();
        }

        public string BaseInterFaceTest1()
        {
            Console.WriteLine("InterfaceFunction");
            return "";
            //throw new NotImplementedException();
        }

        //void BaseInterface.BaseTest()
        //{
        //    Console.WriteLine("实现了接口中的BaseTestFunction");
        //    throw new NotImplementedException();
        //}
    }
}
#endregion