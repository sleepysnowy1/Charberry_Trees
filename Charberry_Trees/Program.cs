namespace Charberry_Trees;

class Program
{
    static void Main(string[] args)
    {
        CharberryTree tree = new CharberryTree();
        Notifier notifier = new Notifier(tree);

        while(true)
        {
            tree.MaybeGrow();             
        }
    }
}
