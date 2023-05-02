void Sum1(params int[] numbers)
{
    int result = 0;
    foreach (var n in numbers)
    {
        result += n;
    }
    Console.WriteLine(result);
}

int[] nums1 = { 1, 2, 3, 4, 5 };
Sum1(nums1);
Sum1(1, 2, 3, 4);
Sum1(1, 2, 3);
Sum1();

void Sum2(int initialValue, params int[] numbers)
{
    int result = initialValue;
    foreach (var n in numbers)
    {
        result += n;
    }
    Console.WriteLine(result);
}

int[] nums2 = { 1, 2, 3, 4, 5 };
Sum2(10, nums2);  // число 10 - передается параметру initialValue
Sum2(1, 2, 3, 4);
Sum2(1, 2, 3);
Sum2(20);

//Так НЕ работает
//void Sum(params int[] numbers, int initialValue)
//{ }


//Массив в качестве параметра


void Sum3(int[] numbers, int initialValue)
{
    int result = initialValue;
    foreach (var n in numbers)
    {
        result += n;
    }
    Console.WriteLine(result);
}

int[] nums = { 1, 2, 3, 4, 5 };
Sum3(nums, 10);

// Sum(1, 2, 3, 4);     // так нельзя - нам надо передать массив

//Ключевое слово params позволяет передавать переменное число агрументов в метод следующих типов:
//* разделенный запятыми список аргументов типа элементов массива;
//* массив аргументов указанного типа;
//* не передавать аргументы. Если аргументы не отправляются, длина списка params равна нулю.