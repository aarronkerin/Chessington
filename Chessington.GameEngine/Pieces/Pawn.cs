using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var currentPosition = board.FindPiece(this);
            var SquareList = new List<Square>();

            if (Player == Player.White)
            {
                SquareList.Add(new Square(currentPosition.Row - 1, currentPosition.Col));
                if (!HasMoved)
                {
                    SquareList.Add(new Square(currentPosition.Row - 2, currentPosition.Col));
                }
            }
            else
            {
                SquareList.Add(new Square(currentPosition.Row + 1, currentPosition.Col));
                if (!HasMoved)
                {
                    SquareList.Add(new Square(currentPosition.Row + 2, currentPosition.Col));
                }
            }

            return SquareList;
        }
    }
}