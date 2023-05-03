//Создание конструкторов




//Person tom = new Person();  // Создание объекта класса Person
//tom.Print();    // Имя: Tom  Возраст: 37

using System;

class PersonSimple
{
    public string name;
    public int age;
    public PersonSimple()
    {
        Console.WriteLine("Создание объекта Person");
        name = "Tom";
        age = 37;
    }
    public void Print()
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }
}

//Person tom = new Person();          // вызов 1-ого конструктора без параметров
//Person bob = new Person("Bob");     //вызов 2-ого конструктора с одним параметром
//Person sam = new Person("Sam", 25); // вызов 3-его конструктора с двумя параметрами

//tom.Print();          // Имя: Неизвестно  Возраст: 18
//bob.Print();          // Имя: Bob  Возраст: 18
//sam.Print();          // Имя: Sam  Возраст: 25

class PersonMulti
{
    public string name;
    public int age;
    public PersonMulti() { name = "Неизвестно"; age = 18; }      // 1 конструктор
    public PersonMulti(string n) { name = n; age = 18; }         // 2 конструктор
    public PersonMulti(string n, int a) { name = n; age = a; }   // 3 конструктор

    public void Print()
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }
}


//Ключевое слово this


//Person sam = new("Sam", 25);
//sam.Print();          // Имя: Sam  Возраст: 25

class PersonThis
{
    public string name;
    public int age;
    public PersonThis() { name = "Неизвестно"; age = 18; }
    public PersonThis(string name) { this.name = name; age = 18; }
    public PersonThis(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
}


//Цепочка вызова конструкторов


class PersonChain
{
    public string name;
    public int age;
    public PersonChain() : this("Неизвестно")    // первый конструктор
    { }
    public PersonChain(string name) : this(name, 18) // второй конструктор
    { }
    public PersonChain(string name, int age)     // третий конструктор
    {
        this.name = name;
        this.age = age;
    }
    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
}

//Person tom = new();
//Person bob = new("Bob");
//Person sam = new("Sam", 25);

//tom.Print();          // Имя: Неизвестно  Возраст: 18
//bob.Print();          // Имя: Bob  Возраст: 18
//sam.Print();          // Имя: Sam  Возраст: 25

class PersonUni
{
    public string name;
    public int age;
    public PersonUni(string name = "Неизвестно", int age = 18)
    {
        this.name = name;
        this.age = age;
    }
    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
}


//Инициализаторы объектов


//Person tom = new Person { name = "Tom", age = 31 };
//// или так
//// Person tom = new() { name = "Tom", age = 31 };
//tom.Print();          // Имя: Tom  Возраст: 31


//Person tom = new Person { name = "Tom", company = { title = "Microsoft" } };
//tom.Print();          // Имя: Tom  Компания: Microsoft

class PersonFieldInit
{
    public string name;
    public Company company;
    public PersonFieldInit()
    {
        name = "Undefined";
        company = new Company();
    }
    public void Print() => Console.WriteLine($"Имя: {name}  Компания: {company.title}");
}

class Company
{
    public string title = "Unknown";
}


//Деконструкторы


class PersonDeconstructor
{
    string name;
    int age;
    public PersonDeconstructor(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Deconstruct(out string personName, out int personAge)
    {
        personName = name;
        personAge = age;
    }
}

//Person person = new Person("Tom", 33);

//(string name, int age) = person;

//Console.WriteLine(name);    // Tom
//Console.WriteLine(age);     // 33



//Инициализаторы объектов - задают значения доступных полей для нового объекта
//Деконструкторы - позволяют выполнить декомпозицию объекта на отдельные части