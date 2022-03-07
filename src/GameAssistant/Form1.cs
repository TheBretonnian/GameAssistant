using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GameAssistant
{
    public partial class Form1 : Form
    {
        DungeonGenerator DG = new DungeonGenerator();
        string label_CurrentRoomOriginal;

        Dice dice = new Dice();

    

        public Form1()
        {
            InitializeComponent();
            label_CurrentRoomOriginal = label_CurrentRoom.Text;
            Validator(100); //Run ALWAYS fast validation, it may not find all problems but it also wont take too much time
            buttonFormat.Enabled = buttonFormat.Visible = true;
        }

        private void buttonRoll_Click(object sender, EventArgs e)
        {
            
            string RollSerie;
            int TotalRoll = dice.RollDice(textBox_Input.Text, out RollSerie);
            textBox_result.AppendText("Rolling " + textBox_Input.Text + ": ");
            if (TotalRoll > 0)
            {
                textBox_result.AppendText(RollSerie.Substring(0, RollSerie.Length - 2) + ": " + TotalRoll.ToString());
            }
            else
            {
                textBox_result.AppendText(TotalRoll.ToString());
            }
            textBox_result.AppendText(Environment.NewLine);

        }

        private void buttonRollOnTable_Click(object sender, EventArgs e)
        {
            //string NewString;
            //int TotalRoll = dice.RollDiceAndReplace(textBox_Input.Text, out NewString);
            //textBox_result.Text = NewString;

            string Script = "";
            string NewScript = textBox_Input.Text;

            while (NewScript != Script)
            {
                Script = NewScript;
                textBox_result.AppendText(Script);
                textBox_result.AppendText(Environment.NewLine);
                NewScript = DG.InterpretScript(Script);
            }
            textBox_result.AppendText(Environment.NewLine);
            textBox_result.AppendText(Environment.NewLine);
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            DG.GenerateRoom();
            textBox_result.Text = DG.dungeonLog.Log;
            textBox_RoomContent.Text = DG.CurrentRoomContent;
            label_CurrentRoom.Text = label_CurrentRoomOriginal + " " + DG.CurrentRoom.ToString();
            label_RoomTopology.Text = "Room";
            if (DG.IsCorridor) { label_RoomTopology.Text = "Corridor"; }
            try
            {
                pictureBox_Room.Image = Image.FromFile(String.Format("Rooms/{0}.png", DG.CurrentRoom));
                pictureBox_Room.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch { }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            DG.dungeonLog.Clear();
            textBox_result.Clear();
        }

        private void buttonFormat_Click(object sender, EventArgs e)
        {
            List<string> newLines = new List<string>();

            foreach (string line in textBox_result.Lines)
            {
                string[] words = line.Split(' ');
                newLines.Add("{ " + words[0]+ ", \"" + line.Replace(words[0],"") + " \"},");
            }

            textBox_result.Clear();

            foreach(string line in newLines)
            {
                textBox_result.AppendText(line);
                textBox_result.AppendText(Environment.NewLine);
            }
           
        }

        public void Validator(int TestRuns)
        {
            string TestLog = "TESTING LOG: \r\n\r\n";
            int Errors = 0;

            for (int i = 1; i < TestRuns; i++)
            {
                DG.GenerateRoom();

                if(File.Exists(String.Format("Rooms/{0}.png", DG.CurrentRoom))==false)
                {
                    Errors++;
                    TestLog += String.Format("Image for Room {0} not found.",DG.CurrentRoom);
                    TestLog +=Environment.NewLine;
                }
                
                if(DG.CurrentRoomContent.Contains("Error with"))
                {
                    Errors++;
                    TestLog += DG.CurrentRoomContent;
                    TestLog += Environment.NewLine;
                }
                textBox_result.Text = String.Format("Validation. Errors: {0}/{1} \r\n\r\n", Errors, TestRuns);
                if (Errors > 0)
                {
                    textBox_result.Text += TestLog;
                }
            }

            //Reset Dungeon
            DG = new DungeonGenerator();
        }

    }
}
