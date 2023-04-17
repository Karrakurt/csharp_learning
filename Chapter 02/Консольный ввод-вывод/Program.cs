//string hello = "Привет мир";
//Console.WriteLine(hello);
//Console.WriteLine("Добро пожаловать в C#!");
//Console.WriteLine("Пока мир...");
//Console.WriteLine(24.5);

// Интерполяция - встраивание переменных в строки
//string name = "Tom";
//int age = 34;
//double height = 1.7;
//Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м");

//string name = "Tom";
//int age = 34;
//double height = 1.7;
//Console.WriteLine("Имя: {0}  Возраст: {2}  Рост: {1}м", name, height, age);

//Console.Write("Введите свое имя: ");
//string? name = Console.ReadLine();
//Console.WriteLine($"Привет {name}");

Console.Write("Введите имя: ");
string? name = Console.ReadLine();

Console.Write("Введите возраст: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите рост: ");
double height = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите размер зарплаты: ");
decimal salary = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м  Зарплата: {salary}$");