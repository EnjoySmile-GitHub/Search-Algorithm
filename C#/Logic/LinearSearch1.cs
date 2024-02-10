using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_.Class;

namespace C_.Logic
{
    internal class LinearSearch1 : LogicSearch
    {
        /// <summary>
        /// 線形探索法（リニアサーチ）
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

            int personLength = person.Length;
            string keyName = "Candy";
            int i = 0;
            while (i < personLength && keyName != person[i].Name)
            {
                i++;
            }

            if (i < personLength)
            {
                Console.WriteLine(person[i].Name + " " + person[i].Age);
            }
            else
            {
                Console.WriteLine("見つかりませんでした。");
            }
        }
    }
}
