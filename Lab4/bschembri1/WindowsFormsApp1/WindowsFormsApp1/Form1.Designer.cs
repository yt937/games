namespace WindowsFormsApp1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtRaiting = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtRunetime = new System.Windows.Forms.TextBox();
            this.dtpDatetime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtaddTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Find_a_Movie = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtReleaseYear = new System.Windows.Forms.TextBox();
            this.txtTitleFind = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblListy = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Find_a_Movie.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtRaiting);
            this.groupBox1.Controls.Add(this.txtDirector);
            this.groupBox1.Controls.Add(this.txtRunetime);
            this.groupBox1.Controls.Add(this.dtpDatetime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtaddTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a Movie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rating";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Director";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Runetime";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(207, 124);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 20);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtRaiting
            // 
            this.txtRaiting.Location = new System.Drawing.Point(100, 125);
            this.txtRaiting.Name = "txtRaiting";
            this.txtRaiting.Size = new System.Drawing.Size(100, 20);
            this.txtRaiting.TabIndex = 6;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(100, 98);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(177, 20);
            this.txtDirector.TabIndex = 5;
            // 
            // txtRunetime
            // 
            this.txtRunetime.Location = new System.Drawing.Point(100, 72);
            this.txtRunetime.Name = "txtRunetime";
            this.txtRunetime.Size = new System.Drawing.Size(100, 20);
            this.txtRunetime.TabIndex = 4;
            // 
            // dtpDatetime
            // 
            this.dtpDatetime.Location = new System.Drawing.Point(100, 46);
            this.dtpDatetime.Name = "dtpDatetime";
            this.dtpDatetime.Size = new System.Drawing.Size(177, 20);
            this.dtpDatetime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Release Date";
            // 
            // txtaddTitle
            // 
            this.txtaddTitle.Location = new System.Drawing.Point(100, 20);
            this.txtaddTitle.Name = "txtaddTitle";
            this.txtaddTitle.Size = new System.Drawing.Size(177, 20);
            this.txtaddTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // Find_a_Movie
            // 
            this.Find_a_Movie.Controls.Add(this.label7);
            this.Find_a_Movie.Controls.Add(this.label6);
            this.Find_a_Movie.Controls.Add(this.btnFind);
            this.Find_a_Movie.Controls.Add(this.txtReleaseYear);
            this.Find_a_Movie.Controls.Add(this.txtTitleFind);
            this.Find_a_Movie.Location = new System.Drawing.Point(12, 175);
            this.Find_a_Movie.Name = "Find_a_Movie";
            this.Find_a_Movie.Size = new System.Drawing.Size(296, 77);
            this.Find_a_Movie.TabIndex = 1;
            this.Find_a_Movie.TabStop = false;
            this.Find_a_Movie.Text = "Find a Movie";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Release Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Title";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(207, 47);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(70, 19);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "&Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtReleaseYear
            // 
            this.txtReleaseYear.Location = new System.Drawing.Point(100, 47);
            this.txtReleaseYear.Name = "txtReleaseYear";
            this.txtReleaseYear.Size = new System.Drawing.Size(100, 20);
            this.txtReleaseYear.TabIndex = 1;
            // 
            // txtTitleFind
            // 
            this.txtTitleFind.Location = new System.Drawing.Point(100, 20);
            this.txtTitleFind.Name = "txtTitleFind";
            this.txtTitleFind.Size = new System.Drawing.Size(176, 20);
            this.txtTitleFind.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(13, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Movies Owned";
            // 
            // lblListy
            // 
            this.lblListy.AllowDrop = true;
            this.lblListy.AutoSize = true;
            this.lblListy.Location = new System.Drawing.Point(14, 272);
            this.lblListy.Name = "lblListy";
            this.lblListy.Size = new System.Drawing.Size(29, 13);
            this.lblListy.TabIndex = 3;
            this.lblListy.Text = "hello";
            this.lblListy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 520);
            this.Controls.Add(this.lblListy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Find_a_Movie);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Find_a_Movie.ResumeLayout(false);
            this.Find_a_Movie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtRaiting;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtRunetime;
        private System.Windows.Forms.DateTimePicker dtpDatetime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtaddTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Find_a_Movie;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtReleaseYear;
        private System.Windows.Forms.TextBox txtTitleFind;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblListy;
    }
}

