using System;
using System.Linq;

namespace SimpleChess
{
    public class Piece {
        private bool _captured { get; set; }
        private int _value { get; set; }

        public Piece(int value)
        {
            _captured = false;
            this._value = value;
        }
    }
}
