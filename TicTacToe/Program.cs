// See https://aka.ms/new-console-template for more information
using TicTacToe;

Console.WriteLine("Hello, World!");

BoardRepository boardRepository = new BoardRepository();
MoveRepository moveRepository = new MoveRepository();

var board = new Board();
boardRepository.Render(board);

bool gameResult = false;
while (gameResult == false)
{
    bool validMoveResult = false;
    int moveXY = 0;
    int moveXX = 0;

    while (validMoveResult == false)
    {
        moveXY = moveRepository.GetMove("X", "Y");
        moveXX = moveRepository.GetMove("X", "X");
        validMoveResult = moveRepository.ValidateMove(board, moveXY, moveXX);
        if (validMoveResult == false)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Invalid move, try again");
            Console.WriteLine(" ");
        } 
    }
    board = moveRepository.MakeMove(board, moveXY, moveXX, "X");
    boardRepository.Render(board);
    gameResult = boardRepository.GetWinner(board, "X");
    if (gameResult)
    {
        Console.WriteLine("X Has Won");
        return;
    }

    gameResult = boardRepository.AnyMoveLeft(board);
    if (gameResult)
    {
        Console.WriteLine("Draw");
        return;
    }

    validMoveResult = false;
    int moveOY = 0;
    int moveOX = 0;
    while (validMoveResult == false)
    {
        moveOY = moveRepository.GetMove("O", "Y");
        moveOX = moveRepository.GetMove("O", "X");
        validMoveResult = moveRepository.ValidateMove(board, moveOY, moveOX);
        if (validMoveResult == false)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Invalid move, try again");
            Console.WriteLine(" ");
        }
    }
    board = moveRepository.MakeMove(board, moveOY, moveOX, "O");
    gameResult = boardRepository.GetWinner(board, "O");

    boardRepository.Render(board);
    if (gameResult)
    {
        Console.WriteLine("O Has Won");
        return;
    }

    gameResult = boardRepository.AnyMoveLeft(board);
    if (gameResult)
    {
        Console.WriteLine("Draw");
        return;
    }
}