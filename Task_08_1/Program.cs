// See https://aka.ms/new-console-template for more information

Console.WriteLine("Input number ");
int numA = Convert.ToInt32(Console.ReadLine());

int i = 2;

while(i <= numA)
{    
    Console.Write(i + " ");  
    i+=2;  
}