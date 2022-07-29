namespace Sudoku.CLI
{
    internal class ConsoleInput : IInput
    {
        public int[,] Read()
        {
            var dimension = int.Parse(Console.ReadLine());

            var array = new int[dimension, dimension];

            for (int i = 0; i < dimension; i++)
            {
                var row = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

                for (int j = 0; j < row.Length; j++)
                {
                    array[i, j] = row[j];
                }
            }

            return array;
        }
    }
}
