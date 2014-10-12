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
            this.cb_nrOfQuestions.SelectedIndex = 0;
            // 
            // btn_startNewGame
            // 
            this.btn_startNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startNewGame.Location = new System.Drawing.Point(16, 299);
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
            this.btn_GoBack.Location = new System.Drawing.Point(366, 299);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(292, 45);
            this.btn_GoBack.TabIndex = 8;
            this.btn_GoBack.Text = "Back to Main Menu";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(725, 425);
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
    }
}