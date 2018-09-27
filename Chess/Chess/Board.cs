using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{

    class Board
    {
        private int[] board = new int[64];

        public Board()
        {
            //for (int i = 0; i < board.Length; i++)
            //{
            //    board[i] = 0;
            //}
            fillBoard();
        }


        public void fillBoard()
        {
            addRook();
            addKnights();
            addBishops();
            addRoyals();
            fillWithPawns();
        }

        public void addRook()
        {
            board[0] = (int)Piece.Rook;
            board[7] = (int)Piece.Rook;
            board[board.Length - 1] = (int)Piece.Rook;
            board[board.Length - 8] = (int)Piece.Rook;
        }

        public void addKnights()
        {
            board[1] = (int)Piece.Knight;
            board[6] = (int)Piece.Knight;
            board[board.Length - 2] = (int)Piece.Knight;
            board[board.Length - 7] = (int)Piece.Knight;
        }

        public void addBishops()
        {
            board[2] = (int)Piece.Bishop;
            board[5] = (int)Piece.Bishop;
            board[board.Length - 3] = (int)Piece.Bishop;
            board[board.Length - 6] = (int)Piece.Bishop;
        }

        public void addRoyals()
        {
            board[3] = (int)Piece.Queen;
            board[4] = (int)Piece.King;
            board[board.Length - 5] = (int)Piece.Queen;
            board[board.Length - 4] = (int)Piece.King;
        }

        public void fillWithPawns()
        {
            for (int i = 8; i < 16; i++)
            {
                board[i] = (int)Piece.Pawn;
                board[board.Length - i - 1] = (int)Piece.Pawn;
            }
        }

        public void setBoard(int index, int piece)
        {
            this.board[index] = piece;
        }



#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        public string ToString()
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
        {
            int counter = 0;
            string retval = "";
            for (int i = 0; i < board.Length; i++)
            {
                retval = retval + " " + board[i] + " ";

                counter = counter + 1;
                if (counter == 8)
                {
                    retval = retval + "\n";
                    counter = 0;
                }
            }
            return retval;
        }



    }

}




        