namespace TicTacToe
{
    public class BoardRepository
    {
        public void Render(Board board)
        {
            Console.WriteLine("---------");
            foreach (var row in board.Rows)
            {
                List<string> printList = new List<string>();

                foreach (var position in row)
                {
                    if (position == "X" || position == "O")
                    {
                        printList.Add(position);
                    }
                    else
                    {
                        printList.Add(" ");
                    }
                }
                Console.WriteLine($"{printList[0]} | {printList[1]} | {printList[2]}");
                Console.WriteLine("---------");
            }
        }

        public bool GetWinner(Board board, string symbol)
        {
            foreach (var row in board.Rows)
            {
                if (row[0] == symbol && row[1] == symbol && row[2] == symbol)
                {
                    return true;
                }
            }

            var i = 0;
            while (i < 3)
            {
                if (board.Rows[0][i] == symbol && board.Rows[1][i] == symbol && board.Rows[2][i] == symbol)
                {
                    return true;
                }
                else
                {
                    i += 1;
                }
            }

            if (board.Rows[0][0] == symbol && board.Rows[1][1] == symbol && board.Rows[2][2] == symbol)
            {
                return true;
            }
            if (board.Rows[0][2] == symbol && board.Rows[1][1] == symbol && board.Rows[2][0] == symbol)
            {
                return true;
            }
            return false;
        }

        public bool AnyMoveLeft(Board board)
        {
            foreach (var row in board.Rows)
            {
                foreach (var item in row)
                {
                    if (item == " ")
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}