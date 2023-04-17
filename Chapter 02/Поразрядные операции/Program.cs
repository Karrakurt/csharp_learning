//int x1 = 2; //010
//int y1 = 5;//101
//int x2 = 4; //100
//int y2 = 5; //101

//Console.WriteLine(x1 & y1); // выведет 0
//Console.WriteLine(x2 & y2); // выведет 4
//Console.WriteLine(x1 | y1); // выведет 7 - 111
//Console.WriteLine(x2 | y2); // выведет 5 - 101

//int x = 45; // Значение, которое надо зашифровать - в двоичной форме 101101
//int key = 102; //Пусть это будет ключ - в двоичной форме 1100110

//int encrypt = x ^ key; //Результатом будет число 1001011 или 75
//Console.WriteLine($"Зашифрованное число: {encrypt}");

//int decrypt = encrypt ^ key; // Результатом будет исходное число 45
//Console.WriteLine($"Расшифрованное число: {decrypt}");

//int x = 12;                 // 00001100
//Console.WriteLine(~x);      // 11110011 или -13

//int x = 12;
//int y = ~--x;
////y += 1;
//Console.WriteLine(y);   // -12


//int a = 16; // в двоичной форме 10000
//int b = 2; // в двоичной форме 10
//int c = a << b; // Сдвиг числа 10000 влево на 2 разряда, равно 1000000 или 64 в десятичной системе

//Console.WriteLine($"Зашифрованное число: {c}");    // 64

//int d = a >> b; // Сдвиг числа 10000 вправо на 2 разряда, равно 100 или 4 в десятичной системе
//Console.WriteLine($"Зашифрованное число: {d}");     // 4


//int a = 22; // в двоичной форме 10110
//int b = 2; // в двоичной форме 10
//int c = a << b; // Сдвиг числа 10110 влево на 2 разряда, равно 1011000 или 88 в десятичной системе

//Console.WriteLine($"Зашифрованное число: {c}");    // 88

//int d = a >> b; // Сдвиг числа 10110 вправо на 2 разряда, равно 101 или 5 в десятичной системе
//Console.WriteLine($"Зашифрованное число: {d}");     // 5


//int value1 = 3;  // 0b0000_0011
//int value2 = 2;  // 0b0000_0010
//int value3 = 1;  // 0b0000_0001
//int result = 0b0000_0000;
//// сохраняем в result значения из value1
//result = result | value1; // 0b0000_0011
//// сдвигаем разряды в result на 2 разряда влево
//result = result << 2;   // 0b0000_1100
//// сохраняем в result значения из value2
//result = result | value2;  // 0b0000_1110
//// сдвигаем разряды в result на 2 разряда влево
//result = result << 2;   // 0b0011_1000
//// сохраняем в result значения из value3
//result = result | value3;  // 0b0011_1001

int value1 = 3;  // 0b0000_0011
int value2 = 2;  // 0b0000_0010
int value3 = 1;  // 0b0000_0001
int result = 0b0000_0000;
// сохраняем в result значения из value1
result = result | (value1 << 4);
// сохраняем в result значения из value2
result = result | (value2 << 2);
// сохраняем в result значения из value3
result = result | value3;  // 0b0011_1001

Console.WriteLine(result);  // 57