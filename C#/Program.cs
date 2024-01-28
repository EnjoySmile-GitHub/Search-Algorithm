// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using C_.Logic;

const int SEARCH_COUNT = 3;

LogicSearch[] logicSearch = new LogicSearch[SEARCH_COUNT];
// 線形探索法（リニアサーチ）
logicSearch[0] = new LinearSearch1();
// 線形探索法（番兵をたてる）
logicSearch[1] = new LinearSearch2();
// 線形探索法（break版）
logicSearch[2] = new LinearSearch3();

for (int i = 0; i < SEARCH_COUNT; i++)
{
    if (logicSearch[i] == null)
    {
        continue;
    }

    logicSearch[i].Search();
}