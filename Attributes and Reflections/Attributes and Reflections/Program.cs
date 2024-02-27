using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.InteropServices;

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

namespace Attributes_and_Reflections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using GetType to obtain type information:
            int i = 42;
            Type type = i.GetType();
            Console.WriteLine(type);

            // Using Reflection to get information of an Assembly:
            Assembly info = typeof(int).Assembly;
            Console.WriteLine(info);

            //To identify an internal method using reflection, use the IsAssembly property.
            //To identify a protected internal method, use the IsFamilyOrAssembly.

            //^^^^^^^^^Attributes^^^^^^^^^//
            /*
             [Serializable]
             public class SampleClass
                {
                    // Objects of this type can be serialized.
                }
            

            //methods too can take on attributes
            [System.Runtime.InteropServices.DllImport("user32.dll")]
            extern static void SampleMethod();

            //more than one attribute can be assigned to a class
            void MethodA([In][Out] ref double x) { }

            //Some attributes can be specified more than once for a given entity.
            [Conditional("DEBUG"), Conditional("TEST1")]
            void TraceMethod()
            {
                // ...
            }

            //attributes can be applied to targets like,assembly,module, field, event,
            method, param, property, return, type.

            //we can set them to the nearest target by doing this
            [assembly: AssemblyTitleAttribute("Production assembly 4")]
            [module: CLSCompliant(true)]


            */
            Console.ReadLine();
        }
    }
}
