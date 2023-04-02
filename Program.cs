Console.WriteLine("Hello, World!");

string name = "old greg";
Console.WriteLine(name);

name = "new greg";
Console.WriteLine(name);

Console.WriteLine("Hello " + name);
Console.WriteLine($"Hello interpolated {name}");

int age = 25;
double timeAlive = 20.6;
char c = 'C';

Console.WriteLine($"Age is {age}");
Console.WriteLine($"time alive is {timeAlive}");
Console.WriteLine($"char is {c}");

var something = 77;
Console.WriteLine($"{something.GetType()}");


bool IsEven(int i)
{
    return (i % 2 == 0);
}

var seconds = DateTime.Now.Second;

if (IsEven(seconds))
{
    Console.WriteLine($"seconds {seconds} is even");
}
else 
{
    Console.WriteLine($"seconds {seconds} is odd");
}

string[] names = {"hello", "world"};

foreach (string n in names)
{
    Console.WriteLine(n);
}

var words = new string[] {"give", "a", "little", "bit"};

foreach (var word in words)
{
    Console.WriteLine(word);
}