using static System.Formats.Asn1.AsnWriter;

namespace hw6t
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store s = new Store();
            Console.WriteLine(s);
            s.AddItem(new Item(0, "milkey", "Milky is popular in Israel", 6));
            s.AddItem(new Item(0, "cottage", "Basic dairy product", 4));
            Console.WriteLine(s);
            Console.WriteLine(s);
        }


    }
}
