using System.Linq;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string myString = "Hello";
Console.WriteLine(myString[1]);  // Outputs "e"

string name = "Balaji Sivakumar";

int namechar = name.IndexOf("S");

string lastname = name.Substring(namechar);

Console.WriteLine(lastname);

Console.WriteLine("Balaji\'s Macbook Air");

int myAge = 25;
int votingAge = 18;
Console.WriteLine(myAge >= votingAge);

//Condition and Type casting
//Console.WriteLine("Enter your age: ");
//int Age = Convert.ToInt32(Console.ReadLine());
//if(Age < 18)
//{
//    Console.WriteLine("Not eligible to vote");
//}
//else
//{
//    Console.WriteLine("Eligible to vote");
//}

//short hand if else condition
//string eligibility = (Age >= 18) ? "Eligible to vote" : "Not eligible to vote";
//Console.WriteLine(eligibility);



int number = 5;

switch (number)
{
    case 1:
        Console.WriteLine("Number 1");
        break;
    case 2:
        Console.WriteLine("Number 2");
        break;
    case 3:
        Console.WriteLine("Number 3");
        break;
    case 4:
        Console.WriteLine("Number 4");
        break;
    case 5:
        Console.WriteLine("Number 5");
        break;
    case 6:
        Console.WriteLine("Number 6");
        break;
    case 7:
        Console.WriteLine("Number 7");
        break;
    default: //default is not mandatory
        Console.WriteLine("out of the loop");
        break;
}

int i = 10;
while (i < 11)
{
    Console.WriteLine("The value of i is greater than 10 and i = " + i);
    i++;
}

//while
do
{
    Console.WriteLine("This part of the code comes from the do while loop");
}
while (i <= 10);


//do while
int integer = 0;
do
{
    Console.WriteLine(integer);
    integer++;
}
while (integer < 5);


//forwach
string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
foreach (string a in cars)
{
    Console.WriteLine(a);
}

for (int d = 0; d < 10; d++)
{
    if (d == 4)
    {
        continue;
    }
    Console.WriteLine(d);
}

string[] minis = { "mini1", "mini2", "mini3", "mini4"};
foreach(string e in minis)
{
    Console.WriteLine(e);
}

for(int e = 0; e<minis.Length; e++)
{
    Console.WriteLine(minis[e]);
}

// Sort a string
string[] miniss = { "g", "C", "D", "F" };
Array.Sort(miniss);
foreach (string r in miniss)
{
    Console.WriteLine(r);
}

int[] myNumbers = { 5, 1, 8, 9 };
Console.WriteLine(myNumbers.Max());  // returns the largest value
Console.WriteLine(myNumbers.Min());  // returns the smallest value
Console.WriteLine(myNumbers.Sum());  // returns the sum of all the number




int[,] nubers = { { 1, 4, 2 }, { 3, 6, 8 } };

for (int ingg = 0; ingg < nubers.GetLength(0); ingg++)
{
    for (int jngg = 0; jngg < nubers.GetLength(1); jngg++)
    {
        Console.WriteLine(nubers[ingg, jngg]);
    }
}

static void Add(int a,int b)
{
    Console.WriteLine(a + b);
}

Add(100, 200);

static void MyMethod(string country = "India")
{
    Console.WriteLine("I am from " + country);
}

MyMethod("USA");
MyMethod("United Kingdom");
MyMethod();


static int Age(int age)
{
    return age;
}

Console.WriteLine(Age(24));


static void ChildMethod(string child1, string child2, string child3)
{
    Console.WriteLine("The youngest child is: " + child3);
}
ChildMethod(child3: "John", child1: "Liam", child2: "Liam");



