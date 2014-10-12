namespace QuizGame
{
    partial class CreateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUser));
            this.btn_addUser = new System.Windows.Forms.Button();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addUser
            // 
            this.btn_addUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addUser.Location = new System.Drawing.Point(83, 315);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(272, 39);
            this.btn_addUser.TabIndex = 0;
            this.btn_addUser.Text = "Add user";
            this.btn_addUser.UseVisualStyleBackColor = true;
            this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(83, 244);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(554, 20);
            this.tb_username.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(75, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please enter your desired username below. and click the \"Add User\"-button.\r\nOnce " +
    "created, your username will be found among the others in the dropdown menu\r\nwhil" +
    "e starting a new game.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(72, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "CREATE NEW USER";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(379, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(725, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.btn_addUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".Query - Create User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addUser;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}