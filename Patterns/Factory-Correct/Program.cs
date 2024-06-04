using Factory_CorrectFactory.Factories;
using Factory_CorrectFactory.Products;

namespace Factory_CorrectFactory;

class Program
{
    static void Main(string[] args)
    {
        Factory amdFactory = new AmdFactory();
        Factory nvidiaFactory = new NvidiaFactory();

        IGpu amdGpu = amdFactory.AssembleGpu();
        IGpu nvidiaGpu = nvidiaFactory.AssembleGpu();
    }
}