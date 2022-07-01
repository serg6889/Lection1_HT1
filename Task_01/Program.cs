// Task_01_1

//int a = 5;
//int b = 7;

//int a = 2;
//int b = 10;

int a = -9;
int b = -3;


int max = a;

if (a > max) max = a;
if (b > max) max = b;

int min = b;

if (b < min) min = b;
if (a < min) min = a;

Console.Write("max = ");
Console.WriteLine(max);

Console.Write("min = ");
Console.WriteLine(min);
