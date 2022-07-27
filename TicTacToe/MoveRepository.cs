namespace TicTacToe
{
    public class MoveRepository
    {
        public int GetMove(string symbol, string axis)
        {
            bool result = false;
            string input = string.Empty;
            while (result == false)
            {
                Console.WriteLine($"{symbol}, What is your moves {axis} coordinate:");
                input = Console.ReadLine();
                result = ValidateInputMove(input);
            }
            return int.Parse(input)-1;
        }

        private bool ValidateInputMove(string input)
        {
            if (input == "1" || input == "2" || input == "3")
            {
                return true;
            }
            return false;
        }

        public Board MakeMove(Board board, int coordY, int coordX, string symbol)
        {
            board.Rows[coordY][coordX] = symbol;
            return board;
        }

        public bool ValidateMove(Board board, int coordY, int coordX)
        {
            if (board.Rows[coordY][coordX] == "X" || board.Rows[coordY][coordX] == "O")
            {
                return false;
            }
            return true;
        }
    }
}