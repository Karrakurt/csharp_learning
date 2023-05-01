

//Цикл for


//for ([действия_до_выполнения_цикла]; [условие] ; [действия_после_выполнения])
//{
//    // действия
//}

//for (int i = 1; i < 4; i++)
//{
//    Console.WriteLine(i);
//}

//for (int i = 1; i < 4; i++)
//    Console.WriteLine(i);

//// или так
//for (int i = 1; i < 4; i++) Console.WriteLine(i);

//var i = 1;
//for (Console.WriteLine("Начало выполнения цикла"); i < 4; Console.WriteLine($"i = {i}"))
//{
//    i++;
//}

//int i = 1;
//for (; ; )
//{
//    Console.WriteLine($"i = {i}");
//    i++;
//}

//int i = 1;
//for (; i < 4;)
//{
//    Console.WriteLine($"i = {i}");
//    i++;
//}

//for (int i = 1, j = 1; i < 10; i++, j++)
//    Console.WriteLine($"{i * j}");


//Цикл do..while


//do
//{
//    действия цикла
//}
//while (условие)

//int i = 6;
//do
//{
//    Console.WriteLine(i);
//    i--;
//}
//while (i > 0);

//int i = -1;
//do
//{
//    Console.WriteLine(i);
//    i--;
//}
//while (i > 0);


//Цикл while


//while (условие)
//{
//    действия цикла
//}

//int i = 6;
//while (i > 0)
//{
//    Console.WriteLine(i);
//    i--;
//}


//Цикл foreach


//foreach (тип_данных переменная in коллекция)
//{
//    // действия цикла
//}

foreach (char c in "Tom")
{
    Console.WriteLine(c);
}

foreach (var c in "Tom")
{
    Console.WriteLine(c);
}


//Операторы continue и break


for (int i = 0; i < 9; i++)
{
    if (i == 5)
        break;
    Console.WriteLine(i);
}

for (int i = 0; i < 9; i++)
{
    if (i == 5)
        continue;
    Console.WriteLine(i);
}


//Вложенные циклы


for (int i = 1; i < 10; i++)
{
    for (int j = 1; j < 10; j++)
    {
        Console.Write($"{i * j} \t");
    }
    Console.WriteLine();
}

//В цикле for допустим пропуск блоков, в которых нет необходимости