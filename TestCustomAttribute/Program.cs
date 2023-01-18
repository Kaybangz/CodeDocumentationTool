using DocumentationTool;

namespace TestCustomAttribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomAttributeAttribute.GetDocs(typeof(Mammals));
            CustomAttributeAttribute.GetDocs(typeof(Reptiles));
        }
    }
}