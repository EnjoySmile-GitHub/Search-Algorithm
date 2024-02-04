using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.Logic
{
    internal class BinarySearch2 : LogicSearch
    {
        /// <summary>
        /// 2分探索法（バイナリサーチ）_2
        /// </summary>
        public override void Search()
        {
            int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int searchData = 8;

            int low = 0;
            int high = data.Length - 1;

            while (low <= high)
            {
                int index = (low + high) / 2;

                if (data[index] <= searchData)
                {
                    low = index + 1;
                }

                if (data[index] >= searchData)
                {
                    high = index - 1;
                }
            }

            if (low == high + 2)
            {
                Console.WriteLine(searchData + "は" + (low - 1) + "番目にありました。");
            }
            else
            {
                Console.WriteLine("見つかりませんでした");
            }
        }
    }
}
