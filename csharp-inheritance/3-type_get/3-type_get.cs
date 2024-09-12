using System;
using System.Collections.Generic;
using System.Reflection;

class Obj
{
    public static void Print(object myObj)
    {
        Console.WriteLine("{0} Properties:", myObj.GetType().Name);

        foreach (PropertyInfo p in myObj.GetType().GetProperties())
        {
            Console.WriteLine(p.Name);
        }

        Console.WriteLine("{0} Methods:", myObj.GetType().Name);

        foreach (MethodInfo m in myObj.GetType().GetMethods())
        {
            Console.WriteLine(m.Name);
        }
    }
}