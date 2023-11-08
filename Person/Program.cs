namespace Person;

class Person
{
    public string Name { get; set; }
    
    public string Address {  get; set; }
    public int PhoneNumber {  get; set; }
    public int Age
    {
        get { return Age; }
        set
        {
            if (Age <= 0)
            {
                throw new Exception();
            }
            else
            {
                Age = value;
            }
        }
    }
    public Person()
    {
       

    }

    public static void Greet(Person person)
    {
        Console.WriteLine($"Hello, My Name is {person.Name} and I am {person.Age} years old");
    }

    public static void IsAdult(Person person) 
    { 
        if(person.Age> 18)
        {
            Console.WriteLine($"{person.Name} is an adult");
        }
        else
        {
            Console.WriteLine($"{person.Name} in not an adult");
        }
    }

    
}

class Program:Person
{
    static void Main(string[] args)
    {
        Person person1 = new Person();
        person1.Name = "Alice";
        person1.Age = 18;
        person1.Address = "smth1";
        person1.PhoneNumber = 231312;

        Person person2 = new Person();
        person2.Name = "Bob";
        person2.Age = 11;
        person2.Address = "smth2";
        person2.PhoneNumber = 21241;


       Greet(person1 );
       IsAdult(person2 );

    }
    
    
    
    


    
}