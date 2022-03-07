using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GameAssistant
{
    public class Die
    {
        public int value;
        public int min = 1;
        public int max = 6;

        public Die(int max, int min = 1)
        {
            this.max = max;
            this.min = min;
        }

        public int Roll()
        {
            Random rnd = new Random();
            value = rnd.Next(min, max + 1);
            return value;
        }

    }

    public class Dice
    {
        string DiceRegexPattern = "[1-9]?[d,D][0-9]{1,3}";

        Random rnd = new Random();

        public int RollDice(string DiceString, out string ValuesSerie)
        {
            int TotalRoll = -1;
            int DiceSize = 6;
            ValuesSerie = "";

            DiceString = DiceString.Trim();
            //Parse DiceString
            int NumberOfDice = 1;
            //Assuming {\d}D{\d} e.g. 3D6
            Match _match = Regex.Match(DiceString, DiceRegexPattern);
            if (_match.Success)
            {
                TotalRoll = 0;
                string[] words = Regex.Split(_match.Value,"[d,D]");
                
                if (words.Length >= 2)
                {
                    if(words[0] != "")
                    {
                        int.TryParse(words[0], out NumberOfDice);
                    }

                    if(int.TryParse(words[1], out DiceSize))
                    {
                        //Random rnd = new Random();
                         
                        for (int i=0; i < NumberOfDice; i++)
                        {
                            if(DiceSize == 66) //Special case
                            {
                                int value1 = rnd.Next(1, 6 + 1);
                                int value2 = rnd.Next(1, 6 + 1);
                                TotalRoll += value1*10+value2;
                                ValuesSerie += String.Format("[{0},{1}], ", value1,value2);
                            }
                            else
                            {
                                int value = rnd.Next(1, DiceSize + 1);
                                TotalRoll += value;
                                ValuesSerie += String.Format("{0}, ", value);
                            }

                        }
                    }
                    else
                    {
                        //Failure by DiceString: not following convention
                        return -1;
                    }
                    
                }
            }


            return TotalRoll;
        }

        public int RollDice(string DiceString)
        {
            string valuesSeriesToBeIgnored;
            return RollDice(DiceString, out valuesSeriesToBeIgnored);
        }

        public int RollDiceAndReplace(string StringWithRoll, out string NewString, out string ValueSeries)
        {
            int TotalRoll = 0;

            NewString = "";

            TotalRoll = RollDice(StringWithRoll, out ValueSeries);
            
            if(TotalRoll != -1)
            {
                string DiceString = Regex.Match(StringWithRoll, DiceRegexPattern).Value;
                NewString = StringWithRoll.Replace(DiceString, TotalRoll.ToString());
            }

            return TotalRoll;
        }

        public int RollDiceAndReplace(string StringWithRoll, out string NewString)
        {
            string valuesSeriesToBeIgnored;
            return RollDiceAndReplace(StringWithRoll, out NewString, out valuesSeriesToBeIgnored);
        }


    }
}
