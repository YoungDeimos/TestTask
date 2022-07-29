using Sudoku.Models;

namespace Sudoku
{
    public interface IValidator
    {
        ValidationResult Validate(int[,] field); 
    }
}
