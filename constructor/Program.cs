using System;

class Program{
    public static void Main(string[] args){
        Animal animal = new Animal();
        animal.Name = "cat";
        animal.Color = "yellow";
        Console.WriteLine(animal.Name);
        Console.WriteLine(animal.Color);

        Animal animal2 = new Animal("dog","red");
        Console.WriteLine(animal2.Name);
        Console.WriteLine(animal2.Color);

        Animal animal3 = new Animal("Duck");
        animal3.Color = "gray";
        Console.WriteLine(animal3.Name);
        Console.WriteLine(animal3.Color);
    }
}