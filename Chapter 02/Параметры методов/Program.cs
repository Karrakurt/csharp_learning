//тип_метода имя_метода(тип_параметра1 параметр1, тип_параметра2 параметр2, ...)
//{
//    // действия метода
//}

void PrintMessage(string message)
{
    Console.WriteLine(message);
}
PrintMessage("Hello work");           // Hello work
PrintMessage("Hello METANIT.COM");    // Hello METANIT.COM
PrintMessage("Hello C#");             // Hello C#

void Sum(int x, int y)
{
    int result = x + y;
    Console.WriteLine($"{x} + {y} = {result}");
}
Sum(10, 15);    // 10 + 15 = 25

void SumShort(int x, int y) => Console.WriteLine($"{x} + {y} = {x + y}");
SumShort(10, 15);    // 10 + 15 = 25

int a = 10, b = 15, c = 6;
SumShort(a, b);                  // 10 + 15 = 25
SumShort(3, c);                  // 3 + 6 = 9
SumShort(14, 4 + c);             // 14 + 10 = 24


//Соответствие параметов и аргументов по типу данных


void PrintPerson(string name, int age)
{
    Console.WriteLine($"Name: {name}  Age: {age}");
}
PrintPerson("Tom", 24); // Name: Tom  Age: 24

byte bb = 37;
PrintPerson("Tom", bb); // Name: Tom  Age: 37

//PrintPerson(45, "Bob"); // Ошибка! несоответствие значений типам параметров


//Необязательные параметры


void PrintPersonOptional(string name, int age = 1, string company = "Undefined")
{
    Console.WriteLine($"Name: {name}  Age: {age}  Company: {company}");
}

PrintPersonOptional("Tom", 37, "Microsoft");  // Name: Tom  Age: 37  Company: Microsoft
PrintPersonOptional("Tom", 37);               // Name: Tom  Age: 37  Company: Undefined
PrintPersonOptional("Tom");                   // Name: Tom  Age: 1   Company: Undefined


//Именованные параметры


PrintPersonOptional("Tom", company: "Microsoft", age: 37);  // Name: Tom  Age: 37  Company: Microsoft
PrintPersonOptional(age: 41, name: "Bob");          // Name: Bob  Age: 41  Company: Undefined
PrintPersonOptional(company: "Google", name: "Sam"); // Name: Sam  Age: 1   Company: Google


//Именованные аргументы позволяют указать аргумент для параметра, связав этот аргумент с именем параметра,
//а не с его позицией в списке параметров