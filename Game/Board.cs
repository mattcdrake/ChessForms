using System;

namespace SimpleChess
{
    public class Board
    {
        private Square[,] Squares {get;}

        public Board()
        {
            Squares = new Square[8,8];
            InitBoard();
        }

        // Initializes the board with pieces
        private void InitBoard()
        {
            InitBackRank(0);
            InitFrontRank(1);
            for (int i = 2; i < 6; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Squares[i, j] = new Square();
                }
            }
            InitFrontRank(6);
            InitBackRank(7);
        }

        // Creates a row of all pawns in the local 2d square array
        private void InitFrontRank(int rank)
        {
            if (rank != 2 || rank != 6)
            {
                throw new BadRankException("Bad rank supplied");
            }

            for (int i = 0; i < 8; i++)
            {
                Squares[rank][i] = new Square(new Piece(Pawn));
            }
        }
    }


}

