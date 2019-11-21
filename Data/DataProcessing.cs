using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
using System.Data;

namespace Data
{  
    
    class DataProcessing
    {
        private static List<int> numberList = new List<int>() { 4, 5, 6, 5, 3, 3, 0, 5, 6, 8, 7, 9, 6,2,1};
        private static List<int> numberListTwo = new List<int>() { 3, 3, 1, 2, 3, 3, 1, 23, 3, 3, 4, };
        /// <summary>
       /// 分组数据
       /// </summary>
        public void Array()
        {
            var GroupForList = numberList.GroupBy(x => x).ToDictionary(a => a.Key, b => b.ToList()).ToList();
            foreach (var item in GroupForList)
            {
                Console.Write(item .Key);
            }
            Console.WriteLine("////");
            foreach (var number in GroupForList.GroupBy(x=>x))
            {
                Console.WriteLine(number);
            }
            foreach (var i in GroupForList.GroupBy(x => x).ToDictionary(a => a.Key))
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// 集合
        /// </summary>
        public void Aggregate()
        {
            //交集
            var intersectList = numberList.Intersect(numberListTwo);
            Console.WriteLine(intersectList);
            var str = "";
            var str2 = "";
            var str3 = "";
            foreach (var item in intersectList)
            {
                str += item + ",";
            }
            Console.WriteLine($"交集为：{str}");

            //差集
            var exceptList = numberList.Except(numberListTwo);
            foreach (var item in intersectList)
            {
                str2 += item + ",";
            }
            Console.WriteLine($"差集{str2}");
            //并集
            var unionList = numberList.Union(numberListTwo);
            foreach (var item in unionList)
            {
                str3 += item + ",";
            }
            Console.WriteLine($"并集：{str3}");

        }
        


    }
}
