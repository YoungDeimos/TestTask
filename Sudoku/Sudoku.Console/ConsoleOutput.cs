using Sudoku.Models;

namespace Sudoku.CLI
{
    internal class ConsoleOutput : IOutput
    {
        public void OutputResult(ValidationResult result)
        {
            if (result.IsValid)
            {
                Console.WriteLine("Sudoku is valid");
            }
            else
            {
                Console.WriteLine("Sudoku is not valid. Errors:");
                foreach(var error in result.Errors)
                {
                    Console.WriteLine(error);
                }
            }
        }
    }
}
