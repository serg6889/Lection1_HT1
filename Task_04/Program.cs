// Task_04_5_6

//int numA = 2;
//int numB = 3;
//int numC = 7;

//int numA = 44;
//int numB = 5;
//int numC = 78;

//int numA = 22;
//int numB = 3;
//int numC = 9;


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



