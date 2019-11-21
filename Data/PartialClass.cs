using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public interface InterFacePartialClass
    {
        void InterFacePartail1();
        void InterFacePartail();
    }

    #region BasePartailClass
    public class BasePartailClass:InterFacePartialClass
    {
        public virtual void InterFacePartail1() 
        {
        }
        
        public virtual void InterFacePartail()
        {
            Console.WriteLine("");
        }
    }
    #endregion 
    public class PartialClass:BasePartailClass
    {
        public override void InterFacePartail1()
        {
            throw new NotImplementedException();
        }
        public override void InterFacePartail()
        {
            base.InterFacePartail();
        }
        public partial class PartialTestClass:BasePartailClass
        {

        } 
    }
}
