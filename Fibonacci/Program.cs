// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int a=0;
int b=1;

Console.WriteLine("Enter the number of terms in the Fibonacci Series: ");
string number=Console.ReadLine()!;
//the purpose of the ! symbol in the above line ending signifies that the number input won't be null
int n=int.Parse(number);

if(n>0)
{
    Console.WriteLine("The Fibonacci Series is as follows: ");
    Console.WriteLine(a);
    Console.WriteLine(b);
    
    for(int i=2;i<n;i++)
    {
        int c=a+b;
        Console.WriteLine(c);
        a=b;
        b=c;
    }
}
else
{
    Console.WriteLine("The number of terms entered is not proper. Try again!!!!");
}