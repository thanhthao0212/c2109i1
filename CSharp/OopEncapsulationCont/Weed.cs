

using OopEcapsulation;

namespace OopEncapsulationCont;
internal class Weed :Plant

{
    static void Main(string[] args)
    {
        Weed w = new();
        w.Protected();
        w.ProtectedInternal();
    }
}
