//if (условие)
//{
//    выполняемые инструкции
//}

//int num1 = 8;
//int num2 = 6;
//if (num1 > num2)
//{
//    Console.WriteLine($"Число {num1} больше числа {num2}");
//}

//int num1 = 8;
//int num2 = 6;
//if (num1 > num2)
//    Console.WriteLine($"Число {num1} больше числа {num2}");

//// или так
//if (num1 > num2) Console.WriteLine($"Число {num1} больше числа {num2}");

//int num1 = 8;
//int num2 = 6;
//if (num1 > num2 && num1 == 8)
//{
//    Console.WriteLine($"Число {num1} больше числа {num2}");
//}

//Выражение else
//int num1 = 8;
//int num2 = 6;
//if (num1 > num2)
//{
//    Console.WriteLine($"Число {num1} больше числа {num2}");
//}
//else
//{
//    Console.WriteLine($"Число {num1} меньше числа {num2}");
//}

//int num1 = 8;
//int num2 = 6;
//if (num1 > num2)
//    Console.WriteLine($"Число {num1} больше числа {num2}");
//else
//    Console.WriteLine($"Число {num1} меньше числа {num2}");

//else if
int num1 = 8;
int num2 = 6;
if (num1 > num2)
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
}
else if (num1 < num2)
{
    Console.WriteLine($"Число {num1} меньше числа {num2}");
}
else
{
    Console.WriteLine("Число num1 равно числу num2");
}

string name = "Alex";

if (name == "Tom")
    Console.WriteLine("Вас зовут Tomas");
else if (name == "Bob")
    Console.WriteLine("Вас зовут Robert");
else if (name == "Mike")
    Console.WriteLine("Вас зовут Michael");
else
    Console.WriteLine("Неизвестное имя");

//Тернарная операция
int x = 3;
int y = 2;

int z = x < y ? (x + y) : (x - y);
Console.WriteLine(z);   // 1