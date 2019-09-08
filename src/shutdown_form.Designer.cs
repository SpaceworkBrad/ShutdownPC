namespace ShutdownPC
{
    partial class shutdown_form
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shutdown_form));
            this.shutdownpc_label = new System.Windows.Forms.Label();
            this.closeapp = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.heuresBox = new System.Windows.Forms.ComboBox();
            this.minutesBox = new System.Windows.Forms.ComboBox();
            this.secondesBox = new System.Windows.Forms.ComboBox();
            this.startShutdown = new System.Windows.Forms.Button();
            this.rpcText = new System.Windows.Forms.Label();
            this.shutdownTime = new System.Windows.Forms.Label();
            this.heuresText = new System.Windows.Forms.Label();
            this.minutesText = new System.Windows.Forms.Label();
            this.secondesText = new System.Windows.Forms.Label();
            this.curTime = new System.Windows.Forms.Label();
            this.curTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.twitter = new System.Windows.Forms.LinkLabel();
            this.checkShutdown = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // shutdownpc_label
            // 
            this.shutdownpc_label.AutoSize = true;
            this.shutdownpc_label.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutdownpc_label.ForeColor = System.Drawing.Color.White;
            this.shutdownpc_label.Location = new System.Drawing.Point(13, 13);
            this.shutdownpc_label.Name = "shutdownpc_label";
            this.shutdownpc_label.Size = new System.Drawing.Size(79, 17);
            this.shutdownpc_label.TabIndex = 0;
            this.shutdownpc_label.Text = "ShutdownPC";
            // 
            // closeapp
            // 
            this.closeapp.BackColor = System.Drawing.Color.Transparent;
            this.closeapp.FlatAppearance.BorderSize = 0;
            this.closeapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeapp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(22)))), ((int)(((byte)(5)))));
            this.closeapp.Location = new System.Drawing.Point(426, 10);
            this.closeapp.Name = "closeapp";
            this.closeapp.Size = new System.Drawing.Size(22, 20);
            this.closeapp.TabIndex = 1;
            this.closeapp.Text = "X";
            this.closeapp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.closeapp.UseVisualStyleBackColor = false;
            this.closeapp.Click += new System.EventHandler(this.Closeapp_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Location = new System.Drawing.Point(398, 10);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(22, 20);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.Text = "-";
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // heuresBox
            // 
            this.heuresBox.FormattingEnabled = true;
            this.heuresBox.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
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
            "23"});
            this.heuresBox.Location = new System.Drawing.Point(53, 142);
            this.heuresBox.Name = "heuresBox";
            this.heuresBox.Size = new System.Drawing.Size(97, 21);
            this.heuresBox.TabIndex = 3;
            // 
            // minutesBox
            // 
            this.minutesBox.FormattingEnabled = true;
            this.minutesBox.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
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
            "59"});
            this.minutesBox.Location = new System.Drawing.Point(178, 142);
            this.minutesBox.Name = "minutesBox";
            this.minutesBox.Size = new System.Drawing.Size(97, 21);
            this.minutesBox.TabIndex = 4;
            // 
            // secondesBox
            // 
            this.secondesBox.FormattingEnabled = true;
            this.secondesBox.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
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
            "59"});
            this.secondesBox.Location = new System.Drawing.Point(300, 142);
            this.secondesBox.Name = "secondesBox";
            this.secondesBox.Size = new System.Drawing.Size(97, 21);
            this.secondesBox.TabIndex = 5;
            // 
            // startShutdown
            // 
            this.startShutdown.FlatAppearance.BorderSize = 0;
            this.startShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startShutdown.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startShutdown.ForeColor = System.Drawing.Color.White;
            this.startShutdown.Location = new System.Drawing.Point(337, 277);
            this.startShutdown.Name = "startShutdown";
            this.startShutdown.Size = new System.Drawing.Size(111, 23);
            this.startShutdown.TabIndex = 6;
            this.startShutdown.Text = "Programmer l\'arrêt";
            this.startShutdown.UseVisualStyleBackColor = true;
            this.startShutdown.Click += new System.EventHandler(this.StartShutdown_Click);
            // 
            // rpcText
            // 
            this.rpcText.AutoSize = true;
            this.rpcText.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpcText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rpcText.Location = new System.Drawing.Point(4, 280);
            this.rpcText.Name = "rpcText";
            this.rpcText.Size = new System.Drawing.Size(74, 16);
            this.rpcText.TabIndex = 7;
            this.rpcText.Text = "Arrêt du PC : ";
            // 
            // shutdownTime
            // 
            this.shutdownTime.AutoSize = true;
            this.shutdownTime.ForeColor = System.Drawing.Color.White;
            this.shutdownTime.Location = new System.Drawing.Point(73, 281);
            this.shutdownTime.Name = "shutdownTime";
            this.shutdownTime.Size = new System.Drawing.Size(0, 13);
            this.shutdownTime.TabIndex = 8;
            // 
            // heuresText
            // 
            this.heuresText.AutoSize = true;
            this.heuresText.ForeColor = System.Drawing.Color.White;
            this.heuresText.Location = new System.Drawing.Point(50, 111);
            this.heuresText.Name = "heuresText";
            this.heuresText.Size = new System.Drawing.Size(47, 13);
            this.heuresText.TabIndex = 9;
            this.heuresText.Text = "Heures :";
            // 
            // minutesText
            // 
            this.minutesText.AutoSize = true;
            this.minutesText.ForeColor = System.Drawing.Color.White;
            this.minutesText.Location = new System.Drawing.Point(175, 111);
            this.minutesText.Name = "minutesText";
            this.minutesText.Size = new System.Drawing.Size(50, 13);
            this.minutesText.TabIndex = 10;
            this.minutesText.Text = "Minutes :";
            // 
            // secondesText
            // 
            this.secondesText.AutoSize = true;
            this.secondesText.ForeColor = System.Drawing.Color.White;
            this.secondesText.Location = new System.Drawing.Point(297, 111);
            this.secondesText.Name = "secondesText";
            this.secondesText.Size = new System.Drawing.Size(64, 13);
            this.secondesText.TabIndex = 11;
            this.secondesText.Text = "Secondes : ";
            // 
            // curTime
            // 
            this.curTime.AutoSize = true;
            this.curTime.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curTime.ForeColor = System.Drawing.Color.White;
            this.curTime.Location = new System.Drawing.Point(4, 254);
            this.curTime.Name = "curTime";
            this.curTime.Size = new System.Drawing.Size(79, 17);
            this.curTime.TabIndex = 12;
            this.curTime.Text = "ShutdownPC";
            // 
            // curTimeTimer
            // 
            this.curTimeTimer.Tick += new System.EventHandler(this.CurTimeTimer_Tick);
            // 
            // twitter
            // 
            this.twitter.AutoSize = true;
            this.twitter.LinkColor = System.Drawing.Color.DodgerBlue;
            this.twitter.Location = new System.Drawing.Point(338, 45);
            this.twitter.Name = "twitter";
            this.twitter.Size = new System.Drawing.Size(110, 13);
            this.twitter.TabIndex = 13;
            this.twitter.TabStop = true;
            this.twitter.Text = "Suivez-moi sur Twitter";
            this.twitter.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.twitter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Twitter_LinkClicked);
            // 
            // checkShutdown
            // 
            this.checkShutdown.Tick += new System.EventHandler(this.CheckShutdown_Tick);
            // 
            // shutdown_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(460, 305);
            this.Controls.Add(this.twitter);
            this.Controls.Add(this.curTime);
            this.Controls.Add(this.secondesText);
            this.Controls.Add(this.minutesText);
            this.Controls.Add(this.heuresText);
            this.Controls.Add(this.shutdownTime);
            this.Controls.Add(this.rpcText);
            this.Controls.Add(this.startShutdown);
            this.Controls.Add(this.secondesBox);
            this.Controls.Add(this.minutesBox);
            this.Controls.Add(this.heuresBox);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeapp);
            this.Controls.Add(this.shutdownpc_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "shutdown_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShutdownPC";
            this.Load += new System.EventHandler(this.Shutdown_form_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Shutdown_form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Shutdown_form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Shutdown_form_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shutdownpc_label;
        private System.Windows.Forms.Button closeapp;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.ComboBox heuresBox;
        private System.Windows.Forms.ComboBox minutesBox;
        private System.Windows.Forms.ComboBox secondesBox;
        private System.Windows.Forms.Button startShutdown;
        private System.Windows.Forms.Label rpcText;
        private System.Windows.Forms.Label shutdownTime;
        private System.Windows.Forms.Label heuresText;
        private System.Windows.Forms.Label minutesText;
        private System.Windows.Forms.Label secondesText;
        private System.Windows.Forms.Label curTime;
        private System.Windows.Forms.Timer curTimeTimer;
        private System.Windows.Forms.LinkLabel twitter;
        private System.Windows.Forms.Timer checkShutdown;
    }
}

