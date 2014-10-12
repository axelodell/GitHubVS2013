namespace QuizGame
{
    partial class CreateQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateQuestion));
            this.lbl_createNewQuestion = new System.Windows.Forms.Label();
            this.lbl_frameDesc = new System.Windows.Forms.Label();
            this.lbl_qDescription = new System.Windows.Forms.Label();
            this.tb_qDescription = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_corrAns = new System.Windows.Forms.Label();
            this.lbl_incAlt1 = new System.Windows.Forms.Label();
            this.lbl_incAlt2 = new System.Windows.Forms.Label();
            this.lbl_incAlt3 = new System.Windows.Forms.Label();
            this.tb_corrAns = new System.Windows.Forms.TextBox();
            this.tb_IncAlt1 = new System.Windows.Forms.TextBox();
            this.tb_IncAlt2 = new System.Windows.Forms.TextBox();
            this.tb_IncAlt3 = new System.Windows.Forms.TextBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_difficulty = new System.Windows.Forms.Label();
            this.btn_addQuestion = new System.Windows.Forms.Button();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.cb_difficulty = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_createNewQuestion
            // 
            this.lbl_createNewQuestion.AutoSize = true;
            this.lbl_createNewQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_createNewQuestion.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_createNewQuestion.Location = new System.Drawing.Point(12, 18);
            this.lbl_createNewQuestion.Name = "lbl_createNewQuestion";
            this.lbl_createNewQuestion.Size = new System.Drawing.Size(383, 36);
            this.lbl_createNewQuestion.TabIndex = 4;
            this.lbl_createNewQuestion.Text = "CREATE NEW QUESTION";
            // 
            // lbl_frameDesc
            // 
            this.lbl_frameDesc.AutoSize = true;
            this.lbl_frameDesc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_frameDesc.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lbl_frameDesc.Location = new System.Drawing.Point(15, 66);
            this.lbl_frameDesc.Name = "lbl_frameDesc";
            this.lbl_frameDesc.Size = new System.Drawing.Size(427, 18);
            this.lbl_frameDesc.TabIndex = 5;
            this.lbl_frameDesc.Text = "Here you can create your own question and add it to the game.";
            this.lbl_frameDesc.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_qDescription
            // 
            this.lbl_qDescription.AutoSize = true;
            this.lbl_qDescription.BackColor = System.Drawing.Color.Transparent;
            this.lbl_qDescription.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lbl_qDescription.Location = new System.Drawing.Point(12, 114);
            this.lbl_qDescription.Name = "lbl_qDescription";
            this.lbl_qDescription.Size = new System.Drawing.Size(157, 18);
            this.lbl_qDescription.TabIndex = 6;
            this.lbl_qDescription.Text = "What is your question?";
            // 
            // tb_qDescription
            // 
            this.tb_qDescription.Location = new System.Drawing.Point(15, 146);
            this.tb_qDescription.MaxLength = 100;
            this.tb_qDescription.Multiline = true;
            this.tb_qDescription.Name = "tb_qDescription";
            this.tb_qDescription.Size = new System.Drawing.Size(427, 60);
            this.tb_qDescription.TabIndex = 7;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(491, 18);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(207, 66);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_corrAns
            // 
            this.lbl_corrAns.AutoSize = true;
            this.lbl_corrAns.BackColor = System.Drawing.Color.Transparent;
            this.lbl_corrAns.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lbl_corrAns.Location = new System.Drawing.Point(12, 227);
            this.lbl_corrAns.Name = "lbl_corrAns";
            this.lbl_corrAns.Size = new System.Drawing.Size(140, 18);
            this.lbl_corrAns.TabIndex = 9;
            this.lbl_corrAns.Text = "The correct answer:";
            // 
            // lbl_incAlt1
            // 
            this.lbl_incAlt1.AutoSize = true;
            this.lbl_incAlt1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_incAlt1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lbl_incAlt1.Location = new System.Drawing.Point(246, 227);
            this.lbl_incAlt1.Name = "lbl_incAlt1";
            this.lbl_incAlt1.Size = new System.Drawing.Size(157, 18);
            this.lbl_incAlt1.TabIndex = 10;
            this.lbl_incAlt1.Text = "Incorrect alternative 1:";
            // 
            // lbl_incAlt2
            // 
            this.lbl_incAlt2.AutoSize = true;
            this.lbl_incAlt2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_incAlt2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lbl_incAlt2.Location = new System.Drawing.Point(12, 315);
            this.lbl_incAlt2.Name = "lbl_incAlt2";
            this.lbl_incAlt2.Size = new System.Drawing.Size(157, 18);
            this.lbl_incAlt2.TabIndex = 11;
            this.lbl_incAlt2.Text = "Incorrect alternative 2:";
            // 
            // lbl_incAlt3
            // 
            this.lbl_incAlt3.AutoSize = true;
            this.lbl_incAlt3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_incAlt3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lbl_incAlt3.Location = new System.Drawing.Point(246, 315);
            this.lbl_incAlt3.Name = "lbl_incAlt3";
            this.lbl_incAlt3.Size = new System.Drawing.Size(157, 18);
            this.lbl_incAlt3.TabIndex = 12;
            this.lbl_incAlt3.Text = "Incorrect alternative 3:";
            // 
            // tb_corrAns
            // 
            this.tb_corrAns.Location = new System.Drawing.Point(15, 263);
            this.tb_corrAns.Name = "tb_corrAns";
            this.tb_corrAns.Size = new System.Drawing.Size(193, 20);
            this.tb_corrAns.TabIndex = 13;
            // 
            // tb_IncAlt1
            // 
            this.tb_IncAlt1.Location = new System.Drawing.Point(249, 263);
            this.tb_IncAlt1.Name = "tb_IncAlt1";
            this.tb_IncAlt1.Size = new System.Drawing.Size(193, 20);
            this.tb_IncAlt1.TabIndex = 14;
            // 
            // tb_IncAlt2
            // 
            this.tb_IncAlt2.Location = new System.Drawing.Point(15, 353);
            this.tb_IncAlt2.Name = "tb_IncAlt2";
            this.tb_IncAlt2.Size = new System.Drawing.Size(193, 20);
            this.tb_IncAlt2.TabIndex = 15;
            // 
            // tb_IncAlt3
            // 
            this.tb_IncAlt3.Location = new System.Drawing.Point(249, 353);
            this.tb_IncAlt3.Name = "tb_IncAlt3";
            this.tb_IncAlt3.Size = new System.Drawing.Size(193, 20);
            this.tb_IncAlt3.TabIndex = 16;
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.BackColor = System.Drawing.Color.Transparent;
            this.lbl_category.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lbl_category.Location = new System.Drawing.Point(488, 114);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(72, 18);
            this.lbl_category.TabIndex = 17;
            this.lbl_category.Text = "Category:";
            // 
            // lbl_difficulty
            // 
            this.lbl_difficulty.AutoSize = true;
            this.lbl_difficulty.BackColor = System.Drawing.Color.Transparent;
            this.lbl_difficulty.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lbl_difficulty.Location = new System.Drawing.Point(488, 218);
            this.lbl_difficulty.Name = "lbl_difficulty";
            this.lbl_difficulty.Size = new System.Drawing.Size(67, 18);
            this.lbl_difficulty.TabIndex = 18;
            this.lbl_difficulty.Text = "Difficulty:";
            // 
            // btn_addQuestion
            // 
            this.btn_addQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addQuestion.Location = new System.Drawing.Point(491, 315);
            this.btn_addQuestion.Name = "btn_addQuestion";
            this.btn_addQuestion.Size = new System.Drawing.Size(207, 58);
            this.btn_addQuestion.TabIndex = 19;
            this.btn_addQuestion.Text = "Add Question";
            this.btn_addQuestion.UseVisualStyleBackColor = true;
            this.btn_addQuestion.Click += new System.EventHandler(this.btn_addQuestion_Click);
            // 
            // cb_category
            // 
            this.cb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_category.IntegralHeight = false;
            this.cb_category.Items.AddRange(new object[] {
            "Sport",
            "Nature",
            "Technology",
            "Entertainment",
            "Geography",
            "Culture",
            "History"});
            this.cb_category.Location = new System.Drawing.Point(491, 146);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(207, 21);
            this.cb_category.TabIndex = 20;
            // 
            // cb_difficulty
            // 
            this.cb_difficulty.DisplayMember = "userName";
            this.cb_difficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_difficulty.IntegralHeight = false;
            this.cb_difficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Extreme"});
            this.cb_difficulty.Location = new System.Drawing.Point(491, 255);
            this.cb_difficulty.Name = "cb_difficulty";
            this.cb_difficulty.Size = new System.Drawing.Size(207, 21);
            this.cb_difficulty.TabIndex = 21;
            // 
            // CreateQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(725, 425);
            this.Controls.Add(this.cb_difficulty);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.btn_addQuestion);
            this.Controls.Add(this.lbl_difficulty);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.tb_IncAlt3);
            this.Controls.Add(this.tb_IncAlt2);
            this.Controls.Add(this.tb_IncAlt1);
            this.Controls.Add(this.tb_corrAns);
            this.Controls.Add(this.lbl_incAlt3);
            this.Controls.Add(this.lbl_incAlt2);
            this.Controls.Add(this.lbl_incAlt1);
            this.Controls.Add(this.lbl_corrAns);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.tb_qDescription);
            this.Controls.Add(this.lbl_qDescription);
            this.Controls.Add(this.lbl_frameDesc);
            this.Controls.Add(this.lbl_createNewQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".Query - Create Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_createNewQuestion;
        private System.Windows.Forms.Label lbl_frameDesc;
        private System.Windows.Forms.Label lbl_qDescription;
        private System.Windows.Forms.TextBox tb_qDescription;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_corrAns;
        private System.Windows.Forms.Label lbl_incAlt1;
        private System.Windows.Forms.Label lbl_incAlt2;
        private System.Windows.Forms.Label lbl_incAlt3;
        private System.Windows.Forms.TextBox tb_corrAns;
        private System.Windows.Forms.TextBox tb_IncAlt1;
        private System.Windows.Forms.TextBox tb_IncAlt2;
        private System.Windows.Forms.TextBox tb_IncAlt3;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_difficulty;
        private System.Windows.Forms.Button btn_addQuestion;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.ComboBox cb_difficulty;
    }
}