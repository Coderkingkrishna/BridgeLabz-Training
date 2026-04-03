using System;

// Interface for flying birds
interface IFlyable{
    void Fly();
}

// Interface for swimming birds
interface ISwimmable{
    void Swim();
}

// Base class
abstract class Bird{
    protected string name;
    public Bird(string name){
        this.name=name;
    }
    public abstract void Display();
}

// Derived classes
class Eagle:Bird,IFlyable{
    public Eagle(string name):base(name){}
    public void Fly(){
        Console.WriteLine(name+" is flying high");
    }
    public override void Display(){
        Console.WriteLine("Bird: Eagle - "+name);
    }
}

class Sparrow:Bird,IFlyable{
    public Sparrow(string name):base(name){}
    public void Fly(){
        Console.WriteLine(name+" is flying fast");
    }
    public override void Display(){
        Console.WriteLine("Bird: Sparrow - "+name);
    }
}

class Duck:Bird,ISwimmable{
    public Duck(string name):base(name){}
    public void Swim(){
        Console.WriteLine(name+" is swimming");
    }
    public override void Display(){
        Console.WriteLine("Bird: Duck - "+name);
    }
}

class Penguin:Bird,ISwimmable{
    public Penguin(string name):base(name){}
    public void Swim(){
        Console.WriteLine(name+" is swimming in cold water");
    }
    public override void Display(){
        Console.WriteLine("Bird: Penguin - "+name);
    }
}

class Seagull:Bird,IFlyable,ISwimmable{
    public Seagull(string name):base(name){}
    public void Fly(){
        Console.WriteLine(name+" is flying near sea");
    }
    public void Swim(){
        Console.WriteLine(name+" is swimming in sea");
    }
    public override void Display(){
        Console.WriteLine("Bird: Seagull - "+name);
    }
}

// Main class
class MainClass{
    static void Main(){
        Bird[] birds=new Bird[5];

        birds[0]=new Eagle("EagleOne");
        birds[1]=new Sparrow("SparrowOne");
        birds[2]=new Duck("DuckOne");
        birds[3]=new Penguin("PenguinOne");
        birds[4]=new Seagull("SeagullOne");

        for(int i=0;i<birds.Length;i++){
            birds[i].Display();

            if(birds[i] is IFlyable){
                ((IFlyable)birds[i]).Fly();
            }

            if(birds[i] is ISwimmable){
                ((ISwimmable)birds[i]).Swim();
            }

            Console.WriteLine("----------------");
        }
    }
}
