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
            var SquareList = new List<Square>();

            var BlackSquare = new Square(2, 0);

            var WhiteSquare = new Square(6, 0);

            if (Player == Player.White)
            {
                SquareList.Add(WhiteSquare);
            }

            SquareList.Add(BlackSquare);


            return SquareList;
        }
    }
}