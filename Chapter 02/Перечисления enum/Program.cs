//enum название_перечисления
//{
//    // значения перечисления
//    значение1,
//    значение2,
//    .......
//    значениеN
//}

DayTime dayTime = DayTime.Morning;

if (dayTime == DayTime.Morning)
    Console.WriteLine("Доброе утро");
else
    Console.WriteLine("Привет");


//Хранение состояния


DayTime now = DayTime.Evening;

PrintMessage(now);                   // Добрый вечер
PrintMessage(DayTime.Afternoon);    // Добрый день
PrintMessage(DayTime.Night);        // Доброй ночи

void PrintMessage(DayTime dayTime)
{
    switch (dayTime)
    {
        case DayTime.Morning:
            Console.WriteLine("Доброе утро");
            break;
        case DayTime.Afternoon:
            Console.WriteLine("Добрый день");
            break;
        case DayTime.Evening:
            Console.WriteLine("Добрый вечер");
            break;
        case DayTime.Night:
            Console.WriteLine("Доброй ночи");
            break;
    }
}

DoOperation(10, 5, Operation.Add);          // 15
DoOperation(10, 5, Operation.Subtract);     // 5
DoOperation(10, 5, Operation.Multiply);     // 50
DoOperation(10, 5, Operation.Divide);       // 2

void DoOperation(double x, double y, Operation op)
{
    double result = op switch
    {
        Operation.Add => x + y,
        Operation.Subtract => x - y,
        Operation.Multiply => x * y,
        Operation.Divide => x / y
    };
    Console.WriteLine(result);
}


//Тип и значения констант перечисления


int numb = (int)DayTime.Night; // 3
//DayTime now = 2;    // ! Ошибка




enum DayTimeNum
{
    Morning = 3,    // каждый следующий элемент по умолчанию увеличивается на единицу
    Afternoon,      // этот элемент равен 4
    Evening,        // 5
    Night           // 6
}

enum DayTimeSet
{
    Morning = 2,
    Afternoon = 4,
    Evening = 8,
    Night = 16
}

enum DayTimeSame
{
    Morning = 1,
    Afternoon = Morning,
    Evening = 2,
    Night = 2
}

enum Time : byte
{
    Morning,
    Afternoon,
    Evening,
    Night
}

enum DayTime
{
    Morning,
    Afternoon,
    Evening,
    Night
}

enum Operation
{
    Add,
    Subtract,
    Multiply,
    Divide
}

//Константы перечисления имеют целочисленный тип начинающийся с 0. По умолчанию это int
//Указав значение первого элемента следующие элементы продолжат отсчет
//Значения констант могут повторяться