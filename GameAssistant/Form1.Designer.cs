namespace GameAssistant
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRoll = new System.Windows.Forms.Button();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.buttonRollOnTable = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label_CurrentRoom = new System.Windows.Forms.Label();
            this.label_RoomContentTitle = new System.Windows.Forms.Label();
            this.textBox_RoomContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFormat = new System.Windows.Forms.Button();
            this.pictureBox_Room = new System.Windows.Forms.PictureBox();
            this.label_RoomTopology = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Room)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRoll
            // 
            this.buttonRoll.Location = new System.Drawing.Point(379, 16);
            this.buttonRoll.Name = "buttonRoll";
            this.buttonRoll.Size = new System.Drawing.Size(101, 36);
            this.buttonRoll.TabIndex = 0;
            this.buttonRoll.Text = "Roll";
            this.buttonRoll.UseVisualStyleBackColor = true;
            this.buttonRoll.Click += new System.EventHandler(this.buttonRoll_Click);
            // 
            // textBox_Input
            // 
            this.textBox_Input.Location = new System.Drawing.Point(72, 20);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(284, 22);
            this.textBox_Input.TabIndex = 1;
            this.textBox_Input.Text = "D6";
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(34, 65);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_result.Size = new System.Drawing.Size(796, 956);
            this.textBox_result.TabIndex = 1;
            // 
            // buttonRollOnTable
            // 
            this.buttonRollOnTable.Location = new System.Drawing.Point(514, 16);
            this.buttonRollOnTable.Name = "buttonRollOnTable";
            this.buttonRollOnTable.Size = new System.Drawing.Size(101, 36);
            this.buttonRollOnTable.TabIndex = 0;
            this.buttonRollOnTable.Text = "Roll on table";
            this.buttonRollOnTable.UseVisualStyleBackColor = true;
            this.buttonRollOnTable.Click += new System.EventHandler(this.buttonRollOnTable_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(1691, 65);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(169, 36);
            this.buttonGenerate.TabIndex = 2;
            this.buttonGenerate.Text = "Gen Room";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(729, 16);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(101, 36);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label_CurrentRoom
            // 
            this.label_CurrentRoom.AutoSize = true;
            this.label_CurrentRoom.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CurrentRoom.Location = new System.Drawing.Point(893, 65);
            this.label_CurrentRoom.Name = "label_CurrentRoom";
            this.label_CurrentRoom.Size = new System.Drawing.Size(316, 53);
            this.label_CurrentRoom.TabIndex = 4;
            this.label_CurrentRoom.Text = "Current Room: ";
            // 
            // label_RoomContentTitle
            // 
            this.label_RoomContentTitle.AutoSize = true;
            this.label_RoomContentTitle.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RoomContentTitle.Location = new System.Drawing.Point(893, 358);
            this.label_RoomContentTitle.Name = "label_RoomContentTitle";
            this.label_RoomContentTitle.Size = new System.Drawing.Size(265, 53);
            this.label_RoomContentTitle.TabIndex = 4;
            this.label_RoomContentTitle.Text = "You found:  ";
            // 
            // textBox_RoomContent
            // 
            this.textBox_RoomContent.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_RoomContent.Font = new System.Drawing.Font("Matura MT Script Capitals", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_RoomContent.Location = new System.Drawing.Point(902, 414);
            this.textBox_RoomContent.Multiline = true;
            this.textBox_RoomContent.Name = "textBox_RoomContent";
            this.textBox_RoomContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_RoomContent.Size = new System.Drawing.Size(988, 607);
            this.textBox_RoomContent.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Roll";
            // 
            // buttonFormat
            // 
            this.buttonFormat.Enabled = false;
            this.buttonFormat.Location = new System.Drawing.Point(621, 16);
            this.buttonFormat.Name = "buttonFormat";
            this.buttonFormat.Size = new System.Drawing.Size(102, 36);
            this.buttonFormat.TabIndex = 7;
            this.buttonFormat.Text = "Format text";
            this.buttonFormat.UseVisualStyleBackColor = true;
            this.buttonFormat.Visible = false;
            this.buttonFormat.Click += new System.EventHandler(this.buttonFormat_Click);
            // 
            // pictureBox_Room
            // 
            this.pictureBox_Room.Location = new System.Drawing.Point(1309, 65);
            this.pictureBox_Room.Name = "pictureBox_Room";
            this.pictureBox_Room.Size = new System.Drawing.Size(300, 300);
            this.pictureBox_Room.TabIndex = 8;
            this.pictureBox_Room.TabStop = false;
            // 
            // label_RoomTopology
            // 
            this.label_RoomTopology.AutoSize = true;
            this.label_RoomTopology.Location = new System.Drawing.Point(1749, 128);
            this.label_RoomTopology.Name = "label_RoomTopology";
            this.label_RoomTopology.Size = new System.Drawing.Size(12, 17);
            this.label_RoomTopology.TabIndex = 9;
            this.label_RoomTopology.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label_RoomTopology);
            this.Controls.Add(this.pictureBox_Room);
            this.Controls.Add(this.buttonFormat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_RoomContent);
            this.Controls.Add(this.label_RoomContentTitle);
            this.Controls.Add(this.label_CurrentRoom);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.textBox_Input);
            this.Controls.Add(this.buttonRollOnTable);
            this.Controls.Add(this.buttonRoll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "FourAgainstDarkness GameAssistant";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Room)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRoll;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button buttonRollOnTable;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label_CurrentRoom;
        private System.Windows.Forms.Label label_RoomContentTitle;
        private System.Windows.Forms.TextBox textBox_RoomContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFormat;
        private System.Windows.Forms.PictureBox pictureBox_Room;
        private System.Windows.Forms.Label label_RoomTopology;
    }
}

