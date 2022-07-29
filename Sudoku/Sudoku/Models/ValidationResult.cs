namespace Sudoku.Models
{
    public class ValidationResult
    {
        public bool IsValid => !Errors.Any();

        public List<string> Errors { get; set; }

        public ValidationResult()
        {
            Errors = new List<string>();
        }

        public static ValidationResult CreateWithSingleError(string error)
        {
            return new ValidationResult
            {
                Errors = new List<string> { error }
            };
        }

    }
}
