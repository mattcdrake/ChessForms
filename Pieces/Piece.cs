using System;

namespace SimpleChess
{
    public class Piece {
        private bool captured { get; set; }
        private int value { get; set; }

        public Piece(int value)
        {
            captured = false;
            this.value = value;
        }
    }
}
