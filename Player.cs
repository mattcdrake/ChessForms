using System;
using System.Collections.Generic;

namespace Chess
{
    public enum Color {White, Black};

    public class Player
    {
        private List<Piece> pieces;
        private Color color;
        private int score;

        public Player(Color color)
        {
            this.color = color;
            this.score = 0;
        }

        public void InitBoard() 
        {
            for (int i = 0; i < 8; i++)
            {
                pieces.Add(new Piece(PieceType.Pawn));
            }
        }
    }
}
