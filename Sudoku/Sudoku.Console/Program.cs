namespace Sudoku.CLI
{
    class Program
    {
        static void Main()
        {
            var input = new ConsoleInput();
            var output = new ConsoleOutput();
            var validator = new SudokuValidator();

            var processor = new SudokuProcessor(input, output, validator);
            processor.Process();
        }
    }
}