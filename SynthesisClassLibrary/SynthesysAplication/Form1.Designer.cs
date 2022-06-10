namespace SynthesysAplication
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxTournaments = new System.Windows.Forms.ListBox();
            this.tbxInformation = new System.Windows.Forms.TextBox();
            this.cbxSport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbxSort = new System.Windows.Forms.TextBox();
            this.btnGenerateSchedule = new System.Windows.Forms.Button();
            this.lbxSchedule = new System.Windows.Forms.ListBox();
            this.lbxTournamentMatches = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddScore = new System.Windows.Forms.Button();
            this.nudScore1 = new System.Windows.Forms.NumericUpDown();
            this.nudScore2 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1413, 790);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.tbxName);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnCreate);
            this.tabPage1.Controls.Add(this.tbxAddress);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.nudMax);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.nudMin);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dtpStartTime);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lbxTournaments);
            this.tabPage1.Controls.Add(this.tbxInformation);
            this.tabPage1.Controls.Add(this.cbxSport);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1405, 764);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tournament Management";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Name:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(22, 53);
            this.tbxName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(265, 20);
            this.tbxName.TabIndex = 16;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(166, 531);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 45);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "DeleteTournament";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(22, 531);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(106, 45);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "Create Tournament";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(22, 461);
            this.tbxAddress.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(265, 52);
            this.tbxAddress.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 446);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Address:";
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(22, 415);
            this.nudMax.Margin = new System.Windows.Forms.Padding(2);
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(90, 20);
            this.nudMax.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 399);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Maximum players:";
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(22, 373);
            this.nudMin.Margin = new System.Windows.Forms.Padding(2);
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(90, 20);
            this.nudMin.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 356);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Minimum players:";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Location = new System.Drawing.Point(22, 323);
            this.dtpStartTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(265, 20);
            this.dtpStartTime.TabIndex = 6;
            this.dtpStartTime.Value = new System.DateTime(2022, 5, 30, 20, 35, 41, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 307);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Start time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Information:";
            // 
            // lbxTournaments
            // 
            this.lbxTournaments.FormattingEnabled = true;
            this.lbxTournaments.Location = new System.Drawing.Point(761, 0);
            this.lbxTournaments.Margin = new System.Windows.Forms.Padding(2);
            this.lbxTournaments.Name = "lbxTournaments";
            this.lbxTournaments.Size = new System.Drawing.Size(642, 758);
            this.lbxTournaments.TabIndex = 3;
            // 
            // tbxInformation
            // 
            this.tbxInformation.Location = new System.Drawing.Point(22, 139);
            this.tbxInformation.Margin = new System.Windows.Forms.Padding(2);
            this.tbxInformation.Multiline = true;
            this.tbxInformation.Name = "tbxInformation";
            this.tbxInformation.Size = new System.Drawing.Size(265, 155);
            this.tbxInformation.TabIndex = 2;
            // 
            // cbxSport
            // 
            this.cbxSport.FormattingEnabled = true;
            this.cbxSport.Items.AddRange(new object[] {
            "Badminton",
            "Karate"});
            this.cbxSport.Location = new System.Drawing.Point(22, 91);
            this.cbxSport.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSport.Name = "cbxSport";
            this.cbxSport.Size = new System.Drawing.Size(146, 21);
            this.cbxSport.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sport:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.nudScore2);
            this.tabPage2.Controls.Add(this.nudScore1);
            this.tabPage2.Controls.Add(this.btnAddScore);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.lbxTournamentMatches);
            this.tabPage2.Controls.Add(this.tbxSort);
            this.tabPage2.Controls.Add(this.btnGenerateSchedule);
            this.tabPage2.Controls.Add(this.lbxSchedule);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1405, 764);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Match Management";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbxSort
            // 
            this.tbxSort.Location = new System.Drawing.Point(50, 168);
            this.tbxSort.Name = "tbxSort";
            this.tbxSort.Size = new System.Drawing.Size(125, 20);
            this.tbxSort.TabIndex = 17;
            this.tbxSort.TextChanged += new System.EventHandler(this.tbxSort_TextChanged);
            // 
            // btnGenerateSchedule
            // 
            this.btnGenerateSchedule.Location = new System.Drawing.Point(50, 71);
            this.btnGenerateSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateSchedule.Name = "btnGenerateSchedule";
            this.btnGenerateSchedule.Size = new System.Drawing.Size(125, 60);
            this.btnGenerateSchedule.TabIndex = 16;
            this.btnGenerateSchedule.Text = "Generate Schedule";
            this.btnGenerateSchedule.UseVisualStyleBackColor = true;
            this.btnGenerateSchedule.Click += new System.EventHandler(this.btnGenerateSchedule_Click);
            // 
            // lbxSchedule
            // 
            this.lbxSchedule.FormattingEnabled = true;
            this.lbxSchedule.Location = new System.Drawing.Point(842, 16);
            this.lbxSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.lbxSchedule.Name = "lbxSchedule";
            this.lbxSchedule.Size = new System.Drawing.Size(561, 745);
            this.lbxSchedule.TabIndex = 0;
            // 
            // lbxTournamentMatches
            // 
            this.lbxTournamentMatches.FormattingEnabled = true;
            this.lbxTournamentMatches.Location = new System.Drawing.Point(277, 15);
            this.lbxTournamentMatches.Margin = new System.Windows.Forms.Padding(2);
            this.lbxTournamentMatches.Name = "lbxTournamentMatches";
            this.lbxTournamentMatches.Size = new System.Drawing.Size(561, 745);
            this.lbxTournamentMatches.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Search by name:";
            // 
            // btnAddScore
            // 
            this.btnAddScore.Location = new System.Drawing.Point(45, 407);
            this.btnAddScore.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddScore.Name = "btnAddScore";
            this.btnAddScore.Size = new System.Drawing.Size(125, 60);
            this.btnAddScore.TabIndex = 21;
            this.btnAddScore.Text = "Add Score";
            this.btnAddScore.UseVisualStyleBackColor = true;
            this.btnAddScore.Click += new System.EventHandler(this.btnAddScore_Click);
            // 
            // nudScore1
            // 
            this.nudScore1.Location = new System.Drawing.Point(50, 331);
            this.nudScore1.Name = "nudScore1";
            this.nudScore1.Size = new System.Drawing.Size(120, 20);
            this.nudScore1.TabIndex = 22;
            // 
            // nudScore2
            // 
            this.nudScore2.Location = new System.Drawing.Point(50, 373);
            this.nudScore2.Name = "nudScore2";
            this.nudScore2.Size = new System.Drawing.Size(120, 20);
            this.nudScore2.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Score 1:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Score 2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 799);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lbxTournaments;
        private System.Windows.Forms.TextBox tbxInformation;
        private System.Windows.Forms.ComboBox cbxSport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxSchedule;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnGenerateSchedule;
        private System.Windows.Forms.TextBox tbxSort;
        private System.Windows.Forms.ListBox lbxTournamentMatches;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudScore2;
        private System.Windows.Forms.NumericUpDown nudScore1;
        private System.Windows.Forms.Button btnAddScore;
    }
}

