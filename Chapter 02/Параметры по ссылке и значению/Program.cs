//Передача параметров по значению


void Increment(int n)
{
    n++;
    Console.WriteLine($"Число в методе Increment: {n}");
}

int number = 5;
Console.WriteLine($"Число до метода Increment: {number}");
Increment(number);
Console.WriteLine($"Число после метода Increment: {number}");


//Передача параметров по ссылке и модификатор ref


void IncrementRef(ref int n)
{
    n++;
    Console.WriteLine($"Число в методе Increment: {n}");
}

int numberRef = 5;
Console.WriteLine($"Число до метода Increment: {numberRef}");
IncrementRef(ref numberRef);
Console.WriteLine($"Число после метода Increment: {numberRef}");


//Выходные параметры. Модификатор out


void Sum(int x, int y, out int result)
{
    result = x + y;
}
int numberOut;
Sum(10, 15, out numberOut);
Console.WriteLine(numberOut);   // 25

//void SumOut2(int x, int y, out int result)
//{
//    Console.WriteLine(x + y); //Ошибка! Параметру result не присвоено значение
//}

void GetRectangleData(int width, int height, out int rectArea, out int rectPerimetr)
{
    rectArea = width * height;       // площадь прямоугольника - произведение ширины на высоту
    rectPerimetr = (width + height) * 2; // периметр прямоугольника - сумма длин всех сторон  
}
int area;
int perimetr;
GetRectangleData(10, 20, out area, out perimetr);
Console.WriteLine($"Площадь прямоугольника: {area}");       // 200
Console.WriteLine($"Периметр прямоугольника: {perimetr}");   // 60

GetRectangleData(10, 20, out int areaInLine, out int perimetrInLine);
Console.WriteLine($"Площадь прямоугольника: {area}");       // 200
Console.WriteLine($"Периметр прямоугольника: {perimetr}");   // 60

GetRectangleData(10, 20, out var areaVar, out var perimetrVar);
Console.WriteLine($"Площадь прямоугольника: {area}");       // 200
Console.WriteLine($"Периметр прямоугольника: {perimetr}");   // 60


//Входные параметры. Модификатор in


void GetRectangleDataIn(in int width, in int height, out int rectArea, out int rectPerimetr)
{
    //width = 25; // нельзя изменить, так как width - входной параметр
    rectArea = width * height;
    rectPerimetr = (width + height) * 2;
}
int w = 10;
int h = 20;
GetRectangleDataIn(w, h, out var areaIn, out var perimetrIn);
Console.WriteLine($"Площадь прямоугольника: {area}");       // 200
Console.WriteLine($"Периметр прямоугольника: {perimetr}");   // 60


//При использовании в списке параметров метода ключевое слово ref указывает на то, что аргумент передается по ссылке, а не по значению
//Определение переменных возможно непосредственно при вызове методов с выходными параметрами