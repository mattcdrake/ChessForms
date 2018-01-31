using System;
using System.Collections.Generic;

namespace SimpleChess
{
    public enum Color {White, Black};

    public class Player
    {
        private Color color;
        private int score;

        public Player(Color color)
        {
            this.color = color;
            this.score = 0;
        }
    }
}
