using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_.Class;

namespace C_.Logic
{
    internal class LinearSearch2 : LogicSearch
    {
        /// <summary>
        /// 線形探索法（番兵をたてる）
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
                new Person("Candy", 16),
                // 番兵をたてる用
                new Person("", 0)
            };

            int personLength = person.Length - 1;
            string keyName = "Candy";
            person[personLength].Name = keyName;
            int i = 0;

            while (person[i].Name != keyName)
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
