In C#, access modifiers are keywords used to specify the accessibility of types and members (methods, properties, fields, etc.) within a program. These modifiers control which parts of a program can access a particular type or member. C# provides five main access modifiers:

1. **public**: This is the most permissive access level. A public type or member can be accessed from any other code in the same assembly or from another assembly that references it.

```csharp
public class MyClass
{
    public int MyProperty { get; set; }
}
```

2. **private**: Members with this access modifier are accessible only within the same class or struct. They cannot be accessed from outside the containing class, including derived classes.

```csharp
public class MyClass
{
    private int myField;

    private void MyMethod()
    {
        // Can only be accessed within MyClass
    }
}
```

3. **protected**: This access level allows access to members within the same class or derived classes. Protected members are not accessible from outside the class or struct.

```csharp
public class MyBaseClass
{
    protected int myField;
}

public class MyDerivedClass : MyBaseClass
{
    public void MyMethod()
    {
        // Can access myField here
    }
}
```

4. **internal**: Members with internal access are accessible only within files in the same assembly.

```csharp
internal class InternalClass
{
    // Can be accessed within the same assembly
}
```

5. **protected internal**: This access level combines the accessibility of protected and internal. Members are accessible within the same assembly or by derived classes, regardless of the assembly.

```csharp
public class MyBaseClass
{
    protected internal int myField;
}

public class MyDerivedClass : MyBaseClass
{
    public void MyMethod()
    {
        // Can access myField here
    }
}
```

Understanding and appropriately using access modifiers in C# helps in designing programs with encapsulation, maintaining security, and controlling access to various parts of the codebase.
