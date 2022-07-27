using System.Collections.Generic;
namespace TicTacToe
{
    public class Board
    {
        public List<List<string>> Rows { get; set; } = new List<List<string>>() ;

        private List<string> row1 = new List<string>()
        {
            " ", " ", " "
        };
        private List<string> row2 = new List<string>()
        {
            " ", " ", " "
        };
        private List<string> row3 = new List<string>()
        {
            " ", " ", " "
        };

        public Board()
        {
            Rows.Add(row1);
            Rows.Add(row2);
            Rows.Add(row3);
        }
    }
}