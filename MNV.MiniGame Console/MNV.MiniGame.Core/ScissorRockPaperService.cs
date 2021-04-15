using System;
using System.Collections.Generic;
using System.Text;

namespace MNV.MiniGame.Core
{
    public class ScissorRockPaperService : IScissorRockPaperService
    {
        public string ChoiceConvert(string val)
        {
            string result = string.Empty;

            switch (val)
            {
                case "q":
                    result = "ROCK";
                    break;
                case "w":
                    result = "PAPER";
                    break;

                case "e":
                    result = "SCISSORS";
                    break;
            }

            return result;
        }

        /// <summary>
        /// q - Rock
        /// w - Paper
        /// e - Scissors
        /// </summary>
        /// <param name="user"></param>
        /// <param name="computer"></param>
        /// <returns>If 0=tie, 1=user won,2=computer won</returns>
        public int Play(string user, string computer)
        {
            user = user.ToLower();
            computer = computer.ToLower();

            int result = 0;

            switch (user)
            {
                case "q":
                    switch (computer)
                    {
                        case "q":
                            result = 0;
                            break;
                        case "w":
                            result = 2;
                            break;

                        case "e":
                            result = 1;
                            break;
                    }
                    break;

                case "w":

                    switch (computer)
                    {
                        case "q":
                            result = 1;
                            break;
                        case "w":
                            result = 0;
                            break;

                        case "e":
                            result = 2;
                            break;
                    }

                    break;

                case "e":

                    switch (computer)
                    {
                        case "q":
                            result = 2;
                            break;
                        case "w":
                            result = 1;
                            break;

                        case "e":
                            result = 0;
                            break;
                    }

                    break;
            }

            return result;
        }

        public string ResultMessage(int val)
        {
            string result = string.Empty;

            switch (val)
            {
                case 0: result = "TIE"; break;
                case 1: result = "YOU WON"; break;
                case 2: result = "COMPUTER WON"; break;
            }

            return result;
        }
    }
}
