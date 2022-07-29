using Sudoku.Models;

namespace Sudoku
{
    public class SudokuValidator : IValidator
    {
        public ValidationResult Validate(int[,] field)
        {
            var result = ValidateSize(field);
            if (!result.IsValid)
            {
                return result;
            }

            result.Errors.AddRange(ValidateVertical(field));
            result.Errors.AddRange(ValidateHorizontal(field));
            result.Errors.AddRange(ValidateSquare(field));

            return result;
        }

        private ValidationResult ValidateSize(int[,] field)
        {
            if (field == null)
                return ValidationResult.CreateWithSingleError("Field is null");
            if (field.GetLength(0) == 0)
                return ValidationResult.CreateWithSingleError("Field is empty");
            if (field.GetLength(0) != field.GetLength(1))
                return ValidationResult.CreateWithSingleError("Dimensional is not equal");
            if (Math.Sqrt(field.GetLength(0)) % 1 != 0)
                return ValidationResult.CreateWithSingleError("The square root of the dimension is not an integer. It is impossible to construct a small square.");
            return new ValidationResult();
        }

        private IEnumerable<string> ValidateHorizontal(int[,] field)
        {
            var result = new List<string>();
            for (int i = 0; i < field.GetLength(0); i++)
            {
                var register = BuildValidationRegister(field.GetLength(0)); 
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    register[field[i, j]]++;
                }
                result.AddRange(CheckErrorsInRegister(register, $"horizontal line {i + 1}"));
            }
            return result;
        }

        private IEnumerable<string> ValidateVertical(int[,] field)
        {
            var result = new List<string>();
            for (int i = 0; i < field.GetLength(0); i++)
            {
                var register = BuildValidationRegister(field.GetLength(0));
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    register[field[j, i]]++;
                }
                result.AddRange(CheckErrorsInRegister(register, $"vertiacal line {i + 1}"));
            }
            return result;
        }

        private IEnumerable<string> ValidateSquare(int[,] field)
        {
            int squareDimension = Convert.ToInt32(Math.Sqrt(field.GetLength(0)));
            var result = new List<string>();
            for (int ih = 0; ih < squareDimension; ih++)
            {
                for (int jh = 0; jh < squareDimension; jh++)
                {
                    var register = BuildValidationRegister(field.GetLength(0));
                    for (int il = 0; il < squareDimension; il++)
                    {
                        for (int jl = 0; jl < squareDimension; jl++)
                        {
                            register[field[ih * squareDimension + il,jh * squareDimension + jl]]++;
                        }
                    }
                    result.AddRange(CheckErrorsInRegister(register, $"litle square {ih}-{jh}"));
                }
            }
            return result;
        }

        private Dictionary<int, int> BuildValidationRegister(int size)
        {
            var result = new Dictionary<int, int>();
            for (int i = 1; i <= size; i++)
            {
                result.Add(i, 0);
            }

            return result;
        }

        private IEnumerable<string> CheckErrorsInRegister(Dictionary<int, int> register, string testedObject)
        {
            var result = new List<string>();
            foreach (var element in register)
            {
                if (element.Value == 0)
                {
                    result.Add($"Number {element.Key} not existed in {testedObject}");
                }
                else if (element.Value > 1)
                {
                    result.Add($"Number {element.Key} placed {element.Value} time in {testedObject}");
                }
            }

            return result;
        }

    }
}
