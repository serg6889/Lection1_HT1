// Task_04_5_6

//int a = 2;
//int b = 3;
//int c = 7;

//int a = 44;
//int b = 5;
//int c = 78;

//int a = 22;
//int b = 3;
//int c = 9;

int numA = new Random().Next(0, 100);
Console.Write("numA = ");
Console.WriteLine(numA);

int numB = new Random().Next(0, 100);
Console.Write("numB = ");
Console.WriteLine(numB);

int numC = new Random().Next(0, 100);
Console.Write("numC= ");
Console.WriteLine(numC);

int max = numA;

if (numA > max) max = numA;
if (numB > max) max = numB;
if (numC > max) max = numC;


Console.WriteLine(max);



