using System;

namespace Day2RockPaperScissors
{
    public class Game
    {
        int elfPlay;
        int playerPlay;

        public Game(char elfPlay, char playerPlay)
        {
            this.elfPlay = GetElfPlay(elfPlay);
            this.playerPlay = CalcPlayerPlay(playerPlay);
            CheckPlayerPlayOverflow();
        }

        int CalcPlayerPlay(char play)
        {
            switch(play)
            {
                case 'X':
                    return elfPlay - 1;
                case 'Y':
                    return elfPlay;
                case  'Z':
                    return elfPlay + 1;
                default:
                    throw new Exception("Can't convert input");
            }
        }

        void CheckPlayerPlayOverflow()
        {
            if (playerPlay < 1)
            {
                playerPlay = 3;
            }
            else if (playerPlay > 3)
            {
                playerPlay = 1;
            }
        }

        static int GetElfPlay(char play)
        {
            switch(play)
            {
                case 'A':
                    return 1;
                case 'B':
                    return 2;
                case 'C':
                    return 3;
                default:
                    throw new Exception("Can't convert input");
            }
        }

        public int GetGameResult()
        {
            if (elfPlay == playerPlay)
            {
                return playerPlay + 3; // draw
            }
            if (elfPlay == 1 && playerPlay == 3)
            {
                return playerPlay; //elf wins with rock
            }
            if (elfPlay == 3 && playerPlay == 1)
            {
                return playerPlay + 6; //player wins with rock
            }
            if (elfPlay > playerPlay)
            {
                return playerPlay; // elf wins with paper/scissors
            }
            return playerPlay + 6; // player wins with paper/scissors
        }
    }
}
