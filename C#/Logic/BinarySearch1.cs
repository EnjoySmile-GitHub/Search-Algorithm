using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.Logic
{
    internal class BinarySearch1 : LogicSearch
    {
        /// <summary>
        /// 2分探索法（バイナリサーチ）_1
        /// </summary>
        public override void Search()
        {
            int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int searchData = 8;
            bool searchFlg = false;

            int low = 0;
            int high = data.Length - 1;

            while (low <= high)
            {
                int index = (low + high) / 2;

                if (data[index] == searchData)
                {
                    Console.WriteLine(searchData + "は" + index + "番目にありました。");
                    searchFlg = true;
                    break;
                }

                if (data[index] < searchData)
                {
                    low = index + 1;
                }
                else
                {
                    high = index - 1;
                }
            }

            if (!searchFlg)
            {
                Console.WriteLine("見つかりませんでした。");
            }
        }
    }
}
