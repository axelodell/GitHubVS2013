namespace QuizGame
{
    partial class NewGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGame));
            this.cb_username = new System.Windows.Forms.ComboBox();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sYSA14DataSet = new QuizGame.SYSA14DataSet();
            this.btn_createNewUser = new System.Windows.Forms.Button();
            this.cb_nrOfQuestions = new System.Windows.Forms.ComboBox();
            this.btn_startNewGame = new System.Windows.Forms.Button();
            this.playerTableAdapter = new QuizGame.SYSA14DataSetTableAdapters.PlayerTableAdapter();
            this.lbl_selectUsername = new System.Windows.Forms.Label();
            this.lbl_selectNumberOfQuestions = new System.Windows.Forms.Label();
            this.lbl_CreateNewGame = new System.Windows.Forms.Label();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.cb_Sport = new System.Windows.Forms.CheckBox();
            this.cb_Nature = new System.Windows.Forms.CheckBox();
            this.cb_Culture = new System.Windows.Forms.CheckBox();
            this.cb_Technology = new System.Windows.Forms.CheckBox();
            this.cb_History = new System.Windows.Forms.CheckBox();
            this.cb_Entertainment = new System.Windows.Forms.CheckBox();
            this.cb_Geography = new System.Windows.Forms.CheckBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSA14DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_username
            // 
            this.cb_username.DataSource = this.playerBindingSource;
            this.cb_username.DisplayMember = "userName";
            this.cb_username.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_username.IntegralHeight = false;
            this.cb_username.Location = new System.Drawing.Point(16, 168);
            this.cb_username.Name = "cb_username";
            this.cb_username.Size = new System.Drawing.Size(292, 21);
            this.cb_username.TabIndex = 0;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataMember = "Player";
            this.playerBindingSource.DataSource = this.sYSA14DataSet;
            // 
            // sYSA14DataSet
            // 
            this.sYSA14DataSet.DataSetName = "SYSA14DataSet";
            this.sYSA14DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_createNewUser
            // 
            this.btn_createNewUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_createNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createNewUser.Location = new System.Drawing.Point(16, 204);
            this.btn_createNewUser.Name = "btn_createNewUser";
            this.btn_createNewUser.Size = new System.Drawing.Size(292, 45);
            this.btn_createNewUser.TabIndex = 1;
            this.btn_createNewUser.Text = "Create New User";
            this.btn_createNewUser.UseVisualStyleBackColor = true;
            this.btn_createNewUser.Click += new System.EventHandler(this.btn_createNewUser_Click);
            // 
            // cb_nrOfQuestions
            // 
            this.cb_nrOfQuestions.Cursor = System.Windows.Forms.Cursors.Default;
            this.cb_nrOfQuestions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nrOfQuestions.FormattingEnabled = true;
            this.cb_nrOfQuestions.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cb_nrOfQuestions.Location = new System.Drawing.Point(366, 168);
            this.cb_nrOfQuestions.Name = "cb_nrOfQuestions";
            this.cb_nrOfQuestions.Size = new System.Drawing.Size(292, 21);
            this.cb_nrOfQuestions.TabIndex = 2;
            // 
            // btn_startNewGame
            // 
            this.btn_startNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startNewGame.Location = new System.Drawing.Point(16, 359);
            this.btn_startNewGame.Name = "btn_startNewGame";
            this.btn_startNewGame.Size = new System.Drawing.Size(292, 45);
            this.btn_startNewGame.TabIndex = 4;
            this.btn_startNewGame.Text = "Start New Game";
            this.btn_startNewGame.UseVisualStyleBackColor = true;
            this.btn_startNewGame.Click += new System.EventHandler(this.btn_startNewGame_Click);
            // 
            // playerTableAdapter
            // 
            this.playerTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_selectUsername
            // 
            this.lbl_selectUsername.AutoSize = true;
            this.lbl_selectUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbl_selectUsername.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectUsername.Location = new System.Drawing.Point(13, 152);
            this.lbl_selectUsername.Name = "lbl_selectUsername";
            this.lbl_selectUsername.Size = new System.Drawing.Size(134, 13);
            this.lbl_selectUsername.TabIndex = 5;
            this.lbl_selectUsername.Text = "Select your username:";
            // 
            // lbl_selectNumberOfQuestions
            // 
            this.lbl_selectNumberOfQuestions.AutoSize = true;
            this.lbl_selectNumberOfQuestions.BackColor = System.Drawing.Color.Transparent;
            this.lbl_selectNumberOfQuestions.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectNumberOfQuestions.Location = new System.Drawing.Point(363, 152);
            this.lbl_selectNumberOfQuestions.Name = "lbl_selectNumberOfQuestions";
            this.lbl_selectNumberOfQuestions.Size = new System.Drawing.Size(164, 13);
            this.lbl_selectNumberOfQuestions.TabIndex = 6;
            this.lbl_selectNumberOfQuestions.Text = "Select number of questions:";
            // 
            // lbl_CreateNewGame
            // 
            this.lbl_CreateNewGame.AutoSize = true;
            this.lbl_CreateNewGame.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CreateNewGame.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CreateNewGame.Location = new System.Drawing.Point(8, 52);
            this.lbl_CreateNewGame.Name = "lbl_CreateNewGame";
            this.lbl_CreateNewGame.Size = new System.Drawing.Size(351, 45);
            this.lbl_CreateNewGame.TabIndex = 7;
            this.lbl_CreateNewGame.Text = "CREATE NEW GAME";
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoBack.Location = new System.Drawing.Point(366, 359);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(292, 45);
            this.btn_GoBack.TabIndex = 8;
            this.btn_GoBack.Text = "Back to Main Menu";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // cb_Sport
            // 
            this.cb_Sport.AutoSize = true;
            this.cb_Sport.Location = new System.Drawing.Point(366, 243);
            this.cb_Sport.Name = "cb_Sport";
            this.cb_Sport.Size = new System.Drawing.Size(51, 17);
            this.cb_Sport.TabIndex = 9;
            this.cb_Sport.Text = "Sport";
            this.cb_Sport.UseVisualStyleBackColor = true;
            this.cb_Sport.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cb_Nature
            // 
            this.cb_Nature.AutoSize = true;
            this.cb_Nature.Location = new System.Drawing.Point(466, 243);
            this.cb_Nature.Name = "cb_Nature";
            this.cb_Nature.Size = new System.Drawing.Size(58, 17);
            this.cb_Nature.TabIndex = 10;
            this.cb_Nature.Text = "Nature";
            this.cb_Nature.UseVisualStyleBackColor = true;
            // 
            // cb_Culture
            // 
            this.cb_Culture.AutoSize = true;
            this.cb_Culture.Location = new System.Drawing.Point(567, 243);
            this.cb_Culture.Name = "cb_Culture";
            this.cb_Culture.Size = new System.Drawing.Size(59, 17);
            this.cb_Culture.TabIndex = 11;
            this.cb_Culture.Text = "Culture";
            this.cb_Culture.UseVisualStyleBackColor = true;
            // 
            // cb_Technology
            // 
            this.cb_Technology.AutoSize = true;
            this.cb_Technology.Location = new System.Drawing.Point(366, 275);
            this.cb_Technology.Name = "cb_Technology";
            this.cb_Technology.Size = new System.Drawing.Size(82, 17);
            this.cb_Technology.TabIndex = 12;
            this.cb_Technology.Text = "Technology";
            this.cb_Technology.UseVisualStyleBackColor = true;
            // 
            // cb_History
            // 
            this.cb_History.AutoSize = true;
            this.cb_History.Location = new System.Drawing.Point(466, 275);
            this.cb_History.Name = "cb_History";
            this.cb_History.Size = new System.Drawing.Size(58, 17);
            this.cb_History.TabIndex = 13;
            this.cb_History.Text = "History";
            this.cb_History.UseVisualStyleBackColor = true;
            // 
            // cb_Entertainment
            // 
            this.cb_Entertainment.AutoSize = true;
            this.cb_Entertainment.Location = new System.Drawing.Point(567, 275);
            this.cb_Entertainment.Name = "cb_Entertainment";
            this.cb_Entertainment.Size = new System.Drawing.Size(91, 17);
            this.cb_Entertainment.TabIndex = 14;
            this.cb_Entertainment.Text = "Entertainment";
            this.cb_Entertainment.UseVisualStyleBackColor = true;
            // 
            // cb_Geography
            // 
            this.cb_Geography.AutoSize = true;
            this.cb_Geography.Location = new System.Drawing.Point(366, 309);
            this.cb_Geography.Name = "cb_Geography";
            this.cb_Geography.Size = new System.Drawing.Size(78, 17);
            this.cb_Geography.TabIndex = 15;
            this.cb_Geography.Text = "Geography";
            this.cb_Geography.UseVisualStyleBackColor = true;
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(363, 221);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(115, 13);
            this.lbl_Category.TabIndex = 16;
            this.lbl_Category.Text = "Select category(s):";
            this.lbl_Category.Click += new System.EventHandler(this.label1_Click);
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(725, 425);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.cb_Geography);
            this.Controls.Add(this.cb_Entertainment);
            this.Controls.Add(this.cb_History);
            this.Controls.Add(this.cb_Technology);
            this.Controls.Add(this.cb_Culture);
            this.Controls.Add(this.cb_Nature);
            this.Controls.Add(this.cb_Sport);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.lbl_CreateNewGame);
            this.Controls.Add(this.lbl_selectNumberOfQuestions);
            this.Controls.Add(this.lbl_selectUsername);
            this.Controls.Add(this.btn_startNewGame);
            this.Controls.Add(this.cb_nrOfQuestions);
            this.Controls.Add(this.btn_createNewUser);
            this.Controls.Add(this.cb_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".Query - New Game";
            this.Load += new System.EventHandler(this.NewGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSA14DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_username;
        private System.Windows.Forms.Button btn_createNewUser;
        private System.Windows.Forms.ComboBox cb_nrOfQuestions;
        private System.Windows.Forms.Button btn_startNewGame;
        private SYSA14DataSet sYSA14DataSet;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private SYSA14DataSetTableAdapters.PlayerTableAdapter playerTableAdapter;
        private System.Windows.Forms.Label lbl_selectUsername;
        private System.Windows.Forms.Label lbl_selectNumberOfQuestions;
        private System.Windows.Forms.Label lbl_CreateNewGame;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.CheckBox cb_Sport;
        private System.Windows.Forms.CheckBox cb_Nature;
        private System.Windows.Forms.CheckBox cb_Culture;
        private System.Windows.Forms.CheckBox cb_Technology;
        private System.Windows.Forms.CheckBox cb_History;
        private System.Windows.Forms.CheckBox cb_Entertainment;
        private System.Windows.Forms.CheckBox cb_Geography;
        private System.Windows.Forms.Label lbl_Category;
    }
}