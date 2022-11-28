using RecursionProgram.Calculations;
using RecursionProgram.Extensions;
using RecursionProgram.Interfaces;
using RecursionProgram.Models;

namespace RecursionProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            var structure = new Branch(new List<Branch>()
            {
                new Branch(new List<Branch>() {new Branch()}),
                new Branch(new List<Branch>()
                {
                    new Branch(),
                    new Branch(new List<Branch>(){new Branch()}),
                    new Branch(new List<Branch>(){
                        new Branch(new List<Branch>()
                        {
                            new Branch(), new Branch()
                        })}),
                })
            });

            DisplayResult(CreateCalculator().CalculateDepth(structure));
        }

        public static ICalculator CreateCalculator()
        {
            return new DepthCalculator();
        }

        public static void DisplayResult(int result)
        {
            new ResultPrinter().Print(result);
        }
    }
}