//switch (выражение)
//{
//    case значение1:
//        код,выполняемый если выражение имеет значение1
//        break;
//    case значение2:
//        код,выполняемый если выражение имеет значение1
//        break;
//    //.............
//    case значениеN:
//        код, выполняемый если выражение имеет значениеN
//        break;
//    default:
//        код, выполняемый если выражение не имеет ни одно из выше указанных значений
//        break;
//}

string name1 = "Tom";

switch (name1)
{
    case "Bob":
        Console.WriteLine("Ваше имя - Bob");
        break;
    case "Tom":
        Console.WriteLine("Ваше имя - Tom");
        break;
    case "Sam":
        Console.WriteLine("Ваше имя - Sam");
        break;
}

string name2 = "Alex";

switch (name2)
{
    case "Bob":
        Console.WriteLine("Ваше имя - Bob");
        break;
    case "Tom":
        Console.WriteLine("Ваше имя - Tom");
        break;
    case "Sam":
        Console.WriteLine("Ваше имя - Sam");
        break;
    default:
        Console.WriteLine("Неизвестное имя");
        break;
}

int number = 1;
switch (number)
{
    case 1:
        Console.WriteLine("case 1");
        goto case 5; // переход к case 5
    case 3:
        Console.WriteLine("case 3");
        break;
    case 5:
        Console.WriteLine("case 5");
        break;
    default:
        Console.WriteLine("default");
        break;
}


//Возвращение значения из switch


int DoOperation1(int op, int a, int b)
{
    switch (op)
    {
        case 1: return a + b;
        case 2: return a - b;
        case 3: return a * b;
        default: return 0;
    }
}

int result1 = DoOperation1(1, 10, 5); // 15
Console.WriteLine(result1);         // 15
int result2 = DoOperation1(3, 10, 5); // 50
Console.WriteLine(result2);         // 50


//Получение результата из switch


int DoOperation2(int op, int a, int b)
{
    int result = op switch
    {
        1 => a + b,
        2 => a - b,
        3 => a * b,
        _ => 0
    };
    return result;
}

int DoOperation3(int op, int a, int b)
{
    return op switch
    {
        1 => a + b,
        2 => a - b,
        3 => a * b,
        _ => 0
    };
}

int DoOperation4(int op, int a, int b) => op switch
{
    1 => a + b,
    2 => a - b,
    3 => a * b,
    _ => 0
};


//Оператор goto case позволяет перенаправить выполнение блока на другой блок
//Сокращенные способы записи оператора switch через лямбду