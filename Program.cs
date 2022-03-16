using System;

public abstract class A
{
    public abstract void m2();
    public void m3()
    {
        Console.WriteLine(" I am M3 method in abstract");
    }

}

public class B : A
{
    public override void m2()
    {
        Console.WriteLine("Hello I am M2 Method");
    }
}
 class AbstractExample
{
        public static void Main(string[] args)
        {
            A b = new B(); 
            b.m2();
            b.m3();
            Console.ReadLine();

        }
}

