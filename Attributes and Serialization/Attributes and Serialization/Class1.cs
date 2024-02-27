using System;
using System.Reflection;
/*
 Attributes provide a powerful method of associating metadata, or declarative information, 
 with code (assemblies, types, methods, properties, and so forth). After an attribute is 
 associated with a program entity, the attribute can be queried at run time by using a 
 technique called reflection.

 Your program can examine its own metadata or the metadata in other programs by using reflection.
 Reflection provides objects (of type Type) that describe assemblies, modules, and types. 
 You can use reflection to dynamically create an instance of a type, bind the type to an 
 existing object, or get the type from an existing object and invoke its methods or access its 
 fields and properties. If you're using attributes in your code, reflection enables you to access them.
 */
namespace Attributes_and_Serialization
{
    public class Class1
    {
        static void main()
        {
            // Using GetType to obtain type information:
            int i = 42;
            Type type = i.GetType();
            Console.WriteLine(type);
        }
    }
}