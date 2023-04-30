//byte a = 4;
//byte b = (byte)(a + 70);

//byte a = 4;             // 0000100
//ushort b = a;   // 000000000000100

//ushort a = 4;
//byte b = (byte)a;

//sbyte a = 4;            // 0000100
//short b = a;    // 000000000000100

//sbyte a = -4;           // 1111100
//short b = a;    // 111111111111100

try
{
    int a = 33;
    int b = 600;
    byte c = checked((byte)(a + b));
    Console.WriteLine(c);
}
catch (OverflowException ex)
{
    Console.WriteLine(ex.Message);
}