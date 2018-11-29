// Syfte: skapa en bil-klass som innehåller bil-egenskaper (använd ej propertys)
using System;

namespace M6_Classes.DemoClasses
{
    public class Demo1
    {
        // todo: gör klassen Car

        public void Run()
        {
            var c1 = new Car();
            var c2 = new Car();
            var c3 = new Car();

            c1.SetColor("blå");
            c2.SetColor("röd");

            var yyy = c1.GetColor();
            var zzz = c2.GetColor();
            var qqq = c3.GetColor();

            Console.WriteLine("Färgen på bilen 'c1' är " + yyy);
            Console.WriteLine("Färgen på bilen 'c2' är " + zzz);
            Console.WriteLine("Färgen på bilen 'c3' är " + qqq);
        }
    }
}
