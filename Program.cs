

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//----------------------------Interface Example--------------------
/*interface IFirstName
{
    void FirstName();
}
interface ILastName
{
    void LastName();
}
class FullName : IFirstName, ILastName
{
    public void FirstName()
    {
        Console.Write("Ajay ");
    }
    public void LastName()
    {
        Console.WriteLine("chakrupe");
    }
}
class Program
{
    static void Main(string[] args)
    {
        FullName name = new FullName();
        name.FirstName();
        name.LastName();
    }
}*/

//--------------Polymorphism Example-----------------
//----Compiletime polymorphism(method overloading)----
/*
    class Employee
    {

        public int salary(int sal, int amt)
        {
            int sum = sal + amt;
            return sum;
        }
        public int salary(int sal, int amt, int num)
        {
            int sum = sal + amt + num;
            return sum;
        }
        public static void Main(String[] args)
        {
            Employee e1 = new Employee();

            Console.WriteLine(e1.salary(123456, 1234));
            Console.WriteLine(e1.salary(987, 654, 321));
        }

    }



*/
//----Runtime polymorphism(method overriding)(To perform method overriding in C#, you need to use virtual keyword with base class method and override keyword with derived class method.)
/*class Animal
{
    public virtual void eat()
    {
        Console.WriteLine("Eating..");
    }
}
class Dog : Animal
{
    public override void eat()
    {
        Console.WriteLine("Eating Bread..");
    }
}
class Overriding
{
   public static void Main(string[] args)
    {
        Dog over = new Dog();
        over.eat();
    }
}*/

//-------------------------------Inheritance-------------------------
//----SingleInheritance----
/*class Parent
{
    public void dad(){
        
   Console.WriteLine("I'm Parent");
    }
}
class Child : Parent
{
   public void son(){
       Console.WriteLine("I'm Child");
   }
}
class SingleInheritance
{
    public static void Main(string[] args){
    Child child = new Child();
    child.dad();
    child.son();
    }
}
*/
//----MultiLevel Inheritance----
/*class Animal
{
    public void move()
    {
        Console.WriteLine("Animals are moving");

    }
    class Dog : Animal
    {
        public void move()
        {
            Console.WriteLine("Dogs can walk and run");
        }
    }
    class Puppy : Dog
    {
        public void move()
        {
            Console.WriteLine("puppy can move ");
        }
    }
    class Tester
    {
        public static void main(String[] args)
        {
            Puppy pu = new Puppy();
            pu.move();
        }
    }

*/
//----Herarchical Inheritance----
/*class Parent
{
    public void dad()
    {
        Console.WriteLine("I'm Dad");
    }
}
class Son : Parent
{
    public void son()
    {
        Console.WriteLine("I'm Son");
    }
}
class GrandSon : Parent
{
    public void gson()
    {
        Console.WriteLine("I'm GrandSon");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        GrandSon grandson = new GrandSon();
        grandson.dad();
        grandson.gson();
        //g.son();    //CompileTime Error
    }
}
*/
//----MultipleInheritance----
/*class Parent
{
    public void dad()
    {
        Console.WriteLine("I'm dad");
    }
}
class Son
{
    public void son()
    {
        Console.WriteLine("I'm Son");
    }
}
class GrandSon: Son, Parent
{
    public void gson()
    {
        Console.WriteLine("I'm grandSon");
    }
}
*/
//------------------------Abstraction-----------------------
/*abstract class Parent
{
    public abstract void dad();
    public void who()
    {
        Console.WriteLine("I'm Dad.");
    }
}
class Son: Parent
{
    public override void dad()
    {
        Console.WriteLine("I'm Son.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Son son = new Son();
        son.dad();
        son.who();
    }
}
*/
