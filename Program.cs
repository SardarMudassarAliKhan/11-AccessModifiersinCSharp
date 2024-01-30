using System;

// Public class accessible from anywhere
public class PublicClass
{
    // Public property accessible from anywhere
    public int PublicProperty { get; set; }

    // Public method accessible from anywhere
    public void PublicMethod()
    {
        Console.WriteLine("This is a public method.");
    }
}

// Class accessible only within this file (internal)
internal class InternalClass
{
    // Internal field accessible only within this file
    internal int InternalField;

    // Internal method accessible only within this file
    internal void InternalMethod()
    {
        Console.WriteLine("This is an internal method.");
    }
}

// Base class with protected member
public class MyBaseClass
{
    protected int ProtectedField;

    // Protected method accessible within this class and derived classes
    protected void ProtectedMethod()
    {
        Console.WriteLine("This is a protected method.");
    }
}

// Derived class inheriting from MyBaseClass
public class MyDerivedClass : MyBaseClass
{
    public void AccessProtectedMember()
    {
        // Can access protected member from the base class
        ProtectedField = 10;
        ProtectedMethod();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of classes
        PublicClass publicClass = new PublicClass();
        InternalClass internalClass = new InternalClass();
        MyDerivedClass derivedClass = new MyDerivedClass();

        // Accessing public members
        publicClass.PublicProperty = 5;
        Console.WriteLine("Public property value: " + publicClass.PublicProperty);
        publicClass.PublicMethod();

        // Accessing internal members
        internalClass.InternalField = 7;
        Console.WriteLine("Internal field value: " + internalClass.InternalField);
        internalClass.InternalMethod();

        // Accessing protected members through derived class
        derivedClass.AccessProtectedMember();

        Console.ReadLine();
    }
}