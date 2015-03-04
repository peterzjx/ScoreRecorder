namespace ScoreRecorder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lstName = new System.Windows.Forms.ListBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.cmbName1 = new System.Windows.Forms.TextBox();
            this.cmbName2 = new System.Windows.Forms.TextBox();
            this.cmbName3 = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnAssignment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearGroup = new System.Windows.Forms.Button();
            this.btnGetName = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textCheckLeave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(977, 600);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(57, 21);
            this.txtScore.TabIndex = 3;
            this.txtScore.Enter += new System.EventHandler(this.txtScore_Enter);
            this.txtScore.Leave += new System.EventHandler(this.txtScore_Leave);
            // 
            // lstName
            // 
            this.lstName.FormattingEnabled = true;
            this.lstName.ItemHeight = 12;
            this.lstName.Location = new System.Drawing.Point(706, 41);
            this.lstName.Name = "lstName";
            this.lstName.Size = new System.Drawing.Size(328, 544);
            this.lstName.TabIndex = 4;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(132, 9);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(54, 25);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // cmbGroup
            // 
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70"});
            this.cmbGroup.Location = new System.Drawing.Point(706, 13);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(60, 20);
            this.cmbGroup.TabIndex = 10;
            this.cmbGroup.Text = "1";
            this.cmbGroup.SelectedIndexChanged += new System.EventHandler(this.cmbGroup_SelectedIndexChanged);
            // 
            // cmbName1
            // 
            this.cmbName1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbName1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbName1.Location = new System.Drawing.Point(132, 600);
            this.cmbName1.Name = "cmbName1";
            this.cmbName1.Size = new System.Drawing.Size(275, 21);
            this.cmbName1.TabIndex = 0;
            this.cmbName1.Enter += new System.EventHandler(this.cmbName1_Enter);
            this.cmbName1.Leave += new System.EventHandler(this.cmbName1_Leave);
            // 
            // cmbName2
            // 
            this.cmbName2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbName2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbName2.Location = new System.Drawing.Point(415, 600);
            this.cmbName2.Name = "cmbName2";
            this.cmbName2.Size = new System.Drawing.Size(275, 21);
            this.cmbName2.TabIndex = 1;
            this.cmbName2.Enter += new System.EventHandler(this.cmbName2_Enter);
            this.cmbName2.Leave += new System.EventHandler(this.cmbName2_Leave);
            // 
            // cmbName3
            // 
            this.cmbName3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbName3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbName3.Location = new System.Drawing.Point(696, 600);
            this.cmbName3.Name = "cmbName3";
            this.cmbName3.Size = new System.Drawing.Size(275, 21);
            this.cmbName3.TabIndex = 2;
            this.cmbName3.Enter += new System.EventHandler(this.cmbName3_Enter);
            this.cmbName3.Leave += new System.EventHandler(this.cmbName3_Leave);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(132, 43);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(568, 542);
            this.webBrowser1.TabIndex = 12;
            this.webBrowser1.Url = new System.Uri("https://webaccess.psu.edu/?cosign-cms.psu.edu&https://cms.psu.edu/cosign/default." +
                    "asp", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(971, 10);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(63, 25);
            this.btnPush.TabIndex = 13;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnAssignment
            // 
            this.btnAssignment.Location = new System.Drawing.Point(192, 9);
            this.btnAssignment.Name = "btnAssignment";
            this.btnAssignment.Size = new System.Drawing.Size(77, 25);
            this.btnAssignment.TabIndex = 15;
            this.btnAssignment.Text = "Assignment";
            this.btnAssignment.UseVisualStyleBackColor = true;
            this.btnAssignment.Click += new System.EventHandler(this.btnAssignment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 609);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "Navigate through Tab";
            // 
            // btnClearGroup
            // 
            this.btnClearGroup.Location = new System.Drawing.Point(879, 10);
            this.btnClearGroup.Name = "btnClearGroup";
            this.btnClearGroup.Size = new System.Drawing.Size(51, 25);
            this.btnClearGroup.TabIndex = 18;
            this.btnClearGroup.Text = "Clear";
            this.btnClearGroup.UseVisualStyleBackColor = true;
            this.btnClearGroup.Click += new System.EventHandler(this.btnClearGroup_Click);
            // 
            // btnGetName
            // 
            this.btnGetName.Location = new System.Drawing.Point(772, 10);
            this.btnGetName.Name = "btnGetName";
            this.btnGetName.Size = new System.Drawing.Size(101, 25);
            this.btnGetName.TabIndex = 19;
            this.btnGetName.Text = "Download Name";
            this.btnGetName.UseVisualStyleBackColor = true;
            this.btnGetName.Click += new System.EventHandler(this.btnGetName_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 569);
            this.label2.TabIndex = 20;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // textCheckLeave
            // 
            this.textCheckLeave.Location = new System.Drawing.Point(1040, 601);
            this.textCheckLeave.Name = "textCheckLeave";
            this.textCheckLeave.Size = new System.Drawing.Size(1, 21);
            this.textCheckLeave.TabIndex = 21;
            this.textCheckLeave.Enter += new System.EventHandler(this.textCheckLeave_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 634);
            this.Controls.Add(this.textCheckLeave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGetName);
            this.Controls.Add(this.btnClearGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAssignment);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.cmbName3);
            this.Controls.Add(this.cmbName2);
            this.Controls.Add(this.cmbName1);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lstName);
            this.Controls.Add(this.txtScore);
            this.Name = "Form1";
            this.Text = "Score Recorder by Peterzjx Version 1.4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.ListBox lstName;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.TextBox cmbName1;
        private System.Windows.Forms.TextBox cmbName2;
        private System.Windows.Forms.TextBox cmbName3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnAssignment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearGroup;
        private System.Windows.Forms.Button btnGetName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCheckLeave;
    }
}

