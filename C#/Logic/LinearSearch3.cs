using C_.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.Logic
{
    internal class LinearSearch3 : LogicSearch
    {
        /// <summary>
        /// 線形探索法（break版）
        /// </summary>
        public override void Search()
        {
            Person[] person = new Person[]
            {
                new Person("Ann", 18),
                new Person("Rolla", 19),
                new Person("Nancy", 16),
                new Person("Eluza", 17),
                new Person("Juliet", 18),
                new Person("Candy", 16)
            };

            string keyName = "Candy";
            bool searchFlg = false;

            for (int i = 0; i < person.Length; i++)
            {
                if (person[i].Name.Equals(keyName))
                {
                    Console.WriteLine(person[i].Name + " " + person[i].Age);
                    searchFlg = true;
                }
            }

            if (!searchFlg)
            {
                Console.WriteLine("見つかりませんでした。");
            }
        }
    }
}
