# C Sharp Sandbox

Explicit Casting 
- double 
- float 
- long 
- int 
- char

double -> float -> long -> int -> char

# Initial Project Github Command (First Time)
- git init
- git remote add origin <input your repo ref here>
- git branch -M main
- git add .
- git commit -m 'feat: My first feature'
- git push -u origin main

Reference : https://mazer.dev/en/git/troubleshooting/error-src-refspec-main-does-not-match-any-git/#:~:text=Gitlab%20or%20Bitbucket.-,What%20means%20the%20error%3A%20src%20refspec%20main%20does%20not%20match,if%20there%20are%20any%20made.

# Inheritance == Polymorphism 
- **virtual** => method prepprae to be override in base clase
- **override** => method override in drived class
```cs
class Animal  // Base class (parent) 
{
  public **virtual** void animalSound() 
  {
    Console.WriteLine("The animal makes a sound");
  }
}

class Pig : Animal  // Derived class (child) 
{
  public **override** void animalSound() 
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Program 
{
  static void Main(string[] args) 
  {
    Animal myAnimal = new Animal();  // Create a Animal object
    Animal myPig = new Pig();  // Create a Pig object

    myAnimal.animalSound();   //The animal makes a sound
    myPig.animalSound();      //The pig says: wee wee

  }
}
```
-------------------------------------------------------------------

#  Abstract vs Interface
- hide detail & show only essential info 

### Abstract
- unable to create object from class
- method have no body, only use in abstact class

```cs
**abstract** class Animal{
    //**No body contain in abstract method** 
    public **abstract** void AnimalCall();
 
    public void AnimalSleep(){
        Console.WriteLine("Time to sleep , Zzz Zzz Zzz");
    }
}

clss Pig : Animal {
    public **override** void AnimalCall{
        // override from Animal abstract class
        Console.WriteLine("The pig says: wee wee");
    }
}

class Program
{
  static void Main(string[] args)
  {
    Pig myPig = new Pig();  // Create a Pig object
    myPig.animalSound();    // Call the abstract method , The pig says: wee wee
    myPig.sleep();          // Call the regular method Time to sleep , Zzz Zzz Zzz
  }
}

```

#### Interface
- contain properties and methods, but not fields.
- Able multiple interface, but not inheritance
- members of an interface are **abstract** and ***public**.

```cs

interface IMyInterface
{
    int MyProperty { get; } // Property to access the field

    void MyMethod();
}

class MyConcreteClass : IMyInterface
{
    private int myField = 42;

    public int MyProperty
    {
        get { return myField; }
    }

    public void MyMethod()
    {
        // Implementation of the method.
    }
}

---------------------------------------------------------
- Multiple Interface

interface IFirstInterface 
{
  void myMethod(); // interface method
}

interface ISecondInterface 
{
  void myOtherMethod(); // interface method
}

// Implement multiple interfaces
class DemoClass : IFirstInterface, ISecondInterface 
{
  public void myMethod() 
  {
    Console.WriteLine("Some text..");
  }
  public void myOtherMethod() 
  {
    Console.WriteLine("Some other text...");
  }
}

class Program 
{
  static void Main(string[] args)
  {
    DemoClass myObj = new DemoClass();
    myObj.myMethod();
    myObj.myOtherMethod();
  }
}

```