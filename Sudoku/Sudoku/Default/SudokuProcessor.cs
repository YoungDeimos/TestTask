namespace Sudoku
{
    public class SudokuProcessor : ISudokuProcessor
    {
        private IInput input;
        private IOutput output;
        private IValidator validator;

        public SudokuProcessor(IInput input, IOutput output, IValidator validator)
        {
            this.input = input;
            this.output = output;
            this.validator = validator;
        }

        public void Process()
        {
            var field = input.Read();
            var result = validator.Validate(field);
            output.OutputResult(result);
        }
    }
}
