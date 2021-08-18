using System;

namespace OutrosMembrosDeFuncao
{
    class Program
    {
        static int s_changeCount;

        static void Main(string[] args)
        {
            MyList<int> a = new MyList<int>();

            a.Changed += new EventHandler(ListChanged);

            a.Add(10);
            a.Add(20);

            

            MyList<int> b = new MyList<int>();
            b.Add(10);
            b.Add(20);
            Console.WriteLine(a == b);
            b.Add(30);
            Console.WriteLine(a == b);

            Console.WriteLine(s_changeCount);

            b[2] = 25;

            Console.WriteLine(b[2]);
        }

        static void ListChanged(object sender, EventArgs e)
        {
            s_changeCount++;
        }
    }
}
