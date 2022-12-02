using System;

namespace Day2RockPaperScissors
{
    public class Game
    {
        int elfPlay;
        int playerPlay;

        public Game(char elfPlay, char playerPlay)
        {
            this.elfPlay = CharToPlay(elfPlay);
            this.playerPlay = CharToPlay(playerPlay);
        }

        static int CharToPlay(char play)
        {
            switch(play)
            {
                case 'A':
                case 'X':
                    return 1;
                case 'B':
                case 'Y':
                    return 2;
                case 'C':
                case 'Z':
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
