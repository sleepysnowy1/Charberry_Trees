namespace Charberry_Trees;

class Program
{
    static void Main(string[] args)
    {
        CharberryTree tree = new CharberryTree();

        while(true)
        {
            tree.MaybeGrow();             
        }
    }
}
