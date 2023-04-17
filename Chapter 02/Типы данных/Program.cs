bool alive = true;
bool isDead = false;

byte b1 = 1;
byte b2 = 102;

sbyte sb1 = -101;
sbyte sb2 = 102;

short s1 = 1;
short s2 = 102;

ushort us1 = 1;
ushort us2 = 102;

int i1 = 10;
int i2 = 0b101;  // бинарная форма i2 = 5
int i3 = 0xFF;   // шестнадцатеричная форма i3 = 255

uint ui1 = 10;
uint ui2 = 0b101;
uint ui3 = 0xFF;

long l1 = -10;
long l2 = 0b101;
long l3 = 0xFF;

ulong ul1 = 10;
ulong ul2 = 0b101;
ulong ul3 = 0xFF;

// float: хранит число с плавающей точкой от -3.4*10^38 до 3.4*10^38 и занимает 4 байта
// double: хранит число с плавающей точкой от ±5.0*10^-324 до ±1.7*10^308 и занимает 8 байтов
// decimal: хранит десятичное дробное число. Если употребляется без десятичной запятой,
// имеет значение от ±1.0*10^-28 до ±7.9228*10^28, может хранить 28 знаков после запятой и занимает 16 байтов

char c1 = 'A';
char c2 = '\x5A';
char c3 = '\u0420';

string hello = "Hello";
string word = "world";

object o1 = 22;
object o2 = 3.14;
object o3 = "hello code";

string name = "Tom";
int age = 33;
bool isEmployed = false;
double weight = 78.65;

Console.WriteLine($"Имя: {name}");
Console.WriteLine($"Возраст: {age}");
Console.WriteLine($"Вес: {weight}");
Console.WriteLine($"Работает: {isEmployed}");

// Для уточнения типов double используются суффиксы:
// F/f - для float
// M/m - для decimal
// Для уточнения типов int используются суффиксы:
// U/u - для uint
// L/l - для long
// UL/ul - для ulong

float f1 = 3.14F;
float f2 = 30.6f;
decimal de1 = 1005.8M;
decimal de2 = 334.8m;

uint ui = 10U;
long l = 20L;
ulong ul = 30UL;

// При неявной типизации значение инициализации не может быть null и она должна происходить при объявлении переменной
// этот код работает
int a;
a = 20;

// этот код не работает
var c;
c = 20;

var c = null;