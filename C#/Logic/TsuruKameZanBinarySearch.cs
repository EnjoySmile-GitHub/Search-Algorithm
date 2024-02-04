using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.Logic
{
    internal class TsuruKameZanBinarySearch : LogicSearch
    {
        /// <summary>
        /// 鶴亀算を2分探索法で解く
        /// </summary>
        public override void Search()
        {
            const int SEARCH_LEGS = 274;
            int low = 0;
            int high = 100;
            int legs = 0;
            int kame = 0;

            while (legs != SEARCH_LEGS)
            {
                kame = (low + high) / 2;

                legs = kame * 4 + (100 - kame) * 2;

                if (legs > SEARCH_LEGS)
                {
                    high = kame - 1;
                }
                else
                {
                    low = kame + 1;
                }
            }

            Console.WriteLine("亀が" + kame + ",鶴が" + (100 - kame));
        }
    }
}
