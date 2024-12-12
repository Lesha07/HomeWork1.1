using HomeWork1;

class Program
{
    static void Main(string[] args)
    {
        Parrot parrot = new Parrot("Kesha", "Alex", 2);
        Fish fish = new Fish("Amigo", "Bob", 1);
        Cat cat = new Cat("Pykich", "Masha", 3);
        Horse horse = new Horse("Gypsy", "Danil", 5);

        parrot.SayHello();
        fish.SayHello();
        cat.SayHello();
        horse.SayHello();

        Defoult defaultAnimal = new Defoult();
        defaultAnimal.SayHello();
    }
}






