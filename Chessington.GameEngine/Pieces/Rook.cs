using System;
using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Rook : Piece
    {
        public Rook(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            List<Square> availablePoistions = new List<Square>();

            Square currentposition = board.FindPiece(this);

            for (int i = 0; i < 8; i++)
            {
                availablePoistions.Add(new Square(currentposition.Row, i));

                availablePoistions.Add(new Square(i,currentposition.Col));


            }


            availablePoistions.RemoveAll(a => a == currentposition);

            return availablePoistions;




            
        }
    }
}