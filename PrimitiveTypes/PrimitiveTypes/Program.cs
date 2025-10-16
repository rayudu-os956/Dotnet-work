using Microsoft.VisualBasic;

namespace PrimitiveTypes
{
    class Program
    {
        static void Main()
        {
            sbyte a = sbyte.MaxValue;
            sbyte b = 100;
            sbyte c = default(sbyte);

            byte d = byte.MaxValue;
            short e = short.MaxValue;
            ushort f = ushort.MaxValue;
            int g = int.MaxValue;
            uint h = uint.MinValue;
            long i = long.MinValue;
            ulong j = ulong.MaxValue;
            float k = float.MaxValue;
            double l = double.MaxValue;
            decimal m = decimal.MaxValue;
            char n = 'a';
            string o = "rayudu";
            bool p = true;
            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
            System.Console.WriteLine(c);
            System.Console.WriteLine(d);
            System.Console.WriteLine(e);
            System.Console.WriteLine(f);
            System.Console.WriteLine(g);
            System.Console.WriteLine(h);
            System.Console.WriteLine(i);
            System.Console.WriteLine(j);
            System.Console.WriteLine(k);
            System.Console.WriteLine(l);
            System.Console.WriteLine(m);
            System.Console.WriteLine(n);
            System.Console.WriteLine(o);
            System.Console.WriteLine(p);

        }
    }
}