namespace QuizGame
{
    partial class LeaderBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaderBoard));
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.grd_Leaderboard = new System.Windows.Forms.DataGridView();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrCorrectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrIncorrectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sYSA14DataSet = new QuizGame.SYSA14DataSet();
            this.resultsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.resultsTableAdapter = new QuizGame.SYSA14DataSetTableAdapters.ResultsTableAdapter();
            this.resultsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.resultsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Leaderboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSA14DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoBack.Location = new System.Drawing.Point(486, 13);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(216, 37);
            this.btn_GoBack.TabIndex = 1;
            this.btn_GoBack.Text = "Back to Main Menu";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // grd_Leaderboard
            // 
            this.grd_Leaderboard.AllowUserToAddRows = false;
            this.grd_Leaderboard.AllowUserToDeleteRows = false;
            this.grd_Leaderboard.AllowUserToOrderColumns = true;
            this.grd_Leaderboard.AutoGenerateColumns = false;
            this.grd_Leaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Leaderboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.gIdDataGridViewTextBoxColumn,
            this.nrCorrectDataGridViewTextBoxColumn,
            this.nrIncorrectDataGridViewTextBoxColumn});
            this.grd_Leaderboard.DataSource = this.resultsBindingSource;
            this.grd_Leaderboard.Location = new System.Drawing.Point(13, 13);
            this.grd_Leaderboard.Name = "grd_Leaderboard";
            this.grd_Leaderboard.ReadOnly = true;
            this.grd_Leaderboard.Size = new System.Drawing.Size(453, 375);
            this.grd_Leaderboard.TabIndex = 2;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "userName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gIdDataGridViewTextBoxColumn
            // 
            this.gIdDataGridViewTextBoxColumn.DataPropertyName = "gId";
            this.gIdDataGridViewTextBoxColumn.HeaderText = "Game #";
            this.gIdDataGridViewTextBoxColumn.Name = "gIdDataGridViewTextBoxColumn";
            this.gIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrCorrectDataGridViewTextBoxColumn
            // 
            this.nrCorrectDataGridViewTextBoxColumn.DataPropertyName = "nrCorrect";
            this.nrCorrectDataGridViewTextBoxColumn.HeaderText = "# of Correct";
            this.nrCorrectDataGridViewTextBoxColumn.Name = "nrCorrectDataGridViewTextBoxColumn";
            this.nrCorrectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrIncorrectDataGridViewTextBoxColumn
            // 
            this.nrIncorrectDataGridViewTextBoxColumn.DataPropertyName = "nrIncorrect";
            this.nrIncorrectDataGridViewTextBoxColumn.HeaderText = "# of Incorrect";
            this.nrIncorrectDataGridViewTextBoxColumn.Name = "nrIncorrectDataGridViewTextBoxColumn";
            this.nrIncorrectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultsBindingSource
            // 
            this.resultsBindingSource.DataMember = "Results";
            this.resultsBindingSource.DataSource = this.sYSA14DataSet;
            // 
            // sYSA14DataSet
            // 
            this.sYSA14DataSet.DataSetName = "SYSA14DataSet";
            this.sYSA14DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resultsBindingSource3
            // 
            this.resultsBindingSource3.DataMember = "Results";
            this.resultsBindingSource3.DataSource = this.sYSA14DataSet;
            // 
            // resultsTableAdapter
            // 
            this.resultsTableAdapter.ClearBeforeFill = true;
            // 
            // resultsBindingSource1
            // 
            this.resultsBindingSource1.DataMember = "Results";
            this.resultsBindingSource1.DataSource = this.sYSA14DataSet;
            // 
            // resultsBindingSource2
            // 
            this.resultsBindingSource2.DataMember = "Results";
            this.resultsBindingSource2.DataSource = this.sYSA14DataSet;
            // 
            // LeaderBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(725, 425);
            this.Controls.Add(this.grd_Leaderboard);
            this.Controls.Add(this.btn_GoBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LeaderBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".Query - Leaderboard";
            this.Load += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Leaderboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSA14DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.DataGridView grd_Leaderboard;
        private SYSA14DataSet sYSA14DataSet;
        private System.Windows.Forms.BindingSource resultsBindingSource;
        private SYSA14DataSetTableAdapters.ResultsTableAdapter resultsTableAdapter;
        private System.Windows.Forms.BindingSource resultsBindingSource2;
        private System.Windows.Forms.BindingSource resultsBindingSource1;
        private System.Windows.Forms.BindingSource resultsBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCorrectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrIncorrectDataGridViewTextBoxColumn;
    }
}