namespace SimplifyMemberRepro;

internal class Program
{
    static void Main(string[] args)
    {
        //access to static member through derived class with same name in different namespace
        Console.WriteLine(Base.StaticPropertyOnBase);
        //code fix suggests this
        Console.WriteLine(Core.Longer.Namespace.To.Make.Weirdness.Obvious.Base.StaticPropertyOnBase);
    }
}
