using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 25, 5, 62, 54, 63, 23, 51 };
            var data = InsertSort(list);
            //var data = SelectSort(list);
            //var data = BubbleSort(list);
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 插入排序
        /// </summary>
        /// <param name="datas"></param>
        /// <returns></returns>
        private static List<int> InsertSort(List<int> datas)
        {
            for (var i = 1; i < datas.Count; i++)
            {
                int temp = datas[i];
                int j = i;
                while (j > 0 && datas[j - 1] > temp)
                {
                    datas[j] = datas[j - 1];
                    j--;
                }
                datas[j] = temp;
            }

            return datas;
        }

        /// <summary>
        /// 选择排序
        /// </summary>
        /// <param name="datas"></param>
        /// <returns></returns>
        private static List<int> SelectSort(List<int> datas)
        {
            int min;
            for (var i = 0; i < datas.Count - 1; i++)
            {
                min = i;
                for (var j = i + 1; j < datas.Count; j++)
                {
                    if (datas[min] > datas[j])
                    {
                        min = j;
                    }
                }
                var temp = datas[min];
                datas[min] = datas[i];
                datas[i] = temp;
            }

            return datas;
        }
        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="datas"></param>
        /// <returns></returns>
        private static List<int> BubbleSort(List<int> datas)
        {
            for (var i = datas.Count - 1; i > 0; i--)
            {
                for (var j = 0; j < i; j++)
                {
                    if (datas[j] > datas[j + 1])
                    {
                        var temp = datas[j];
                        datas[j] = datas[j + 1];
                        datas[j + 1] = temp;
                    }
                }
            }
            return datas;
        }
    }
}
