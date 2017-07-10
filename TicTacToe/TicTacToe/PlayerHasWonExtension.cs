using TicTacToe.Models;

namespace TicTacToe
{
    public static class PlayerHasWonExtension
    {
        public static bool HasWon(this Player player, Board board)
        {
            if (CheckRowConditions(player, board))
            {
                return true;
            }

            if (CheckColumnConditions(player, board))
            {
                return true;
            }

            if (CheckDiagonalConditions(player, board))
            {
                return true;
            }

            return false;
        }
        private static bool CheckRowConditions(Player player, Board board)
        {
            for (int x = 0; x <= 6; x+=3)
            {
                if (AllSpacesOwnedByPlayer(player, board.Spaces[x], board.Spaces[x+1], board.Spaces[x+2]))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool CheckColumnConditions(Player player, Board board)
        {
            for (int x = 0; x < 3; x++)
            {
                if (AllSpacesOwnedByPlayer(player, board.Spaces[x], board.Spaces[x+3], board.Spaces[x+6]))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool CheckDiagonalConditions(Player player, Board board)
        {
            if (AllSpacesOwnedByPlayer(player, board.Spaces[0], board.Spaces[4], board.Spaces[8]))
            {
                return true;
            }

            if (AllSpacesOwnedByPlayer(player, board.Spaces[2], board.Spaces[4],board.Spaces[6]))
            {
                return true;
            }

            return false;
        }

        private static bool AllSpacesOwnedByPlayer(Player player, Space A, Space B, Space C)
        {
            return (A.OccupiedBy == player.Occupation && B.OccupiedBy == player.Occupation && C.OccupiedBy == player.Occupation);
        }
    }
}
