namespace HomeWork1;

public interface IAnimal
{
    string Name { get; set; }
    string OwnerName { get; set; }

    public void SayHello()
    {
        Console.WriteLine("I am default implementation");
    }
}

class Parrot : IAnimal
{
    public string Name { get; set; }
    public string OwnerName { get; set; }
    public int Age { get; set; }

    public Parrot() { }

    public Parrot(string name, string ownerName, int age)
    {
        Name = name;
        OwnerName = ownerName;
        Age = age;
    }

    public void SayHello()
    {
        Console.WriteLine("Rysnya sosat!");
    }
}

class Fish : IAnimal
{
    public string Name { get; set; }
    public string OwnerName { get; set; }
    public int Age { get; set; }

    public Fish() { }

    public Fish(string name, string ownerName, int age)
    {
        Name = name;
        OwnerName = ownerName;
        Age = age;
    }

    public void SayHello()
    {
        Console.WriteLine("Kuliti rabotyagi!");
    }
}

class Cat : IAnimal
{
    public string Name { get; set; }
    public string OwnerName { get; set; }
    public int Age { get; set; }

    public Cat() { }

    public Cat(string name, string ownerName, int age)
    {
        Name = name;
        OwnerName = ownerName;
        Age = age;
    }

    public void SayHello()
    {
        Console.WriteLine("Meow!");
    }
}

class Horse : IAnimal
{
    public string Name { get; set; }
    public string OwnerName { get; set; }
    public int Age { get; set; }

    public Horse() { }

    public Horse(string name, string ownerName, int age)
    {
        Name = name;
        OwnerName = ownerName;
        Age = age;
    }

    public void SayHello()
    {
        Console.WriteLine("Почему"); //https://www.tiktok.com/@loopyiix/video/7393036364616338730
    }
}