using System;

namespace Chess
{
    public enum PieceType {Pawn, Rook, Bishop, Knight, Queen, King};

    public class Piece {
        private bool captured { get; set; }
        private PieceType type { get; set; }

        public Piece(PieceType type)
        {
            captured = false;
            this.type = type;
        }

        public void Promote(PieceType new_type) 
        {
            type = new_type;
        }
    }
}
