using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    static class Rules
    {

        /*  takes the board, piece and move as input and 
         * 
         */
        public static bool Move(Board board, int pieceIndex, int moveIndex)
        {
            bool isLegit = false;

            return isLegit;
        }

        private static bool MovePawn(Board board, int pieceIndex, int moveIndex, bool isLegit)
        {
            if (moveIndex == pieceIndex - 8 && moveIndex == (int)Piece.Empty)
            {
                board.setBoard(pieceIndex, (int)Piece.Empty);
                board.setBoard(moveIndex, (int)Piece.Pawn);
                isLegit = true;
            }
            else if (moveIndex == pieceIndex - 9 && moveIndex - 1 != (int)Piece.Empty)
            {
                board.setBoard(pieceIndex, (int)Piece.Empty);
                board.setBoard(moveIndex - 1, (int)Piece.Pawn);
                isLegit = true;
            }
            else if (moveIndex == pieceIndex - 7 && moveIndex + 1 != (int)Piece.Empty)
            {
                board.setBoard(pieceIndex, (int)Piece.Empty);
                board.setBoard(moveIndex + 1, (int)Piece.Pawn);
                isLegit = true;
            }
            else return false;

            return isLegit;
        }


        private static void MoveBishop(Board board, int pieceIndex, int moveIndex)
        {
          
        }

        private static void MoveKnight(Board board, int pieceIndex, int moveIndex)
        {

        }

        private static void MoveRook(Board board, int pieceIndex, int moveIndex)
        {

        }

        private static void MoveQueen(Board board, int pieceIndex, int moveIndex)
        {

        }

        private static void MoveKing(Board board, int pieceIndex, int moveIndex)
        {

        }


    }

        
}
