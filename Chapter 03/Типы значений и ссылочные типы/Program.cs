﻿//Составные типы


State state1 = new State(); // State - структура, ее данные размещены в стеке
Country country1 = new Country(); // Country - класс, в стек помещается ссылка на адрес в хипе
                                  // а в хипе располагаются все данные объекта country1
struct State
{
    public int x;
    public int y;
}
class Country
{
    public int x;
    public int y;
}