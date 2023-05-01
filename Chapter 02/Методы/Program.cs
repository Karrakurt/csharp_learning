//[модификаторы] тип_возвращаемого_значения название_метода([параметры])
//{
//    // тело метода
//}


//Определение метода


void SayHello()
{
    Console.WriteLine("Hello");
}


//Вызов методов


//название_метода (значения_для_параметров_метода);
//SayHello();

SayHello(); // Hello
SayHello(); // Hello

void SayHelloRu()
{
    Console.WriteLine("Привет");
}
void SayHelloEn()
{
    Console.WriteLine("Hello");
}
void SayHelloFr()
{
    Console.WriteLine("Salut");
}

string language = "en";

switch (language)
{
    case "en":
        SayHelloEn();
        break;
    case "ru":
        SayHelloRu();
        break;
    case "fr":
        SayHelloFr();
        break;
}


//Сокращенная запись методов


void SayHelloShort() => Console.WriteLine("Hello");