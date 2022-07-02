// Task_01_1_2_3

//int a = 5;
//int b = 7;

//int a = 2;
//int b = 10;

//int a = -9;
//int b = -3;

int numA = new Random().Next(-10, 10);
Console.Write("numA = ");
Console.WriteLine(numA);

int numB = new Random().Next(-10, 10);
Console.Write("numB = ");
Console.WriteLine(numB);


int max = numA;

if (numA > max) max = numA;
if (numB > max) max = numB;

int min = numB;

if (numB < min) min = numB;
if (numA < min) min = numA;

Console.Write("max = ");
Console.WriteLine(max);

Console.Write("min = ");
Console.WriteLine(min);
