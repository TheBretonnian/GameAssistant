using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GameAssistant
{
    class DungeonGenerator
    {
        

        private Boolean Debugging = false;
        private Dice dice = new Dice();

        public DungeonLog dungeonLog = new DungeonLog("");
        public int CurrentRoom = 0;
        public string CurrentRoomContent = ""; //Final room content after parsing 

        public Boolean IsCorridor = false; 
        public Boolean CanSearch = false; //Using an array/ table with RoomContentRoll
        public Boolean HasTreasure = false; //Using an array/ table with RoomContentRoll
        public Boolean CanLevelUp = false;

        public void GenerateRoom ()
        {
           
            Dice dice = new Dice();
            //Roll D66 for Room
            CurrentRoom = dice.RollDice("D66");
            dungeonLog.AppendLine("Next Room is Room " + CurrentRoom.ToString());
                        
            //Check Room Type properties
            IsCorridor = false;
            try
            {
                if (Dungeon.Tables["DungeonTopology"][CurrentRoom].ToLower().Contains("corridor"))
                {
                    IsCorridor = true;
                }
            }
            catch { }
            

            //Roll 2D6 for Room Content
            string NewScript = "Roll 2D6 on table.RoomContent";
            string Script = "";
            int loop = 0;

            //Alternatively get script from corridor table
            if (IsCorridor)
            {
                NewScript = "Roll 2D6 on table.CorridorContent";
            }

            //Script Interpreter algorithm
            while(NewScript!=Script && loop<10)
            {
                loop++;
                if (Debugging) { dungeonLog.AppendLine("<<DEBUG>>Loop " + loop); }
                Script = NewScript;
                dungeonLog.AppendLine(Script);
                NewScript = InterpretScript(Script);
            }
            //Update current RoomContent
            CurrentRoomContent = NewScript;
            
            //Check Room Content properties
            CanSearch = false; //Using an array/ table with RoomContentRoll
            HasTreasure = false; //Using an array/ table with RoomContentRoll
            CanLevelUp = false;

            //If Can Search: Show Search Button
            //If Can Search: Show Treasure Button
            //Allow user rolls every time based on description

            dungeonLog.AppendLine("");
            dungeonLog.AppendLine("");

            return;
        }

        /// <summary>
        /// Interpret a given script ("Roll [dice_expression] on table.[TableKey]"). If there is no recognisable [dice_expression] then Output = Input(Script). If there is a roll but no recognisable tablekey, return Script but replaces [dice_expression] for TotalRoll value on given Script. 
        /// </summary>
        /// <param name="Script">Example: "D6 on table.X"</param>
        /// <returns>Table content after rolling. For example "4 Trolls"</returns>
        public string InterpretScript(string Script)
        {
            string Output = "";
            //1. Roll
            //Dice dice = new Dice();
            string RollSerie;
            int Roll = dice.RollDice(Script, out RollSerie);

            if(Roll == -1) //No Roll recognised in Script
            {
                if (Debugging) { dungeonLog.AppendLine("<<DEBUG>>:No Roll recognised in Script"); }

                return Output = Script; //Return here to break from sub-routine.
            }
            //2. Get table key from script
            Match _match = Regex.Match(Script,@"table.(\S*)");   //[0]; //Get first group that matches (\S*);
            if(_match.Success)
            {
                string TableKey = _match.Groups[1].Value;//_match.Value;
                TableKey = TableKey.Replace(".", ""); //Remove points, sometimes when Table name is at the end of sentence 
                dungeonLog.AppendLine("Rolling on table " + TableKey + ": " + RollSerie.Substring(0, RollSerie.Length - 2));
                //Table key recognised. Try to get value from dictionary (TryCatch -> lazy structure to spare checking for existence of keys) 
                try
                {
                    Output = Dungeon.Tables[TableKey][Roll]; //Tables is a dictionary of dictionary
                }
                catch
                {
                    Output = String.Format("Error with {0} - Table key: {1} not found", Script, TableKey);
                }

            }
            else //No Table Key -> Just replace dice expression for Roll value inside Script and returns new Script
            {
                if (Debugging) { dungeonLog.AppendLine("<<DEBUG>>:Replacing roll on script"); }
                Roll = dice.RollDiceAndReplace(Script, out Output, out RollSerie); //It rolls again but does not matter, we know Roll is possible with this Script
                dungeonLog.AppendLine("Rolling: " + RollSerie.Substring(0, RollSerie.Length - 2));
            }

            return Output;
        }

        public class DungeonLog
        {
            public string Log = "";

            public DungeonLog(string InitialLog)
            {
                this.Log = InitialLog;
            }
            public void Clear()
            {
                Log = "";
            }
            public void Append(string Text)
            {
                Log += Text;
            }
            public void AppendLine(string NewLine)
            {
                Append(NewLine);
                Log += Environment.NewLine;
            }
        }
    }
}
