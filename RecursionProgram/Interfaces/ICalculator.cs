using RecursionProgram.Models;

namespace RecursionProgram.Interfaces
{
    public interface ICalculator
    {
        int CalculateDepth(Branch structure, int structureDepth = 1);
    }
}