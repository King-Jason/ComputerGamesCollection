namespace ComputerGamesCollection
{
    partial class ComputerGamesCollection
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
            this.components = new System.ComponentModel.Container();
            this.lbGameOutput = new System.Windows.Forms.ListBox();
            this.tbGameNameInput = new System.Windows.Forms.TextBox();
            this.tbGamePlatformInput = new System.Windows.Forms.TextBox();
            this.tbGameGenreInput = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPlatform = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonSaveAS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbGameOutput
            // 
            this.lbGameOutput.FormattingEnabled = true;
            this.lbGameOutput.Location = new System.Drawing.Point(12, 12);
            this.lbGameOutput.Name = "lbGameOutput";
            this.lbGameOutput.Size = new System.Drawing.Size(308, 342);
            this.lbGameOutput.TabIndex = 0;
            this.lbGameOutput.SelectedIndexChanged += new System.EventHandler(this.lbGameOutput_SelectedIndexChanged);
            // 
            // tbGameNameInput
            // 
            this.tbGameNameInput.Location = new System.Drawing.Point(547, 32);
            this.tbGameNameInput.Name = "tbGameNameInput";
            this.tbGameNameInput.Size = new System.Drawing.Size(100, 20);
            this.tbGameNameInput.TabIndex = 1;
            this.toolTip.SetToolTip(this.tbGameNameInput, "Please enter a game name.");
            // 
            // tbGamePlatformInput
            // 
            this.tbGamePlatformInput.Location = new System.Drawing.Point(547, 58);
            this.tbGamePlatformInput.Name = "tbGamePlatformInput";
            this.tbGamePlatformInput.Size = new System.Drawing.Size(100, 20);
            this.tbGamePlatformInput.TabIndex = 2;
            this.toolTip.SetToolTip(this.tbGamePlatformInput, "Please enter a platform for the game.");
            // 
            // tbGameGenreInput
            // 
            this.tbGameGenreInput.Location = new System.Drawing.Point(547, 84);
            this.tbGameGenreInput.Name = "tbGameGenreInput";
            this.tbGameGenreInput.Size = new System.Drawing.Size(100, 20);
            this.tbGameGenreInput.TabIndex = 3;
            this.toolTip.SetToolTip(this.tbGameGenreInput, "Please enter a genre for the game.");
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(488, 35);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name:";
            // 
            // labelPlatform
            // 
            this.labelPlatform.AutoSize = true;
            this.labelPlatform.Location = new System.Drawing.Point(488, 61);
            this.labelPlatform.Name = "labelPlatform";
            this.labelPlatform.Size = new System.Drawing.Size(48, 13);
            this.labelPlatform.TabIndex = 5;
            this.labelPlatform.Text = "Platform:";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(488, 87);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(39, 13);
            this.labelGenre.TabIndex = 6;
            this.labelGenre.Text = "Genre:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(491, 126);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(572, 126);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(491, 155);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(572, 155);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(491, 184);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(572, 184);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 12;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(491, 239);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(572, 239);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 14;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            // 
            // buttonSaveAS
            // 
            this.buttonSaveAS.Location = new System.Drawing.Point(532, 268);
            this.buttonSaveAS.Name = "buttonSaveAS";
            this.buttonSaveAS.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveAS.TabIndex = 15;
            this.buttonSaveAS.Text = "Save As";
            this.buttonSaveAS.UseVisualStyleBackColor = true;
            this.buttonSaveAS.Click += new System.EventHandler(this.buttonSaveAS_Click);
            // 
            // ComputerGamesCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 371);
            this.Controls.Add(this.buttonSaveAS);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelPlatform);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.tbGameGenreInput);
            this.Controls.Add(this.tbGamePlatformInput);
            this.Controls.Add(this.tbGameNameInput);
            this.Controls.Add(this.lbGameOutput);
            this.Name = "ComputerGamesCollection";
            this.Text = "Computer Games Collection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComputerGamesCollection_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbGameOutput;
        private System.Windows.Forms.TextBox tbGameNameInput;
        private System.Windows.Forms.TextBox tbGamePlatformInput;
        private System.Windows.Forms.TextBox tbGameGenreInput;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPlatform;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button buttonSaveAS;
    }
}

