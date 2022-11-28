using RecursionProgram.Interfaces;
using RecursionProgram.Models;

namespace RecursionProgram.Calculations
{
    public class DepthCalculator : ICalculator
    {
        public int CalculateDepth(Branch structure, int structureDepth)
        {
            if (structure.branches == null)
            {
                return structureDepth;
            }

            structureDepth++;

            return structure.branches
                .Select(branch => CalculateDepth(branch, structureDepth))
                .ToList()
                .Max();
        }
    }
}