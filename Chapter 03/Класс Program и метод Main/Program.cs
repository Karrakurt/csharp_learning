﻿// инструкции верхнего уровня (top-level statements)
Person tom = new();
tom.SayHello();

// определение класса идет после инструкций верхнего уровня
class Person
{
    public void SayHello() => Console.WriteLine("Hello");
}