

//Количество положительных чисел


int[] positiveCount = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
int result = 0;
foreach (int number in positiveCount)
{
    if (number > 0)
    {
        result++;
    }
}
Console.WriteLine($"Число элементов больше нуля: {result}");


//Инверсия массива


int[] inversionArray = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

int n = inversionArray.Length; // длина массива
int k = n / 2;          // середина массива
int t;               // вспомогательный элемент для обмена значениями
for (int i = 0; i < k; i++)
{
    t = inversionArray[i];
    inversionArray[i] = inversionArray[n - i - 1];
    inversionArray[n - i - 1] = t;
}
foreach (int i in inversionArray)
{
    Console.Write($"{i} \t");
}


//Программа сортировки массива


int[] nums = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };

// сортировка
for (int i = 0, a; i < nums.Length - 1; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] > nums[j])
        {
            a = nums[i];
            nums[i] = nums[j];
            nums[j] = a;
        }
    }
}

// вывод
Console.WriteLine("Вывод отсортированного массива");
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}
