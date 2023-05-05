//Определение структуры


//struct имя_структуры
//{
//    // элементы структуры
//}

//struct Person
//{
//    public string name;
//    public int age;

//    public void Print()
//    {
//        Console.WriteLine($"Имя: {name}  Возраст: {age}");
//    }
//}


//Создание объекта структуры
//Инициализация с помощью конструктора

//new название_структуры();


//Person tom = new Person();  // вызов конструктора
//                            // или так 
//                            // Person tom = new();

//tom.name = "Tom";   // изменяем значение по умолчанию в поле name

//tom.Print();    // Имя: Tom  Возраст: 0

//struct Person
//{
//    public string name;
//    public int age;

//    public void Print()
//    {
//        Console.WriteLine($"Имя: {name}  Возраст: {age}");
//    }
//}


//Непосредственная иницилизация полей


//Person tom;         // не вызываем конструктор
//// инициализация полей
//tom.name = "Sam";
//tom.age = 37;

//tom.Print();    // Имя: Sam  Возраст: 37

//struct Person
//{
//    public string name;
//    public int age;

//    public void Print()
//    {
//        Console.WriteLine($"Имя: {name}  Возраст: {age}");
//    }
//}


//Инициализация полей по умолчанию


//Person tom = new Person();
//tom.Print();    // Имя:Tom  Возраст: 1

//struct Person
//{
//    // инициализация полей значениями по умолчанию - доступна с C#10
//    public string name = "Tom";
//    public int age = 1;
//    public Person() { }
//    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
//}


//Конструкторы структуры


//Person tom = new();
//Person bob = new("Bob");
//Person sam = new("Sam", 25);

//tom.Print();    // !!!! Имя:   Возраст: 0 потому что вызывается конструктор по умолчанию, который не имеет параметров
//bob.Print();    // Имя: Bob  Возраст: 1 
//sam.Print();    // Имя: Sam  Возраст: 25

//struct Person
//{
//    public string name;
//    public int age;

//    public Person(string name = "Tom", int age = 1)
//    {
//        this.name = name;
//        this.age = age;
//    }
//    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
//}


//Person tom = new();

//tom.Print();    // Имя: Tom  Возраст: 37

//struct Person
//{
//    public string name;
//    public int age;

//    public Person()
//    {
//        name = "Tom";
//        age = 37;
//    }
//    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
//}

//Person tom = new();
//Person bob = new("Bob");
//Person sam = new("Sam", 25);

//tom.Print();    // Имя: Tom  Возраст: 1
//bob.Print();    // Имя: Bob  Возраст: 1 
//sam.Print();    // Имя: Sam  Возраст: 25

//struct Person
//{
//    public string name;
//    public int age;

//    public Person() : this("Tom") { }
//    public Person(string name) : this(name, 1) { }
//    public Person(string name, int age)
//    {
//        this.name = name;
//        this.age = age;
//    }
//    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
//}


//Инициализатор структуры


//Person tom = new() { name = "Tom", age = 22 };

//tom.Print();    // Имя: Tom  Возраст: 22

//struct Person
//{
//    public string name;
//    public int age;
//    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
//}


//Копирование структуры с помощью with


//Person tom = new Person { name = "Tom", age = 22 };
//Person bob = tom with { name = "Bob" };
//bob.Print();    // Имя: Bob  Возраст: 22

//Структурами можно пользоваться без вызова конструктора, если проинициализировать поля вручную и при отсутствии приватных полей
//Структуры можно копировать с помощью ключевого слова with: b = a with { field1 = value1, field2 = value2... }