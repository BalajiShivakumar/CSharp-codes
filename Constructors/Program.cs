class Person
{
    private string name; // field

    public string Name   // property
    {
        get { return name; }    //read
        set { name = value; }   //writable
    }
}


//class Program
//{
//    static void Main(string[] args)
//    {
//        Person myObj = new Person();
//        myObj.Name = "Liam";
//        Console.WriteLine(myObj.Name);
//    }
//}







class Persona
{
    private int count = 300;

    public int Count
    {
        get { return count; }
        set
        {
            if (value > 300)
            {
                Console.WriteLine("Error Value");
            }
            else
            {
                count = value;
            }
        }
    }
}