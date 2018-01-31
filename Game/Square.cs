using System;

namespace SimpleChess
{
    public class Square
    {
        private Piece pieceOnSquare { get; set; }
        private bool occupied { get; set; }

        public Square()
        {
            pieceOnSquare = null;
            occupied = false;
        }

        public Square(Piece piece)
        {
            pieceOnSquare = piece;
            occupied = true;
        }
    }
}

