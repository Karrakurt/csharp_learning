//Классы и объекты


//class название_класса
//{
//    // содержимое класса
//}

//class Person
//{

//}


//Поля и методы класса


//class Person
//{
//    public string name = "Undefined";   // имя
//    public int age;                     // возраст

//    public void Print()
//    {
//        Console.WriteLine($"Имя: {name}  Возраст: {age}");
//    }
//}


//Создание объекта класса


//new конструктор_класса(параметры_конструктора);


//Конструктор по умолчанию


//Person tom = new Person();  // создание объекта класса Person

//// определение класса Person
//class Person
//{
//    public string name = "Undefined";
//    public int age;

//    public void Print()
//    {
//        Console.WriteLine($"Имя: {name}  Возраст: {age}");
//    }
//}


//Обращение к функциональности класса


//объект.поле_класса
//объект.метод_класса(параметры_метода)

//Person tom = new Person();  // создание объекта класса Person

//// Получаем значение полей в переменные
//string personName = tom.name;
//int personAge = tom.age;
//Console.WriteLine($"Имя: {personName}  Возраст {personAge}");   // Имя: Undefined  Возраст: 0

//// устанавливаем новые значения полей
//tom.name = "Tom";
//tom.age = 37;

//// обращаемся к методу Print
//tom.Print();    // Имя: Tom  Возраст: 37

//class Person
//{
//    public string name = "Undefined";
//    public int age;

//    public void Print()
//    {
//        Console.WriteLine($"Имя: {name}  Возраст: {age}");
//    }
//}


//Добавление класса


using Классы__структуры_и_пространства_имен;

Person tom = new Person();
tom.name = "Tom";
tom.Print();    // Person Tom

