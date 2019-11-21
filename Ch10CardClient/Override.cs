using System;
using System.Collections.Generic;
using System.Text;

namespace Ch10CardClient
{
    public class Override
    {
        public virtual void Test()
        {
            Console.WriteLine("base");
        }
    }
    public class override1 : Override
    {
        public override void Test()
        {
            Console.WriteLine("sub");
            //base.Test();
        }
    }
}
