

//Массивы


//тип_переменной[] название_массива;
int[] numbers;
int[] nums = new int[4];
int[] nums2 = new int[4] { 1, 2, 3, 5 };
int[] nums3 = new int[] { 1, 2, 3, 5 };
int[] nums4 = new[] { 1, 2, 3, 5 };
int[] nums5 = { 1, 2, 3, 5 };
string[] people = { "Tom", "Sam", "Bob" };


//Индексы и получение элементов массива


//int[] numbers = { 1, 2, 3, 5 };
//// получение элемента массива
//Console.WriteLine(numbers[3]);  // 5
//// получение элемента массива в переменную
//var n = numbers[1];     // 2
//Console.WriteLine(n);  // 2

//int[] numbers = { 1, 2, 3, 5 };
//// изменим второй элемент массива
//numbers[1] = 505;
//Console.WriteLine(numbers[1]);  // 505

//int[] numbers = { 1, 2, 3, 5 };
//Console.WriteLine(numbers[6]);  // ! Ошибка - в массиве только 4 элемента


//Свойство Length и длина массива


//int[] numbers = { 1, 2, 3, 5 };
//Console.WriteLine(numbers.Length);  // 4


//Получение элементов с конца массива


//int[] numbers = { 1, 2, 3, 5 };
//Console.WriteLine(numbers[numbers.Length - 1]);  // 5 - первый с конца или последний элемент
//Console.WriteLine(numbers[numbers.Length - 2]);  // 3 - второй с конца или предпоследний элемент
//Console.WriteLine(numbers[numbers.Length - 3]);  // 2 - третий элемент с конца

//int[] numbers = { 1, 2, 3, 5 };
//Console.WriteLine(numbers[^1]);  // 5 - первый с конца или последний элемент
//Console.WriteLine(numbers[^2]);  // 3 - второй с конца или предпоследний элемент
//Console.WriteLine(numbers[^3]);  // 2 - третий элемент с конца


//Перебор массивов


//int[] numbers = { 1, 2, 3, 4, 5 };
//foreach (int i in numbers)
//{
//    Console.WriteLine(i);
//}

//int[] numbers = { 1, 2, 3, 4, 5 };
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

//int[] numbers = { 1, 2, 3, 4, 5 };
//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = numbers[i] * 2;
//    Console.WriteLine(numbers[i]);
//}

//int[] numbers = { 1, 2, 3, 4, 5 };
//int i = 0;
//while (i < numbers.Length)
//{
//    Console.WriteLine(numbers[i]);
//    i++;
//}


//Многомерные массивы


//int[] nums1 = new int[] { 0, 1, 2, 3, 4, 5 };
//int[,] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } };

//int[,] nums1;
//int[,] nums2 = new int[2, 3];
//int[,] nums3 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
//int[,] nums4 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
//int[,] nums5 = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
//int[,] nums6 = { { 0, 1, 2 }, { 3, 4, 5 } };

//int[,,] nums3 = new int[2, 3, 4];

//int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };
//foreach (int i in numbers)
//    Console.Write($"{i} ");

//numbers.GetUpperBound(0) + 1
//numbers.Length / количество_строк

//int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };
//int rows = numbers.GetUpperBound(0) + 1;    // количество строк
//int columns = numbers.Length / rows;        // количество столбцов
//                                            // или так
//                                            // int columns = numbers.GetUpperBound(1) + 1;
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        Console.Write($"{numbers[i, j]} \t");
//    }
//    Console.WriteLine();
//}


//Массив массивов


//int[][] nums = new int[3][];
//nums[0] = new int[2] { 1, 2 };          // выделяем память для первого подмассива
//nums[1] = new int[3] { 1, 2, 3 };       // выделяем память для второго подмассива
//nums[2] = new int[5] { 1, 2, 3, 4, 5 }; // выделяем память для третьего подмассива

//int[][] numbers = {
//    new int[] { 1, 2 },
//    new int[] { 1, 2, 3 },
//    new int[] { 1, 2, 3, 4, 5 }
//};

//int[][] numbers = new int[3][];
//numbers[0] = new int[] { 1, 2 };
//numbers[1] = new int[] { 1, 2, 3 };
//numbers[2] = new int[] { 1, 2, 3, 4, 5 };
//foreach (int[] row in numbers)
//{
//    foreach (int number in row)
//    {
//        Console.Write($"{number} \t");
//    }
//    Console.WriteLine();
//}

//// перебор с помощью цикла for
//for (int i = 0; i < numbers.Length; i++)
//{
//    for (int j = 0; j < numbers[i].Length; j++)
//    {
//        Console.Write($"{numbers[i][j]} \t");
//    }
//    Console.WriteLine();
//}


//Оператор ^ - предоставляет доступ к индексированной коллекции начиная с последнего элемента
//Метод GetUpperBound(номер_размерности) - возвращает индекс последнего элемента в заданной размерности
//При инициализации массива массивов, длина указывается только для первого ранга