namespace fa2011;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mekkora legyen a fa?");
        string fa = Console.ReadLine().ToLower();
        Stack<long> magassagstack = new Stack<long>();
        long szamlalas=0;
        long magassag = 0;
        long maxmagassag = 0;
        long leghosszabb = 0;
        long leghosszabb2 = 0;

        foreach (char c in fa)
        {
            if (c == '(' || c == ')') szamlalas++;
        }

        long elagazas = szamlalas / 2;

        foreach (char c in fa)
        {
            if (c == 'x')
            {
                magassag++;
                Console.WriteLine($"{magassag} debug x");
                leghosszabb++;
                Console.WriteLine($"{leghosszabb} {leghosszabb2} debug leghosszabb");
            }

            else if (c == '(')
            {
                magassagstack.Push(magassag);
                Console.WriteLine($"{magassagstack.Peek()} debug (");
                leghosszabb = 0;
                Console.WriteLine($"{leghosszabb} {leghosszabb2} debug leghosszabb");
            }
            
            else if  (c == ')')
            {
                magassagstack.Pop();
                //Console.WriteLine($"{magassagstack.Peek()} debug )");
                leghosszabb = 0;
                Console.WriteLine($"{leghosszabb} {leghosszabb2} debug leghosszabb");
            }
            
            if (maxmagassag<magassag) maxmagassag = magassag;

            if (leghosszabb2<leghosszabb) leghosszabb2 = leghosszabb;
        }
        Console.WriteLine($"végső max magassag: {maxmagassag}");
        Console.WriteLine($"elagazasok szama: {elagazas}");
        Console.WriteLine($"leghosszabb sequence: {leghosszabb2}");
        
    }
}